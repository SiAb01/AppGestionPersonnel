using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek86.Model
{/// <summary>
 /// classe metier  source table motif base de données
 /// </summary>
    class Motif
    {
        private int idmotif;
        private string libelle;

        public Motif(int idmotif, string libelle)
        {
            this.Idmotif = idmotif;
            this.Libelle = libelle;
        }

        public int Idmotif { get => idmotif; set => idmotif = value; }
        public string Libelle { get => libelle; set => libelle = value; }

        /// <summary>
        /// Méthode temporaire qui deviendra un constructeur privé qui imposera que ces 4 instances de classe
        /// </summary>
        /// <returns> les 4 instances de Motif</returns>

        public static void MotifInstance()
        {
            Motif motifVacances = new Motif(1, "vacances");
            Motif motifMaladie = new Motif(2, "maladie");
            Motif motifCongeParentale = new Motif(3, "congé parental");
        }
       


    }
}
