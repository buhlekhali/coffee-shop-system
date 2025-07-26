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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void pastriesAndSandwichesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void coffeeTeaToolStripMenuItem_Click(object sender, EventArgs e)
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

            Drinks newMDIChild = new Drinks();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            newMDIChild.ClientSize = new System.Drawing.Size(2000, 800);
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            newMDIChild.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            newMDIChild.Dock = DockStyle.Fill;
            newMDIChild.Show();
        }

        private void pastriesSandwichesToolStripMenuItem_Click(object sender, EventArgs e)
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

            Food newMDIChild = new Food();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            newMDIChild.ClientSize = new System.Drawing.Size(2000, 800);
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            newMDIChild.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            newMDIChild.Dock = DockStyle.Fill;
            newMDIChild.Show();
        }

        private void cartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                // If frmSearch is Opened, set focus to it and exit subroutine.
                if (form.GetType() == typeof(Cart))
                {

                    form.Activate();
                    return;
                }
            }

            Cart newMDIChild = new Cart();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            newMDIChild.ClientSize = new System.Drawing.Size(2000, 800);
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            newMDIChild.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            newMDIChild.Dock = DockStyle.Fill;
            newMDIChild.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
                Form1 ch2 = new Form1();
                ch2.Show();
            }
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                // If frmSearch is Opened, set focus to it and exit subroutine.
                if (form.GetType() == typeof(Staff))
                {

                    form.Activate();
                    return;
                }
            }

            Staff newMDIChild = new Staff();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            newMDIChild.ClientSize = new System.Drawing.Size(2000, 800);
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            newMDIChild.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            newMDIChild.Dock = DockStyle.Fill;
            newMDIChild.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
