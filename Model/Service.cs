using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediatek86.Dal;
using Mediatek86.Connexion;

namespace Mediatek86.Model
{/// <summary>
 /// classe metier source table service base de données
 /// </summary
    public class Service
    {
       private int idservice;
       private string nom;
      

        /// <summary>
        /// Les propiétes contenant les 3 instances de la classe services qui équivaut au 3 enrengistrement de services dans la table service de la bdd
        /// </summary>
        private static Service serviceAdministratif = new Service(1, "administratif");
        private static Service serviceMediationCult = new Service(2, "médiation culturelle");
        private static Service servicePret =  new Service(3, "pret");

       



        public Service(int idservice , string nom)
        {
            this.idservice = idservice;
            this.nom = nom;
        }
        // valorisations des proprietés
        public int Idservice { get => idservice; set => idservice = value; }
        public string Nom { get => nom; set => nom = value; }

        ///Valorisations des instances 
        public static Service Service1Administratif { get => serviceAdministratif; set => serviceAdministratif = value; }
        public static Service Service2MediationCult { get => serviceMediationCult; set => serviceMediationCult = value; }
        public static Service Service3Pret { get => servicePret; set => servicePret = value; }

        /// <summary>
        /// Retourne une lisste de service
        /// </summary>
        /// <returns></returns>
        public static List<Service> GetService()
        {
            List<Service> lesservices = new List<Service>();
            lesservices.Add(Service.Service1Administratif);
            lesservices.Add(Service.Service2MediationCult);
            lesservices.Add(Service.Service3Pret);
            return lesservices;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns> Nom service en majuscule</returns>
        public override string ToString()
        {
            return this.nom.ToUpper();
        }



        /// <summary>
        /// Méthode temporaire qui deviendra un constructeur privé qui imposera que ces 4 instances de classe
        /// </summary>
        /// <returns> les 4 instances de Service</returns>

        //public static void ServiceInstance()
        //{
        //    Service serviceAdministratif = new Service(1, "administratif");
        //    Service serviceMediationCult = new Service(2, "médiation culturelle");
        //    Service servicePret new Service(2, "médiation culturelle");

        //}
    }



    
}
   
