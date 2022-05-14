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
        private Personnel personnel;
        private DateTime datedebut;
        private int idmotif;
        DateTime datefin;

        public Absence(int idabsence, Personnel personnel, DateTime datedebut, int idmotif, DateTime datefin)
        {
            this.idabsence = idabsence;
            this.personnel = personnel;
            this.datedebut = datedebut;
            this.idmotif = idmotif;
            this.datefin = datefin;
        }

        public int Idabsence { get => idabsence; set => idabsence = value; }
        public Personnel Personnel { get => personnel; set => personnel = value; }
        public DateTime Datedebut { get => datedebut; set => datedebut = value; }
        public int Idmotif { get => idmotif; set => idmotif = value; }
        public DateTime Datefin { get => datefin; set => datefin = value; }
        /// <summary>
        ///Methode temporaire qui viendra ds le constructeur qui sera privé et imposera ques ces 4 instances
        /// </summary>
        /// <returns>liste des profils</returns>
        public static List<Absence> ListeAbsence(Personnel personnel)
        { 
            return AccesDonnes.GetLesAbsences(personnel);
        
        }


    }

}
