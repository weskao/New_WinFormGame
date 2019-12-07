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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            // 降低flicker，改善圖像閃爍的情形 
            this.DoubleBuffered = true;  
        }

        
        private bool All_Pic = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (All_Pic)
            {
                pic1.Visible = true;
                pic2.Visible = true;
                pic3.Visible = true;
                pic4.Visible = true;
                pic5.Visible = true;
                pic6.Visible = true;
                pic7.Visible = true;
                pic8.Visible = true;
                pic9.Visible = true;
                pic10.Visible = true;
                pic11.Visible = true;
                pic12.Visible = true;
                pic13.Visible = true;

                All_Pic = false;        //  為了下一次的切換設置

            }
            else
            {
                pic1.Visible = false;
                pic2.Visible = false;
                pic3.Visible = false;
                pic4.Visible = false;
                pic5.Visible = false;
                pic6.Visible = false;
                pic7.Visible = false;
                pic8.Visible = false;
                pic9.Visible = false;
                pic10.Visible = false;
                pic11.Visible = false;
                pic12.Visible = false;
                pic13.Visible = false;

                All_Pic = true;        //  為了下一次的切換設置
            }
        }

        
    }
}
