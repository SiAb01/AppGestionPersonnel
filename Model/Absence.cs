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
        private Personnel unpersonnel;
        //                       attribut avant remplacement par un objet personnel                 
        //private int idpersonnel;
        //private string nom;
        //private string prenom;
        private DateTime datedebut ;
        //                      attribut avant remplacement par un objet motif 
        //private int idmotif;
        //private string libelle;

        private Motif motifabs;
        private DateTime datefin ;

        public Absence(int idabsence,Personnel unpersonnel,/*int idpersonnel, string nom, string prenom,*/ DateTime datedebut, Motif motifabs/*int idmotif, string libelle*/, DateTime datefin)
        {
            
            this.idabsence = idabsence;
            this.unpersonnel = unpersonnel;
            
            //this.idpersonnel = idpersonnel;
            //this.nom = nom;
            //this.prenom = prenom;  
            this.datedebut = datedebut;
            this.motifabs = motifabs;
            //this.idmotif = idmotif;
            //this.libelle = libelle;
            this.datefin = datefin;
        }

        public int Idabsence { get => idabsence; set => idabsence = value; }
        public Personnel Unpersonnel{ get => unpersonnel; set => unpersonnel = value; }
         //public int Idpersonnel { get => idpersonnel; set => idpersonnel = value; }
         // public string Nom { get => nom; set => nom = value; }
         // public string Prenom { get => prenom; set => prenom = value; } 
        public DateTime Datedebut { get => datedebut; set => datedebut = value; }

        public Motif MotifAbs { get => motifabs; set => motifabs = value; }
        //public int Idmotif { get => idmotif; set => idmotif = value; }
        //public string Libelle { get => libelle; set => libelle = value; }
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

        public override string ToString()
        {
            return this.idabsence + this.unpersonnel.ToString() + this.datedebut.ToString();
        }
    }

}
