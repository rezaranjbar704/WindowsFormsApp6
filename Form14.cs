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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection("Server=DESKTOP-7GFCUDL;Database=master;Trusted_Connection =True");
            // Connection.ConnectionString = "Server=DESKTOP-7GFCUDL;Database=master;Trusted_Connection =True";


            string selectsql = "Select * FROM student   ";

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
    }
}
