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
    public partial class Form5 : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-7GFCUDL;Initial Catalog=master;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("INSERT INTO Lesson (codelesson , namelesso , course , codeProfessor , startdate , examday , field ) VALUES(@codelesson , @namelesso , @course , @codeProfessor , @startdate , @examday , @field)", con);
            if (textBox1.Text == "")
            {
                MessageBox.Show("کد درس را وارد کنید");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("   نام درس را وارد کنید");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("   واحد درس را وارد کنید");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("   کد استاد را وارد کنید");
            }
           
            else if (textBox7.Text == "")
            {
                MessageBox.Show("   رشته تحصیلی  را وارد کنید");
            }
            else
            {
                cmd.Parameters.Add("@codelesson", textBox1.Text);
                cmd.Parameters.Add("@namelesso", textBox2.Text);
                cmd.Parameters.Add("@course", textBox3.Text);
                cmd.Parameters.Add("@codeProfessor", textBox4.Text);
                cmd.Parameters.Add("@startdate", textBox5.Text);
                cmd.Parameters.Add("@examday", textBox6.Text);
                cmd.Parameters.Add("@field", textBox7.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("درس ثبت شد");
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
