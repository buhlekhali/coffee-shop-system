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
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                // If frmSearch is Opened, set focus to it and exit subroutine.
                if (form.GetType() == typeof(Form1))
                {

                    form.Activate();
                    return;
                }
            }
            /*Form1 newMDIChild = new Form1();
            // Set the Parent Form of the Child window.
            //newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();*/
        }

        private void Receipt_Load(object sender, EventArgs e)
        {

        }
    }
}
