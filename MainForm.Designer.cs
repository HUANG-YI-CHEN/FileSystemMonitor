
namespace FileSystemMonitor
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rtb_Msg_Watcher = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.rtb_Msg_Manual = new System.Windows.Forms.RichTextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_Upload_Files = new System.Windows.Forms.Button();
            this.btn_Upload_Date = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_ASE01_OST = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_ASE01_DCT = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_ASE02_OST = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_ASE02_DCT = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_ASE03_ALL = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tb_ASE07_ALL = new System.Windows.Forms.TextBox();
            this.tb_ASE08_ALL = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Open = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_EXEC_PATH = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_HOSTNAME = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_IP = new System.Windows.Forms.TextBox();
            this.tb_MAINTENANCE = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_VERSION = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_MONITOR_FROM = new System.Windows.Forms.TextBox();
            this.tb_MONITOR_TO = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_TESTER = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_PLANT = new System.Windows.Forms.ComboBox();
            this.cb_STATION = new System.Windows.Forms.ComboBox();
            this.cb_MACHID = new System.Windows.Forms.ComboBox();
            this.tb_MACHTYPE = new System.Windows.Forms.TextBox();
            this.tb_EQPNAME = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.rtb_Msg_Retry = new System.Windows.Forms.RichTextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.rtb_Msg_System = new System.Windows.Forms.RichTextBox();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rtb_Msg_Watcher);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(523, 254);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "WatcherLog";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rtb_Msg_Watcher
            // 
            this.rtb_Msg_Watcher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Msg_Watcher.Location = new System.Drawing.Point(3, 3);
            this.rtb_Msg_Watcher.Name = "rtb_Msg_Watcher";
            this.rtb_Msg_Watcher.Size = new System.Drawing.Size(517, 248);
            this.rtb_Msg_Watcher.TabIndex = 0;
            this.rtb_Msg_Watcher.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel7);
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(523, 254);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Manual";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.rtb_Msg_Manual);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 43);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(517, 207);
            this.panel7.TabIndex = 1;
            // 
            // rtb_Msg_Manual
            // 
            this.rtb_Msg_Manual.BackColor = System.Drawing.Color.Black;
            this.rtb_Msg_Manual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Msg_Manual.ForeColor = System.Drawing.Color.Yellow;
            this.rtb_Msg_Manual.Location = new System.Drawing.Point(0, 0);
            this.rtb_Msg_Manual.Name = "rtb_Msg_Manual";
            this.rtb_Msg_Manual.Size = new System.Drawing.Size(517, 207);
            this.rtb_Msg_Manual.TabIndex = 0;
            this.rtb_Msg_Manual.Text = "";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel6.Controls.Add(this.btn_Upload_Files);
            this.panel6.Controls.Add(this.btn_Upload_Date);
            this.panel6.Controls.Add(this.dateTimePicker1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(517, 39);
            this.panel6.TabIndex = 0;
            // 
            // btn_Upload_Files
            // 
            this.btn_Upload_Files.AllowDrop = true;
            this.btn_Upload_Files.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Upload_Files.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Upload_Files.Location = new System.Drawing.Point(369, 3);
            this.btn_Upload_Files.Name = "btn_Upload_Files";
            this.btn_Upload_Files.Size = new System.Drawing.Size(110, 23);
            this.btn_Upload_Files.TabIndex = 2;
            this.btn_Upload_Files.Text = "Upload by File";
            this.btn_Upload_Files.UseVisualStyleBackColor = false;
            this.btn_Upload_Files.Click += new System.EventHandler(this.Btn_Upload_Files_Click);
            this.btn_Upload_Files.DragDrop += new System.Windows.Forms.DragEventHandler(this.Btn_Upload_Files_DragDrop);
            this.btn_Upload_Files.DragEnter += new System.Windows.Forms.DragEventHandler(this.Btn_Upload_Files_DragEnter);
            // 
            // btn_Upload_Date
            // 
            this.btn_Upload_Date.AllowDrop = true;
            this.btn_Upload_Date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Upload_Date.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Upload_Date.Location = new System.Drawing.Point(246, 3);
            this.btn_Upload_Date.Name = "btn_Upload_Date";
            this.btn_Upload_Date.Size = new System.Drawing.Size(107, 23);
            this.btn_Upload_Date.TabIndex = 1;
            this.btn_Upload_Date.Text = "Upload by Date";
            this.btn_Upload_Date.UseVisualStyleBackColor = false;
            this.btn_Upload_Date.Click += new System.EventHandler(this.Btn_Upload_Date_Click);
            this.btn_Upload_Date.DragDrop += new System.Windows.Forms.DragEventHandler(this.Btn_Upload_Date_DragDrop);
            this.btn_Upload_Date.DragEnter += new System.Windows.Forms.DragEventHandler(this.Btn_Upload_Date_DragEnter);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(19, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(523, 254);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Setup";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tableLayoutPanel5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 253);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(517, 0);
            this.panel5.TabIndex = 4;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.50996F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.49004F));
            this.tableLayoutPanel5.Controls.Add(this.label21, 0, 7);
            this.tableLayoutPanel5.Controls.Add(this.label20, 0, 6);
            this.tableLayoutPanel5.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tb_ASE01_OST, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label15, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.tb_ASE01_DCT, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label16, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.tb_ASE02_OST, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.label17, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.tb_ASE02_DCT, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.label18, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.tb_ASE03_ALL, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.label19, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.tb_ASE07_ALL, 1, 5);
            this.tableLayoutPanel5.Controls.Add(this.tb_ASE08_ALL, 1, 6);
            this.tableLayoutPanel5.Controls.Add(this.textBox17, 1, 7);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 8;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(517, 0);
            this.tableLayoutPanel5.TabIndex = 11;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.SandyBrown;
            this.label21.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label21.Location = new System.Drawing.Point(57, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 1);
            this.label21.TabIndex = 27;
            this.label21.Text = "FTP-CIM";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.SandyBrown;
            this.label20.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label20.Location = new System.Drawing.Point(44, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 1);
            this.label20.TabIndex = 25;
            this.label20.Text = "ASE08-ALL";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.SandyBrown;
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(40, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 1);
            this.label14.TabIndex = 12;
            this.label14.Text = "ASE01-OST";
            // 
            // tb_ASE01_OST
            // 
            this.tb_ASE01_OST.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ASE01_OST.Location = new System.Drawing.Point(119, 4);
            this.tb_ASE01_OST.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_ASE01_OST.Name = "tb_ASE01_OST";
            this.tb_ASE01_OST.Size = new System.Drawing.Size(395, 23);
            this.tb_ASE01_OST.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.SandyBrown;
            this.label15.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(40, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 1);
            this.label15.TabIndex = 15;
            this.label15.Text = "ASE01-DCT";
            // 
            // tb_ASE01_DCT
            // 
            this.tb_ASE01_DCT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ASE01_DCT.Location = new System.Drawing.Point(119, 4);
            this.tb_ASE01_DCT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_ASE01_DCT.Name = "tb_ASE01_DCT";
            this.tb_ASE01_DCT.Size = new System.Drawing.Size(395, 23);
            this.tb_ASE01_DCT.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.SandyBrown;
            this.label16.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(40, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 1);
            this.label16.TabIndex = 17;
            this.label16.Text = "ASE02-OST";
            // 
            // tb_ASE02_OST
            // 
            this.tb_ASE02_OST.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ASE02_OST.Location = new System.Drawing.Point(119, 4);
            this.tb_ASE02_OST.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_ASE02_OST.Name = "tb_ASE02_OST";
            this.tb_ASE02_OST.Size = new System.Drawing.Size(395, 23);
            this.tb_ASE02_OST.TabIndex = 18;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.SandyBrown;
            this.label17.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.Location = new System.Drawing.Point(40, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 1);
            this.label17.TabIndex = 19;
            this.label17.Text = "ASE02-DCT";
            // 
            // tb_ASE02_DCT
            // 
            this.tb_ASE02_DCT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ASE02_DCT.Location = new System.Drawing.Point(119, 4);
            this.tb_ASE02_DCT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_ASE02_DCT.Name = "tb_ASE02_DCT";
            this.tb_ASE02_DCT.Size = new System.Drawing.Size(395, 23);
            this.tb_ASE02_DCT.TabIndex = 20;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.SandyBrown;
            this.label18.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label18.Location = new System.Drawing.Point(44, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 1);
            this.label18.TabIndex = 21;
            this.label18.Text = "ASE03-ALL";
            // 
            // tb_ASE03_ALL
            // 
            this.tb_ASE03_ALL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ASE03_ALL.Location = new System.Drawing.Point(119, 4);
            this.tb_ASE03_ALL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_ASE03_ALL.Name = "tb_ASE03_ALL";
            this.tb_ASE03_ALL.Size = new System.Drawing.Size(395, 23);
            this.tb_ASE03_ALL.TabIndex = 22;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.SandyBrown;
            this.label19.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label19.Location = new System.Drawing.Point(44, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 1);
            this.label19.TabIndex = 23;
            this.label19.Text = "ASE07-ALL";
            // 
            // tb_ASE07_ALL
            // 
            this.tb_ASE07_ALL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ASE07_ALL.Location = new System.Drawing.Point(119, 4);
            this.tb_ASE07_ALL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_ASE07_ALL.Name = "tb_ASE07_ALL";
            this.tb_ASE07_ALL.Size = new System.Drawing.Size(395, 23);
            this.tb_ASE07_ALL.TabIndex = 24;
            // 
            // tb_ASE08_ALL
            // 
            this.tb_ASE08_ALL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ASE08_ALL.Location = new System.Drawing.Point(119, 4);
            this.tb_ASE08_ALL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_ASE08_ALL.Name = "tb_ASE08_ALL";
            this.tb_ASE08_ALL.Size = new System.Drawing.Size(395, 23);
            this.tb_ASE08_ALL.TabIndex = 26;
            // 
            // textBox17
            // 
            this.textBox17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox17.Location = new System.Drawing.Point(119, 4);
            this.textBox17.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(395, 23);
            this.textBox17.TabIndex = 28;
            this.textBox17.Text = "/5070_OS_REPORT/";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.btn_Save);
            this.panel4.Controls.Add(this.btn_Open);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 216);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(517, 37);
            this.panel4.TabIndex = 3;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.BackColor = System.Drawing.Color.Cyan;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Save.Location = new System.Drawing.Point(318, 7);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(118, 23);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "Save Setup Info";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // btn_Open
            // 
            this.btn_Open.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Open.BackColor = System.Drawing.Color.Cyan;
            this.btn_Open.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Open.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Open.Location = new System.Drawing.Point(69, 7);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(137, 23);
            this.btn_Open.TabIndex = 8;
            this.btn_Open.Text = "Open Exec Directory";
            this.btn_Open.UseVisualStyleBackColor = false;
            this.btn_Open.Click += new System.EventHandler(this.Btn_Open_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel4);
            this.panel3.Controls.Add(this.tableLayoutPanel3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 125);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(517, 91);
            this.panel3.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.48485F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.51515F));
            this.tableLayoutPanel4.Controls.Add(this.tb_EXEC_PATH, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 59);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(517, 32);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tb_EXEC_PATH
            // 
            this.tb_EXEC_PATH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_EXEC_PATH.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_EXEC_PATH.Location = new System.Drawing.Point(127, 6);
            this.tb_EXEC_PATH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_EXEC_PATH.Name = "tb_EXEC_PATH";
            this.tb_EXEC_PATH.Size = new System.Drawing.Size(385, 22);
            this.tb_EXEC_PATH.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(54, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 15);
            this.label13.TabIndex = 17;
            this.label13.Text = "EXEC PATH";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.67424F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.94697F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.65873F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.34127F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tb_HOSTNAME, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label10, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.tb_IP, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.tb_MAINTENANCE, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label12, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.tb_VERSION, 3, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(517, 59);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(30, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "MAINTENANCE";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(49, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "HOSTNAME";
            // 
            // tb_HOSTNAME
            // 
            this.tb_HOSTNAME.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_HOSTNAME.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_HOSTNAME.Location = new System.Drawing.Point(127, 6);
            this.tb_HOSTNAME.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_HOSTNAME.Name = "tb_HOSTNAME";
            this.tb_HOSTNAME.Size = new System.Drawing.Size(126, 22);
            this.tb_HOSTNAME.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(275, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 15);
            this.label10.TabIndex = 14;
            this.label10.Text = "IP ADDRESS";
            // 
            // tb_IP
            // 
            this.tb_IP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_IP.Location = new System.Drawing.Point(352, 6);
            this.tb_IP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_IP.Name = "tb_IP";
            this.tb_IP.Size = new System.Drawing.Size(160, 23);
            this.tb_IP.TabIndex = 15;
            // 
            // tb_MAINTENANCE
            // 
            this.tb_MAINTENANCE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_MAINTENANCE.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_MAINTENANCE.Location = new System.Drawing.Point(127, 34);
            this.tb_MAINTENANCE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_MAINTENANCE.Name = "tb_MAINTENANCE";
            this.tb_MAINTENANCE.Size = new System.Drawing.Size(126, 22);
            this.tb_MAINTENANCE.TabIndex = 17;
            this.tb_MAINTENANCE.Text = "OS_REPORT";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(290, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "VERSION";
            // 
            // tb_VERSION
            // 
            this.tb_VERSION.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_VERSION.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_VERSION.Location = new System.Drawing.Point(352, 34);
            this.tb_VERSION.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_VERSION.Name = "tb_VERSION";
            this.tb_VERSION.Size = new System.Drawing.Size(160, 22);
            this.tb_VERSION.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 69);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 56);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.66412F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.33588F));
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_MONITOR_FROM, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_MONITOR_TO, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(517, 56);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.SandyBrown;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(12, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "MONITOR FORM";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tb_MONITOR_FROM
            // 
            this.tb_MONITOR_FROM.AllowDrop = true;
            this.tb_MONITOR_FROM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_MONITOR_FROM.Location = new System.Drawing.Point(127, 6);
            this.tb_MONITOR_FROM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_MONITOR_FROM.Name = "tb_MONITOR_FROM";
            this.tb_MONITOR_FROM.Size = new System.Drawing.Size(385, 23);
            this.tb_MONITOR_FROM.TabIndex = 13;
            this.tb_MONITOR_FROM.DragDrop += new System.Windows.Forms.DragEventHandler(this.Tb_MONITOR_FROM_DragDrop);
            this.tb_MONITOR_FROM.DragEnter += new System.Windows.Forms.DragEventHandler(this.Tb_MONITOR_FROM_DragEnter);
            this.tb_MONITOR_FROM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_MONITOR_FROM_KeyPress);
            // 
            // tb_MONITOR_TO
            // 
            this.tb_MONITOR_TO.AllowDrop = true;
            this.tb_MONITOR_TO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_MONITOR_TO.Location = new System.Drawing.Point(127, 33);
            this.tb_MONITOR_TO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_MONITOR_TO.Name = "tb_MONITOR_TO";
            this.tb_MONITOR_TO.Size = new System.Drawing.Size(385, 23);
            this.tb_MONITOR_TO.TabIndex = 14;
            this.tb_MONITOR_TO.DragDrop += new System.Windows.Forms.DragEventHandler(this.Tb_MONITOR_TO_DragDrop);
            this.tb_MONITOR_TO.DragEnter += new System.Windows.Forms.DragEventHandler(this.Tb_MONITOR_TO_DragEnter);
            this.tb_MONITOR_TO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_MONITOR_TO_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.SandyBrown;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(31, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "MONITOR TO";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 65);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.PeachPuff;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.89683F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.04762F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.06349F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.65873F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.label6, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cb_TESTER, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cb_PLANT, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cb_STATION, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cb_MACHID, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_MACHTYPE, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_EQPNAME, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(517, 65);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.SandyBrown;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(349, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "MACHTYPE";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SandyBrown;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(178, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "EQPNAME";
            // 
            // cb_TESTER
            // 
            this.cb_TESTER.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_TESTER.FormattingEnabled = true;
            this.cb_TESTER.Items.AddRange(new object[] {
            "OST",
            "DCT"});
            this.cb_TESTER.Location = new System.Drawing.Point(71, 37);
            this.cb_TESTER.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_TESTER.Name = "cb_TESTER";
            this.cb_TESTER.Size = new System.Drawing.Size(89, 24);
            this.cb_TESTER.TabIndex = 11;
            this.cb_TESTER.Text = "OST";
            this.cb_TESTER.TextChanged += new System.EventHandler(this.Cb_TESTER_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SandyBrown;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(12, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "TESTER";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SandyBrown;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(365, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "MACHID";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SandyBrown;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(187, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "STATION";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SandyBrown;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(17, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLANT";
            // 
            // cb_PLANT
            // 
            this.cb_PLANT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_PLANT.FormattingEnabled = true;
            this.cb_PLANT.Location = new System.Drawing.Point(71, 6);
            this.cb_PLANT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_PLANT.Name = "cb_PLANT";
            this.cb_PLANT.Size = new System.Drawing.Size(89, 24);
            this.cb_PLANT.TabIndex = 1;
            this.cb_PLANT.TextChanged += new System.EventHandler(this.Cb_PLANT_TextChanged);
            // 
            // cb_STATION
            // 
            this.cb_STATION.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_STATION.FormattingEnabled = true;
            this.cb_STATION.Location = new System.Drawing.Point(255, 6);
            this.cb_STATION.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_STATION.Name = "cb_STATION";
            this.cb_STATION.Size = new System.Drawing.Size(82, 24);
            this.cb_STATION.TabIndex = 2;
            // 
            // cb_MACHID
            // 
            this.cb_MACHID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_MACHID.FormattingEnabled = true;
            this.cb_MACHID.Location = new System.Drawing.Point(430, 6);
            this.cb_MACHID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_MACHID.Name = "cb_MACHID";
            this.cb_MACHID.Size = new System.Drawing.Size(82, 24);
            this.cb_MACHID.TabIndex = 3;
            this.cb_MACHID.TextChanged += new System.EventHandler(this.Cb_MACHID_TextChanged);
            // 
            // tb_MACHTYPE
            // 
            this.tb_MACHTYPE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_MACHTYPE.Location = new System.Drawing.Point(430, 37);
            this.tb_MACHTYPE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_MACHTYPE.Name = "tb_MACHTYPE";
            this.tb_MACHTYPE.Size = new System.Drawing.Size(82, 23);
            this.tb_MACHTYPE.TabIndex = 9;
            // 
            // tb_EQPNAME
            // 
            this.tb_EQPNAME.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_EQPNAME.Location = new System.Drawing.Point(255, 37);
            this.tb_EQPNAME.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_EQPNAME.Name = "tb_EQPNAME";
            this.tb_EQPNAME.Size = new System.Drawing.Size(82, 23);
            this.tb_EQPNAME.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(531, 283);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.rtb_Msg_Retry);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(523, 254);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "RetryLog";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // rtb_Msg_Retry
            // 
            this.rtb_Msg_Retry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Msg_Retry.Location = new System.Drawing.Point(3, 3);
            this.rtb_Msg_Retry.Name = "rtb_Msg_Retry";
            this.rtb_Msg_Retry.Size = new System.Drawing.Size(517, 248);
            this.rtb_Msg_Retry.TabIndex = 0;
            this.rtb_Msg_Retry.Text = "";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.rtb_Msg_System);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(523, 254);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "SystemLog";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // rtb_Msg_System
            // 
            this.rtb_Msg_System.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Msg_System.Location = new System.Drawing.Point(3, 3);
            this.rtb_Msg_System.Name = "rtb_Msg_System";
            this.rtb_Msg_System.Size = new System.Drawing.Size(517, 248);
            this.rtb_Msg_System.TabIndex = 0;
            this.rtb_Msg_System.Text = "";
            this.rtb_Msg_System.TextChanged += new System.EventHandler(this.Rtb_Msg_System_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(531, 283);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileSystemMonitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.RichTextBox rtb_Msg_Manual;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_Upload_Files;
        private System.Windows.Forms.Button btn_Upload_Date;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox tb_EXEC_PATH;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_HOSTNAME;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_IP;
        private System.Windows.Forms.TextBox tb_MAINTENANCE;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_VERSION;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_MONITOR_FROM;
        private System.Windows.Forms.TextBox tb_MONITOR_TO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_TESTER;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_PLANT;
        private System.Windows.Forms.ComboBox cb_STATION;
        private System.Windows.Forms.ComboBox cb_MACHID;
        private System.Windows.Forms.TextBox tb_MACHTYPE;
        private System.Windows.Forms.TextBox tb_EQPNAME;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_ASE01_OST;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_ASE01_DCT;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_ASE02_OST;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tb_ASE02_DCT;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tb_ASE03_ALL;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tb_ASE07_ALL;
        private System.Windows.Forms.TextBox tb_ASE08_ALL;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.RichTextBox rtb_Msg_Watcher;
        private System.Windows.Forms.RichTextBox rtb_Msg_Retry;
        private System.Windows.Forms.RichTextBox rtb_Msg_System;
    }
}

