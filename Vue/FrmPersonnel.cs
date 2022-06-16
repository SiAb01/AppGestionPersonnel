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
using MySql.Data.MySqlClient;
using Mediatek86.Controler;

namespace Mediatek86.Vue
{

    /// <summary>
    /// Frm qui va permettre d'ajouter - supprimier - modifier  personnel
    /// </summary>
    public  partial class FrmPersonnel : Form





    {
        // FrmAbsence frmAbsence;


        /// <summary>
        /// C'est le personnel qui dont on va géré l'absence dans la FrmAbsence il va étre instancié après un clique btn_gererabs
        /// </summary>
        public static Personnel personnelAbs;

        /// <summary>
        /// binding source du cbxservice qui contiendra des instances des 3 services
        /// </summary>
        BindingSource bdgcbxservice = new BindingSource();

        /// <summary>
        /// dtg qui affichera tous les personnels et info (tel, mail,nomrvice)
        /// </summary>
        public static DataGridView dtgpersonnel = new DataGridView();

        /// <summary>
        /// Liste qui va permettre de remplir le combobox service
        /// </summary>
        static List<Service> lesservices = Service.GetService();

        /// <summary>
        /// liste personnels va faire une réfrence à la fonction qui retourne une liste qui récupere les personnel ds bdd
        /// </summary>
        static List<Personnel> lesPersonnels = Controleur.ListePersonnel();


        /// <summary>
        /// Va reinitialiser la form 
        /// </summary>

        public void InitialisationForm()
        {
            FrmPersonnel frmPersonnelnew = new FrmPersonnel();
            frmPersonnelnew.Show();
            this.Close();


        }

        /// <summary>
        /// Mets à jour le Datagrid Personnel
        /// </summary>
        public void MajAjoutPersonnel()
        {

            bdgPersonnel.DataSource = lesPersonnels;
            dtgPersonnel.DataSource = bdgPersonnel;
            dtgPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgPersonnel.MultiSelect = false;
            dtgPersonnel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgPersonnel.ReadOnly = true;
        }



        /// <summary>
        /// Remplit le datagrid personnel
        /// </summary>
        public void RemplirListePersonnel()
        {

            bdgPersonnel.DataSource = lesPersonnels;
            dtgPersonnel.DataSource = bdgPersonnel;
            dtgPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            // dtgpersonnel.
            dtgPersonnel.MultiSelect = false;
            dtgPersonnel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgPersonnel.ReadOnly = true;
            //  dtgpersonnel.AutoResizeRows
            //dtgPersonnel.ClearSelection();
            //dtgPersonnel.Rows[0].Selected = false;

            //  dtgPersonnel.CurrentRow.Selected = true;

        }





        /// <summary>
        /// Constructeur de la form ensemmble des élements initialisé lors de la création du forme
        /// </summary>
        public FrmPersonnel()
        {
            InitializeComponent();
            RemplirListePersonnel();
            BtnAbsPersonnel.Visible = false;

            //Iniatialisation des combo services
            //


            bdgcbxservice.DataSource = lesservices;
            cbxservice.DataSource = bdgcbxservice;
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
        private void btnSupprimer_onclick(object sender, EventArgs e)

        {




            if (dtgPersonnel.SelectedRows.Count > 0)

            {

                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];

                if (MessageBox.Show("Etes vous sur de supprimer le personnel " + personnel.ToString(), "Suppresion Personnel", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {    // int idunpersonnel = (int)dtgPersonnel.SelectedRows[0].Cells["idpersonnel"].Value;
                    dtgPersonnel.Visible = false;



                    // Supprimer le personnel dans la datagrid pour éviter d'avoir une ligne vide dans le dtg
                    dtgPersonnel.Rows.RemoveAt(dtgPersonnel.SelectedRows[0].Index);
                    //Supprimer le personnel dans la liste personnel.lalistepersonnel
                    lesPersonnels.Remove(personnel);
                    dtgpersonnel.Visible = true;

                    InitialisationForm();



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


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Permet d'accéder au formulaire de modification du personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifFiche_Click(object sender, EventArgs e)
        {
            btnValidModif.Visible = true;
            btnValidAjout.Visible = false;
            grpAjouterPersonnel.Visible = true;
            grpAjouterPersonnel.Text = "Modification ";
            if (grpaffichecontact.Visible == true)
            { grpaffichecontact.Visible = false; }


            // Préinscriotion des champs selon la personne qui a été cliqué

            Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
            txtnom.Text = personnel.Nom.ToUpper();
            txtprenom.Text = personnel.Prenom;
            txttelephone.Text = personnel.Tel;
            txtEmail.Text = personnel.Mail;
            cbxservice.SelectedIndex = cbxservice.FindStringExact(personnel.Nomservice);







        }

        private void lstpersonnel_MouseClick(object sender, MouseEventArgs e)
        {
            grpaffichecontact.Visible = true;
            if (grpAjouterPersonnel.Visible == true)
                grpAjouterPersonnel.Visible = false;
        }
        /// <summary>
        /// Permet l'accès à la frmabsence et création de l'objet personnelAbsqui sera une référence à au personnel sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGererAbs(object sender, EventArgs e)
        {


            if (dtgPersonnel.SelectedRows.Count > 0 && grpaffichecontact.Visible == true)
            {
                personnelAbs = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
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


        /// <summary>
        /// Retour sur la frm authentification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            FrmAuthentification FormBase = new FrmAuthentification();
            FormBase.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)


        {
            BtnAbsPersonnel.Visible = true;
            Personnel personnelabs;
            personnelabs = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];

        }

        private void Mainapp_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Affiche  un recap du personnel  NOM Prenom (fonction)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgPersonnel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnAbsPersonnel.Visible = true;
            // Pour les cas utilisation modif ou annuler
            grpaffichecontact.Visible = true;
            Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
            lblNomPrenom.Text = personnel.ToString();
            lblfonction.Text = char.ToUpper(personnel.Nomservice[0]) + personnel.Nomservice.Substring(1);
            lbltelephone.Text = personnel.Tel;
            lblEmail.Text = personnel.Mail;


        }
        /// <summary>
        /// Enrengistre l'ajout du personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValiderAjoutPersonel_Click(object sender, EventArgs e)
        {

            //  grpaffichecontact.Visible = true;
            if (!txtnom.Text.Equals("") && !txtprenom.Text.Equals("") && !txtprenom.Text.Equals("") && !txtEmail.Text.Equals("") && 
                cbxservice.SelectedIndex != -1 && !txttelephone.Text.Equals(""))
            { // Pour la modification

                string serviceunpersonnel = cbxservice.SelectedItem.ToString();
                int idunpersonnel = Controleur.ListePersonnel().Count() + 1;
                Service service = (Service)bdgcbxservice.List[bdgcbxservice.Position];
                string nomservice = service.Nom;
                int idservice = service.Idservice;

                Personnel personnel = new Personnel((int)idunpersonnel, (string)txtnom.Text, (string)txtprenom.Text, (string)nomservice, 
                (int)idservice, (string)txttelephone.Text, (string)txtEmail.Text);
                //  MessageBox.Show(personnel.IdService.ToString() + " " + personnel.Nomservice);
                //Ajout dans base de donnée
                Controleur.AddPersonnel(personnel, idservice);
                // On utilise la propriété liste pour qu'elle recoit les donnnes que retourne la méthode Personne.ListePersonnel
                // Personnel.lalistepersonnel = Personnel.ListePersonnels();
                lesPersonnels.Add(personnel);

                MessageBox.Show("Le personnel " + personnel.ToString() + "a été ajouté .", "Information");


                MajAjoutPersonnel();

                grpAjouterPersonnel.Visible = false;
                grpaffichecontact.Visible = true;

                //Affichage fiche recap du profil du personnel nouvellement crée sur le côté gauche avec la possibilité de modifier et supprimer
                lblNomPrenom.Text = personnel.ToString();
                lblfonction.Text = char.ToUpper(personnel.Nomservice[0]) + personnel.Nomservice.Substring(1);
                lbltelephone.Text = personnel.Tel;
                lblEmail.Text = personnel.Mail;

                dtgPersonnel.Enabled = true;
                // bdgPersonnel.ResetBindings(false);

               








                // RemplirListePersonnel();



            }
            else
            {
                MessageBox.Show(" Veuillez remplir tous les champs", "Information");
                // Créer unPersonnel avec les données saisi  et l'ajouter dans la liste lesPersonnel


            }


        }

        /// <summary>
        /// Enrengistre la modification des info d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValidModif_Click(object sender, EventArgs e)
        {
            Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
            if (dtgPersonnel.SelectedRows.Count > 0 && MessageBox.Show("Voulez vous confirmer la modification de cette fiche de personnel", "Confirmation", 
                MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                if (!txtnom.Text.Equals("") && !txtprenom.Text.Equals("") && !txtprenom.Text.Equals("") && !txtEmail.Text.Equals("") 
                    && cbxservice.SelectedIndex != -1 && !txttelephone.Text.Equals(""))
                {


                    personnel.Nom = txtnom.Text;
                    personnel.Prenom = txtprenom.Text;
                    personnel.Tel = txttelephone.Text;
                    personnel.Mail = txtEmail.Text;
                    Service service = (Service)bdgcbxservice.List[bdgcbxservice.Position];
                    int ideservice = service.Idservice;
                    string nomservice = service.Nom;
                    personnel.Nomservice = nomservice;
                    personnel.IdService = ideservice;


                    Controleur.UpdatePersonnel(personnel, ideservice);

                    MessageBox.Show("La fiche de  " + personnel.ToString() + " a bien été modifié");

                    btnValidModif.Visible = false;
                    grpAjouterPersonnel.Visible = false;


                    //bdgPersonnel.ResetBindings(true);


                    MajAjoutPersonnel();




                }
                else
                {
                    MessageBox.Show("Veuilleez remplir tous les champs");
                }


            }
            else
            {

                MessageBox.Show("Modification annulée", "Information");

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
            Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
            MajAjoutPersonnel();
        }

        private void dtgPersonnel_selectionchanged(object sender, EventArgs e)
        {

        }

        private void cbxservice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Affiche une formulaire de saisie pour ajouter un nouveau personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouterPersonnel(object sender, EventArgs e)
        {


            btnValidAjout.Visible = true;
            btnValidModif.Visible = false;
            dtgPersonnel.Enabled = false;
            grpAjouterPersonnel.Visible = true;
            grpAjouterPersonnel.Text = "Ajout d'un nouveau personnel";
            if (grpaffichecontact.Visible == true)
            { grpaffichecontact.Visible = false; }

        }

        private void grpaffichecontact_Enter(object sender, EventArgs e)
        {

        }
    }
}
