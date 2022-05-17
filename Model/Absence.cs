using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediatek86.Dal;
using Mediatek86.Connexion;


namespace Mediatek86.Model
{ /// <summary>
  /// classe metier absence source table absence base de données
  /// </summary>
    public class Absence
    {
        private int idabsence;
      //  private Personnel personnel;
        private int idpersonnel;
        private string nom;
        private string prenom;
        private DateTime datedebut ;
        private int idmotif;
        private string libelle;
        private DateTime datefin ;

        public Absence(int idabsence,/* Personnel personnel*/int idpersonnel, string nom, string prenom, DateTime datedebut, int idmotif, string libelle, DateTime datefin)
        {
            
            this.idabsence = idabsence;
           /// this.personnel = personnel;
           
            this.idpersonnel = idpersonnel;
            this.nom = nom;
            this.prenom = prenom;  
            this.datedebut = datedebut;
            this.idmotif = idmotif;
            this.libelle = libelle;
            this.datefin = datefin;
        }

        public int Idabsence { get => idabsence; set => idabsence = value; }
        ///public Personnel unpersonnel{ get => personnel; set => personnel = value; }
         public int Idpersonnel { get => idpersonnel; set => idpersonnel = value; }
          public string Nom { get => nom; set => nom = value; }
          public string Prenom { get => prenom; set => prenom = value; } 
        public DateTime Datedebut { get => datedebut; set => datedebut = value; }
        public int Idmotif { get => idmotif; set => idmotif = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public DateTime Datefin { get => datefin; set => datefin = value; }

        /// <summary>
        ///Methode temporaire qui viendra ds le constructeur qui sera privé et imposera ques ces 4 instances
        ///ajouter Personnel personnel en paramettre
        /// </summary>
        /// <returns>liste des profils</returns>
        public static List<Absence> ListeAbsence()
        { 
            return AccesDonnes.GetLesAbsences();
        
        }


    }

}
