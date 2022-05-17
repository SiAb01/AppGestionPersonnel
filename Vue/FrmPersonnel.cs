using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mediatek86.Model;
using Mediatek86.Dal;
using Mediatek86.Connexion;

namespace Mediatek86.Vue
{ 
    public partial class FrmPersonnel : Form


    {
        public void RemplirListeAbsence()
        {
            bdgPersonnel.DataSource = Personnel.ListePersonnels();
            dtgPersonnel.DataSource = bdgPersonnel;
            dtgPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgPersonnel.MultiSelect = false;
            dtgPersonnel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgPersonnel.ReadOnly = true;

        }
        public FrmPersonnel()
        {
            InitializeComponent();
            RemplirListeAbsence();
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
            FrmAbsence frmAbsence= new FrmAbsence();
            frmAbsence.Show();
            this.Hide();
        }

        private void grpaffichecontact_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmAuthentification FormBase = new FrmAuthentification();
            FormBase.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /// Evenememnt se déclenche que lorsque qu'on clique sur une cell champs donc faux
           /// int indexrow = dtgPersonnel.CurrentRow.Index;
           /// MessageBox.Show("hellleo"+ indexrow.ToString());
        }

        private void Mainapp_Load(object sender, EventArgs e)
        {

        }

        private void dtgPersonnel_CellClick(object sender, DataGridViewCellEventArgs e)
        {   /// Pour les cas utilisation modif ou annuler
            int indexrow = dtgPersonnel.CurrentRow.Index;
            MessageBox.Show("hellleo"+ indexrow.ToString());
        }

        private void btnValiderAjoutPersonel_Click(object sender, EventArgs e)
        {
            ///Personnel personnel;
            // MessageBox.Show("Voulez vous confirmer ce choix ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            ///verifier si les champs sont correcte
            if (!txtnom.Text.Equals("") && !txtprenom.Text.Equals("") && !txtprenom.Text.Equals("") && !txtEmail.Text.Equals("") && cbxservice.SelectedIndex != -1 && !txttelephone.Text.Equals(""))
            { /// Pour la modification
              /// int idunpersonnel = (int)dtgPersonnel.SelectedRows[0].Cells["idpersonnel"].Value;
                string serviceunpersonnel = cbxservice.SelectedItem.ToString();
                int idunpersonnel = Personnel.ListePersonnels().Count() + 1;
                MessageBox.Show(idunpersonnel.ToString());
                Personnel personnel = new Personnel((int)idunpersonnel, (string)txtnom.Text, (string)txtprenom.Text, (string)serviceunpersonnel, (string)txttelephone.Text, (string)txtEmail.Text);
                
             
                MessageBox.Show("Le personnel " + personnel.ToString() + "a été ajouté .");
                
                Personnel.lalistepersonnel.Add(personnel);
                MessageBox.Show(" la liste : "+Personnel.lalistepersonnel[0].ToString());

                //return Personnel.ListePersonnels().Add(personnel);
                MessageBox.Show(Personnel.ListePersonnels().Count().ToString());
                MessageBox.Show( Personnel.ListePersonnels().Last().ToString());
            
                
                /// foreach (Personnel unpersonnel in  Personnel.ListePersonnels())
                ///  {
                //     MessageBox.Show(unpersonnel.ToString());
                ///  }
                //   int index = 13 ;
                MessageBox.Show(Personnel.ListePersonnels()[13].ToString());
                RemplirListeAbsence();
                


            }
            else
            {
                MessageBox.Show(" Veuillez remplir tous les champs");
                /// Créer unPersonnel avec les données saisi  et l'ajouter dans la liste lesPersonnel
                /// 

            }

      
        }
        public void UpdateAjout ()
        {

        }

    }
}
