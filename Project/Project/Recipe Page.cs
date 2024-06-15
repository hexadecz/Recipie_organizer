using MySql.Data.MySqlClient;
using System;
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
    public partial class Recipe_Page : Form
    {
        public Recipe_Page()
        {
            InitializeComponent();
        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            string server = "localhost";
            string uid = "root";
            string password = "project5";
            string database = "myrecipe";
            string constring = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            
            string query = "insert into recipe(title,instructions) values ('" + titledataTextBox.Text + "','" + instructioninputTextBox.Text + "'); insert into category(color) values ('" + categoryinputTextBox.Text + "') ;   insert into baseitem(baseitem_name) values('" + ingredientinputTextBox.Text + "') ;  insert into ingredient(quantity) values('" + numericUpDown2.Text + "') ";

            MySqlCommand cmd = new MySqlCommand(query, con);


            int i = cmd.ExecuteNonQuery();
            if (i > -1)
            {
                MessageBox.Show("Data Successfully insterted");
            }

            else { MessageBox.Show("Error data not inserted"); }


            con.Close();


            this.Hide();
        }
    }
}
