using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dad_ViziteuMihai.Forms
{
    public partial class frmConturi : Form
    {
        public frmConturi()
        {
            InitializeComponent();
        }

        databaseEntities dad = new databaseEntities();

        private void frmConturi_Load(object sender, EventArgs e)
        {
            dad.Cont.Load();

            contBindingSource.DataSource = dad.Cont.Local.ToBindingList();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.contBindingSource.EndEdit();
                dad.SaveChanges();
                contBindingSource.ResetBindings(false);
                MessageBox.Show("Datele au fost salvate");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Datele nu pot fi salvate! {ex.Message}");
            }
        }
    }
}
