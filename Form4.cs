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
    public partial class Form4 : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        public Form4()
        {
            InitializeComponent();
                 
        }
       

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-7GFCUDL;Initial Catalog=master;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("INSERT INTO student (codestdent , namestudent , lastnamestudent , Idstudent , fathername , birthday , field ) VALUES(@codestdent , @namestudent , @lastnamestudent , @Idstudent , @fathername , @birthday , @field)", con);
            if (textBox1.Text == "")
            {
                MessageBox.Show("شماره دانشجویی را وارد کنید");
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
                MessageBox.Show("   رشته تحصیلی  را وارد کنید");
            }
            else
            {
                cmd.Parameters.Add("@codestdent", textBox1.Text);
                cmd.Parameters.Add("@namestudent", textBox2.Text);
                cmd.Parameters.Add("@lastnamestudent", textBox3.Text);
                cmd.Parameters.Add("@Idstudent", textBox4.Text);
                cmd.Parameters.Add("@fathername", textBox5.Text);
                cmd.Parameters.Add("@birthday", textBox6.Text);
                cmd.Parameters.Add("@field", textBox7.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("دانشجو ثبت شد");
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = ""; 
            textBox7.Text = "";

        }
    }
}
