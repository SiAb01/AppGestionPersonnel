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
{
    class Controleur

    {
       





        /// <summary>
        /// Methode qui retourne la methode qui supp abs ds bdd
        /// </summary>
        /// <param name="personnelgere"></param>
        /// <param name="absence"></param>
        public static void DelAbsence(Personnel personnelgere, Absence absence)
        {
            AccesDonnes.SupprAbsence(personnelgere,absence);
        }
        /// <summary>
        /// Ajoute une absence dans la bdd
        /// </summary>
        /// <param name="personnelgere"></param>
        /// <param name="absence"></param>
        public static void InsertAbs(Personnel personnelgere, Absence absence)
        {
            AccesDonnes.InsertAbsence(personnelgere, absence);
        }

        /// <summary>
        /// Mets à jour une absence ds bdd
        /// </summary>
        /// <param name="personnelgere"></param>
        /// <param name="absence"></param>
        public static void UpdateAbs(Personnel personnelgere, Absence absence)
        {
            AccesDonnes.UpdateAbsence(personnelgere, absence);
        }







        public static List<Absence> AfficherdtgAbsence(Personnel personnel)
        {
            return AccesDonnes.Liste1PersonlelAbsence(personnel);
        }





        public static void AfficherDtgPersonnel()
        {
            AccesDonnes.GetLesPersonnels();
            MySqlConnection connectionbdd = new MySqlConnection("server=localhost;user id=root;database=mlr1");
            connectionbdd.Open();
            MySqlDataAdapter mymysqldatadapt = new MySqlDataAdapter("SELECT personnel.NOM, personnel.PRENOM, service.NOM AS Expr1 FROM personnel INNER JOIN service ON personnel.IDSERVICE = service.IDSERVICE", connectionbdd);
            DataTable mydatatable = new DataTable();
            mymysqldatadapt.Fill(mydatatable);
            //dgvPersonnel.DataSource = mydatatable;

        }
    }
}
