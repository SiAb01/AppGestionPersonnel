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
        /// Liste des motifs ; assigner la valeur retourné par listeMotif
        /// </summary>
        /// <returns>liste  objet motifs (id, libellle</returns>
        /// 
        public static List<Motif> lestmotif = new List<Motif>();
        
        public static List<Motif> listeMotif()
            
        { List<Motif> lalistemotif = new List<Motif>();
          lalistemotif.Add(  new Motif(1, "vacances"));
            lalistemotif.Add(new Motif(2, "maladie"));
            lalistemotif.Add( new Motif(3, "motif familiale"));
            lalistemotif.Add( new Motif(4, "congé parental"));
  

            return lalistemotif;
        }
       


    }
}
