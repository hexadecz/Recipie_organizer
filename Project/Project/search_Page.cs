using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class search_Page : Form
    {
        private Recipe recipe;
        public search_Page()
        {
            InitializeComponent();

        }

        private void button_search_Click(object sender, EventArgs e)
        {


            string server = "localhost";
            string uid = "root";
            string password = "project5";
            string database = "myrecipe";
            string constring = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(constring);

            con.Open();





            string query = "select * from recipe where title like " + textBox_searchbytitle.Text + "";
            MySqlCommand cmd2 = new MySqlCommand(query, con);
            cmd2.Parameters.AddWithValue("@title", $"%{textBox_searchbytitle.Text}%");

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd2);
            DataTable dt = new DataTable("recipe");

            adapter.Fill(dt);
            dataGridView1.DataSource = dt;







            int i = cmd2.ExecuteNonQuery();
            if (i > -1)
            {
                MessageBox.Show("Data Successfully insterted");
            }



            con.Close();
        }

        public void RfreshData()
        {

            string server = "localhost";
            string uid = "root";
            string password = "project5";
            string database = "myrecipe";
            string constring = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            DataTable dt = new DataTable("recipe");
            DataSet ds = new DataSet();
            string query = " ";
            MySqlCommand cmd3 = new MySqlCommand("SELECT * from recipe", con);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(cmd3);
            mySqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

            int i = cmd3.ExecuteNonQuery();
            if (i > -1)
            {
                MessageBox.Show("Data Successfully insterted");
            }
        }

        private void textBox_searchbytitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                button_search_Click(sender, e);

            // dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox_searchbytitle_TextChanged(object sender, EventArgs e)
        {
            string server = "localhost";
            string uid = "root";
            string password = "project5";
            string database = "myrecipe";
            string constring = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(constring);

            con.Open();





            string query = "select * from recipe where title like " + "'" + textBox_searchbytitle.Text+"%'" + "";
            MySqlCommand cmd2 = new MySqlCommand(query, con);
            //cmd2.Parameters.AddWithValue("@title", $"%{textBox_searchbytitle.Text}%");

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd2);
            DataTable dt = new DataTable("recipe");

            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            MessageBox.Show(dt.Rows[0]);
        }
    }

}

