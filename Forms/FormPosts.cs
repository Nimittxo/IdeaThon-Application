using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProjectPsi.Forms
{
    public partial class FormPosts : Form
    {
        public FormPosts()
        {
            InitializeComponent();
        }

        private void documentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.documentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.modelDataSet);

        }

        private void FormPosts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'modelDataSet.Documents' table. You can move, or remove it, as needed.
            this.documentsTableAdapter.Fill(this.modelDataSet.Documents);
            pieChart1_ChildChanged(pieChart1, null);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pieChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {
            
        }
    }
}
