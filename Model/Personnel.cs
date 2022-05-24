using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediatek86.Connexion;
using Mediatek86.Dal;
using Mediatek86.Vue;

namespace Mediatek86.Model
{  /// <summary>
   /// classe metier personnel source table personnel  base de données
   /// </summary>
   /// Modification 15/05 : propriete int id service de personnel va devenir une instance de la classe service
    public class Personnel
    {
        private int idpersonnel;
        private string nom;
        private string prenom;
        // private string nomservice;
        private Service servicepersonnel;
        private string tel;
        private string mail;

        /// <summary>
        /// Acceder aux propriete privées prix grace aux acceseurs pour utiliser à chaque instance de classe via au constructeur
        /// <param name="idpersonnel"></param>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// </summary>

        public Personnel(int idpersonnel, string nom, string prenom, /*string nomservice*/Service servicepersonnel, string tel, string mail)
        {
          ///  Personnel personnel;
            this.idpersonnel = idpersonnel;
            this.nom = nom;
            this.prenom = prenom;
            //this.nomservice = nomservice;
            this.servicepersonnel = servicepersonnel;
            this.tel = tel;
            this.mail = mail;

           /// ListePersonnels().Add(personnel);
        }

        public int Idpersonnel { get => idpersonnel; set => idpersonnel = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        // public string Nomservice { get => nomservice; set => nomservice = value; }
        public Service ServicePersonnel { get => servicepersonnel; set => servicepersonnel= value; }

        public string Tel { get => tel; set => tel = value; }
        public string Mail { get => mail; set => mail = value; }

        public static List<Personnel> lalistepersonnel = new List<Personnel>();
        public static List<Personnel> ListePersonnels ()
        {
            return AccesDonnes.GetLesPersonnels();

        }

        public override string ToString()
        {
            string topersonnnel = this.nom.ToUpper() + "  " + this.prenom ;
              return topersonnnel;
        }

     //   public static List<Absence> ListeAbsenceDuPersonnel = FrmAbsence.listeabsdupersonnel;




        /// <summary>
        /// Affiche les infos  la classe personnel
        /// </summary>
        /* public  override string ToString()
         {
             string inforpersonnel = "" ;
             foreach (Personnel personnel in ListePersonnels)
             {

                 inforpersonnel = this.idpersonnel.ToString() + "  " + this.idservice.ToString() + "   " + this.nom + " " + this.prenom + " " + this.mail + " " + this.tel;
                 inforpersonnel += inforpersonnel;
             }
             return inforpersonnel;
         }

        */
    }
}
