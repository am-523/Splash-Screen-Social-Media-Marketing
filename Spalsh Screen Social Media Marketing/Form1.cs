using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spalsh_Screen_Social_Media_Marketing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int  count = 1;

        private void slider()
        {

            if(count == 4)
            {
                count = 1;
            }
            guna2PictureBox1.ImageLocation = string.Format(@"Img\{0}.png", count);
            count++;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            slider();
        }
    }
}
