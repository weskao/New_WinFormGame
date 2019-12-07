namespace New_視窗程式
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.pic_Unit = new System.Windows.Forms.PictureBox();
            this.pic_Background = new System.Windows.Forms.PictureBox();
            this.pic_Unit_Right = new System.Windows.Forms.PictureBox();
            this.imgList_Arms = new System.Windows.Forms.ImageList(this.components);
            this.pic_Unit_Left = new System.Windows.Forms.PictureBox();
            this.timer_Arms = new System.Windows.Forms.Timer(this.components);
            this.imgList_Weapon = new System.Windows.Forms.ImageList(this.components);
            this.timer_Light = new System.Windows.Forms.Timer(this.components);
            this.pic_Light = new System.Windows.Forms.PictureBox();
            this.timer_Star = new System.Windows.Forms.Timer(this.components);
            this.img_Star = new System.Windows.Forms.ImageList(this.components);
            this.panel_Record = new System.Windows.Forms.Panel();
            this.lbl_Life = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pic_Large_Right = new System.Windows.Forms.PictureBox();
            this.pic_Arms_initiall = new System.Windows.Forms.PictureBox();
            this.pic_Small_Left = new System.Windows.Forms.PictureBox();
            this.pic_Arms_Right = new System.Windows.Forms.PictureBox();
            this.pic_Arms_Left = new System.Windows.Forms.PictureBox();
            this.pic_Small_Right = new System.Windows.Forms.PictureBox();
            this.pic_Large_Left = new System.Windows.Forms.PictureBox();
            this.pic_Medium_Right = new System.Windows.Forms.PictureBox();
            this.pic_Medium_Left = new System.Windows.Forms.PictureBox();
            this.pic_baseball = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_Right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_Left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Light)).BeginInit();
            this.panel_Record.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Large_Right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Arms_initiall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Small_Left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Arms_Right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Arms_Left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Small_Right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Large_Left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Medium_Right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Medium_Left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_baseball)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Unit
            // 
            this.pic_Unit.BackColor = System.Drawing.Color.Black;
            this.pic_Unit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Unit.Image = ((System.Drawing.Image)(resources.GetObject("pic_Unit.Image")));
            this.pic_Unit.Location = new System.Drawing.Point(0, 0);
            this.pic_Unit.Name = "pic_Unit";
            this.pic_Unit.Size = new System.Drawing.Size(63, 66);
            this.pic_Unit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Unit.TabIndex = 12;
            this.pic_Unit.TabStop = false;
            this.pic_Unit.LocationChanged += new System.EventHandler(this.pic_Unit_LocationChanged);
            this.pic_Unit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_Unit_MouseDown);
            this.pic_Unit.MouseEnter += new System.EventHandler(this.pic_Unit_MouseEnter);
            this.pic_Unit.MouseLeave += new System.EventHandler(this.pic_Unit_MouseLeave);
            // 
            // pic_Background
            // 
            this.pic_Background.BackColor = System.Drawing.Color.Black;
            this.pic_Background.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Background.Image = ((System.Drawing.Image)(resources.GetObject("pic_Background.Image")));
            this.pic_Background.Location = new System.Drawing.Point(-3, 0);
            this.pic_Background.Name = "pic_Background";
            this.pic_Background.Size = new System.Drawing.Size(504, 350);
            this.pic_Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Background.TabIndex = 13;
            this.pic_Background.TabStop = false;
            this.pic_Background.MouseEnter += new System.EventHandler(this.pic_Background_MouseEnter);
            this.pic_Background.MouseLeave += new System.EventHandler(this.pic_Background_MouseLeave);
            this.pic_Background.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_Background_MouseMove);
            // 
            // pic_Unit_Right
            // 
            this.pic_Unit_Right.BackColor = System.Drawing.Color.Transparent;
            this.pic_Unit_Right.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_Unit_Right.BackgroundImage")));
            this.pic_Unit_Right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Unit_Right.Image = ((System.Drawing.Image)(resources.GetObject("pic_Unit_Right.Image")));
            this.pic_Unit_Right.Location = new System.Drawing.Point(318, 254);
            this.pic_Unit_Right.Name = "pic_Unit_Right";
            this.pic_Unit_Right.Size = new System.Drawing.Size(63, 66);
            this.pic_Unit_Right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Unit_Right.TabIndex = 15;
            this.pic_Unit_Right.TabStop = false;
            this.pic_Unit_Right.Visible = false;
            // 
            // imgList_Arms
            // 
            this.imgList_Arms.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList_Arms.ImageStream")));
            this.imgList_Arms.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList_Arms.Images.SetKeyName(0, "Arms.bmp");
            this.imgList_Arms.Images.SetKeyName(1, "Arms.bmp");
            this.imgList_Arms.Images.SetKeyName(2, "Arms.bmp");
            this.imgList_Arms.Images.SetKeyName(3, "Arms.bmp");
            this.imgList_Arms.Images.SetKeyName(4, "Arms.bmp");
            this.imgList_Arms.Images.SetKeyName(5, "Arms.bmp");
            this.imgList_Arms.Images.SetKeyName(6, "Arms.bmp");
            this.imgList_Arms.Images.SetKeyName(7, "Arms.bmp");
            this.imgList_Arms.Images.SetKeyName(8, "Arms.bmp");
            this.imgList_Arms.Images.SetKeyName(9, "Arms.bmp");
            this.imgList_Arms.Images.SetKeyName(10, "Arms.bmp");
            this.imgList_Arms.Images.SetKeyName(11, "Arms.bmp");
            this.imgList_Arms.Images.SetKeyName(12, "Arms.bmp");
            this.imgList_Arms.Images.SetKeyName(13, "Arms.bmp");
            this.imgList_Arms.Images.SetKeyName(14, "Arms.bmp");
            this.imgList_Arms.Images.SetKeyName(15, "Arms.bmp");
            this.imgList_Arms.Images.SetKeyName(16, "Arms.bmp");
            this.imgList_Arms.Images.SetKeyName(17, "Arms.bmp");
            this.imgList_Arms.Images.SetKeyName(18, "Arms.bmp");
            this.imgList_Arms.Images.SetKeyName(19, "Arms.bmp");
            this.imgList_Arms.Images.SetKeyName(20, "Star(六芒星).jpg");
            this.imgList_Arms.Images.SetKeyName(21, "Starry_Sky.gif");
            this.imgList_Arms.Images.SetKeyName(22, "black.png");
            // 
            // pic_Unit_Left
            // 
            this.pic_Unit_Left.BackColor = System.Drawing.Color.Transparent;
            this.pic_Unit_Left.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_Unit_Left.BackgroundImage")));
            this.pic_Unit_Left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Unit_Left.Image = ((System.Drawing.Image)(resources.GetObject("pic_Unit_Left.Image")));
            this.pic_Unit_Left.Location = new System.Drawing.Point(216, 254);
            this.pic_Unit_Left.Name = "pic_Unit_Left";
            this.pic_Unit_Left.Size = new System.Drawing.Size(63, 66);
            this.pic_Unit_Left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Unit_Left.TabIndex = 16;
            this.pic_Unit_Left.TabStop = false;
            this.pic_Unit_Left.Visible = false;
            // 
            // timer_Arms
            // 
            this.timer_Arms.Interval = 10;
            this.timer_Arms.Tick += new System.EventHandler(this.timer_Arms_Tick);
            // 
            // imgList_Weapon
            // 
            this.imgList_Weapon.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgList_Weapon.ImageSize = new System.Drawing.Size(16, 16);
            this.imgList_Weapon.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // timer_Light
            // 
            this.timer_Light.Interval = 1000;
            this.timer_Light.Tick += new System.EventHandler(this.timer_Light_Tick);
            // 
            // pic_Light
            // 
            this.pic_Light.BackColor = System.Drawing.Color.Transparent;
            this.pic_Light.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_Light.BackgroundImage")));
            this.pic_Light.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Light.Image = ((System.Drawing.Image)(resources.GetObject("pic_Light.Image")));
            this.pic_Light.Location = new System.Drawing.Point(0, 53);
            this.pic_Light.Name = "pic_Light";
            this.pic_Light.Size = new System.Drawing.Size(67, 40);
            this.pic_Light.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_Light.TabIndex = 25;
            this.pic_Light.TabStop = false;
            this.pic_Light.Visible = false;
            // 
            // timer_Star
            // 
            this.timer_Star.Interval = 60;
            this.timer_Star.Tick += new System.EventHandler(this.timer_Star_Tick);
            // 
            // img_Star
            // 
            this.img_Star.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Star.ImageStream")));
            this.img_Star.TransparentColor = System.Drawing.Color.Transparent;
            this.img_Star.Images.SetKeyName(0, "1.JPG");
            this.img_Star.Images.SetKeyName(1, "2.JPG");
            this.img_Star.Images.SetKeyName(2, "3.JPG");
            this.img_Star.Images.SetKeyName(3, "4.JPG");
            // 
            // panel_Record
            // 
            this.panel_Record.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel_Record.Controls.Add(this.lbl_Life);
            this.panel_Record.Controls.Add(this.pictureBox1);
            this.panel_Record.Location = new System.Drawing.Point(0, 292);
            this.panel_Record.Name = "panel_Record";
            this.panel_Record.Size = new System.Drawing.Size(501, 58);
            this.panel_Record.TabIndex = 27;
            this.panel_Record.MouseEnter += new System.EventHandler(this.panel_Record_MouseEnter);
            // 
            // lbl_Life
            // 
            this.lbl_Life.AutoSize = true;
            this.lbl_Life.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Life.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Life.Location = new System.Drawing.Point(46, 13);
            this.lbl_Life.Name = "lbl_Life";
            this.lbl_Life.Size = new System.Drawing.Size(45, 20);
            this.lbl_Life.TabIndex = 1;
            this.lbl_Life.Text = "x 10";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pic_Large_Right
            // 
            this.pic_Large_Right.BackColor = System.Drawing.Color.Black;
            this.pic_Large_Right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Large_Right.Image = ((System.Drawing.Image)(resources.GetObject("pic_Large_Right.Image")));
            this.pic_Large_Right.Location = new System.Drawing.Point(273, 235);
            this.pic_Large_Right.Name = "pic_Large_Right";
            this.pic_Large_Right.Size = new System.Drawing.Size(71, 51);
            this.pic_Large_Right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_Large_Right.TabIndex = 29;
            this.pic_Large_Right.TabStop = false;
            this.pic_Large_Right.Visible = false;
            // 
            // pic_Arms_initiall
            // 
            this.pic_Arms_initiall.BackColor = System.Drawing.Color.Transparent;
            this.pic_Arms_initiall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_Arms_initiall.BackgroundImage")));
            this.pic_Arms_initiall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Arms_initiall.Image = ((System.Drawing.Image)(resources.GetObject("pic_Arms_initiall.Image")));
            this.pic_Arms_initiall.Location = new System.Drawing.Point(228, 195);
            this.pic_Arms_initiall.Name = "pic_Arms_initiall";
            this.pic_Arms_initiall.Size = new System.Drawing.Size(37, 4);
            this.pic_Arms_initiall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_Arms_initiall.TabIndex = 33;
            this.pic_Arms_initiall.TabStop = false;
            this.pic_Arms_initiall.Visible = false;
            // 
            // pic_Small_Left
            // 
            this.pic_Small_Left.BackColor = System.Drawing.Color.Black;
            this.pic_Small_Left.Image = ((System.Drawing.Image)(resources.GetObject("pic_Small_Left.Image")));
            this.pic_Small_Left.Location = new System.Drawing.Point(12, 258);
            this.pic_Small_Left.Name = "pic_Small_Left";
            this.pic_Small_Left.Size = new System.Drawing.Size(40, 28);
            this.pic_Small_Left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_Small_Left.TabIndex = 25;
            this.pic_Small_Left.TabStop = false;
            this.pic_Small_Left.Visible = false;
            // 
            // pic_Arms_Right
            // 
            this.pic_Arms_Right.BackColor = System.Drawing.Color.Transparent;
            this.pic_Arms_Right.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_Arms_Right.BackgroundImage")));
            this.pic_Arms_Right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Arms_Right.Image = ((System.Drawing.Image)(resources.GetObject("pic_Arms_Right.Image")));
            this.pic_Arms_Right.Location = new System.Drawing.Point(447, 217);
            this.pic_Arms_Right.Name = "pic_Arms_Right";
            this.pic_Arms_Right.Size = new System.Drawing.Size(37, 4);
            this.pic_Arms_Right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_Arms_Right.TabIndex = 32;
            this.pic_Arms_Right.TabStop = false;
            this.pic_Arms_Right.Visible = false;
            // 
            // pic_Arms_Left
            // 
            this.pic_Arms_Left.BackColor = System.Drawing.Color.Transparent;
            this.pic_Arms_Left.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_Arms_Left.BackgroundImage")));
            this.pic_Arms_Left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Arms_Left.Image = ((System.Drawing.Image)(resources.GetObject("pic_Arms_Left.Image")));
            this.pic_Arms_Left.Location = new System.Drawing.Point(15, 217);
            this.pic_Arms_Left.Name = "pic_Arms_Left";
            this.pic_Arms_Left.Size = new System.Drawing.Size(37, 4);
            this.pic_Arms_Left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_Arms_Left.TabIndex = 26;
            this.pic_Arms_Left.TabStop = false;
            this.pic_Arms_Left.Visible = false;
            // 
            // pic_Small_Right
            // 
            this.pic_Small_Right.BackColor = System.Drawing.Color.Black;
            this.pic_Small_Right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Small_Right.Image = ((System.Drawing.Image)(resources.GetObject("pic_Small_Right.Image")));
            this.pic_Small_Right.Location = new System.Drawing.Point(444, 258);
            this.pic_Small_Right.Name = "pic_Small_Right";
            this.pic_Small_Right.Size = new System.Drawing.Size(40, 28);
            this.pic_Small_Right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_Small_Right.TabIndex = 31;
            this.pic_Small_Right.TabStop = false;
            this.pic_Small_Right.Visible = false;
            // 
            // pic_Large_Left
            // 
            this.pic_Large_Left.BackColor = System.Drawing.Color.Black;
            this.pic_Large_Left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Large_Left.Image = ((System.Drawing.Image)(resources.GetObject("pic_Large_Left.Image")));
            this.pic_Large_Left.Location = new System.Drawing.Point(152, 235);
            this.pic_Large_Left.Name = "pic_Large_Left";
            this.pic_Large_Left.Size = new System.Drawing.Size(71, 51);
            this.pic_Large_Left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_Large_Left.TabIndex = 27;
            this.pic_Large_Left.TabStop = false;
            this.pic_Large_Left.Visible = false;
            // 
            // pic_Medium_Right
            // 
            this.pic_Medium_Right.BackColor = System.Drawing.Color.Black;
            this.pic_Medium_Right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Medium_Right.Image = ((System.Drawing.Image)(resources.GetObject("pic_Medium_Right.Image")));
            this.pic_Medium_Right.Location = new System.Drawing.Point(364, 243);
            this.pic_Medium_Right.Name = "pic_Medium_Right";
            this.pic_Medium_Right.Size = new System.Drawing.Size(60, 43);
            this.pic_Medium_Right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_Medium_Right.TabIndex = 30;
            this.pic_Medium_Right.TabStop = false;
            this.pic_Medium_Right.Visible = false;
            // 
            // pic_Medium_Left
            // 
            this.pic_Medium_Left.BackColor = System.Drawing.Color.Black;
            this.pic_Medium_Left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Medium_Left.Image = ((System.Drawing.Image)(resources.GetObject("pic_Medium_Left.Image")));
            this.pic_Medium_Left.Location = new System.Drawing.Point(72, 243);
            this.pic_Medium_Left.Name = "pic_Medium_Left";
            this.pic_Medium_Left.Size = new System.Drawing.Size(60, 43);
            this.pic_Medium_Left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_Medium_Left.TabIndex = 28;
            this.pic_Medium_Left.TabStop = false;
            this.pic_Medium_Left.Visible = false;
            // 
            // pic_baseball
            // 
            this.pic_baseball.BackColor = System.Drawing.Color.Transparent;
            this.pic_baseball.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_baseball.BackgroundImage")));
            this.pic_baseball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_baseball.Image = ((System.Drawing.Image)(resources.GetObject("pic_baseball.Image")));
            this.pic_baseball.Location = new System.Drawing.Point(232, 153);
            this.pic_baseball.Name = "pic_baseball";
            this.pic_baseball.Size = new System.Drawing.Size(20, 20);
            this.pic_baseball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_baseball.TabIndex = 34;
            this.pic_baseball.TabStop = false;
            this.pic_baseball.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(383, 22);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 35;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(497, 349);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pic_baseball);
            this.Controls.Add(this.pic_Large_Right);
            this.Controls.Add(this.panel_Record);
            this.Controls.Add(this.pic_Arms_initiall);
            this.Controls.Add(this.pic_Light);
            this.Controls.Add(this.pic_Small_Left);
            this.Controls.Add(this.pic_Unit);
            this.Controls.Add(this.pic_Arms_Right);
            this.Controls.Add(this.pic_Arms_Left);
            this.Controls.Add(this.pic_Small_Right);
            this.Controls.Add(this.pic_Large_Left);
            this.Controls.Add(this.pic_Medium_Right);
            this.Controls.Add(this.pic_Medium_Left);
            this.Controls.Add(this.pic_Background);
            this.Controls.Add(this.pic_Unit_Right);
            this.Controls.Add(this.pic_Unit_Left);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlyDragon";
            this.Activated += new System.EventHandler(this.Form4_Activated);
            this.Deactivate += new System.EventHandler(this.Form4_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.Load += new System.EventHandler(this.Form4_Load);
            this.SizeChanged += new System.EventHandler(this.Form4_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form4_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form4_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_Right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Unit_Left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Light)).EndInit();
            this.panel_Record.ResumeLayout(false);
            this.panel_Record.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Large_Right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Arms_initiall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Small_Left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Arms_Right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Arms_Left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Small_Right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Large_Left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Medium_Right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Medium_Left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_baseball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Unit;
        private System.Windows.Forms.PictureBox pic_Background;
        private System.Windows.Forms.PictureBox pic_Unit_Right;
        private System.Windows.Forms.ImageList imgList_Arms;
        private System.Windows.Forms.PictureBox pic_Unit_Left;
        private System.Windows.Forms.Timer timer_Arms;
        private System.Windows.Forms.ImageList imgList_Weapon;
        private System.Windows.Forms.Timer timer_Light;
        private System.Windows.Forms.PictureBox pic_Light;
        private System.Windows.Forms.Timer timer_Star;
        private System.Windows.Forms.ImageList img_Star;
        private System.Windows.Forms.Panel panel_Record;
        private System.Windows.Forms.PictureBox pic_Large_Right;
        private System.Windows.Forms.PictureBox pic_Arms_initiall;
        private System.Windows.Forms.PictureBox pic_Small_Left;
        private System.Windows.Forms.PictureBox pic_Arms_Right;
        private System.Windows.Forms.PictureBox pic_Arms_Left;
        private System.Windows.Forms.PictureBox pic_Small_Right;
        private System.Windows.Forms.PictureBox pic_Large_Left;
        private System.Windows.Forms.PictureBox pic_Medium_Right;
        private System.Windows.Forms.PictureBox pic_Medium_Left;
        private System.Windows.Forms.Label lbl_Life;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pic_baseball;
        private System.Windows.Forms.Button btnExit;
    }
}