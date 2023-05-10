using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static FileSystemMonitor.Lib.LogUtil;
using static FileSystemMonitor.Lib.MethodUtil;

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
            LogTracer_System("[START] WinEventProc", GetParentInfo());
            LogTracer_System(GetActiveWindowTitle(), GetParentInfo());
            LogTracer_System("[END] WinEventProc", GetParentInfo());
        }
        #endregion

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
        }
        #endregion

        #region MainForm_Shown
        private void MainForm_Shown(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Visible = false;
            this.ShowInTaskbar = false;
        }
        #endregion

        #region MainForm_FormClosing
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogTracer_System("[MSG] Click Button Closing - Shrink", GetParentInfo());
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
                    LogTracer_System("[MSG] DoubleClick NotifyIcon - Expand", GetParentInfo());
                    this.Visible = true;
                    this.WindowState = FormWindowState.Normal;
                    this.ShowInTaskbar = true;
                    break;
                case FormWindowState.Normal:
                    LogTracer_System("[MSG] DoubleClick NotifyIcon - Shrink", GetParentInfo());
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
                    LogTracer_System("[MSG] Click MenuStrip - Open", GetParentInfo());
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
                    LogTracer_System("[MSG] Click MenuStrip - Shrink", GetParentInfo());
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
            LogTracer_System("[MSG] Are you want to exit the program?", GetParentInfo());
            if (MessageBox.Show("Are you want to exit the program?", "Alarm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LogTracer_System("[YES] Exit Program.", GetParentInfo());
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
                LogTracer_System("[NO] Exit Program.", GetParentInfo());
            }
        }
        #endregion

        #region rtb_Msg_TextChanged
        private void rtb_Msg_TextChanged(object sender, EventArgs e)
        {
            if (rtb_Msg.TextLength > 4000)
            {
                LogTracer_System("[MSG] Clear Message Log.", GetParentInfo());
                rtb_Msg.Text = "";
            }
            rtb_Msg.SelectionStart = rtb_Msg.TextLength;
            // Scrolls the contents of the control to the current caret position.
            rtb_Msg.ScrollToCaret();
        }
        #endregion

        #region update RTB_Msg
        public void update_RTB_Msg(string Message)
        {
            if (this.InvokeRequired)
            {
                EventMsgToLog?.Invoke(this.rtb_Msg.Text);
            }
            else
            {
                this.rtb_Msg.Text += Message;
            }
        }
        
        private void LogTracer_System(string Message, string MethodClass)
        {
            LogTrace(Message, MethodClass);
            EventMsgToLog = (s) => update_RTB_Msg(s);
        }
        # endregion
    }
}
