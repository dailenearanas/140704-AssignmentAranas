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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            try
            {
                frmSecond frm = new frmSecond();
                frm.ShowDialog();
                
                double a = Convert.ToDouble(frm.txtNum.Text) + Convert.ToDouble(btnNum.Text);
                btnNum.Text = a.ToString(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }           
        }      
    }
}
