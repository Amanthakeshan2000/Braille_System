using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SA_Assignment
{
    public partial class Start_Page : Form
    {
        public Start_Page()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool expand = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(expand == false) 
            {
                flowLayoutPanel1.Height += 15;
                if(flowLayoutPanel1.Height >= flowLayoutPanel1.MaximumSize.Height)
                {
                    timer1.Stop();
                    expand = false;
                }

            }
            else
            {
                flowLayoutPanel1.Height -= 15;
                if (flowLayoutPanel1.Height <= flowLayoutPanel1.MinimumSize.Height)
                {
                    timer1.Stop();
                    expand = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void bttn_Circle_Click(object sender, EventArgs e)
        {

            circle_Page1.Show();



        }

        private void bttn_Rectangle_Click(object sender, EventArgs e)
        {
            rectangle_Page1.Show();
        }

        private void bttn_Square_Click(object sender, EventArgs e)
        {
            square_Page1.Show();
        }

        private void bttn_Triangle_Click(object sender, EventArgs e)
        {
            triangle_Page1.Show();
        }

        private void triangle_Page1_Load(object sender, EventArgs e)
        {

        }

        private void triangle_Page1_Load_1(object sender, EventArgs e)
        {
            
        }



        //private void flowLayoutPanel1_Click(object sender, EventArgs e)
        //{
        // timer1.Start();
        //}



        //private void button1_Click(object sender, EventArgs e)
        //{
        //  timer1.Start();
        //}
    }
}
