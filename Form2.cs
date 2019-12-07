using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace New_視窗程式
{
    public partial class Form2 : Form
    {
        public class F1 : Form1 { }

        public Form2()
        {
            InitializeComponent();

            // 降低flicker，改善圖像閃爍的情形 
            this.DoubleBuffered = true;  

            /*        F1 form1 = new F1();

                    this.Left = form1.Left + form1.Width;  //  設定 X 座標
                    this.Top = form1.Top;    //  設定 Y 座標  

                    this.Height = form1.Height;   */


        }

        private int n=0,num=0;
        private void timer_Tick(object sender, EventArgs e)
        {
            n++;
            num++;
            if (n == imgList_Bird.Images.Count)
            {
                n = 0;
            }
            /* 圖片1  */
            pic_Bird.Left = (pic_Bird.Left + this.Width) % this.Width;
            pic_Bird.Top = (pic_Bird.Top + this.Height) % this.Height;
            ////////////////////////////////////////////////////////////

            /* 圖片2  */
            pic_Runner.Left = (pic_Runner.Left + this.Width) % this.Width;
            pic_Runner.Top = (pic_Runner.Top + this.Height) % this.Height;
            //////////////////////////////////////////////////////////////

            /* 圖片3  */
            pic_weapon.Left = (pic_weapon.Left + this.Width) % this.Width;
            pic_weapon.Top = (pic_weapon.Top + this.Height) % this.Height;
            //////////////////////////////////////////////////////////////

            /*    if (pic_Bird.Left >= this.Width)
                {
                    pic_Bird.Left = 0 - pic_Bird.Width;
                }*/

            pic_Bird.Image = imgList_Bird.Images[n];
            pic_Bird.Left += 2;
            pic_weapon.Left -= 18;
        }


        private void btn_Up_Click(object sender, EventArgs e)
        {
            pic_Bird.Top -= 4;
        }

        private void btn_Down_Click(object sender, EventArgs e)
        {
            pic_Bird.Top += 4;
        }


        private void btn_Left_Click(object sender, EventArgs e)  //  左
        {
            pic_Bird.Left -= 4;
        }

        private void btn_Right_Click(object sender, EventArgs e)  //  右
        {
            pic_Bird.Left += 4;
        }


        private void Form2_KeyDown(object sender, KeyEventArgs e) //鍵盤控制 - 上下左右
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    //       pic_Bird.Top -= 4;
                    pic_Runner.Top -= 4;
                    break;
                case Keys.Down:
                    //     pic_Bird.Top += 4;
                    pic_Runner.Top += 4;
                    break;
                case Keys.Left:
                    //     pic_Bird.Left-=4;
                    pic_Runner.Left -= 4;
                    break;
                case Keys.Right:
                    //     pic_Bird.Left += 4;
                    pic_Runner.Left += 4;
                    break;
            }
        }

        //////////////////////////////////////////////////////////

        private void btn_Up_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    pic_Bird.Top -= 4;
                    break;
            }
        }

        private void btn_Down_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    pic_Bird.Top += 4;
                    break;
            }
        }

        private void btn_Left_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    pic_Bird.Left -= 4;
                    break;
            }
        }

        private void btn_Right_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    pic_Bird.Left += 4;
                    break;
            }
        }


        private void pic_Bird_LocationChanged_1(object sender, EventArgs e)
        {

            int value = (pic_Bird.Left) * 100 / this.Width;
            progressBar1.Value = value;
            lblprocess.Text = value.ToString();
        }


        private int count = 0;
        private void timer_pic_Tick(object sender, EventArgs e)
        {
            count++;
            if (count == imgList_weapon.Images.Count)
            {
                count = 0;
            }

            pic_weapon.Image = imgList_weapon.Images[count];
        }

        
        

        
        




        //////////////////////////////////////////////////////////


    }
}
