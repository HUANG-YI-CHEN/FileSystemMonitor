using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileSystemMonitor.Lib
{
    public class EQPXML
    {
        public GENERAL_SECTION GENERAL { get; set; } = new GENERAL_SECTION();
        public SYSYEM_SECTION SYSTEM { get; set; } = new SYSYEM_SECTION();
    }
    public class GENERAL_SECTION
    {
        public string PLANT { get; set; }
        public string STAIOTN { get; set; }
        public string MACHID { get; set; }
        public string EQPNAME { get; set; }
        public string MACHTYPE { get; set; }
        public string TESTER { get; set; }
        public string MONITOR_FROM { get; set; }
        public string MONITOR_TO { get; set; }
    }
    public class SYSYEM_SECTION
    {
        public string SYS_NAME { get; set; }
        public string SYS_VER { get; set; }
        public string SYS_PATH { get; set; }
        public string HOSTNAME { get; set; }
        public string IP { get; set; }
        public string FTP_CIM_IP { get; set; }
        public string FTP_CIM_PORT { get; set; }
    }
    public class MonitorUtil
    {
        public EQPXML EqpInfo { get; set; } = new EQPXML();
        public string Filters { get; set; } = "*.TXT;*.XLS";
        private List<string> FilterTokens { get; set; } = new List<string>();
        private List<FileSystemWatcher> FSW { get; set; } = new List<FileSystemWatcher>();

        public void Monitor()
        {
            Monitor(Filters);
        }

        public void Monitor(string filterString)
        {
            string separator = ";";
            if (EqpInfo != null && EqpInfo.GENERAL != null)
            {
                string sourcePath = EqpInfo.GENERAL.MONITOR_FROM;
                if (Directory.Exists(sourcePath))
                {
                    FilterTokens = new List<string>(filterString.Split(new string[] { separator }, StringSplitOptions.None));
                    FSW.Clear();
                    for (int i = 0; i < FilterTokens.Count; i++)
                    {
                        FSW.Add(new FileSystemWatcher());
                        FSW[i].NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
                        FSW[i].Path = sourcePath;
                        FSW[i].Filter = FilterTokens[i];
                        FSW[i].IncludeSubdirectories = false;
                        FSW[i].EnableRaisingEvents = true;
                        FSW[i].Created += new FileSystemEventHandler(Monitor_Create);
                    }
                }
            }
        }

        public void Monitor_Create(object o, FileSystemEventArgs e)
        {            
            if(EqpInfo!=null && EqpInfo.GENERAL!=null)
            {
                FileInfo fileInfo = new FileInfo(e.FullPath);
                DateTime FileDate = fileInfo.LastAccessTime;
                string MonitorPath = e.FullPath.Replace(e.Name, "");
                string fail_CIM = string.Format(@"{0}{1}\", MonitorPath, "FAIL_CIM");
                string fail_WEB = string.Format(@"{0}{1}\", MonitorPath, "FAIL_WEB");
                string fail_MFG = string.Format(@"{0}{1}\", MonitorPath, "FAIL_MFG");
                string move_Date = string.Format(@"{0}{1}\{2}\{3}\", MonitorPath, FileDate.ToString("yyyy"), FileDate.ToString("MM"), FileDate.ToString("yyyyMMdd"));
        
                
                // (1.) 檔案搬移日期目錄 - C:\tmp\Report\2023\05\20230501\*.TXT
                if (!Directory.Exists(move_Date))
                    Directory.CreateDirectory(move_Date);

                // (2.) 日期目錄檔案 進行 CIM-FTP 檔案上傳, 若失敗搬移至失敗區 - C:\tmp\Report\FAIL_CIM\*.TXT
                if (!Directory.Exists(fail_CIM))
                    Directory.CreateDirectory(fail_CIM);

                // (3.) 日期目錄檔案 進行 CIM-WEB 檔案上傳, 若失敗搬移至失敗區 - C:\tmp\Report\FAIL_WEB\*.TXT
                if (!Directory.Exists(fail_WEB))
                    Directory.CreateDirectory(fail_WEB);

                // (3.) 日期目錄檔案 進行 各廠 SERVER 檔案上傳, 若失敗搬移至失敗區 - C:\tmp\Report\FAIL_MFG\*.TXT
                if (!Directory.Exists(fail_MFG))
                    Directory.CreateDirectory(fail_MFG);

            }
        }
    }
}
