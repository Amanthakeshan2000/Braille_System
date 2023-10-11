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
    public partial class Square_Page : UserControl
    {
        public Square_Page()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.Restart();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel1.Show();


//Calculate------------------------------------------------>
            try
            {
                int x;
                x = Convert.ToInt32(textBox1.Text);
                float ansC = 4 * x;

                textBox2.Text = Convert.ToString(ansC);


                //pass value BrailleConvert_Class
                BrailleConvert_Class.pass1 = textBox2.Text;

                //get value BrailleConvert_Class
                textBox3.Text = BrailleConvert_Class.pass1;

                //pass value BrailleToDot_Class
                BrailleToDot_Class.pass2 = textBox2.Text;

                //get value BrailleToDot_Class
                textBox4.Text = BrailleToDot_Class.pass2;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please Enter Values");
            }
        }

        private void bttn_Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString("");
            textBox2.Text = Convert.ToString("");
            textBox3.Text = Convert.ToString("");
            textBox4.Text = Convert.ToString("");
        }
    }
}
