using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediatek86.Connexion;
using Mediatek86.Dal;
using Mediatek86.Vue;

namespace Mediatek86.Model
{ 
    /// <summary>
    /// Classe Metier de personnel contient une fonction ToString défini
    /// </summary>
    public class Personnel
    {
        private int idpersonnel;
        private string nom;
        private string prenom;
        private int idservice;
        private string nomservice;
        /// <summary>
        /// difficulté à implémenter l'objet service donc utilisation propriété string nomservice juste
        /// </summary>
        ////private Service servicepersonnel;
        private string tel;
        private string mail;

  
        /// <summary>
        /// constructeur classe personnel
        /// </summary>
        /// <param name="idpersonnel">idpersonnel</param>
        /// <param name="nom">nom du peronnel</param>
        /// <param name="prenom">prenom du personnel</param>
        /// <param name="nomservice">nom du service du peronnel</param>
        /// <param name="idservice">le numéro du service</param>
        /// <param name="tel"> tel du personnel</param>
        /// <param name="mail"> mail du personnel</param>
        public Personnel(int idpersonnel, string nom, string prenom, string nomservice, int idservice/*Service servicepersonnel*/, string tel, string mail)
        {
          //  Personnel personnel;
            this.idpersonnel = idpersonnel;
            this.nom = nom;
            this.prenom = prenom;
            this.nomservice = nomservice;
            this.idservice = idservice;
           // this.servicepersonnel = servicepersonnel;
            this.tel = tel;
            this.mail = mail;

           // ListePersonnels().Add(personnel);
        }
        /// <summary>
        /// valorise 
        /// </summary>
        public int Idpersonnel { get => idpersonnel; set => idpersonnel = value; }
        /// <summary>
        /// valorise 
        /// </summary>
       
        
        public string Nom { get => nom; set => nom = value; }
        /// <summary>
        /// valorise 
        /// </summary>
        public string Prenom { get => prenom; set => prenom = value; }
        /// <summary>
        /// valorise 
        /// </summary>
        public string Nomservice { get => nomservice; set => nomservice = value; }
        /// <summary>
        /// valorise 
        /// </summary>
        public int IdService { get => idservice; set => idservice = value; }
        // public Service ServicePersonnel { get => servicepersonnel; set => servicepersonnel= value; }
        /// <summary>
        /// valorise 
        /// </summary>
       
        public string Tel { get => tel; set => tel = value; }
        /// <summary>
        /// valorise 
        /// </summary>
        public string Mail { get => mail; set => mail = value; }

        
     
        // public static List<Personnel> lalistepersonnel = new List<Personnel>();
       
        //public static List<Personnel> ListePersonnels ()
        //{
        //    return AccesDonnes.GetLesPersonnels();

        //}

        /// <summary>
        /// Affiche info personnel
        /// </summary>
        /// <returns> MARTIN jean</returns>
        public override string ToString()
        {
            string topersonnnel = this.nom.ToUpper() + "  " + this.prenom ;
              return topersonnnel;
        }

     //   public static List<Absence> ListeAbsenceDuPersonnel = FrmAbsence.listeabsdupersonnel;




       
       
        
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
