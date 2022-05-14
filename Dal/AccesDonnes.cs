using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediatek86.Connexion;
using Mediatek86.Model;
using Mediatek86;
using MySql.Data.MySqlClient;

namespace Mediatek86.Dal
{ /// <summary>
  /// Classe regroupant requetes permettant d'accèder aux données provenant de base de données
  /// </summary>
    public class AccesDonnes
    {
        /// <summary>
        /// Chaine de connection qui permet d'accèder à la base donnée
        /// </summary>
        private static string connectionString = "server=localhost;user id=root;database=mlr1";


        /// <summary>
        ///  Methodes  des requetes pour recupérer les données de la base de données necessaire à l'app
        /// </summary>


        /// <summary>
        /// Récupère les données de la table personnel pour le mettre dans la classe personnel
        /// </summary>
        /// <returns>liste des profils</returns>
        public static List<Personnel> GetLesPersonnels()
        {
            List<Personnel> lesPersonnels = new List<Personnel>();
            string req = "select * from Personnel order by nom;";

            Singleton curs = Singleton.GetInstance("server=localhost;user id=root;database=mlr1");
            curs.ReqSelect(req, null);
            while (curs.Read())
            {
                Personnel personnel = new Personnel ((int)curs.Field("idpersonnel"), (int)curs.Field("idservice") , (string)curs.Field("nom"),
               (string)curs.Field("prenom"), (string)curs.Field("tel"), (string)curs.Field("mail"));
                lesPersonnels.Add(personnel);
            }
            curs.Close();
            return lesPersonnels;

        }

        public static List<Absence> GetLesAbsences(Personnel personnel)
        {
            List<Absence> lesAbsences = new List<Absence>();
            string req = "SELECT absence.DATEDEBUT, absence.IDMOTIF, personnel.NOM, personnel.PRENOM, motif.LIBELLE FROM     absence INNER JOIN    personnel ON absence.IDPERSONNEL = personnel.IDPERSONNEL INNER JOIN  motif ON absence.IDMOTIF = motif.IDMOTIF ;";
            Singleton curs = Singleton.GetInstance("server=localhost;user id=root;database=mlr1");
            curs.ReqSelect(req, null);
            while (curs.Read())
            {
                Absence absence= new Absence((int)curs.Field("idabsence"), (Personnel)curs.Field("idpersonnel"), (DateTime)curs.Field("datedebut"),
               (int)curs.Field("idmotif"), (DateTime)curs.Field("Datefin"));
                lesAbsences.Add(absence);
            }
            curs.Close();
            return lesAbsences;
        }
    












    }
}
