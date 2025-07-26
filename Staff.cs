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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            
            
              Stock newMDIChild = new Stock();
              newMDIChild.Show();
            
        }

        private void Staff_Load(object sender, EventArgs e)
        {

        }
    }
}
