namespace New_視窗程式
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.imgList_Bird = new System.Windows.Forms.ImageList(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_Up = new System.Windows.Forms.Button();
            this.imgList_weapon = new System.Windows.Forms.ImageList(this.components);
            this.pic_weapon = new System.Windows.Forms.PictureBox();
            this.btn_Down = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btn_Right = new System.Windows.Forms.Button();
            this.pic_Bird = new System.Windows.Forms.PictureBox();
            this.btn_Left = new System.Windows.Forms.Button();
            this.timer_pic = new System.Windows.Forms.Timer(this.components);
            this.pic_Runner = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lblprocess = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_weapon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Runner)).BeginInit();
            this.SuspendLayout();
            // 
            // imgList_Bird
            // 
            this.imgList_Bird.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList_Bird.ImageStream")));
            this.imgList_Bird.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList_Bird.Images.SetKeyName(0, "bird0.png");
            this.imgList_Bird.Images.SetKeyName(1, "bird1.png");
            this.imgList_Bird.Images.SetKeyName(2, "bird2.png");
            this.imgList_Bird.Images.SetKeyName(3, "bird3.png");
            this.imgList_Bird.Images.SetKeyName(4, "bird4.png");
            this.imgList_Bird.Images.SetKeyName(5, "bird5.png");
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Chartreuse;
            this.progressBar1.Location = new System.Drawing.Point(127, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 17;
            // 
            // btn_Up
            // 
            this.btn_Up.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Up.BackgroundImage")));
            this.btn_Up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Up.Enabled = false;
            this.btn_Up.Location = new System.Drawing.Point(152, 246);
            this.btn_Up.Name = "btn_Up";
            this.btn_Up.Size = new System.Drawing.Size(50, 30);
            this.btn_Up.TabIndex = 16;
            this.btn_Up.UseVisualStyleBackColor = true;
            this.btn_Up.Click += new System.EventHandler(this.btn_Up_Click);
            this.btn_Up.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Up_KeyDown);
            // 
            // imgList_weapon
            // 
            this.imgList_weapon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList_weapon.ImageStream")));
            this.imgList_weapon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList_weapon.Images.SetKeyName(0, "0001.png");
            this.imgList_weapon.Images.SetKeyName(1, "0002.png");
            this.imgList_weapon.Images.SetKeyName(2, "0003.png");
            this.imgList_weapon.Images.SetKeyName(3, "0004.png");
            this.imgList_weapon.Images.SetKeyName(4, "0005.png");
            this.imgList_weapon.Images.SetKeyName(5, "0006.png");
            this.imgList_weapon.Images.SetKeyName(6, "0007.png");
            this.imgList_weapon.Images.SetKeyName(7, "0008.png");
            this.imgList_weapon.Images.SetKeyName(8, "0009.png");
            this.imgList_weapon.Images.SetKeyName(9, "0010.png");
            this.imgList_weapon.Images.SetKeyName(10, "0011.png");
            // 
            // pic_weapon
            // 
            this.pic_weapon.BackColor = System.Drawing.Color.Transparent;
            this.pic_weapon.Location = new System.Drawing.Point(292, 216);
            this.pic_weapon.Name = "pic_weapon";
            this.pic_weapon.Size = new System.Drawing.Size(80, 60);
            this.pic_weapon.TabIndex = 18;
            this.pic_weapon.TabStop = false;
            // 
            // btn_Down
            // 
            this.btn_Down.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Down.BackgroundImage")));
            this.btn_Down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Down.Enabled = false;
            this.btn_Down.Location = new System.Drawing.Point(152, 282);
            this.btn_Down.Name = "btn_Down";
            this.btn_Down.Size = new System.Drawing.Size(50, 30);
            this.btn_Down.TabIndex = 14;
            this.btn_Down.UseVisualStyleBackColor = true;
            this.btn_Down.Click += new System.EventHandler(this.btn_Down_Click);
            this.btn_Down.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Down_KeyDown);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 25;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btn_Right
            // 
            this.btn_Right.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Right.BackgroundImage")));
            this.btn_Right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Right.Enabled = false;
            this.btn_Right.Location = new System.Drawing.Point(209, 282);
            this.btn_Right.Name = "btn_Right";
            this.btn_Right.Size = new System.Drawing.Size(50, 30);
            this.btn_Right.TabIndex = 13;
            this.btn_Right.UseVisualStyleBackColor = true;
            this.btn_Right.Click += new System.EventHandler(this.btn_Right_Click);
            this.btn_Right.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Right_KeyDown);
            // 
            // pic_Bird
            // 
            this.pic_Bird.BackColor = System.Drawing.Color.Transparent;
            this.pic_Bird.Location = new System.Drawing.Point(1, 57);
            this.pic_Bird.Name = "pic_Bird";
            this.pic_Bird.Size = new System.Drawing.Size(80, 62);
            this.pic_Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Bird.TabIndex = 11;
            this.pic_Bird.TabStop = false;
            this.pic_Bird.LocationChanged += new System.EventHandler(this.pic_Bird_LocationChanged_1);
            // 
            // btn_Left
            // 
            this.btn_Left.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Left.BackgroundImage")));
            this.btn_Left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Left.Enabled = false;
            this.btn_Left.Location = new System.Drawing.Point(95, 282);
            this.btn_Left.Name = "btn_Left";
            this.btn_Left.Size = new System.Drawing.Size(50, 30);
            this.btn_Left.TabIndex = 12;
            this.btn_Left.UseVisualStyleBackColor = true;
            this.btn_Left.Click += new System.EventHandler(this.btn_Left_Click);
            this.btn_Left.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Left_KeyDown);
            // 
            // timer_pic
            // 
            this.timer_pic.Enabled = true;
            this.timer_pic.Interval = 150;
            this.timer_pic.Tick += new System.EventHandler(this.timer_pic_Tick);
            // 
            // pic_Runner
            // 
            this.pic_Runner.BackColor = System.Drawing.Color.Transparent;
            this.pic_Runner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Runner.Image = ((System.Drawing.Image)(resources.GetObject("pic_Runner.Image")));
            this.pic_Runner.Location = new System.Drawing.Point(192, 129);
            this.pic_Runner.Name = "pic_Runner";
            this.pic_Runner.Size = new System.Drawing.Size(77, 74);
            this.pic_Runner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Runner.TabIndex = 20;
            this.pic_Runner.TabStop = false;
            // 
            // lblprocess
            // 
            this.lblprocess.AutoEllipsis = true;
            this.lblprocess.AutoSize = true;
            this.lblprocess.BackColor = System.Drawing.SystemColors.Window;
            this.lblprocess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblprocess.Font = new System.Drawing.Font("新細明體", 20F);
            this.lblprocess.ForeColor = System.Drawing.Color.Red;
            this.lblprocess.Location = new System.Drawing.Point(12, 153);
            this.lblprocess.Name = "lblprocess";
            this.lblprocess.Size = new System.Drawing.Size(76, 29);
            this.lblprocess.TabIndex = 23;
            this.lblprocess.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(369, 316);
            this.Controls.Add(this.lblprocess);
            this.Controls.Add(this.pic_Runner);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_Up);
            this.Controls.Add(this.pic_weapon);
            this.Controls.Add(this.btn_Down);
            this.Controls.Add(this.btn_Right);
            this.Controls.Add(this.pic_Bird);
            this.Controls.Add(this.btn_Left);
            this.Name = "Form2";
            this.Text = "我是一隻小小小小鳥~";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pic_weapon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Runner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imgList_Bird;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_Up;
        private System.Windows.Forms.ImageList imgList_weapon;
        private System.Windows.Forms.PictureBox pic_weapon;
        private System.Windows.Forms.Button btn_Down;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btn_Right;
        private System.Windows.Forms.PictureBox pic_Bird;
        private System.Windows.Forms.Button btn_Left;
        private System.Windows.Forms.Timer timer_pic;
        private System.Windows.Forms.PictureBox pic_Runner;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lblprocess;
    }
}