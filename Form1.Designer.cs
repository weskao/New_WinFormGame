namespace New_視窗程式
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_restore = new System.Windows.Forms.Button();
            this.btn_max = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.textBox_pic = new System.Windows.Forms.TextBox();
            this.label_picHeight = new System.Windows.Forms.Label();
            this.label_picWidth = new System.Windows.Forms.Label();
            this.vsb_Height = new System.Windows.Forms.VScrollBar();
            this.hsb_Width = new System.Windows.Forms.HScrollBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btn_coordinates = new System.Windows.Forms.Button();
            this.btn_Open_form2 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.textBox_PW = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_role = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Open_form4 = new System.Windows.Forms.Button();
            this.btn_Open_form3 = new System.Windows.Forms.Button();
            this.label_Now_time = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_explain = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.選項ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Item_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.chkBox_BackGround_Music = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_role)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_restore);
            this.groupBox1.Controls.Add(this.btn_max);
            this.groupBox1.Controls.Add(this.btn_min);
            this.groupBox1.Controls.Add(this.textBox_pic);
            this.groupBox1.Controls.Add(this.label_picHeight);
            this.groupBox1.Controls.Add(this.label_picWidth);
            this.groupBox1.Controls.Add(this.vsb_Height);
            this.groupBox1.Controls.Add(this.hsb_Width);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 12F);
            this.groupBox1.Location = new System.Drawing.Point(287, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 230);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "圖片大小控制項";
            // 
            // btn_restore
            // 
            this.btn_restore.Font = new System.Drawing.Font("新細明體", 9F);
            this.btn_restore.ForeColor = System.Drawing.Color.Green;
            this.btn_restore.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_restore.Location = new System.Drawing.Point(35, 167);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(142, 28);
            this.btn_restore.TabIndex = 23;
            this.btn_restore.Text = "恢復原始大小";
            this.btn_restore.UseVisualStyleBackColor = true;
            this.btn_restore.Click += new System.EventHandler(this.btn_restore_Click);
            // 
            // btn_max
            // 
            this.btn_max.Font = new System.Drawing.Font("新細明體", 9F);
            this.btn_max.ForeColor = System.Drawing.Color.Blue;
            this.btn_max.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_max.Location = new System.Drawing.Point(120, 201);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(75, 23);
            this.btn_max.TabIndex = 22;
            this.btn_max.Text = "最大化";
            this.btn_max.UseVisualStyleBackColor = true;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // btn_min
            // 
            this.btn_min.Font = new System.Drawing.Font("新細明體", 9F);
            this.btn_min.ForeColor = System.Drawing.Color.Blue;
            this.btn_min.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_min.Location = new System.Drawing.Point(19, 201);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(75, 23);
            this.btn_min.TabIndex = 21;
            this.btn_min.Text = "最小化";
            this.btn_min.UseVisualStyleBackColor = true;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // textBox_pic
            // 
            this.textBox_pic.Font = new System.Drawing.Font("新細明體", 11F);
            this.textBox_pic.Location = new System.Drawing.Point(6, 126);
            this.textBox_pic.Name = "textBox_pic";
            this.textBox_pic.Size = new System.Drawing.Size(40, 25);
            this.textBox_pic.TabIndex = 20;
            this.textBox_pic.Text = "50";
            this.textBox_pic.TextChanged += new System.EventHandler(this.textBox_pic_TextChanged);
            this.textBox_pic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_pic_KeyPress);
            // 
            // label_picHeight
            // 
            this.label_picHeight.AutoSize = true;
            this.label_picHeight.Font = new System.Drawing.Font("新細明體", 10F);
            this.label_picHeight.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_picHeight.Location = new System.Drawing.Point(43, 67);
            this.label_picHeight.Name = "label_picHeight";
            this.label_picHeight.Size = new System.Drawing.Size(68, 14);
            this.label_picHeight.TabIndex = 20;
            this.label_picHeight.Text = "※高度 =  ";
            // 
            // label_picWidth
            // 
            this.label_picWidth.AutoSize = true;
            this.label_picWidth.Font = new System.Drawing.Font("新細明體", 10F);
            this.label_picWidth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_picWidth.Location = new System.Drawing.Point(43, 27);
            this.label_picWidth.Name = "label_picWidth";
            this.label_picWidth.Size = new System.Drawing.Size(68, 14);
            this.label_picWidth.TabIndex = 19;
            this.label_picWidth.Text = "※寬度 =  ";
            // 
            // vsb_Height
            // 
            this.vsb_Height.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.vsb_Height.Location = new System.Drawing.Point(171, 10);
            this.vsb_Height.Maximum = 300;
            this.vsb_Height.Name = "vsb_Height";
            this.vsb_Height.Size = new System.Drawing.Size(17, 80);
            this.vsb_Height.TabIndex = 17;
            this.vsb_Height.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsb_Height_Scroll);
            // 
            // hsb_Width
            // 
            this.hsb_Width.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hsb_Width.Location = new System.Drawing.Point(73, 98);
            this.hsb_Width.Maximum = 300;
            this.hsb_Width.Name = "hsb_Width";
            this.hsb_Width.Size = new System.Drawing.Size(80, 17);
            this.hsb_Width.TabIndex = 18;
            this.hsb_Width.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsb_Width_Scroll);
            // 
            // trackBar1
            // 
            this.trackBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.trackBar1.Location = new System.Drawing.Point(52, 126);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(143, 45);
            this.trackBar1.TabIndex = 16;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btn_coordinates
            // 
            this.btn_coordinates.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_coordinates.Location = new System.Drawing.Point(353, 316);
            this.btn_coordinates.Name = "btn_coordinates";
            this.btn_coordinates.Size = new System.Drawing.Size(75, 23);
            this.btn_coordinates.TabIndex = 35;
            this.btn_coordinates.Text = "當前座標";
            this.btn_coordinates.UseVisualStyleBackColor = true;
            this.btn_coordinates.Click += new System.EventHandler(this.btn_coordinates_Click);
            // 
            // btn_Open_form2
            // 
            this.btn_Open_form2.BackColor = System.Drawing.Color.Cyan;
            this.btn_Open_form2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Open_form2.Location = new System.Drawing.Point(353, 351);
            this.btn_Open_form2.Name = "btn_Open_form2";
            this.btn_Open_form2.Size = new System.Drawing.Size(97, 26);
            this.btn_Open_form2.TabIndex = 36;
            this.btn_Open_form2.Text = "開啟Form2 (F2)";
            this.btn_Open_form2.UseVisualStyleBackColor = false;
            this.btn_Open_form2.Click += new System.EventHandler(this.btn_Open_form2_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.GreenYellow;
            this.btnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExit.Location = new System.Drawing.Point(128, 316);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 25);
            this.btnExit.TabIndex = 30;
            this.btnExit.Text = "離開";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_Login.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Login.Location = new System.Drawing.Point(15, 316);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(77, 25);
            this.btn_Login.TabIndex = 29;
            this.btn_Login.Text = "登入";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // textBox_PW
            // 
            this.textBox_PW.Location = new System.Drawing.Point(95, 273);
            this.textBox_PW.Name = "textBox_PW";
            this.textBox_PW.PasswordChar = '*';
            this.textBox_PW.Size = new System.Drawing.Size(100, 22);
            this.textBox_PW.TabIndex = 28;
            this.textBox_PW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_PW_KeyPress);
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(95, 235);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(100, 22);
            this.textBox_ID.TabIndex = 27;
            this.textBox_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_ID_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(31, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "密碼 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(31, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "帳號 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("標楷體", 39.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(99, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 53);
            this.label1.TabIndex = 26;
            this.label1.Text = "搞鬼Online";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_role
            // 
            this.pic_role.BackColor = System.Drawing.Color.Transparent;
            this.pic_role.Image = ((System.Drawing.Image)(resources.GetObject("pic_role.Image")));
            this.pic_role.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pic_role.Location = new System.Drawing.Point(24, 100);
            this.pic_role.Name = "pic_role";
            this.pic_role.Size = new System.Drawing.Size(55, 95);
            this.pic_role.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_role.TabIndex = 25;
            this.pic_role.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 91);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(164, 128);
            this.textBox1.TabIndex = 33;
            this.textBox1.Tag = "";
            this.textBox1.Text = "======人物資訊======\r\n     名稱 :  HIGH\r\n    等級 :  Lv.1\r\n攻擊 :  53\r\n 防禦 :  25\r\n    武器 : " +
    " 竹劍\r\n┌────────┐\r\n　　[職業] : 平民　　\r\n└────────┘";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Open_form4
            // 
            this.btn_Open_form4.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_Open_form4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Open_form4.Location = new System.Drawing.Point(353, 420);
            this.btn_Open_form4.Name = "btn_Open_form4";
            this.btn_Open_form4.Size = new System.Drawing.Size(97, 26);
            this.btn_Open_form4.TabIndex = 43;
            this.btn_Open_form4.Text = "開啟Form4 (F4)";
            this.btn_Open_form4.UseVisualStyleBackColor = false;
            this.btn_Open_form4.Click += new System.EventHandler(this.btn_Open_form4_Click);
            // 
            // btn_Open_form3
            // 
            this.btn_Open_form3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Open_form3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Open_form3.Location = new System.Drawing.Point(353, 386);
            this.btn_Open_form3.Name = "btn_Open_form3";
            this.btn_Open_form3.Size = new System.Drawing.Size(97, 26);
            this.btn_Open_form3.TabIndex = 42;
            this.btn_Open_form3.Text = "開啟Form3 (F3)";
            this.btn_Open_form3.UseVisualStyleBackColor = false;
            this.btn_Open_form3.Click += new System.EventHandler(this.btn_Open_form3_Click);
            // 
            // label_Now_time
            // 
            this.label_Now_time.AutoSize = true;
            this.label_Now_time.BackColor = System.Drawing.Color.Transparent;
            this.label_Now_time.Font = new System.Drawing.Font("新細明體", 12F);
            this.label_Now_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label_Now_time.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Now_time.Location = new System.Drawing.Point(16, 394);
            this.label_Now_time.Name = "label_Now_time";
            this.label_Now_time.Size = new System.Drawing.Size(76, 16);
            this.label_Now_time.TabIndex = 38;
            this.label_Now_time.Text = "當前時間:";
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_start.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_start.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_start.Location = new System.Drawing.Point(15, 436);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(80, 36);
            this.btn_start.TabIndex = 39;
            this.btn_start.Text = "開始遊戲";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_explain
            // 
            this.btn_explain.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_explain.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_explain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_explain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_explain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_explain.Location = new System.Drawing.Point(128, 436);
            this.btn_explain.Name = "btn_explain";
            this.btn_explain.Size = new System.Drawing.Size(80, 36);
            this.btn_explain.TabIndex = 40;
            this.btn_explain.Text = "遊戲說明";
            this.btn_explain.UseVisualStyleBackColor = false;
            this.btn_explain.Click += new System.EventHandler(this.btn_explain_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_exit.Location = new System.Drawing.Point(241, 436);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(80, 36);
            this.btn_exit.TabIndex = 41;
            this.btn_exit.Text = "結束(Esc)";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.選項ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(513, 24);
            this.menuStrip1.TabIndex = 45;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 選項ToolStripMenuItem
            // 
            this.選項ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Item_exit});
            this.選項ToolStripMenuItem.Name = "選項ToolStripMenuItem";
            this.選項ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.選項ToolStripMenuItem.Text = "選項";
            // 
            // Item_exit
            // 
            this.Item_exit.Name = "Item_exit";
            this.Item_exit.Size = new System.Drawing.Size(122, 22);
            this.Item_exit.Text = "結束程式";
            this.Item_exit.ToolTipText = "結束程式";
            this.Item_exit.Click += new System.EventHandler(this.Item_exit_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // chkBox_BackGround_Music
            // 
            this.chkBox_BackGround_Music.AutoSize = true;
            this.chkBox_BackGround_Music.Checked = true;
            this.chkBox_BackGround_Music.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBox_BackGround_Music.Font = new System.Drawing.Font("新細明體", 12F);
            this.chkBox_BackGround_Music.ForeColor = System.Drawing.Color.Blue;
            this.chkBox_BackGround_Music.Location = new System.Drawing.Point(95, 365);
            this.chkBox_BackGround_Music.Margin = new System.Windows.Forms.Padding(2);
            this.chkBox_BackGround_Music.Name = "chkBox_BackGround_Music";
            this.chkBox_BackGround_Music.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkBox_BackGround_Music.Size = new System.Drawing.Size(15, 14);
            this.chkBox_BackGround_Music.TabIndex = 47;
            this.chkBox_BackGround_Music.UseVisualStyleBackColor = true;
            this.chkBox_BackGround_Music.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F);
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(16, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "背景音樂";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_exit;
            this.ClientSize = new System.Drawing.Size(513, 484);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkBox_BackGround_Music);
            this.Controls.Add(this.btn_Open_form4);
            this.Controls.Add(this.btn_Open_form3);
            this.Controls.Add(this.label_Now_time);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_explain);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_coordinates);
            this.Controls.Add(this.btn_Open_form2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.textBox_PW);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_role);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "搞鬼Online";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_role)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_restore;
        private System.Windows.Forms.Button btn_max;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.TextBox textBox_pic;
        private System.Windows.Forms.Label label_picHeight;
        private System.Windows.Forms.Label label_picWidth;
        private System.Windows.Forms.VScrollBar vsb_Height;
        private System.Windows.Forms.HScrollBar hsb_Width;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btn_coordinates;
        private System.Windows.Forms.Button btn_Open_form2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox textBox_PW;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_role;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Open_form4;
        private System.Windows.Forms.Button btn_Open_form3;
        private System.Windows.Forms.Label label_Now_time;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_explain;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 選項ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Item_exit;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox chkBox_BackGround_Music;
        private System.Windows.Forms.Label label4;
    }
}

