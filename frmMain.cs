using dad_ViziteuMihai.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dad_ViziteuMihai
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnConturi_Click(object sender, EventArgs e)
        {
            var frm = new frmConturi();
            frm.Show();
        }

        private void btnRulaje_Click(object sender, EventArgs e)
        {
            var frm = new frmRulaje();
            frm.Show();
        }

        private void btnBalanta_Click(object sender, EventArgs e)
        {
            var frm = new frmBalanta();
            frm.Show();
        }
    }
}
