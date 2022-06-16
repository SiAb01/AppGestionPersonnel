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
using Mediatek86.Controler;
using Mediatek86.Dal;

namespace Mediatek86.Vue
{
    public partial class FrmAbsence : Form
    { 
        
        /// <summary>
        /// personnelgere sera un objet personnel  dont on va gerer les absences et fait réference à l'objet de la frmPersonnel = personnel selectionné
        /// </summary>
        public static Personnel personnelgere = FrmPersonnel.personnelAbs;
        /// <summary>
        ///   /// liste des absence d'un personnel de la frmAbsence 
        /// </summary>
        public static List<Absence> listeabsdupersonnel = AccesDonnes.Liste1PersonlelAbsence(personnelgere);
        /// <summary>
        /// Objet pour gérer la liste des motifs
        /// </summary>
        BindingSource bdgcbxmotifs = new BindingSource();


        List<Motif> lesMotifs = Controleur.ListeMotif();

        /// <summary>
        /// Mettre à jour le Datagrid absence à chaque fin d'operation type ajouter, modifier, supprimmer
        /// </summary>
        public void MajAjoutAbsence ()
        {
            //bdgAbsence.ResetBindings(true);
            bdgAbsence.DataSource = listeabsdupersonnel;
            dtgAbsence.DataSource = bdgAbsence;

            dtgAbsence.Columns[0].Visible = false;

            dtgAbsence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgAbsence.MultiSelect = false;
            dtgAbsence.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgAbsence.ReadOnly = true;
        }
        
       

        /// <summary>
        /// Remplie datagrid absence
        /// </summary>
        public void RemplirListeAbsence()
        {
           Personnel personnelgere = FrmPersonnel.personnelAbs;


            bdgAbsence.DataSource = Controleur.AbsencesDuPersonnel(personnelgere);
            dtgAbsence.DataSource = bdgAbsence;
            dtgAbsence.Columns[0].Visible = false;
            dtgAbsence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgAbsence.MultiSelect = false;
            dtgAbsence.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgAbsence.ReadOnly = true;

            bdgcbxmotifs.DataSource = lesMotifs;
            cbxMotifAbsence.DataSource = bdgcbxmotifs;
          //  if (cbxMotifAbsence.Items.Count > 0)
           // {
             //   cbxMotifAbsence.SelectedIndex = 0;
          

           

        }
        /// <summary>
        /// Redimensionner un datagridview (en cours)
        /// </summary>
        /// <param name="DataGridView1"> dtg d'un form</param>
        /// <param name="num">taille largeur colonne en pixels</param>
        protected static void prodatagridview( DataGridView DataGridView1 , int num)
        {

            DataGridView1.Columns[0].FillWeight = num;// The id column 
            DataGridView1.Columns[1].FillWeight = num;// The abbrevation columln
            DataGridView1.Columns[2].FillWeight = num;// The id column 
            DataGridView1.Columns[3].FillWeight=  num;// The abbrevation columln
            DataGridView1.Columns[4].FillWeight= num;// The id column 
            //DataGridView1.Columns[1].Width = 200;// The abbrevation columln
            // DataGridView1.Columns[0].Width = 100;// The id column 
            //DataGridView1.Columns[1].Width = 200;// The abbrevation columln
        }


      
        
        /// <summary>
        /// Constructeur de la Frmabsence
        /// </summary>
        public FrmAbsence()
        {
            InitializeComponent();
            RemplirListeAbsence();
            // prodatagridview(dtgAbsence , 200);
            dtgAbsence.AutoResizeColumn(0);
            dtgAbsence.AutoResizeColumn(1);
            dtgAbsence.AutoResizeColumn(2);
            dtgAbsence.AutoResizeColumn(3);
            dtgAbsence.AutoResizeColumn(4);
            dtgAbsence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;





            // Afficher un petit recap du profil du personnel dont on va gérer l'absence
            lblNomPrenom.Text = FrmPersonnel.personnelAbs.ToString();
            lblfonction.Text = " ( " + FrmPersonnel.personnelAbs.Nomservice.ToString() + " ) ";     

        }
        /// <summary>
        /// Rends visible absence
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
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
        /// <summary>
        /// Ajout d'une ebsence , commentaire = dtg se mets à ajour après click et non directement après l'ajout
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void button2_Click(object sender, EventArgs e)
        {
        //    MessageBox.Show("Voulez vous confirmer cet ajout d'absence ?", "Confirmation", MessageBoxButtons.YesNoCancel , MessageBoxIcon.Warning);

        //    if (DatepDatedebut.Text != " " && DatepDateFin.Text != " " && cbxMotifAbsence.SelectedIndex != -1)
        //    {
        //        if (DatepDatedebut.Value > DatepDateFin.Value)
        //        {
        //            MessageBox.Show(" La date de fin de l'absence ne peut pas être placé avant le date de début.", "Erreur saisie");
        //            DatepDatedebut.Focus();
        //            return;
        //        }


               

        //        //Debut de l'ajout de l'absence
                
        //        ///Ajouter un personnel
        //        ///On ajoutera l'objet de type absence dans la liste générale absence et celle spécifique à une seul persoone
        //        int idabsence= AccesDonnes.GetLesAbsences().Count() + 1;
        //        // int motifid = cbxMotifAbsence.SelectedIndex + 1;
        //        string libelle = cbxMotifAbsence.SelectedItem.ToString();
        //        // Motif unmotifabs =(Motif) cbxMotifAbsence.SelectedItem;
        //        int motifid = cbxMotifAbsence.SelectedIndex + 1;
        //        Absence absence = new Absence(idabsence, personnelgere, DatepDatedebut.Value,   motifid ,libelle/*motifid,libellemotif*/, DatepDateFin.Value);
        //        MessageBox.Show(absence.Libelle);
        //        string req =
        //           "INSERT INTO `absence`( `IDPERSONNEL`, `DATEDEBUT`, `IDMOTIF`, `DATEFIN`)  VALUES (@idpersonnel, '@datedebut' , @idmotif, '@datefin');  ";
        //        Dictionary<string, object> parameters = new Dictionary<string, object>();
        //        // absencepersonnel.Datedebut.ToString
        //        string datedebut = absence.Datedebut.ToString("yyyy-MM-dd HH:mm:ss");
        //        string datefin = absence.Datefin.ToString("yyyy - MM - dd HH: mm:ss");
        //        //parameters.Add("@idabsence",absencepersonnel.Idabsence);
        //        parameters.Add("@idpersonnel", personnelgere.Idpersonnel);
        //        parameters.Add("@datedebut",datedebut );
        //        parameters.Add("@idmotif", absence.Idmotif);
        //        parameters.Add("@datefin", datefin);
                
        //        Singleton connection = Singleton.GetInstance(AccesDonnes.connectionString);
        //        connection.ReqUpdate(req, parameters);
               
                
        //        AccesDonnes.GetLesAbsences().Add(absence);
        //        listeabsdupersonnel.Add(absence);
        //        Controleur.AbsencesDuPersonnel(personnelgere).Add(absence);
              
                
        //        // AccesDonnes.InsertAbsence(personnelgere, absence);

        //        MajAjoutAbsence();
        //        //foreach ( Absence item in Controleur.AbsencesDuPersonnel(personnelgere))
        //        //{
        //        //    MessageBox.Show(item.ToString());
        //        //}

        //        //foreach (Absence item in listeabsdupersonnel)
        //        //{
        //        //    MessageBox.Show(item.ToString());
        //        //}



        //        //Absence absence = new Absence(personnelgere);
        //        //int idpersonnel = personnelgere.Idpersonnel;
        //        //Absence absence = new Absence( ) 


        //    }
        //    else
        //    {
        //        MessageBox.Show("Veuillez remplir tous les champs", "Erreur saisie");
        //    }

        }
        /// <summary>
        /// Remets le  bon
        ///format à l'heure que il y a une saisie de l'heure
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void DatepDatedebut_ValueChanged(object sender, EventArgs e)
        {
            DatepDatedebut.Format = DateTimePickerFormat.Custom;
            DatepDatedebut.CustomFormat = " dd/MM/yyyy  HH:mm";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Remets le  bon
        ///format à l'heure que il y a une saisie de l'heure
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DatepDateFin.Format = DateTimePickerFormat.Custom;
            DatepDateFin.CustomFormat = " dd/MM/yyyy  HH:mm";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lstabsence_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Va afficher le formulaire saisie pour ajout d'absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        { 
       
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            grpAjoutAbsence.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voulez vous confirmer ce choix ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop);
        }
        /// <summary>
        /// Retour sur sur la FrmPersonnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRetourFrmPersonnel_Click(object sender, EventArgs e)
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

        private void btnRetour_Click_1(object sender, EventArgs e)
        {
           FrmPersonnel frmPersonnel = new FrmPersonnel();
            frmPersonnel.Show();
            this.Hide();
            
            
        }

      

        private void btnValidAjout_Click(object sender, EventArgs e)
        {
            ////  A FAIRE = classses motif fait
            ////string libelle = cbxMotifAbsence.SelectedItem.ToString();
            ////libelle = uneabsence.Libelle;
        }

        private void btnModifierAbs_Click_1(object sender, EventArgs e)
        {
            if (dtgAbsence.SelectedRows.Count > 0)
            {
                grpAjoutAbsence.Visible = true;
                btnValidModif.Visible = true;
                btnAjouterAbs.Visible = false;

                Absence uneabsence = (Absence)bdgAbsence.List[bdgAbsence.Position];
                DatepDatedebut.Value = uneabsence.Datedebut;
                DatepDateFin.Value = uneabsence.Datefin;
                cbxMotifAbsence.SelectedIndex = cbxMotifAbsence.FindStringExact(uneabsence.Libelle);
               

            }
            else
            { MessageBox.Show("Veuillez selectionner une absence à modifier .", "Information"); }
        
        
        
        }
        /// <summary>
        /// Enrengistre la modifation d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValidModif_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous confirmer cette modification","Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (cbxMotifAbsence.SelectedIndex != -1 && !DatepDatedebut.Value.ToString().Equals("") && !DatepDateFin.Value.ToString().Equals(""))
                {
                    if (DatepDatedebut.Value < DatepDateFin.Value)

                    {
                        Absence uneabsence = (Absence)bdgAbsence.List[bdgAbsence.Position];

                        uneabsence.Datedebut = DatepDatedebut.Value;
                        uneabsence.Datefin = DatepDateFin.Value;
                        Motif motifabs = (Motif)bdgcbxmotifs.List[bdgcbxmotifs.Position];
                        int idmotif = motifabs.Idmotif;
                        string libelle = motifabs.Libelle;

                        uneabsence.Idmotif = idmotif;
                        uneabsence.Libelle = libelle;
                        //MessageBox.Show(uneabsence.ToString() + " " + motifabs.Idmotif);
                        Controleur.UpdateAbs(personnelgere, uneabsence);


                    }
                    else
                    {
                        MessageBox.Show("La date de début de l'absence est plus récente que la date de fin", "Erreur saisie");
                    }





                }

                else
                {

                    MessageBox.Show("Des champs sont manquants");
                }

                grpAjoutAbsence.Visible = false;
                
                //     Absence uneabsence = (Absence)bdgAbsence.List[bdgAbsence.Position];

                // uneabsence.Datedebut = DatepDatedebut.Value;
                // uneabsence.Datefin = DatepDateFin.Value;
                // Motif motifabs = (Motif)bdgcbxmotifs.List[bdgcbxmotifs.Position];
                // int idmotif = motifabs.Idmotif;
                // string libelle = motifabs.Libelle;

                // uneabsence.Idmotif = idmotif;
                //uneabsence.Libelle = libelle;
                // MessageBox.Show(uneabsence.ToString() + " " + motifabs.Idmotif );

                // AccesDonnes.UpdateAbsence(personnelgere, uneabsence);



                // // Mise à des lbl après modif et visisilité de grp

                // string dulabel = "Absence du " + uneabsence.Datedebut.ToString();
                // lbltitreabsence.Text = dulabel;
                // grpAjoutAbsence.Visible = false;






            }
            else
            {
                grpAjoutAbsence.Visible = false;
                btnValidAjoutAbs.Visible = false;

            }


            // listeabsdupersonnel.


        }

      
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dtgAbsence_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

       /// <summary>
       /// afficher un lbl nommant de l'absence sélectionné "absence du 20/03"
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void dtgAbsence_SelectionChanged(object sender, EventArgs e)
        {   
            if (bdgAbsence.Position > 0)
            {

                Absence uneabsence = (Absence)bdgAbsence.List[bdgAbsence.Position];
                string dulabel = "Absence du " + uneabsence.Datedebut.ToString();
                lbltitreabsence.Text = dulabel;
            }
               
            
        }
        /// <summary>
        /// Effacer la selection 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bdgAbsence_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
           dtgAbsence.ClearSelection();
        }




        /// <summary>
        /// Methode événementielle qui va supprimer une absence selectionnée de la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprAbs_Click(object sender, EventArgs e)
        {
            Absence uneabsence = (Absence)bdgAbsence.List[bdgAbsence.Position];
            if (dtgAbsence.SelectedRows.Count> 0  &&
                MessageBox.Show("Voulez vous confirmer la supression de l'absence du "+uneabsence.Datedebut.ToString(), "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes )
            {
                dtgAbsence.Visible = false;


                Controleur.DelAbsence(personnelgere, uneabsence);

                



                // Supprimer le personnel dans la datagrid pour éviter d'avoir une ligne vide dans le dtg
              //  dtgAbsence.Rows.RemoveAt(dtgAbsence.SelectedRows[0].Index);
                listeabsdupersonnel.Remove(uneabsence);
                if (listeabsdupersonnel.Contains(uneabsence))
                { MessageBox.Show("Element non supprime"); }
                // Remove
               // AccesDonnes.Liste1PersonlelAbsence(personnelgere) 




                MessageBox.Show("Absence supprimé");

               // bdgAbsence.ResetBindings(true);
                bdgAbsence.DataSource = listeabsdupersonnel;

                dtgAbsence.DataSource = bdgAbsence;
                dtgAbsence.Columns[0].Visible = false;
                // pour supprimer du dtg
                dtgAbsence.Rows.RemoveAt(dtgAbsence.SelectedRows[0].Index);

                dtgAbsence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dtgAbsence.MultiSelect = false;
                dtgAbsence.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dtgAbsence.ReadOnly = true;
                dtgAbsence.Visible = true;



                
            
            }
       
        
        
        }
        /// <summary>
        /// Affiche le formulaire pour ajouter une absence d'unpersonnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnajouterabs_Click(object sender, EventArgs e)
        {
            // visiblité du grp et du bonton valider ajout
            grpAjoutAbsence.Visible = true;
            btnValidAjoutAbs.Visible = true;
            btnValidModif.Visible = false;
            // Pour qu'il n'ai pas de date afficher au moment d'ajouter la date
            DatepDatedebut.Format = DateTimePickerFormat.Custom;
            DatepDatedebut.CustomFormat = " ";

            DatepDateFin.Format = DateTimePickerFormat.Custom;
            DatepDateFin.CustomFormat = " ";

        }
        /// <summary>
        /// Enrengistre l'ajout d'une absence d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValidAjoutAbsence_Click(object sender, EventArgs e)
        {
           

            
            if (MessageBox.Show("Voulez vous ajouter l'absence du ", "Confirmations", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                if (cbxMotifAbsence.SelectedIndex != -1 && !DatepDatedebut.Value.ToString().Equals("") && !DatepDateFin.Value.ToString().Equals(""))
                {

                    if (DatepDatedebut.Value < DatepDateFin.Value)
                    {

                        int idabsence = AccesDonnes.GetLesAbsences().Count + 1;
                        Motif motifabs = (Motif)bdgcbxmotifs.List[bdgcbxmotifs.Position];
                        int idmotif = motifabs.Idmotif;
                        string libelle = motifabs.Libelle;

                   
                        Absence absence = new Absence(idabsence, personnelgere, DatepDatedebut.Value, idmotif, libelle, DatepDateFin.Value);
                      //  MessageBox.Show(absence.ToString() + " " + motifabs.Libelle + " personnel id"+absence.Unpersonnel.Idpersonnel);
                        //Controller 
                       Controleur.InsertAbs(personnelgere, absence);
                        MessageBox.Show("L'absence du " +absence.Datedebut +" a bien été ajouté .");


                        bdgAbsence.ResetBindings(true);
                        RemplirListeAbsence();




                    }
                    else
                    {
                        MessageBox.Show("La date de début de l'absence est plus récente que la date de fin", "Erreur saisie");
                    }


                }
                else
                {
                    MessageBox.Show("Des champs sont manquants");
                   
                }


             

               

            }
            else
            {
                grpAjoutAbsence.Visible = false;
                btnValidAjoutAbs.Visible = false;

            }


            grpAjoutAbsence.Visible = false;
            btnValidAjoutAbs.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
