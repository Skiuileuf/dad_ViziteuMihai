using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dad_ViziteuMihai.Forms
{
    public partial class frmBalanta : Form
    {
        public frmBalanta()
        {
            InitializeComponent();
        }

        private void frmBalanta_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
