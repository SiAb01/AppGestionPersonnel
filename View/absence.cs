using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediatek86
{
    public partial class absence : Form
    {
        public absence()
        {
            InitializeComponent();
        }

        private void lstabsence_MouseClick(object sender, MouseEventArgs e)
        {
            grpAjoutAbsence.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voulez vous confirmer ce choix ?", "Confirmation", MessageBoxButtons.YesNoCancel , MessageBoxIcon.Warning);
        }

        private void DatepDatedebut_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lstabsence_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            grpAjoutAbsence.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            grpAjoutAbsence.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voulez vous confirmer ce choix ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop);
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Mainapp mainapp = new Mainapp();
            mainapp.Show();
            this.Hide();
        }
    }
}
