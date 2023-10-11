using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA_Assignment
{
    public partial class Rectangle_Page : UserControl
    {
        public Rectangle_Page()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.Restart();
        }

        private void Rectangle_Page_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel1.Show();

//Calculate------------------------------------------------>
            try
            {
                int x, y;
                x = Convert.ToInt32(textBox1.Text);
                y = Convert.ToInt32(textBox2.Text);

                float ansC = 2 * (x + y);

                textBox5.Text = Convert.ToString(ansC);


//pass value BrailleConvert_Class
BrailleConvert_Class.pass1 = textBox5.Text;

 //get value BrailleConvert_Class
textBox3.Text = BrailleConvert_Class.pass1;


                //pass value BrailleToDot_Class
                BrailleToDot_Class.pass2 = textBox5.Text;

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
            textBox5.Text = Convert.ToString("");
        }
    }
}
