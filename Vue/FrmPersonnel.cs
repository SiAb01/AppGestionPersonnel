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



    /// <summary>
    /// Retour sur l'action principal
    /// </summary>

    {
        FrmAbsence frmAbsence;
        //public static Personnel personnelAbs ()
        //{ 
        //}

        public static Personnel personnelAbs;


        public static DataGrid dtgpersonnel = new DataGrid();
    
        /// <summary>
        /// Objet pour gérer la liste des développeurs
        /// </summary>
        
    //  public static  BindingSource bdgPersonnel = new BindingSource();
        /// <summary>
        /// Sera le personnel dont on va gérer ses absences
        /// </summary>
        /// <returns> objet de type personne qui a été récupéré ds le dtg</returns>
        //public static Personnel GetPersonnelAbs()
        //{
        //    Personnel personnel;
        //    if (FrmPersonnel.dtgPersonnel.SelectedRows.Count > 0)
        //    {
        //        personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
        //        return personnel;
        //    }
        //    else
        //    {
        //        MessageBox.Show("nom");
        //    }
        //}
        //public static void dtginitial()
        //{
        //    bdgPersonnel.DataSource = Personnel.lalistepersonnel;
        //    dtgpersonnel.DataSource = bdgPersonnel;
        //    //dtgpersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        //    //dtgpersonnel.MultiSelect = false;
        //    //dtgpersonnel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //    //dtgpersonnel.ReadOnly = true;
        //}

        public void AnnulerAction()
        {
            dtgPersonnel.Enabled = true;

        }
        /// <summary>
        /// Mets à jour le Datagrid Personnel
        /// </summary>
        public void MajAjoutPersonnel()
        {
            
            bdgPersonnel.DataSource = Personnel.lalistepersonnel;
            dtgPersonnel.DataSource = bdgPersonnel;
            dtgPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgPersonnel.MultiSelect = false;
            dtgPersonnel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgPersonnel.ReadOnly = true;
        }
        public void RemplirListeAbsence()
        {
            Personnel.lalistepersonnel = Personnel.ListePersonnels();
            bdgPersonnel.DataSource = Personnel.lalistepersonnel;
            dtgPersonnel.DataSource = bdgPersonnel;
            dtgPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgPersonnel.MultiSelect = false;
            dtgPersonnel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgPersonnel.ReadOnly = true;
            dtgPersonnel.ClearSelection();
            // MessageBox.Show(s);

            dtgPersonnel.Rows[0].Selected = false;
            // MessageBox.Show(s);

            //  dtgPersonnel.CurrentRow.Selected = true;



        }
        public FrmPersonnel()
        {
            InitializeComponent();
            RemplirListeAbsence();
            button2.Visible = false;

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
        /// <summary>
        /// Supprimer le personnel sélectionné de la dtgPersonne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_onclick (object sender, EventArgs e)

        {
            

            MessageBox.Show(Personnel.lalistepersonnel[1].ToString());

            if (dtgPersonnel.SelectedRows.Count > 0)

            {
               
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];

                if (MessageBox.Show("Etes vous sur de supprimer le personnel" + personnel.ToString(), "Suppresion Personnel", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {    // int idunpersonnel = (int)dtgPersonnel.SelectedRows[0].Cells["idpersonnel"].Value;
                    dtgPersonnel.Visible = false;



                    // Supprimer le personnel dans la datagrid pour éviter d'avoir une ligne vide dans le dtg
                    dtgPersonnel.Rows.RemoveAt(dtgPersonnel.SelectedRows[0].Index);
                    //Supprimer le personnel dans la liste personnel.lalistepersonnel
                    Personnel.lalistepersonnel.Remove(personnel);


                    dtgPersonnel.Visible = true;

                    MajAjoutPersonnel();


                   
                }

            }
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

        }

        private void grpAjouterPersonnel_Enter(object sender, EventArgs e)
        {
           //// if (dtgPersonnel.SelectedRows.Count > 0)
           // {
           //     Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
           //     MessageBox.Show("Voulez vous confirmer ce choix ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
           //     if (MessageBox.Show("Voulez vous confirmer ce choix ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
           //         // int idunpersonnel = (int)dtgPersonnel.SelectedRows[0].Cells["idpersonnel"].Value;
           //         Personnel.lalistepersonnel.Remove(personnel);

           //     bdgPersonnel.DataSource = Personnel.lalistepersonnel;
           //     dtgPersonnel.DataSource = bdgPersonnel;
           //     dtgPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
           //     dtgPersonnel.MultiSelect = false;
           //     dtgPersonnel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
           //     dtgPersonnel.ReadOnly = true;

           // }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //if (dtgPersonnel.SelectedRows.Count > 0)
            //{
            //    btnAjoutPersonnel.Enabled = true;
            //    MessageBox.Show("Veuillez ne pas selectionner de personnel");
            //}
            //else
            //{
            btnValidAjout.Visible = true;
            btnValidModif.Visible = false;
            dtgPersonnel.Enabled = false;
                grpAjouterPersonnel.Visible = true;
                if (grpaffichecontact.Visible = true)
                    grpaffichecontact.Visible = false;
           
          //  }


        }

        private void btnModifFiche_Click(object sender, EventArgs e)
        {
            btnValidModif.Visible = true;
            btnValidAjout.Visible = false;
            grpAjouterPersonnel.Visible = true;
            if (grpaffichecontact.Visible =  true)
                grpaffichecontact.Visible = false;

            // Préinscriotion des champs selon la personne qui a été cliqué

            Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
            txtnom.Text = personnel.Nom.ToUpper();
            txtprenom.Text = personnel.Prenom;
            txttelephone.Text = personnel.Tel;
            txtEmail.Text = personnel.Mail;
           // CHECK APRES DEFINITION  CLASSE SERVICE




        }

        private void lstpersonnel_MouseClick(object sender, MouseEventArgs e)
        {
            grpaffichecontact.Visible = true;
            if (grpAjouterPersonnel.Visible = true)
                grpAjouterPersonnel.Visible = false;
        }

        private void btnGererAbs(object sender, EventArgs e)
        {
            string s = dtgPersonnel.SelectedRows.Count.ToString();
            //MessageBox.Show(s);
            ///  dtgPersonnel.ClearSelection();
            // MessageBox.Show(s);
            //dtgPersonnel.Rows[0].Selected = false;

            MessageBox.Show(s);

            // Personnel personnel;
            if (dtgPersonnel.SelectedRows.Count > 0 && grpaffichecontact.Visible==true )
            {
                personnelAbs = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                //        return personnel;
                FrmAbsence frmAbsence = new FrmAbsence();
                personnelAbs = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                frmAbsence.Show();
                this.Hide();
                
                
                
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un personnel", "Information");

            }

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
            button2.Visible = true;
            Personnel personnelabs;
          //  if (dtgPersonnel.SelectedRows.Count > 0)
          //  {
                personnelabs = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
               // MessageBox.Show(personnelabs.ToString());

               // return personnel;
            //}
            //else
            //{
            //    MessageBox.Show("nom");
            //}


            /// Evenememnt se déclenche que lorsque qu'on clique sur une cell champs donc faux
            /// int indexrow = dtgPersonnel.CurrentRow.Index;
            /// MessageBox.Show("hellleo"+ indexrow.ToString());
        }

        private void Mainapp_Load(object sender, EventArgs e)
        {

        }

        private void dtgPersonnel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button2.Visible = true;
            /// Pour les cas utilisation modif ou annuler
            grpaffichecontact.Visible = true;
            Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
            lblNomPrenom.Text = personnel.ToString();
            lblfonction.Text = char.ToUpper(personnel.Nomservice[0]) +  personnel.Nomservice.Substring(1);
            lbltelephone.Text = personnel.Tel;
            lblEmail.Text = personnel.Mail;

            // int indexrow = dtgPersonnel.CurrentRow.Index;
            // MessageBox.Show("hellleo"+ indexrow.ToString());
            // dtgPersonnel.SelectedRows.Count
        }

        private void btnValiderAjoutPersonel_Click(object sender, EventArgs e)
        {
            ///Personnel personnel;
            // MessageBox.Show("Voulez vous confirmer ce choix ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            // En cas de validation d'une modification d'une fiche personnel
           
            // En cas validation d'ajout de personnel
            
            grpaffichecontact.Visible = true;
            if (!txtnom.Text.Equals("") && !txtprenom.Text.Equals("") && !txtprenom.Text.Equals("") && !txtEmail.Text.Equals("") && cbxservice.SelectedIndex != -1 && !txttelephone.Text.Equals("") )
            { // Pour la modification
              /// int idunpersonnel = (int)dtgPersonnel.SelectedRows[0].Cells["idpersonnel"].Value;
                string serviceunpersonnel = cbxservice.SelectedItem.ToString();
                int idunpersonnel = Personnel.ListePersonnels().Count() + 1;
                
                Personnel personnel = new Personnel((int)idunpersonnel, (string)txtnom.Text, (string)txtprenom.Text, (string)serviceunpersonnel, (string)txttelephone.Text, (string)txtEmail.Text);
               /// On utilise la propriété liste pour qu'elle recoit les donnnes que retourne la méthode Personne.ListePersonnel
                Personnel.lalistepersonnel = Personnel.ListePersonnels();
                Personnel.lalistepersonnel.Add(personnel);
                 MessageBox.Show("Le personnel " + personnel.ToString() + "a été ajouté .", "Information");

                MajAjoutPersonnel();

                grpAjouterPersonnel.Visible = false;
                grpaffichecontact.Visible = true;
                //Affichage du profil nouvellement crée sur le côté gauche avec la possibilité de modifier et supprimer
                lblNomPrenom.Text = personnel.ToString();
                lblfonction.Text = char.ToUpper(personnel.Nomservice[0]) + personnel.Nomservice.Substring(1);
                lbltelephone.Text = personnel.Tel;
                lblEmail.Text = personnel.Mail;
                dtgPersonnel.Enabled = true;
               







                // RemplirListeAbsence();



            }
            else
            {
                MessageBox.Show(" Veuillez remplir tous les champs","Information");
                /// Créer unPersonnel avec les données saisi  et l'ajouter dans la liste lesPersonnel
                /// 

            }

      
        }
        public void UpdateAjout ()
        {

        }

        private void btnValidModif_Click(object sender, EventArgs e)
        {
            if (dtgPersonnel.SelectedRows.Count > 0)

            {
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                // insérez dans les champs de saisie du formulaire de modification du la fiche personnel  les informations sur le personnel qui a été selections
                personnel.Nom = txtnom.Text;
                personnel.Prenom = txtprenom.Text;
                personnel.Tel = txttelephone.Text;
                personnel.Mail = txtEmail.Text;
                personnel.Nomservice = cbxservice.SelectedItem.ToString();
                //txtnom.Text = personnel.Nom;
                //txtprenom.Text = personnel.Prenom;
                //txttelephone.Text = personnel.Tel;
                //txtEmail.Text = personnel.Mail;
                //string nomservice = cbxservice.SelectedItem.ToString();
                //nomservice = personnel.Nomservice;
                // if (Personnel.lalistepersonnel.Contains(personnel))
                ///On cherche l'index de personnel dans la liste Personnel.lalistepersonnel pour pouvoir mettre à jour les données saisiés
                Personnel item = personnel;
                int index = Personnel.lalistepersonnel.FindIndex(a => a == item);

                if (index != -1)
                {
                    Personnel.lalistepersonnel[index].Nom = txtnom.Text;
                    Personnel.lalistepersonnel[index].Prenom = txtprenom.Text;
                    Personnel.lalistepersonnel[index].Tel = txttelephone.Text;
                    Personnel.lalistepersonnel[index].Mail = txtEmail.Text;
                    Personnel.lalistepersonnel[index].Nomservice = cbxservice.SelectedItem.ToString();

                    MessageBox.Show("La fiche de " + Personnel.lalistepersonnel[index].ToString() + " a bien été modifié");
                    grpAjouterPersonnel.Visible = false;
                    grpaffichecontact.Visible = true;
                    //Affichage du profil nouvellement crée sur le côté gauche avec la possibilité de modifier et supprimer
                    lblNomPrenom.Text = personnel.ToString();
                    lblfonction.Text = char.ToUpper(personnel.Nomservice[0]) + personnel.Nomservice.Substring(1);
                    lbltelephone.Text = personnel.Tel;
                    lblEmail.Text = personnel.Mail;

                    // bdgPersonnel = new Binding

                    List<Personnel> lesPersonnelsvu = Personnel.lalistepersonnel;

                    bdgPersonnel.DataSource = lesPersonnelsvu;
                    dtgPersonnel.DataSource = bdgPersonnel;
                    dtgPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dtgPersonnel.MultiSelect = false;
                    dtgPersonnel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dtgPersonnel.ReadOnly = true;
                }

            


                //Personnel.lalistepersonnel
                //Personnel.lalistepersonnel
                // bdgPersonnel.List[bdgPersonnel.P]







            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            FrmPersonnel frmPersonnel = new FrmPersonnel();
            frmPersonnel.Show();
            this.Close();
            grpaffichecontact.Visible = false;
            grpAjouterPersonnel.Visible = false;
           
        }

        private void bdgPersonnelCompleteenvent(object sender, BindingCompleteEventArgs e)
        {
            dtgPersonnel.ClearSelection();
        }

        private void dtgPersonnel_selectionchanged(object sender, EventArgs e)
        {
            
        }
    }
}
