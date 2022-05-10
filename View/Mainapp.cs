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
    public partial class Mainapp : Form
    {
        public Mainapp()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voulez vous confirmer ce choix ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop);
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voulez vous confirmer ce choix ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
        }

        private void grpAjouterPersonnel_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            grpAjouterPersonnel.Visible = true;
            if(grpaffichecontact.Visible = true)
             grpaffichecontact.Visible = false;
        }

        private void btnModifFiche_Click(object sender, EventArgs e)
        {
            grpAjouterPersonnel.Visible = true;
            if (grpaffichecontact.Visible =  true)
                grpaffichecontact.Visible = false;




        }

        private void lstpersonnel_MouseClick(object sender, MouseEventArgs e)
        {
            grpaffichecontact.Visible = true;
            if (grpAjouterPersonnel.Visible = true)
                grpAjouterPersonnel.Visible = false;
        }

        private void btnGererAbs(object sender, EventArgs e)
        {
            absence Absence = new absence();
            Absence.Show();
            this.Hide();
        }

        private void grpaffichecontact_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            formBase FormBase = new formBase();
            FormBase.Show();
            this.Close();
        }
    }
}
