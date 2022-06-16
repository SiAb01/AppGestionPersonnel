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
using Mediatek86.Dal;


namespace Mediatek86.Vue 
{
    public partial class FrmAuthentification : Form
    { /// <summary>
    /// Constructeur fomr authentification
    /// </summary>
        public FrmAuthentification()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbllogo1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelmdp_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           FrmPersonnel  frmPersonnel = new FrmPersonnel();
            frmPersonnel.Show();
            this.Hide();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          
               
            
            
            
                  

















            }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblstringcheck_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //FrmAbsence frmAbsence = new FrmAbsence();
            //frmAbsence.Show();
            //this.Hide();
        }
        /// <summary>
        /// Permet l'accès au frm Personnel et Absence si l
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Connection_Click(object sender, EventArgs e)
        {
           
            if (!txtlogin.Text.Equals("") && !txtmotdepasse.Text.Equals(""))
            {
                if (!AccesDonnes.ControleAuthentification(txtlogin.Text, txtmotdepasse.Text))
                {
                    MessageBox.Show("Authentification incorrecte ou vous n'êtes pas admin", "Alerte");
                    txtlogin.Text = "";
                    txtmotdepasse.Text = "";

                    txtlogin.Focus();
                }
                else
                {
                    MessageBox.Show("Connection reussie" ,"Information");
                    //Faire en sorte que l'utilisation soit lié à  cette authentification
                    Responsable responsableuser = new Responsable((string)txtlogin.Text, (string)txtmotdepasse.Text);
                    FrmPersonnel frmpersonnel = new FrmPersonnel();
                    frmpersonnel.Show();
                    this.Hide();



                }


            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }



        }


        /// <summary>
        /// Pour ne pas afficher le mot de passe en clair lors de la saisie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtmotdepasse_ModifiedChanged(object sender, EventArgs e)
        {
            txtmotdepasse.PasswordChar = '*';
        }

        private void lbllogo2_Click(object sender, EventArgs e)
        {

        }
    }
} 
