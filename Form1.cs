using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices; 


namespace New_視窗程式
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

             // 更改滑鼠游標 "+" 
       // this.Cursor = System.Windows.Forms.Cursors.Cross;

            

  /*      Cursor cur = Cursors.WaitCursor;
        this.Cursor = cur;*/

            
     }

        //     System.Threading.Thread.Sleep(5000); 
        public static bool form4_is_opened = false;      //  用來檢查form4是否已經處於開啟狀態 // 寫這個是因為避免使用者可以產生多個form4視窗
        private int initiall_W, initiall_H, initiall_Top, initiall_Left;

        [DllImport("winmm.dll")]
        public static extern int mciSendString(string m_strCmd, string m_strReceive, int m_v1, int m_v2);

        [DllImport("Kernel32", CharSet = CharSet.Auto)]
        static extern Int32 GetShortPathName(String path, StringBuilder shortPath, Int32 shortPathLength);

        /// <summary>
        /// 使用mciSendString播放音樂
        /// </summary>
        /// <param name="name">檔案名稱</param>
        /// <param name="command">命令</param>

        private static void mciMusic(string name, string command)
        {
            StringBuilder shortpath = new StringBuilder();
            int result = GetShortPathName(name, shortpath, shortpath.Capacity);
            name = shortpath.ToString();
            string buf = string.Empty;
       
            string str;
            if (command == "play" && name.EndsWith(".mp3"))
            {
                str = " repeat";
            }
            else
            {
                str = "";
            }
            mciSendString(command + " " + name +" "+ str, null, 0, 0); //播放 
        }

        string[] BackGround_Music;// = new string[] { "Sound\\BGM_login_1.mp3", "Sound\\BGM_login_2.mp3" };
        Random music = new Random();
        int number;

        private void Form1_Load(object sender, EventArgs e)
        {
            label_Now_time.Text = "當前時間:   " + DateTime.Now.ToString();
            label_picWidth.Text = "※寬度 =  " + pic_role.Width;
            label_picHeight.Text = "※高度 =  " + pic_role.Height;
            vsb_Height.Value = pic_role.Height;
            hsb_Width.Value = pic_role.Width;
            initiall_W = pic_role.Width;    // 儲存圖片初始寬度 
            initiall_H = pic_role.Height;   // 儲存圖片初始高度 
            initiall_Top = this.Top;    //  儲存Form1 初始 X 座標
            initiall_Left = this.Left;  //  儲存Form1 初始 Y 座標
            

            BackGround_Music = new string[] { "Back\\login1.mp3", "Back\\login2.mp3" };
            number = music.Next(BackGround_Music.Count());   //   產生介於 「 0  ~  BackGround_Music.Count()-1 」  的亂數 
            
            try
            {
                this.Cursor = new Cursor("Cursor\\arrow_im(透明).cur");
                
         //       this.Cursor = new Cursor(new Bitmap("cursor\\Arrow.ico").GetHicon());
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            
        }


        private void Form1_Activated(object sender, EventArgs e)
        {
            Cursor.Show();

            
            /* 隨機播放其中一首  */
            if (chkBox_BackGround_Music.Checked == true)
            {
                mciMusic(BackGround_Music[number], "play");   // 似乎只能播放 (*.mp3) ???
            }
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            mciMusic(BackGround_Music[number], "pause");
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_explain_Click(object sender, EventArgs e)
        {
       //    MessageBox.Show("設計者為了「搞鬼Online」而製作此程式!", "遊戲說明", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            MessageBox.Show("「W」\t聖光\n「E」\t六芒星\n「S」\t初始武器\n「Z」\t小武器\n「X」\t中武器\n「C」\t大武器\n「B」\t棒球武器\n「Space」\t射擊 \n←↑↓→ \t移動", "鍵盤", MessageBoxButtons.OK, MessageBoxIcon.None);
            MessageBox.Show("「滑鼠左鍵」\t射擊\n「滑鼠右鍵」\t目標轉換方向\n「滑鼠移動」\t控制目標\n", "滑鼠", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        int num = 0;
        private void btn_Login_Click(object sender, EventArgs e)
        {
            DialogResult result;

            if (textBox_ID.Text == "123" && textBox_PW.Text == "456")
            {
                MessageBox.Show("歡迎進入「搞鬼Online」的世界", "登入成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //      System.Diagnostics.Process.Start("http://www.google.com.tw");    // 連結到google的首頁
                num = 0;
            }
            else if (textBox_PW.Text == "")
            {
                MessageBox.Show("請輸入密碼!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                num++;

                if (num == 3)
                {
                    MessageBox.Show("帳號密碼連續3次輸入錯誤!\n按\"確定\"後離開程式", "登入失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                else
                {
                    result = MessageBox.Show("帳號密碼有誤，剩下" + (3 - num) + "次! 是否重新輸入?", "登入失敗", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (result == DialogResult.No)
                    {
                        Application.Exit();
                    }
                    textBox_PW.Text = null;     //  清空密碼欄    //  等同於 textBox_PW.Text = "";  //  等同於  textBox_PW.Clear();
                }

                
                
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("離開程式!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }


        private void Item_ExitProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            label_Now_time.Text = "當前時間:   " + DateTime.Now.ToString();
        }

        private void btn_open_form2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();   //   先產生 form2 視窗

            this.Left = initiall_Left - form2.Width / 2;   //  設定 Form1視窗 的 X 軸位置
            this.Top = initiall_Top;
            form2.Top = this.Top;      //  設定form2的 X 座標
            form2.Left = this.Left + this.Width;   //  設定form2的 Y 座標

            form2.Height = this.Height;

            //     this.CenterToScreen();   //  可使用此行將 Form1 置中
        }

        private void btn_coordinates_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(X,Y) = " + "(" + this.Left + "," + this.Top + ")");
        }

        private void hsb_Width_Scroll(object sender, ScrollEventArgs e)
        {
            pic_role.Width = hsb_Width.Value;
            label_picWidth.Text = "※寬度 =  " + pic_role.Width;
        }

        private void vsb_Height_Scroll(object sender, ScrollEventArgs e)
        {
            pic_role.Height = vsb_Height.Value;
            label_picHeight.Text = "※高度 =  " + pic_role.Height;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {    // 配合   textBox_pic_TextChanged_1 事件~~~
            //  尚未完成~~  尚未完成~~  尚未完成~~  尚未完成~~
            textBox_pic.Text = trackBar1.Value.ToString();

            pic_role.Height = trackBar1.Value;
            pic_role.Width = trackBar1.Value;

            label_picWidth.Text = "※寬度 =  " + pic_role.Width;
            label_picHeight.Text = "※高度 =  " + pic_role.Height;

        }

        private void textBox_pic_TextChanged(object sender, EventArgs e)
        {   // 配合 trackBar1_Scroll 事件~~~
            try
            {
                if (Convert.ToInt32(textBox_pic.Text) > 100)
                {
                    textBox_pic.Text = "100";
                }

                trackBar1.Value = Convert.ToInt32(textBox_pic.Text);
                pic_role.Height = trackBar1.Value;
                pic_role.Width = trackBar1.Value;

                label_picWidth.Text = "※寬度 =  " + pic_role.Width;
                label_picHeight.Text = "※高度 =  " + pic_role.Height;
            }
            catch (Exception ex)
            {}
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            pic_role.Size = new Size(0, 0);
            label_picWidth.Text = "※寬度 =  " + pic_role.Width;
            label_picHeight.Text = "※高度 =  " + pic_role.Height;
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            pic_role.Size = new Size(this.Width, this.Height);
            label_picWidth.Text = "※寬度 =  " + pic_role.Width;
            label_picHeight.Text = "※高度 =  " + pic_role.Height;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void btn_restore_Click(object sender, EventArgs e)
        {
            /*    -- Way1 --  */
            textBox_pic.Text = "50";
            trackBar1.Value = 50;
            pic_role.Size = new Size(initiall_W, initiall_H);
            label_picWidth.Text = "※寬度 =  " + initiall_W;
            label_picHeight.Text = "※高度 =  " + initiall_H;
            
            /*    -- Way2 --*/
            /*     pic_role.Width  = initiall_W;   // 恢復成一開始的寬度
                 pic_role.Height = initiall_H;   // 恢復成一開始的高度   */
        }

        

        private void textBox_PW_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if ((byte)ch == 13)   //  按下 Enter 鍵，控制權跳到 btn_Login按紐
            {
                
                    btn_Login_Click(sender, e);
                
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            MessageBox.Show("遊戲啟動中...", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        private void btn_Open_form2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();   //   先產生 form2 視窗

            this.Left = initiall_Left - form2.Width / 2;   //  設定 Form1視窗 的 X 軸位置
            this.Top = initiall_Top;
            form2.Top = this.Top;      //  設定form2的 X 座標
            form2.Left = this.Left + this.Width;   //  設定form2的 Y 座標

            form2.Height = this.Height;

            //     this.CenterToScreen();   //  可使用此行將 Form1 置中
        }

        private void btn_Open_form3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
        
        private void btn_Open_form4_Click(object sender, EventArgs e)
        {
            if (form4_is_opened == false)  // //  若form4尚未開啟
            {
                Form4 form4 = new Form4();
                form4.Show();
                form4_is_opened = true;  //  將form4設為開啟狀態，代表form4已經開啟
            }
            
        }

        private void Item_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox_BackGround_Music.Checked == true)
            {
                mciMusic(BackGround_Music[number], "resume");
            }
            else
            {
                mciMusic(BackGround_Music[number], "pause");
            }
        }

        private void textBox_pic_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* 除了數字以外不接受其他字元的輸入 */
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {}
            else
            {
                e.Handled = true;   //   
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
    /*        switch (e.KeyCode)
            {
                case Keys.F2:
                    btn_Open_form2_Click(sender, e);
                    break;
                case Keys.F3:
                    btn_Open_form3_Click(sender,e);
                    break;
                case Keys.F4:
                    btn_Open_form2_Click(sender, e);
                    break;   
            }                  */
        }

        private void textBox_ID_KeyDown(object sender, KeyEventArgs e)
        {
      /*      switch (e.KeyCode)
            {
                case Keys.F2:
                    btn_Open_form2_Click(sender, e);
                    break;
                case Keys.F3:
                    btn_Open_form3_Click(sender, e);
                    break;
                case Keys.F4:
                    btn_Open_form4_Click(sender, e);
                    break;
            }               */
        }




    }
}
