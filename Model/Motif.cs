using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediatek86.Dal;
using Mediatek86.Connexion;

namespace Mediatek86.Model
{/// <summary>
 /// classe metier  source table motif base de données
 /// </summary>
   public class Motif
    {
        private int idmotif;
        private string libelle;



        /// chaque instance de classes des motifs sera un membre statique de la classe
        private static Motif motifVacances = new Motif(1, "vacances");
        private static Motif motifMaladie = new Motif(2, "maladie");
        private static Motif motifFamiliale = new Motif(3, "motif familiale");
        private static Motif motifCongeParental = new Motif(4, "congé parental");
        /// valorisations des instances de classe
        public static Motif Motif1Vacances { get => motifVacances; set => motifVacances = value; }
        public static Motif Moti2fMaladie { get => motifMaladie; set => motifMaladie = value; }
        public static Motif Motif3Familiale { get => motifFamiliale; set => motifFamiliale = value; }
        public static Motif Motif4CongeParental { get => motifCongeParental; set => motifCongeParental = value; }

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
        public static List<Motif> GetMotifs()
        {
            List<Motif> lesmotifs = new List<Motif> ();
            lesmotifs.Add(Motif1Vacances);
            lesmotifs.Add(Moti2fMaladie);
            lesmotifs.Add(Motif3Familiale);
            lesmotifs.Add(Motif4CongeParental);

            return lesmotifs;


        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns> "moti famifilia</returns>
        public override string ToString()
        {
            return this.libelle ;
        }




        //public static List<Motif> listeMotif()

        //{ List<Motif> lalistemotif = new List<Motif>();
        //  lalistemotif.Add(  new Motif(1, "vacances"));
        //    lalistemotif.Add(new Motif(2, "maladie"));
        //    lalistemotif.Add( new Motif(3, "motif familiale"));
        //    lalistemotif.Add( new Motif(4, "congé parental"));


        //    return lalistemotif;
        //}






    }
}
