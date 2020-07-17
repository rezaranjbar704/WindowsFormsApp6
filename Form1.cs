using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("نام کاربری را وارد کنید");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("رمز عبور را وارد کنید");
            }
            else
            {
                if (textBox1.Text == "admin" && textBox2.Text == "admin")
                {
                    this.Hide();
                    Form3 f3 = new Form3();
                    f3.Show();

                }
                else
                {
                    MessageBox.Show(" نام کاربری یا رمز عبور اشتباه میباشد");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }
        }
    }
}
