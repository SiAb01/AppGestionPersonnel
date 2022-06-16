using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediatek86.Dal;
using Mediatek86.Connexion;

 namespace Mediatek86.Model
{
    /// <summary>
    /// Classe métier Service qui a des membres qui sont des instance de classe qui correspond au service déja crée dans la bdd
    /// </summary>
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

       

/// <summary>
/// Constructeur de service
/// </summary>
/// <param name="idservice">id service </param>
/// <param name="nom"> nom du service</param>
        public Service(int idservice , string nom)
        {
            this.idservice = idservice;
            this.nom = nom;
        }
        // valorisations des proprietés
        /// <summary>
        /// valorise 
        /// </summary>
        public int Idservice { get => idservice; set => idservice = value; }
        /// <summary>
        /// valorise 
        /// </summary>
        public string Nom { get => nom; set => nom = value; }

      /// <summary>
      /// Valorise une instanciation d'un Service
      /// </summary>
        public static Service Service1Administratif { get => serviceAdministratif; set => serviceAdministratif = value; }

        /// <summary>
        /// Valorise une instanciation d'un Service
        /// </summary>
        public static Service Service2MediationCult { get => serviceMediationCult; set => serviceMediationCult = value; }

        /// <summary>
        /// Valorise une instanciation d'un Service
        /// </summary>
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



    

       
    }



    
}
   
