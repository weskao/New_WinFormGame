using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices; 

namespace New_視窗程式
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            // 降低flicker，改善圖像閃爍的情形 
            this.DoubleBuffered = true;  
        }

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
            if (command.Equals("play") && name.EndsWith(".mp3"))
            {
                str = " repeat";
            }
            else
            {
                str = "";
            }
            mciSendString(command + " " + name + " " + str, null, 0, 10); //播放 
        }

        string[] BackGround_Music;// = new string[] { "Sound\\BGM_login_1.mp3", "Sound\\BGM_login_2.mp3" };
        Random music = new Random();
        int number;

   //     System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
        System.Media.SoundPlayer sp_Arms = new System.Media.SoundPlayer();
        private void Form4_Load(object sender, EventArgs e)
        {
            pic_Background.Size = new Size(this.Width - 5, this.Height - 33-58);

            panel_Record.Size = new Size(this.Width - 6, this.Height - 333);
            panel_Record.Location = new Point(0,pic_Background.Height);


            /* 隨機播放其中一首  */
            BackGround_Music = new string[] { "Sound\\fight.mp3", "Sound\\PK.mp3", "Sound\\SD.mp3", "Sound\\ttr.mp3" };
            number = music.Next(BackGround_Music.Count());   //   產生介於 「 0  ~  BackGround_Music.Count()-1 」  的亂數 

            try
            {
                sp_Arms.SoundLocation = ("Sound\\mac10-1.wav");  //  設定武器初始音效

                /*     string[] Music_Location = new string[] { "Sound\\fight.mp3", "Sound\\PK.mp3", "Sound\\SD.mp3","Sound\\ttr.mp3" };
                     Random music = new Random();
                     int number = music.Next( Music_Location.Count() );   //   產生介於的亂數 
                     sp.SoundLocation = (Music_Location[number]);
                     sp.PlayLooping();    //  循環播放音樂      */
            }
            catch (Exception ex)
            {
                MessageBox.Show("由於某些因素，並未載入背景音樂!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.None);
            }

            pic_Light.Left = pic_Unit.Left - 2;   //  設定 X 座標
            pic_Light.Top = pic_Unit.Top + pic_Unit.Height - 13;  //  設定 Y 座標
        }

        private void Form4_Activated(object sender, EventArgs e)
        {
            /* 隨機播放其中一首  */
            mciMusic(BackGround_Music[number], "play");   // 似乎只能播放 (*.mp3) ???
        }

        private void Form4_Deactivate(object sender, EventArgs e)
        {
            mciMusic(BackGround_Music[number], "pause");
        }

        private void Form4_SizeChanged(object sender, EventArgs e)
        {  //  使圖像能隨著視窗大小縮放
            //      pic_Unit.Size=new Size(this.Width-442,this.Height-317);
            pic_Background.Size = new Size(this.Width - 5, this.Height - 33 - 58);

            panel_Record.Size = new Size(this.Width - 6, this.Height - 333);
            panel_Record.Location = new Point(0, pic_Background.Height);
        }

        private bool direction = true;  // 定義向"右"為 true
        private void Form4_KeyDown(object sender, KeyEventArgs e)  //鍵盤控制 - 上下左右
        {
            switch (e.KeyCode)
            {

                case Keys.Up:
                    pic_Unit.Top -= 7;
                    break;
                case Keys.Down:
                    pic_Unit.Top += 7;
                    break;
                case Keys.Left:
                    if (direction)   //  如果在這之前是"向右"
                    {
                        pic_Unit.Image = pic_Unit_Left.Image;
                        direction = false;
                    }
                    pic_Unit.Left -= 7;
                    break;
                case Keys.Right:
                    if (!direction)   //  如果在這之前是"向左"
                    {
                        pic_Unit.Image = pic_Unit_Right.Image;
                        direction = true;
                    }
                    pic_Unit.Left += 7;
                    break;
            }
        }

        
        private void pic_Unit_LocationChanged(object sender, EventArgs e)
        {
            pic_Unit.Left = (pic_Unit.Left + this.Width) % this.Width;
            pic_Unit.Top = (pic_Unit.Top + this.Height) % this.Height;

            pic_Light.Left = pic_Unit.Left-2;   //  設定 X 座標
            pic_Light.Top = pic_Unit.Top +pic_Unit.Height-17 ;  //  設定 Y 座標
            
        }

        private int y = 30;
        private void Form4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            
            try   //  因為要播放音效檔(*.wav)  所以要用到 try  catch 防止例外狀況發生
            {
               if (ch == 32)   //  當按下空白鍵
                {
                    if (direction)  //  如果此時方向"向右"
                    {
                        pic_Arms_Right.Left = pic_Unit.Right; //  武器的 X 座標
                        pic_Arms_Right.Top = pic_Unit.Top + y; //  武器的 Y 座標
                        pic_Arms_Right.Visible = true;
                    }
                    else        //   此時方向"向左"
                    {
                        pic_Arms_Left.Left = pic_Unit.Left - pic_Unit.Width;       //  武器的 X 座標
                        pic_Arms_Left.Top = pic_Unit.Top + y;  //  武器的 Y 座標
                        pic_Arms_Left.Visible = true;
                    }

                    timer_Arms.Enabled = true;
                    sp_Arms.Play();               //   播放音效!
                }
                else if (ch == 'Z' || ch == 'z')   //  小
                {
                    pic_Arms_Left.Image = pic_Small_Left.Image;
                    pic_Arms_Right.Image = pic_Small_Right.Image;
                    y = 18;
                    sp_Arms.SoundLocation = ("Sound\\ric1.wav");
                    mciMusic("Sound\\轉換.wav", "play");
                }
                else if (ch == 'X' || ch == 'x')   //  中
                {
                    pic_Arms_Left.Image = pic_Medium_Left.Image;
                    pic_Arms_Right.Image = pic_Medium_Right.Image;
                    y = 13;
                    sp_Arms.SoundLocation = ("Sound\\m249-2.wav");
                    mciMusic("Sound\\轉換.wav", "play");
                }
                else if (ch == 'C' || ch == 'c')   //  大
                {
                    pic_Arms_Left.Image = pic_Large_Left.Image;
                    pic_Arms_Right.Image = pic_Large_Right.Image;
                    y = 10;
                    sp_Arms.SoundLocation = ("Sound\\xm1014-1.wav");
                    mciMusic("Sound\\轉換.wav", "play");
                }
                else if (ch == 'S' || ch == 's')   //  一開始的武器!!!
                {
                    pic_Arms_Left.Image = pic_Arms_initiall.Image;
                    pic_Arms_Right.Image = pic_Arms_initiall.Image;
                    y=30;
                    sp_Arms.SoundLocation = ("Sound\\mac10-1.wav");
                    mciMusic("Sound\\轉換.wav", "play");
                }
               else if (ch == 'B' || ch == 'b')    //  Baseball
               {
                   pic_Arms_Left.Image = pic_baseball.Image;
                   pic_Arms_Right.Image = pic_baseball.Image;
                   y = 25;
                   sp_Arms.SoundLocation = ("Sound\\mac10-1.wav");
                   mciMusic("Sound\\轉換.wav", "play");
               }
                else if (ch == 'W' || ch == 'w')   // Level Up
                {
                    timer_Light.Enabled = true;
                    pic_Light.Visible = true;
                    mciMusic("level up-1.wav", "play");
                }
               else if (ch == 'E' || ch == 'e')  //  六芒星
               {
                   timer_Star.Enabled = true;
                   mciMusic("Sound\\Star.wav", "play");
               }
               else
               {
                   timer_Arms.Enabled = false;
               }
            }
            catch(Exception ex){}

        }

        private void timer_Arms_Tick(object sender, EventArgs e)
        {
            if (pic_Arms_Left.Right > this.Width && pic_Arms_Right.Left > this.Width)
            {
                timer_Arms.Enabled = false;
            }

            pic_Arms_Right.Left += 10;        //   往→ 前進
            pic_Arms_Left.Left -= 10;         //   往← 前進
             
        }
        
        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
  //          sp.Stop();    //  關閉背景音樂
            mciMusic(BackGround_Music[number], "stop");  // 經過測試後，此行必加!!!  因為如果沒有這行，下次播放到同一首音樂時會接續上一部份的中斷點接著往下播放。
            Form1.form4_is_opened = false;  // 代表form4處於關閉狀態
        }

        int time_Light = 0; 
        private void timer_Light_Tick(object sender, EventArgs e)
        {
            time_Light++;
            if (time_Light % 3 == 0 && time_Light != 0)
            {
                timer_Light.Enabled=false;
                pic_Light.Visible = false;
            }
        }

        private int time_Star = 0,time_i=0;
        private void timer_Star_Tick(object sender, EventArgs e)
        {
            pic_Unit.BackgroundImage = img_Star.Images[time_i];
            time_Star++;
            time_i++;

            if (time_Star % 33 == 0 && time_Star != 0)   //  約達到兩秒的時後
            {
                pic_Unit.BackgroundImage = imgList_Arms.Images[22];//  換回原本的背景
                timer_Star.Enabled = false;
            }

            if (time_i == img_Star.Images.Count - 1) { time_i = 0; }
        }

        
        private void pic_Background_MouseMove(object sender, MouseEventArgs e)
        {
            pic_Unit.Left = e.X - pic_Unit.Width / 2;
            pic_Unit.Top  = e.Y - pic_Unit.Height/2;
        }
        
        private void pic_Unit_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Show();    //  隱藏滑鼠游標
        }

        private void pic_Unit_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Hide();    //  顯示滑鼠游標
        }

        private void pic_Unit_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    if (direction)  //  如果此時方向"向右"
                    {
                        pic_Arms_Right.Left = pic_Unit.Right; //  武器的 X 座標
                        pic_Arms_Right.Top = pic_Unit.Top + y; //  武器的 Y 座標
                        pic_Arms_Right.Visible = true;
                    }
                    else        //   此時方向"向左"
                    {
                        pic_Arms_Left.Left = pic_Unit.Left - pic_Unit.Width;       //  武器的 X 座標
                        pic_Arms_Left.Top = pic_Unit.Top + y;  //  武器的 Y 座標
                        pic_Arms_Left.Visible = true;
                    }

                    timer_Arms.Enabled = true;
                    sp_Arms.Play();               //   播放音效!

                    break;

                case MouseButtons.Right:    //  圖片轉換方向
                    if (direction) { direction = false; }
                    else { direction = true; }

                    if (direction) { pic_Unit.Image = pic_Unit_Right.Image; }
                    else { pic_Unit.Image = pic_Unit_Left.Image; }

                    break;

            }
        }

        private void panel_Record_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Hide();  //  隱藏滑鼠游標
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pic_Background_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Hide();
        }

        private void pic_Background_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Show();
        }

        

        



        
    }
}
