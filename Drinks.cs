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

/***** TA SIBUYA 42591570 & BJ KHALI 42579759 ***********/
namespace Project1
{
    public partial class Drinks : Form
    {
        public static object Tea { get; internal set; }
        public static object Coffee { get; internal set; }

        public Drinks()
        {
            InitializeComponent();
        }
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BeelteCafDB.mdf;Integrated Security=True;";
        private void Drinks_Load(object sender, EventArgs e)
        {
            rdb_coffee.Checked = false;
            rdb_tea.Checked = false;
        }

        private void rdb_coffee_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_coffee.Checked)
            { 
                grb_Coffee.Visible = true;
                rdb_tea.Checked = false;
                grb_Tea.Visible = false;

                string type = "Coffee";
                string query = "SELECT Name FROM Drinks WHERE Type LIKE '%" + type + "%'";
                lst_Coffee.Items.Clear();
                try
                {
                    SqlConnection cnn = new SqlConnection(connectionString);
                    cnn.Open();

                    SqlCommand cmd = new SqlCommand(query, cnn);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataSet ds = new DataSet();
                    adapter.SelectCommand = cmd;
                    adapter.Fill(ds, "Drinks");
                    SqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {

                        lst_Coffee.Items.Add(reader.GetValue(0));

                    }
                    reader.Close();
                    cnn.Close();

                }

                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }

            
        }

        private void rdb_tea_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_tea.Checked)
            {
                grb_Tea.Visible = true;
                rdb_coffee.Checked = false;
                grb_Coffee.Visible = false;

                string type = "Tea";
                string query = "SELECT Name FROM Drinks WHERE Type LIKE '%" + type + "%'";
                lst_Tea.Items.Clear();
                try
                {
                    SqlConnection cnn = new SqlConnection(connectionString);
                    cnn.Open();

                    SqlCommand cmd = new SqlCommand(query, cnn);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataSet ds = new DataSet();
                    adapter.SelectCommand = cmd;
                    adapter.Fill(ds, "Drinks");
                    SqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {

                        lst_Tea.Items.Add(reader.GetValue(0));

                    }
                    reader.Close();
                    cnn.Close();

                }

                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Coffee = lst_Coffee.SelectedItem.ToString();
            Tea = lst_Coffee.SelectedItem.ToString();
            MessageBox.Show("Item Added to cart");
        }
    }
}
