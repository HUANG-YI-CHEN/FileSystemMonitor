using System;
using System.IO;
using System.Diagnostics;
//using Renci.SshNet;
//using ICSharpCode.SharpZipLib.Zip;
namespace AutoUpdate
{
    /*1.先查c_ap Table中定义的程序版本,然后判断ap_version的值是否大於当前版本,大於則開始升級邏輯
  2.升級邏輯是:先檢查升級程序是否存在,如果已經存在則先Kill,然后再打開AutoUpdate*/
    string CurrentProjectPath = Environment.CurrentDirectory.ToString();//程序所在目录
        string APPName = Application.ProductName;//程序名称
        string APVersion = Application.ProductVersion;//程序版本
        DataTable GetAPDefineInfo = GetAPInfoByAPName(APPName);//获取AP定义内容
      if (GetAPDefineInfo.Rows.Count > 0)
      {
          string TempVersion = GetAPDefineInfo.Rows[0]["ap_version"].ToString();
        Version DBDefineVersion = new Version(TempVersion);
        Version LocalAPtVersion = new Version(APVersion);
          if (DBDefineVersion > LocalAPtVersion)
          {
          //特别注意:不能把.exe后缀名修进来,否则procList会是空的,就算AutoUpdate已经打开也是找不到的
          //Process在System.Diagnostics中
          Process[] procList = Process.GetProcessesByName("AutoUpdate");
          foreach (Process proc in procList)
            {
              proc.Kill();
            }
                //如果文件不存在,则会报:系统找不到指定档案
                Process.Start(CurrentProjectPath + "\\" + "AutoUpdate.exe");
          }
      }



    class Program
{  //程序所在文件夾
    private static string APPath = Environment.CurrentDirectory.ToString();
    //压缩文件后缀需要是zip,因为7z的后缀在解压时会报错
    private static string ZIPFileName = "MES.zip";
    static void Main(string[] args)
    {
        string Message = "Begin";
        //关闭MES主程序
        Message = CloseMESAP();
        Console.WriteLine(Message);
        //从SFTP下载zip
        Message = DownloadZIPFromSFTP();
        Console.WriteLine(Message);
        //解压缩时覆盖原文件
        Message = UnMESZIP();
        Console.WriteLine(Message);
        //打开主程序
        Message = OpenMESAP();
        Console.WriteLine(Message);
        //Delete压缩文件
        Message = DeleteZIP();//ok
        Console.WriteLine(Message);
        Console.WriteLine("Auto Update Finish");
        Console.ReadKey(); //如果没有这一行,Console界面会立即消失            
    }
    //关闭MES主程序
    public static string CloseMESAP()
    {
        Process[] procList = Process.GetProcessesByName("MES");
        foreach (Process proc in procList)
        {
            proc.Kill();
        }
        return "Close MES OK";
    }
    //从SFTP下载zip
    public static string DownloadZIPFromSFTP()
    {
        string ServerIP = "192.168.1.2";
        string UseID = "shmes";
        string UserPWD = "mes123456!";
        DownloadFile(ZIPFileName, ServerIP, UseID, UserPWD);
        return "DownLoad Zip OK";
    }
    //解压缩时覆盖原文件
    public static string UnMESZIP()
    {
        string MesStr = UnZip(ZIPFileName, APPath, "MESZIPPassword");
        return MesStr;
    }
    //主程序MES.exe
    public static string OpenMESAP()
    {
        //前面已经Close MES了,所以不再检查Kill,
        //此文件夹内如果没有MES.exe文件,这里会报错:系统找不到指定文件
        System.Diagnostics.Process.Start(APPath + "\\" + "MES.exe");
        return "Open MES OK";
    }
    //Delete压缩文件
    public static string DeleteZIP()
    {
        File.Delete(APPath + "\\" + ZIPFileName);
        return "DeleteZIP OK";
    }

    //上传文件,已经测试过OK
    public static string UploadFile(string FileName, string sftpServerIP, string sftpUserID, string sftpUserPWD)
    {
        string LocalFileName = FileName;//SFTP服务器上的文件名和下载到本地一致
        string LocalFullName = Path.Combine(APPath, LocalFileName);//E:\SFC\MES\MES.zip
        string rndWorkPathName = "MES";//SFTP上MES相关程序所在文件夾
        string RemoteFullPath = "/uploads/" + rndWorkPathName + "/" + LocalFileName;
        using (var sftpclient = new SftpClient(sftpServerIP, sftpUserID, sftpUserPWD))
        {
            sftpclient.Connect();
            rndWorkPathName = "/uploads/" + rndWorkPathName + "/";
            sftpclient.ChangeDirectory("/uploads/");//切换目录   
            if (!sftpclient.Exists("MES"))
            {
                sftpclient.CreateDirectory("MES");
            }
            //切换目录/uploads/MES
            sftpclient.ChangeDirectory(rndWorkPathName);
            using (var fileStream = new FileStream(LocalFullName, FileMode.Open))
            {
                sftpclient.BufferSize = 8 * 1024; // bypass Payload error large
                                                  //如果文件已经存在则覆盖
                sftpclient.UploadFile(fileStream, RemoteFullPath);
                fileStream.Close();
            }
            sftpclient.Dispose();
        }
        return "OK";
    }
    //下载文件,已经验证过OK
    public static string DownloadFile(string FileName, string sftpServerIP, string sftpUserID, string sftpUserPWD)
    {
        string LocalFileName = FileName;//SFTP服务器上的文件名和下载到本地一致
        string LocalFullName = Path.Combine(APPath, LocalFileName);//E:\SFC\MES\MES.zip
        string rndWorkPathName = "MES";//SFTP上MES相关程序所在文件夾
                                       // RemoteFullPath: /uploads/MES/MES.zip
        string RemoteFullPath = "/uploads/" + rndWorkPathName + "/" + LocalFileName;
        using (var sftpclient = new SftpClient(sftpServerIP, sftpUserID, sftpUserPWD))
        {
            sftpclient.Connect();
            //切换到指定文件夹(如果文件夾不存在,则报错:No such file)
            rndWorkPathName = "/uploads/" + rndWorkPathName + "/";// /uploads/MES/
            sftpclient.ChangeDirectory(rndWorkPathName);
            using (var fileStream = new FileStream(LocalFullName, FileMode.Create))
            {
                //如果文件不存在,也會報:No such file
                sftpclient.DownloadFile(RemoteFullPath, fileStream);
                fileStream.Dispose();
            }
            sftpclient.Dispose();
        }
        return "OK";
    }

    // ZIP:解压一个zip文件,不能用7z
    //ZipFile:需要解压的Zip文件名,例如:MES.zip,加不加上完整路径都可以
    //TargetDirectory:解压到的文件夹
    //Password:解压密码,如果压缩时没有密码,这里填了密码,不影响解压
    //OverWrite:是否覆盖已存在的文件,Default覆盖
    public static string UnZip(string ZipFile, string TargetDirectory, string Password, bool OverWrite = true)
    {
        string ReturnStr = "UnZIP OK";
        //TargetDirectory结尾一定要有\\
        if (!TargetDirectory.EndsWith("\\"))
        {
            TargetDirectory = TargetDirectory + "\\";
        }
        //读取压缩文件(zip文件),准备解压缩
        using (ZipInputStream zipfiles = new ZipInputStream(File.OpenRead(ZipFile)))
        {
            if (!string.IsNullOrEmpty(Password))
            {
                zipfiles.Password = Password;
            }
            ZipEntry theEntry;
            //如果是.7z后缀,程序会报:Wrong Local header signature: 0xAFBC7A37
            //改为: .zip 则OK
            while ((theEntry = zipfiles.GetNextEntry()) != null)
            {
                string directoryName = "";
                //解压出来的文件保存路径
                string pathToZip = "";
                pathToZip = theEntry.Name;
                if (pathToZip != "")
                {
                    directoryName = Path.GetDirectoryName(pathToZip) + "\\";
                    //如果不加下面的一行内容,解压后会变成.\MES\MES\,实际上我们不想有第二个MES
                    directoryName = directoryName.Replace("MES\\", "");
                }
                //得到根目录下的第一级子文件夹下的子文件夹名称
                string fileName = Path.GetFileName(pathToZip);
                if (!Directory.Exists(TargetDirectory + directoryName))
                {
                    Directory.CreateDirectory(TargetDirectory + directoryName);
                }
                //根目录下的文件名称
                if (fileName != "")
                {
                    if ((File.Exists(TargetDirectory + directoryName + fileName) && OverWrite) || (!File.Exists(TargetDirectory + directoryName + fileName)))
                    {
                        using (FileStream streamWriter = File.Create(TargetDirectory + directoryName + fileName))
                        {
                            int size = 2048;
                            byte[] data = new byte[2048];
                            while (true)
                            {
                                size = zipfiles.Read(data, 0, data.Length);

                                if (size > 0)
                                    streamWriter.Write(data, 0, size);
                                else
                                    break;
                            }
                            streamWriter.Close();
                        }
                    }
                }
            }

            zipfiles.Close();
        }
        return ReturnStr;
    }
}
