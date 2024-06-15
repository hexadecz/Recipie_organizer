using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Random_Page : Form
    {
        public Random_Page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Random rnd = new Random();
            // int x = rnd.Next(1, 10);



            string server = "localhost";
            string uid = "root";
            string password = "project5";
            string database = "myrecipe";
            string constring = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();

            string query = " ";
            //View.rowfilter = "recipie_id = 'x'";
            MySqlCommand cmd2 = new MySqlCommand("SELECT * from recipe", con);

            // use count to get max number in table
            int i = cmd2.ExecuteNonQuery();
            if (i > -1)
            {
                MessageBox.Show("Data Successfully insterted");
            }

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd2;
            DataSet ds2 = new DataSet();
            DataTable dt = new DataTable();
            adapter.Fill(ds2);
            dt = ds2.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                dataGridView1.DataSource = ds2.Tables[0];
            }

            con.Close();







        }


    }
}
