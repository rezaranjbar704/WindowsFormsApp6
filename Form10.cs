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
    public partial class Form10 : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        public Form10()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            con = new SqlConnection(@"Data Source=DESKTOP-7GFCUDL;Initial Catalog=master;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("INSERT INTO Grading (codestdent  , codelesson  , grade  ) VALUES(@codestdent , @codelesson , @grade )", con);
            if (textBox2.Text == "")
            {
                MessageBox.Show("کد دانشجو را وارد کنید");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("   کد درس را وارد کنید");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("   نمره درس را وارد کنید");
            }
            else
            {
                cmd.Parameters.Add("@codestdent", textBox2.Text);
                cmd.Parameters.Add("@codelesson", textBox3.Text);
                cmd.Parameters.Add("@grade", textBox4.Text);



                cmd.ExecuteNonQuery();
                MessageBox.Show("  نمره این درس دانشجو ثبت شد ");
            }
        }
    }
}
