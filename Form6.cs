using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApp6
{
    public partial class Form6 : Form
    {

        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;



        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-7GFCUDL;Initial Catalog=master;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("INSERT INTO Professor (codeProfessor , nameprofessor , lastnameprofessor , Idprofessor , fathername , birthday , Crosssection ) VALUES(@codeProfessor , @nameprofessor , @lastnameprofessor , @Idprofessor , @fathername , @birthday , @Crosssection)", con);
            if (textBox1.Text == "")
            {
                MessageBox.Show("کد استاد را وارد کنید");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("   نام را وارد کنید");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("   نام خانوادگی را وارد کنید");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("   کد ملی را وارد کنید");
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("   نام پدر را وارد کنید");
            }
           
            else if (textBox7.Text == "")
            {
                MessageBox.Show("   مقطع را وارد کنید");
            }
            else
            {
                cmd.Parameters.Add("@codeProfessor", textBox1.Text);
                cmd.Parameters.Add("@nameprofessor", textBox2.Text);
                cmd.Parameters.Add("@lastnameprofessor", textBox3.Text);
                cmd.Parameters.Add("@Idprofessor", textBox4.Text);
                cmd.Parameters.Add("@fathername", textBox5.Text);
                cmd.Parameters.Add("@birthday", textBox6.Text);
                cmd.Parameters.Add("@Crosssection", textBox7.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("استاد ثبت شد");
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
           
        }
    }
}
