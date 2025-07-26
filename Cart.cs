using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/***** TA SIBUYA 42591570 & BJ KHALI 42579759 ***********/
namespace Project1
{
    public partial class Cart : Form
    {
        string Coffee { get; set; }
        string Tea { get; set; }
        string Pastry { get; set; }
        string Sandwich { get; set; }

        public Cart()
        {
            InitializeComponent();

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Receipt newMDIChild = new Receipt();
            // Set the Parent Form of the Child window.
            //newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            lst_Cart.Items.Add(Drinks.Coffee);
            lst_Cart.Items.Add(Drinks.Tea);
            lst_Cart.Items.Add(Food.Pastry);
            lst_Cart.Items.Add(Food.Sandwich);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                // If frmSearch is Opened, set focus to it and exit subroutine.
                if (form.GetType() == typeof(Food))
                {

                    form.Activate();
                    return;
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                // If frmSearch is Opened, set focus to it and exit subroutine.
                if (form.GetType() == typeof(Drinks))
                {

                    form.Activate();
                    return;
                }
            }
        }
    }
}
