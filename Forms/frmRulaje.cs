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
            try
            {
                dad.Cont.Load();
                dad.Operatie.Include("Rulaje").Load();

                bsCont.DataSource = dad.Cont.Local;
                bsOperatie.DataSource = dad.Operatie.Local.ToBindingList();

            } catch (Exception ex)
            {
                // nu ar trebui sa se intample prea des ayaye
                MessageBox.Show($"Ups eroare UwU {ex.Message}");
            }

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.bsOperatie.EndEdit();
                dad.SaveChanges();
                bsOperatie.ResetBindings(false);
                MessageBox.Show("Datele au fost salvate");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Datele nu pot fi salvate! {ex.Message}");
            }
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Mananca eroarea
            // yum yum
        }
    }

    public class myColl<T> : System.Collections.ObjectModel.ObservableCollection<T>
    {

    }
}
