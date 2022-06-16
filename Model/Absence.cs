using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediatek86.Dal;
using Mediatek86.Connexion;


namespace Mediatek86.Model


{  //
   //The <see cref="Mediatek86.Model"/> Ensemble  de Classes metiers : personnel, absences, services, motif et responsable
   // 
    //[System.Runtime.CompilerServices.CompilerGenerated]

   /// <summary>
   /// Classe  metier Absence qui a comme membre de classe un objet de type personnel
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
        private int idmotif;
        private string libelle;

      //  private Motif motifabs;
        private DateTime datefin ;
        /// <summary>
        /// Constructeur de la classe absence qui utilise un objet peronnel
        /// </summary>
        /// <param name="idabsence"> identifiant absence parmi toutes les absence de tous les personnels</param>
        /// <param name="unpersonnel"> le personnel dont on va géré l'absence</param>
        /// <param name="datedebut"> datedebut de l'absence</param>
        /// <param name="idmotif"> id du motif de l'absence</param>
        /// <param name="libelle"> le nom du motif de l'absence</param>
        /// <param name="datefin">fin de l'absence</param>
        public Absence(int idabsence,Personnel unpersonnel,/*int idpersonnel, string nom, string prenom,*/ DateTime datedebut,/* Motif motifabs*/int idmotif, string libelle, DateTime datefin)
        {
            
            this.idabsence = idabsence;
            this.unpersonnel = unpersonnel;
            
            //this.idpersonnel = idpersonnel;
            //this.nom = nom;
            //this.prenom = prenom;  
            this.datedebut = datedebut;
            //this.motifabs = motifabs;
            this.idmotif = idmotif;
            this.libelle = libelle;
            this.datefin = datefin;
        }
        /// <summary>
        /// valorise ^propriété
        /// </summary>
        public int Idabsence { get => idabsence; set => idabsence = value; }
        /// <summary>
        /// valorise
        /// </summary>
        public Personnel Unpersonnel{ get => unpersonnel; set => unpersonnel = value; }
        //public int Idpersonnel { get => idpersonnel; set => idpersonnel = value; }
        // public string Nom { get => nom; set => nom = value; }
        // public string Prenom { get => prenom; set => prenom = value; } 
        /// <summary>
        /// valorise
        /// </summary>
        public DateTime Datedebut { get => datedebut; set => datedebut = value; }
        /// <summary>
        /// valorise
        /// </summary>
        // public Motif MotifAbs { get => motifabs; set => motifabs = value; }
        public int Idmotif { get => idmotif; set => idmotif = value; }
        /// <summary>
        /// valorise
        /// </summary>
       
        public string Libelle { get => libelle; set => libelle = value; }
        /// <summary>
        /// valorise
        /// </summary>
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
        /// <summary>
        /// Affiche info absence d'une personnel
        /// </summary>
        /// <returns> 1 Martin jean 23\08\2022 </returns>
        public override string ToString()
        {
            return this.idabsence + " "+this.unpersonnel.ToString()+" " + this.datedebut.ToString();
        }
    }

}
