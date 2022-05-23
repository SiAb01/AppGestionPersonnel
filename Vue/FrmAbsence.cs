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
    { ///Remplir methode au moment de creer les methodes associé cas utilisation AJOUTERABSENCE()
        public static Personnel personnelgere = FrmPersonnel.personnelAbs;
        /// liste des absence d'un personnel de la frmAbsence qui recoit celle AccesDonnes.Liste1PersonlelAbsence(personnelgere)
        public static List<Absence> listeabsdupersonnel = AccesDonnes.Liste1PersonlelAbsence(personnelgere);
        public void AjoutAbsence()
        {
          
        }

        public void MajAjoutAbsence ()
        {
            bdgAbsence.ResetBindings(true);
            bdgAbsence.DataSource = listeabsdupersonnel;
            dtgAbsence.DataSource = bdgAbsence;

            dtgAbsence.Columns[0].Visible = false;

            dtgAbsence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgAbsence.MultiSelect = false;
            dtgAbsence.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgAbsence.ReadOnly = true;
        }
        /// <summary>
        /// La liste de la frmabsence qui equivaut à liste acces donnes qui retourne les absence d'un personnnel en parametre
        /// </summary>
       

        /// <summary>
        /// Remplie datagrid absence
        /// </summary>
        public void RemplirListeAbsence()
        {
           Personnel personnelgere = FrmPersonnel.personnelAbs;
            bdgAbsence.DataSource = Controleur.AfficherdtgAbsence(personnelgere);
            dtgAbsence.DataSource = bdgAbsence;
            //foreach (DataGridViewRow row in dtgAbsence.Rows)
            //{
            //    if (row.Cells[1].Value != personnelgere)

            //    {
            //        row.Visible = false;
            //        DataGridViewBand band = row;
            //        band.Visible = false;
            //        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dtgAbsence.DataSource];

            //        currencyManager1.SuspendBinding();
            //        row.Visible = false;
            //    }
            //    else
            //    {
            //        row.Visible = true;
            //    }
            //}
            dtgAbsence.Columns[0].Visible = false;

            dtgAbsence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgAbsence.MultiSelect = false;
            dtgAbsence.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgAbsence.ReadOnly = true;
            //Afficher seulement les lignes qui correspond aux absence du personnel selectionner 

           

        }



        //Pour pouvoir mettre la visisibilité d'une ligne en  faux


        //        foreach (DataGridViewRow row in dtgAbsence.Rows)
        //{
        //    if (row.Cells[1].Value.ToString().Contains(personnelgere.Idpersonnel.ToString()))

        //    dtgAbsence.row .Visible = false;
        // MessageBox.Show(row.Cells[1].Value.ToString());
        //nt k = dataGridView1.SelectedRows[0].Index;
        //dataGridView1.CurrentCell = null;


        //if (row.Cells[1].Value.ToString().Contains(personnelgere.Idpersonnel.ToString()))
        //{
        //    CurrencyManager currencyManager1 = (CurrencyManager)dtgAbsence.BindingContext[dtgAbsence.DataSource];
        //    currencyManager1.SuspendBinding();
        //    row.Visible = false;
        //    currencyManager1.ResumeBinding();
        //}

      
        

        public FrmAbsence()
        {
            InitializeComponent();
            RemplirListeAbsence();
            // Afficher un petit recap du profil du personnel dont on va gérer l'absence
            lblNomPrenom.Text = FrmPersonnel.personnelAbs.ToString();
            lblfonction.Text = " ( " + FrmPersonnel.personnelAbs.Nomservice.ToString() + " ) ";

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
        /// <summary>
        /// Ajout d'une ebsence , commentaire = dtg se mets à ajour après click et non directement après l'ajout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voulez vous confirmer cet ajout d'absence ?", "Confirmation", MessageBoxButtons.YesNoCancel , MessageBoxIcon.Warning);

            if (DatepDatedebut.Text != " " && DatepDateFin.Text != " " && cbxMotifAbsence.SelectedIndex != -1)
            {
                if (DatepDatedebut.Value > DatepDateFin.Value)
                {
                    MessageBox.Show(" La date de fin de l'absence ne peut pas être placé avant le date de début.", "Erreur saisie");
                    DatepDatedebut.Focus();
                    return;
                }


               

                //Debut de l'ajout de l'absence
                
                ///Ajouter un personnel
                ///On ajoutera l'objet de type absence dans la liste générale absence et celle spécifique à une seul persoone
                int idabsence= AccesDonnes.GetLesAbsences().Count() + 1;
                int motifid = cbxMotifAbsence.SelectedIndex + 1;
                string libellemotif = cbxMotifAbsence.SelectedItem.ToString();
                Absence absence = new Absence(idabsence, personnelgere, DatepDatedebut.Value,motifid,libellemotif, DatepDateFin.Value);
                MessageBox.Show(absence.ToString());
                AccesDonnes.GetLesAbsences().Add(absence);
                listeabsdupersonnel.Add(absence);
                Controleur.AfficherdtgAbsence(personnelgere).Add(absence);

                MajAjoutAbsence();
                //foreach ( Absence item in Controleur.AfficherdtgAbsence(personnelgere))
                //{
                //    MessageBox.Show(item.ToString());
                //}

                //foreach (Absence item in listeabsdupersonnel)
                //{
                //    MessageBox.Show(item.ToString());
                //}



                //Absence absence = new Absence(personnelgere);
                //int idpersonnel = personnelgere.Idpersonnel;
                //Absence absence = new Absence( ) 


            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs", "Erreur saisie");
            }

        }
        /// <summary>
        /// Remets le  bon
        ///format à l'heure que il y a une saisie de l'heure
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DatepDatedebut_ValueChanged(object sender, EventArgs e)
        {
            DatepDatedebut.Format = DateTimePickerFormat.Custom;
            DatepDatedebut.CustomFormat = " dd/MM/yyyy  HH:mm";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            grpAjoutAbsence.Visible = true;
            /// Pour qu'il n'ai pas de date afficher au moment d'ajouter la date
            DatepDatedebut.Format = DateTimePickerFormat.Custom;
            DatepDatedebut.CustomFormat = " ";

            DatepDateFin.Format = DateTimePickerFormat.Custom;
            DatepDateFin.CustomFormat = " ";

       
            

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

        private void btnRetour_Click_1(object sender, EventArgs e)
        {
           FrmPersonnel frmPersonnel = new FrmPersonnel();
            frmPersonnel.Show();
            this.Hide();
            
            
        }

      

        private void btnValidAjout_Click(object sender, EventArgs e)
        {

        }

        private void btnModifierAbs_Click_1(object sender, EventArgs e)
        {
            if (dtgAbsence.SelectedRows.Count > 0)
            {
                grpAjoutAbsence.Visible = true;
                btnModifierAbs.Visible = true;
                btnAjouterAbs.Visible = false;

                Absence uneabsence = (Absence)bdgAbsence.List[bdgAbsence.Position];
                DatepDatedebut.Value = uneabsence.Datedebut;
                DatepDateFin.Value = uneabsence.Datefin;
                ////  A FAIRE = classses motif fait
                ////string libelle = cbxMotifAbsence.SelectedItem.ToString();
                ////libelle = uneabsence.Libelle;

            }
            else
            { MessageBox.Show("Veuillez selectionner une absence à modifier .", "Information"); }
        
        
        
        }

        private void btnValidModif_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous confirmer cette modification","Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                Absence uneabsence = (Absence)bdgAbsence.List[bdgAbsence.Position];
                uneabsence.Datedebut = DatepDatedebut.Value;
                uneabsence.Datefin = DatepDateFin.Value;
                string libelle = cbxMotifAbsence.SelectedItem.ToString();
                uneabsence.Libelle = libelle;


                // Mise à des lbl après modif et visisilité de grp

                string dulabel = "Absence du " + uneabsence.Datedebut.ToString();
                lbltitreabsence.Text = dulabel;
                grpAjoutAbsence.Visible = false;






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
            Absence uneabsence = (Absence)bdgAbsence.List[bdgAbsence.Position];
            string dulabel = "Absence du " + uneabsence.Datedebut.ToString();
            lbltitreabsence.Text = dulabel;
            
        }

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
                MessageBox.Show("Voulez vous confirmer la supression de l'abesence du"+uneabsence.Datedebut.ToString(), "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes )
            {
                dtgAbsence.Visible = false;



                // Supprimer le personnel dans la datagrid pour éviter d'avoir une ligne vide dans le dtg
              //  dtgAbsence.Rows.RemoveAt(dtgAbsence.SelectedRows[0].Index);
                listeabsdupersonnel.Remove(uneabsence);
                if (listeabsdupersonnel.Contains(uneabsence))
                { MessageBox.Show("Element non supprime"); }
                // Remove
               // AccesDonnes.Liste1PersonlelAbsence(personnelgere) 




                MessageBox.Show("Absence supprimé");

                bdgAbsence.ResetBindings(true);
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

    }
}
