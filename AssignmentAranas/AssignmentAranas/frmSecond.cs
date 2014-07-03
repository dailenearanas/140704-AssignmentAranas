using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentAranas
{
    public partial class frmSecond : Form
    {
        public frmSecond()
        {
            InitializeComponent();
        }

        private void btnCance_Click(object sender, EventArgs e)
        {
            txtNum.Text = "0";
            this.Close(); 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double number = 0;
            if (double.TryParse(txtNum.Text.Trim(), out number))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Input numbers only okay?");
            }
            
        }        
    }
}
