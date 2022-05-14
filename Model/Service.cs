using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek86.Model
{/// <summary>
 /// classe metier source table service base de données
 /// </summary
    public class Service
    {
       private int idservice;
        private string nom;

        public Service(int idservice, string nom)
        {
            this.idservice = idservice;
            this.nom = nom;
        }

        public int Idservice { get => idservice; set => idservice = value; }
        public string Nom { get => nom; set => nom = value; }

        /// <summary>
        /// Méthode temporaire qui deviendra un constructeur privé qui imposera que ces 4 instances de classe
        /// </summary>
        /// <returns> les 4 instances de Service</returns>

        public static void ServiceInstance()
        {
            Service serviceAdministratif = new Service(1, "administratif");
            Service serviceMediationCult = new Service(2, "médiation culturelle");
            Service servicePret = new Service(3, "pret");

        }
    }

    
}
   
