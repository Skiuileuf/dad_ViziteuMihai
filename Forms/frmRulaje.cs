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
    public partial class frmRulaje : Form
    {
        public frmRulaje()
        {
            InitializeComponent();
        }

        databaseEntities dad = new databaseEntities();

        private void frmRulaje_Load(object sender, EventArgs e)
        {
            dad.Operatie.Include("Rulaje").Load();
            bindingSource.DataSource = dad.Operatie.Local.ToBindingList();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.bindingSource.EndEdit();
                dad.SaveChanges();
                bindingSource.ResetBindings(false);
                MessageBox.Show("Datele au fost salvate");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Datele nu pot fi salvate! {ex.Message}");
            }
        }
    }
}
