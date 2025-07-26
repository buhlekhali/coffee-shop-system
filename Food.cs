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
    public partial class Food : Form
    {
        public static object Pastry { get; set; }
        public static object Sandwich { get; set; }
        public Food()
        {
            InitializeComponent();
        }
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BeelteCafDB.mdf;Integrated Security=True;";

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(rdb_pastry.Checked)
            {
                grb_pastry.Visible = true;
                rdb_sandwich.Checked = false;
                grb_sandwich.Visible = false;
                string type = "Pastry";
                string query = "SELECT Name FROM Food WHERE Type LIKE '%" + type + "%'";
                lst_pastry.Items.Clear();
                try
                {
                    SqlConnection cnn = new SqlConnection(connectionString);
                    cnn.Open();

                    SqlCommand cmd = new SqlCommand(query, cnn);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataSet ds = new DataSet();
                    adapter.SelectCommand = cmd;
                    adapter.Fill(ds, "Food");
                    SqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {

                        lst_pastry.Items.Add(reader.GetValue(0));

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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(rdb_sandwich.Checked)
            {
                grb_sandwich.Visible = true;
                rdb_pastry.Checked = false;
                grb_pastry.Visible = false;
            
                string type = "Sandwich";
                string query = "SELECT Name FROM Food WHERE Type LIKE '%" + type + "%'";
                lst_Sandwich.Items.Clear();
                try
                {
                    SqlConnection cnn = new SqlConnection(connectionString);
                    cnn.Open();

                    SqlCommand cmd = new SqlCommand(query, cnn);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataSet ds = new DataSet();
                    adapter.SelectCommand = cmd;
                    adapter.Fill(ds, "Food");
                    SqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {

                        lst_Sandwich.Items.Add(reader.GetValue(0));

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
 

        private void Food_Load(object sender, EventArgs e)
        {
            rdb_pastry.Checked = false;
            rdb_sandwich.Checked = false;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Pastry = lst_pastry.SelectedItem.ToString();
            Sandwich = lst_Sandwich.SelectedItem.ToString();
            MessageBox.Show("Item Added to cart");
        }
    }
}
