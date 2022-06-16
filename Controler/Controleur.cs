using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mediatek86.Connexion;
using System.Data;
using Mediatek86.Model;
using Mediatek86.Dal;
using MySql.Data.MySqlClient;
using Mediatek86.Vue;

namespace Mediatek86.Controler
{//
 //The <see cref="Mediatek86.Controler"/>  Classe qui va gérer les interactions entre la vue, le model et les accèes au données
 //
 //[System.Runtime.CompilerServices.CompilerGenerated]

    /// <summary>
    /// Classe qui va gérer les interactions entre la vue, le model et les accèes au données
    /// </summary>
    public class Controleur

    {


        /// <summary>
        /// Liste de tous les objets de type personnel
        /// </summary>
        /// <returns> une liste objet type personneel</returns>
        public static List<Personnel> ListePersonnel()
        {
            return AccesDonnes.GetLesPersonnels();
        }
        /// <summary>
        /// Ajoute un personnel nouvellement crée
        /// </summary>
        /// <param name="personnel">personneel géré</param>
        /// <param name="idservice">idservice</param>
        public static void AddPersonnel(Personnel personnel , int idservice)
        {
             AccesDonnes.AjoutPersonnel(personnel , idservice);
        }
       
        /// <summary>
        /// Supprime un personnel selectionné
        /// </summary>
        /// <param name="personnel">personnel</param>
        /// <param name="idservice">idservice</param>
        public static void UpdatePersonnel (Personnel personnel, int idservice)

        {
            AccesDonnes.MajduPersonnel(personnel, idservice);
        }
        /// <summary>
        /// Supprime une personnel selectionné
        /// </summary>
        /// <param name="personnel">personnel</param>
        public static void DelPersonnel(Personnel personnel)
        {
            AccesDonnes.SupprPersonnel(personnel);
        }


        /// <summary>
        /// Methode qui retourne la methode qui supp abs ds bdd
        /// </summary>
        /// <param name="personnelgere">personnel géré</param>
        /// <param name="absence">absence</param>
        public static void DelAbsence(Personnel personnelgere, Absence absence)
        {
            AccesDonnes.SupprAbsence(personnelgere,absence);
        }
        /// <summary>
        /// Ajoute une absence dans la bdd
        /// </summary>
        /// <param name="personnelgere">personnelgere</param>
        /// <param name="absence">absence</param>
        public static void InsertAbs(Personnel personnelgere, Absence absence)
        {
            AccesDonnes.InsertAbsence(personnelgere, absence);
        }

        /// <summary>
        /// Mets à jour une absence ds bdd
        /// </summary>
        /// <param name="personnelgere">personnel géré</param>
        /// <param name="absence"> une absence du personnel géré</param>
        public static void UpdateAbs(Personnel personnelgere, Absence absence)
        {
            AccesDonnes.UpdateAbsence(personnelgere, absence);
        }






        /// <summary>
        /// Liste qui va retourner la liste des absences pour un personnel 
        /// </summary>
        /// <param name="personnel"> le personnel selectionné</param>
        /// <returns> List de type absence </returns>
        public static List<Absence> AbsencesDuPersonnel(Personnel personnel)
        {
            return AccesDonnes.Liste1PersonlelAbsence(personnel);
        }

/// <summary>
/// Liste qui va retourner TOUTES les absences de TOUS les personnel
/// </summary>
/// <param name="absence"> une absence parmi tout les personnel</param>
/// <returns></returns>
        public static List<Absence> TotalAbsence(Absence absence)
        {
            return AccesDonnes.GetLesAbsences();
        }

        /// <summary>
        /// Liste des Motifs déjà existants vacances, motif familiale ...
        /// </summary>
        /// <returns> </returns>
        public static List <Motif> ListeMotif ()
        {
            return Motif.GetMotifs();

        }
        //public static void AfficherDtgPersonnel()
        //{
        //    AccesDonnes.GetLesPersonnels();
        //    MySqlConnection connectionbdd = new MySqlConnection("server=localhost;user id=root;database=mlr1");
        //    connectionbdd.Open();
        //    MySqlDataAdapter mymysqldatadapt = new MySqlDataAdapter("SELECT personnel.NOM, personnel.PRENOM, service.NOM AS Expr1 FROM personnel INNER JOIN service ON personnel.IDSERVICE = service.IDSERVICE", connectionbdd);
        //    DataTable mydatatable = new DataTable();
        //    mymysqldatadapt.Fill(mydatatable);
        //    //dgvPersonnel.DataSource = mydatatable;

        //}
    }
}
