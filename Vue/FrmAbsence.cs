using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mediatek86.Connexion;
using Mediatek86.Model;

namespace Mediatek86.Vue
{
    public partial class FrmAbsence : Form
    { //Remplir methode au moment de creer les methodes associé cas utilisation AJOUTERABSENCE()
       public void AjoutAbsence()
        {

        }
        
        public void RemplirListeAbsence()
        {
            bdgAbsence.DataSource = Absence.ListeAbsence();
            dtgAbsence.DataSource = bdgAbsence;
            dtgAbsence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgAbsence.MultiSelect = false;
            dtgAbsence.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgAbsence.ReadOnly = true;

        } 
     
        public FrmAbsence()
        {
            InitializeComponent();
            RemplirListeAbsence();
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
           FrmPersonnel frmPersonnel = new FrmPersonnel();
            frmPersonnel.Show();
            this.Hide();
        }

        private void PicIcone_Click(object sender, EventArgs e)
        {
            
        }

        private void absence_Load(object sender, EventArgs e)
        {

        }

        private void dtgAbsence_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dtgAbsence_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
