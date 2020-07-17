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
    public partial class Form12 : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        public Form12()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7GFCUDL;Initial Catalog=master;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select namestudent  , lastnamestudent  , field  from student where codestdent  = @codestdent  ", con);
            cmd.Parameters.AddWithValue("@codestdent ", int.Parse(textBox1.Text));
            SqlDataReader da = cmd.ExecuteReader();

            while (da.Read())
            {
                textBox2.Text = da.GetValue(0).ToString();
                textBox3.Text = da.GetValue(1).ToString();
                textBox4.Text = da.GetValue(2).ToString();
               


            }
            con.Close();


            SqlConnection Connection = new SqlConnection("Server=DESKTOP-7GFCUDL;Database=master;Trusted_Connection =True");
            // Connection.ConnectionString = "Server=DESKTOP-7GFCUDL;Database=master;Trusted_Connection =True";

            string insertsql = "INSERT INTO Selectunit VALUES (@codestdent , @codelesson , @namelesso , @course , @codeProfessor , @startdate , @examday , @field) ";
            string selectsql = "Select * FROM Selectunit   " ;
            string selectWhereClause = "WHERE codestdent = @codestdent ";

            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandText = selectsql;


            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                selectsql += selectWhereClause;
                Command.Parameters.Clear();
                SqlParameter Selectunitcode = new SqlParameter("codestdent", textBox1.Text);
                Command.Parameters.Add(Selectunitcode);
            }



            DataTable table = new DataTable();

            Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = Command;

            adapter.Fill(table);

            Connection.Close();



            dataGridView1.DataSource = table;





        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7GFCUDL;Initial Catalog=master;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select namelesso    , course	  , codeProfessor   , startdate    , examday    , field   from Lesson where codelesson   = @codelesson   ", con);
            cmd.Parameters.AddWithValue("@codelesson  ", Convert.ToInt32(textBox5.Text));
            SqlDataReader da = cmd.ExecuteReader();

            while (da.Read())
            {
                textBox6.Text = da.GetValue(0).ToString();
                textBox7.Text = da.GetValue(1).ToString();
                textBox8.Text = da.GetValue(2).ToString();
                textBox9.Text = da.GetValue(3).ToString();
                textBox10.Text = da.GetValue(4).ToString();
                textBox11.Text = da.GetValue(5).ToString();


            }
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-7GFCUDL;Initial Catalog=master;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("INSERT INTO Selectunit (codestdent , codelesson , namelesso , course , codeProfessor , startdate , examday , field ) VALUES(@codestdent , @codelesson , @namelesso , @course , @codeProfessor , @startdate , @examday , @field)", con);

                cmd.Parameters.Add("@codestdent", textBox1.Text);
                cmd.Parameters.Add("@codelesson", textBox5.Text);
                cmd.Parameters.Add("@namelesso", textBox6.Text);
                cmd.Parameters.Add("@course", textBox7.Text);
                cmd.Parameters.Add("@codeProfessor", textBox8.Text);
                cmd.Parameters.Add("@startdate", textBox9.Text);
                cmd.Parameters.Add("@examday", textBox10.Text);
                cmd.Parameters.Add("@field", textBox11.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("درس ثبت شد");
            this.Hide();
            Form12 f12 = new Form12();
            f12.Show();
            
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7GFCUDL;Initial Catalog=master;Integrated Security=True");
            con.Open();
            string codelesson = textBox5.Text;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Delete from Selectunit where codelesson ='" + codelesson + "' ";

            cmd.ExecuteNonQuery();
            MessageBox.Show("درس حذف شد");
            con.Close();
            this.Hide();
            Form12 f12 =new Form12();
            f12.Show();
        }
    }
}
