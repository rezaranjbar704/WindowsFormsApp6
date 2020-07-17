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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            

            
        }

        private void button3_Click(object sender, EventArgs e)
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
                textBox7.Text = da.GetValue(2).ToString();


            }
            con.Close();




            SqlConnection Connection = new SqlConnection("Server=DESKTOP-7GFCUDL;Database=master;Trusted_Connection =True");
            // Connection.ConnectionString = "Server=DESKTOP-7GFCUDL;Database=master;Trusted_Connection =True";

            
            string selectsql = "Select * FROM Grading --WHERE codestdent  = @codestdent  ";

            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandText = selectsql;

            DataTable table = new DataTable();

            Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = Command;

            adapter.Fill(table);

            Connection.Close();



            dataGridView1.DataSource = table;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
