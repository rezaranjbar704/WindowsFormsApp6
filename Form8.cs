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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7GFCUDL;Initial Catalog=master;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select namelesso    , course	  , codeProfessor   , startdate    , examday    , field   from Lesson where codelesson   = @codelesson   ", con);
            cmd.Parameters.AddWithValue("@codelesson  ", int.Parse(textBox1.Text));
            SqlDataReader da = cmd.ExecuteReader();

            while (da.Read())
            {
                textBox2.Text = da.GetValue(0).ToString();
                textBox3.Text = da.GetValue(1).ToString();
                textBox4.Text = da.GetValue(2).ToString();
                textBox5.Text = da.GetValue(3).ToString();
                textBox6.Text = da.GetValue(4).ToString();
                textBox7.Text = da.GetValue(5).ToString();


            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7GFCUDL;Initial Catalog=master;Integrated Security=True");
            con.Open();
            string codelesson = textBox1.Text;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Delete from Lesson where codelesson ='" + codelesson + "' ";

            cmd.ExecuteNonQuery();
            MessageBox.Show("درس حذف شد");
            con.Close();
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
