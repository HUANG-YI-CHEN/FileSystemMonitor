using FileSystemMonitor.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static FileSystemMonitor.Lib.LogUtil;
using static FileSystemMonitor.Lib.MethodUtil;
using static FileSystemMonitor.Lib.XmlUtil;

namespace FileSystemMonitor
{
    public partial class MainForm : Form
    {
        #region Error Win Delegate
        WinEventDelegate dele { get; set; } = null;
        delegate void WinEventDelegate(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime);

        [DllImport("user32.dll")]
        static extern IntPtr SetWinEventHook(uint eventMin, uint eventMax, IntPtr hmodWinEventProc, WinEventDelegate lpfnWinEventProc, uint idProcess, uint idThread, uint dwFlags);

        private const uint WINEVENT_OUTOFCONTEXT = 0;
        private const uint EVENT_SYSTEM_FOREGROUND = 3;

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);
        private string GetActiveWindowTitle()
        {
            const int nChars = 256;
            IntPtr handle = IntPtr.Zero;
            StringBuilder Buff = new StringBuilder(nChars);
            handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }
        public void WinEventProc(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime)
        {
            LogTrace_System("[START] WinEventProc", GetParentInfo());
            LogTrace_System(GetActiveWindowTitle(), GetParentInfo());
            LogTrace_System("[END] WinEventProc", GetParentInfo());
        }
        #endregion

        #region Class - Define
        public static class SERVER_PATH
        {
            public const string ASE01_OST = @"C:\tmp\Server\ASE01\OST";
            public const string ASE01_DCT = @"C:\tmp\Server\ASE01\DCT";
            public const string ASE02_OST = @"C:\tmp\Server\ASE02\OST";
            public const string ASE02_DCT = @"C:\tmp\Server\ASE02\DCT";
            public const string ASE03_ALL = @"C:\tmp\Server\ASE03";
            public const string ASE07_ALL = @"C:\tmp\Server\ASE07";
            public const string ASE08_ALL = @"C:\tmp\Server\ASE08";
        }

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
            public string SYS_NAME { get; set; } = "OS_REPORT";
            public string SYS_VER { get; set; } = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion.ToString();
            public string SYS_PATH { get; set; } = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            public string HOSTNAME { get; set; } = System.Net.Dns.GetHostName();
            public string IP { get; set; } = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).ToString();
            public string FTP_CIM_IP { get; set; } = "127.0.0.1";
            public string FTP_CIM_PORT { get; set; } = "21";
        }       
        #endregion

        public EQPXML EQP { get; set; } = new EQPXML();
        public string EqpXmlPath { get; set; } = string.Format("{0}{1}", AppDomain.CurrentDomain.BaseDirectory, "EQP.xml");

        #region MainForm
        public MainForm()
        {
            InitializeComponent();

            #region WinEventDelegate
            if (dele != null)
            {
                dele = new WinEventDelegate(WinEventProc);
                IntPtr m_hhook = SetWinEventHook(EVENT_SYSTEM_FOREGROUND, EVENT_SYSTEM_FOREGROUND, IntPtr.Zero, dele, 0, 0, WINEVENT_OUTOFCONTEXT);
            }          
            #endregion

            #region NotifyIcon
            this.Icon = Properties.Resources.filewatcher_16x161;
            this.notifyIcon1.Text = "OS_REPORT";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Icon = Properties.Resources.filewatcher_16x161;
            this.notifyIcon1.ContextMenuStrip = new ContextMenuStrip();
            this.notifyIcon1.ContextMenuStrip.Items.Add("Open", null, this.MenuStrip_Open);
            this.notifyIcon1.ContextMenuStrip.Items.Add("Shrink", null, this.MenuStrip_Shrink);
            this.notifyIcon1.ContextMenuStrip.Items.Add("Exit", null, this.MenuStrip_Exit);
            #endregion

            #region Init Class - XML
            EQP = new EQPXML();
            EQP.GENERAL = new GENERAL_SECTION();
            EQP.SYSTEM = new SYSYEM_SECTION();            
            #endregion           
            
        }
        #endregion

        #region How to fix the flickering in User controls
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        #endregion

        #region MainForm_Load
        private void MainForm_Load(object sender, EventArgs e)
        {
            #region Set Init Region
            if(EQP!=null && EQP.SYSTEM!=null)
            {
                tb_HOSTNAME.Text = EQP.SYSTEM.HOSTNAME;
                tb_EXEC_PATH.Text = EQP.SYSTEM.SYS_PATH;
                tb_VERSION.Text = EQP.SYSTEM.SYS_VER;
                tb_MAINTENANCE.Text = EQP.SYSTEM.SYS_NAME;
                tb_IP.Text = EQP.SYSTEM.IP;
            }
            #endregion

            #region Check EQP.xml EXISTS
            if(File.Exists(EqpXmlPath))
            {
                LoadXmlInfo();
                // check select plant, machid exists

            }
            else
            {
                // Get Query
            }
            #endregion
        }
        #endregion     

        #region MainForm_Shown
        private void MainForm_Shown(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
            //this.Visible = false;
            //this.ShowInTaskbar = false;
        }
        #endregion

        #region MainForm_FormClosing
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogTrace_System("[MSG] Click Button Closing - Shrink", GetParentInfo());
            e.Cancel = true;
            this.WindowState = FormWindowState.Minimized;
            this.Visible = false;
            this.ShowInTaskbar = false;
        }
        #endregion

        #region MainForm_SizeChanged
        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            switch (this.WindowState)
            {
                case FormWindowState.Minimized:
                    this.WindowState = FormWindowState.Minimized;
                    this.Visible = false;
                    this.ShowInTaskbar = false;
                    break;
                case FormWindowState.Normal:
                    this.Visible = true;
                    this.WindowState = FormWindowState.Normal;
                    this.ShowInTaskbar = true;
                    break;
            }
        }
        #endregion

        #region notifyIcon1_MouseDoubleClick
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            switch (this.WindowState)
            {
                case FormWindowState.Minimized:
                    LogTrace_System("[MSG] DoubleClick NotifyIcon - Expand", GetParentInfo());
                    this.Visible = true;
                    this.WindowState = FormWindowState.Normal;
                    this.ShowInTaskbar = true;
                    break;
                case FormWindowState.Normal:
                    LogTrace_System("[MSG] DoubleClick NotifyIcon - Shrink", GetParentInfo());
                    this.WindowState = FormWindowState.Minimized;
                    this.Visible = false;
                    this.ShowInTaskbar = false;
                    break;
            }
        }
        #endregion

        #region notifyIcon MenuStrip_Open
        private void MenuStrip_Open(object sender, EventArgs e)
        {
            switch (this.WindowState)
            {
                case FormWindowState.Minimized:
                    LogTrace_System("[MSG] Click MenuStrip - Open", GetParentInfo());
                    this.Visible = true;
                    this.WindowState = FormWindowState.Normal;
                    this.ShowInTaskbar = true;
                    break;
            }
            //EventMsgToLog = (s) => update_RTB_Msg(s);
        }
        #endregion

        #region notifyIcon MenuStrip_Shrink
        private void MenuStrip_Shrink(object sender, EventArgs e)
        {
            switch (this.WindowState)
            {
                case FormWindowState.Normal:
                    LogTrace_System("[MSG] Click MenuStrip - Shrink", GetParentInfo());
                    this.WindowState = FormWindowState.Minimized;
                    this.Visible = false;
                    this.ShowInTaskbar = false;
                    break;
            }
        }
        #endregion

        #region notifyIcon MenuStrip_Exit
        private void MenuStrip_Exit(object sender, EventArgs e)
        {
            LogTrace_System("[MSG] Are you want to exit the program?", GetParentInfo());
            if (MessageBox.Show("Are you want to exit the program?", "Alarm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LogTrace_System("[YES] Exit Program.", GetParentInfo());
                if (this.notifyIcon1 != null)
                {
                    this.notifyIcon1.Visible = false;
                    this.notifyIcon1.Icon.Dispose();
                    this.notifyIcon1.Dispose();
                    this.notifyIcon1 = null;
                }
                this.Dispose();
                Application.Exit();
            }
            else
            {
                LogTrace_System("[NO] Exit Program.", GetParentInfo());
            }
        }
        #endregion

        #region Rtb_Msg_System_TextChanged
        private void Rtb_Msg_System_TextChanged(object sender, EventArgs e)
        {
            if (rtb_Msg_System.TextLength > 4000)
            {
                LogTrace_System("[MSG] Clear Message Log.", GetParentInfo());
                rtb_Msg_System.Text = "";
            }
            rtb_Msg_System.SelectionStart = rtb_Msg_System.TextLength;
            // Scrolls the contents of the control to the current caret position.
            rtb_Msg_System.ScrollToCaret();
        }
        #endregion

        #region Update_Rtb_Msg_System
        public void Update_Rtb_Msg_System(string Message)
        {
            if (this.InvokeRequired)
            {
                EventMsgToLog?.Invoke(this.rtb_Msg_System.Text);
            }
            else
            {
                this.rtb_Msg_System.Text += Message;
            }
        }
        
        private void LogTrace_System(string Message, string MethodClass)
        {
            LogTrace(Message, MethodClass);
            EventMsgToLog = (s) => Update_Rtb_Msg_System(s);
        }
        #endregion

        #region Open Current Executabe Directory
        private void Btn_Open_Click(object sender, EventArgs e)
        {
            string curPath = System.AppDomain.CurrentDomain.BaseDirectory;
            System.Diagnostics.Process ps = new System.Diagnostics.Process();
            ps.StartInfo.FileName = curPath;
            ps.Start();
            ps.Dispose();
        }
        #endregion

        #region Btn_Save_Click - EQPXML SAVE
        private void Btn_Save_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region label7_Click - MONITOR_FROM
        private void label7_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Select a directory set up the path for monitoring:";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string folderPath = dialog.SelectedPath;
                tb_MONITOR_FROM.Text = folderPath;
            }
        }
        private void Tb_MONITOR_FROM_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All; 
            else 
                e.Effect = DragDropEffects.None;
        }
        private void Tb_MONITOR_FROM_DragEnter(object sender, DragEventArgs e)
        {
            string Path = ((Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            this.tb_MONITOR_FROM.Text = Path;
        }      
        private void Tb_MONITOR_FROM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (!Directory.Exists(tb_MONITOR_FROM.Text))
                {
                    MessageBox.Show(string.Format("[ERROR] Path [{0}] is not exists !", tb_MONITOR_FROM.Text));
                }
            }
        }   
        #endregion

        #region label8_Click - MONITOR_TO
        private void label8_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Select  a directory to set up the path for uploading:";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string folderPath = dialog.SelectedPath;
                tb_MONITOR_TO.Text = folderPath;
            }
        }
        private void Tb_MONITOR_TO_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }
        private void Tb_MONITOR_TO_DragEnter(object sender, DragEventArgs e)
        {
            string Path = ((Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            this.tb_MONITOR_TO.Text = Path;
        }
        private void Tb_MONITOR_TO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (!Directory.Exists(tb_MONITOR_TO.Text))
                {
                    MessageBox.Show(string.Format("[ERROR] Path [{0}] is not exists !", tb_MONITOR_TO.Text));
                }
            }
        }    
        #endregion

        #region Cb_PLANT_TextChanged
        private void Cb_PLANT_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Cb_MACHID_TextChanged
        private void Cb_MACHID_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Cb_TESTER_TextChanged
        private void Cb_TESTER_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(cb_PLANT.Text) && !string.IsNullOrEmpty(cb_TESTER.Text))
            {
                switch(cb_PLANT.Text.ToUpper())
                {
                    case "ASE01":
                        tb_MONITOR_TO.Text = cb_TESTER.Text.ToUpper().Equals("OST") ? SERVER_PATH.ASE01_OST : SERVER_PATH.ASE01_DCT;
                        break;
                    case "ASE02":
                        tb_MONITOR_TO.Text = cb_TESTER.Text.ToUpper().Equals("OST") ? SERVER_PATH.ASE02_OST : SERVER_PATH.ASE02_DCT;                    
                        break;
                    case "ASE03":
                        tb_MONITOR_TO.Text = SERVER_PATH.ASE03_ALL;
                        break;
                    case "ASE07":
                        tb_MONITOR_TO.Text = SERVER_PATH.ASE07_ALL;
                        break;
                    case "ASE08":
                        tb_MONITOR_TO.Text = SERVER_PATH.ASE08_ALL;
                        break;
                }
            }
        }
        #endregion

        #region btn_Upload_Date_Click
        private void Btn_Upload_Date_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Upload_Date_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Btn_Upload_Date_DragEnter(object sender, DragEventArgs e)
        {
            string Path = ((Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            this.rtb_Msg_Manual.Text = Path;
        }
        #endregion

        #region Btn_Upload_Files_Click
        private void Btn_Upload_Files_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Upload_Files_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Btn_Upload_Files_DragEnter(object sender, DragEventArgs e)
        {
            Array Selected = ((Array)e.Data.GetData(DataFormats.FileDrop));
            string ArrayStrings = string.Empty;
            foreach(var item in Selected)
            {
                ArrayStrings += item.ToString() + "\r\n";
            }
            this.rtb_Msg_Manual.Text = ArrayStrings;
        }
        #endregion

        #region XML Load
        public void LoadXmlInfo()
        {
            if (EQP != null)
            {
                EQP = DeserializeFromXml<EQPXML>(EqpXmlPath);
            }
        }
        #endregion

        #region XML Setup
        public void SetXmlInfo()
        {
            if (EQP != null)
            {
                SerializeToXml(EqpXmlPath, EQP);
            }
        }
        #endregion

    }
}
