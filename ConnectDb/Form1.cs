using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ConnectDb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string connectionString = "Data Source=WIN-RTEN43736N0\\SQLEXPRESS;Initial Catalog=TestDb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            /*
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Emp WHERE ID = '" + textBox1.Text + "'", conn );
            DataTable dt = new DataTable();
            sda.Fill(dt);

            textBox1.Text = dt.Rows[0][0].ToString();
            textBox2.Text = dt.Rows[0][1].ToString();
            textBox3.Text = dt.Rows[0][2].ToString();
            textBox4.Text = dt.Rows[0][3].ToString();
            */

            conn.Open();
            //SqlCommand command = new SqlCommand("SELECT * FROM Emp WHERE ID = @id", conn);
            //command.Parameters.Add(new SqlParameter("id", 1));
            SqlCommand command = new SqlCommand("SELECT * FROM Emp", conn);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0} \t {1} \t {2} \t {3}", reader[0], reader[1], reader[2], reader[3])) ;
                }
            }

        }
    }
}
