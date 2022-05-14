using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediatek86.Connexion;
using Mediatek86.Dal;

namespace Mediatek86.Model
{  /// <summary>
   /// classe metier personnel source table personnel  base de données
   /// </summary>
    public class Personnel
    {
        private int idpersonnel;
        private int idservice;
        private string nom;
        private string prenom;
        private string tel;
        private string mail;

        public int Idpersonnel { get => idpersonnel; set => idpersonnel = value; }
        public int Idservice { get => idservice; set => idservice = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Tel { get => tel; set => tel= value; }
        public string Mail { get => mail; set => mail = value; }

        public static List<Personnel> ListePersonnels ()
        {
            return AccesDonnes.GetLesPersonnels();
        }
       


        /// <summary>
        /// Acceder aux propriete privées prix grace aux acceseurs pour utiliser à chaque instance de classe via au constructeur
        /// <param name="idpersonnel"></param>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// </summary>

        public Personnel (int idpersonnel, int idservice, string nom,
         string prenom, string tel , string mail  )
        {
            this.idpersonnel = idpersonnel;
            this.idservice = idservice;
            this.nom = nom;
            this.prenom = prenom;
            this.mail= mail;
            this.tel = tel;



        }

        
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
