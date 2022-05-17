using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediatek86.Connexion;
using Mediatek86.Model;
using Mediatek86;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace Mediatek86.Dal
{ /// <summary>
  /// Classe regroupant requetes permettant d'accèder aux données provenant de base de données
  /// </summary>
    public class AccesDonnes
    {
        /// <summary>
        /// Chaine de connection qui permet d'accèder à la base donnée
        /// </summary>
        private static string connectionString = "server=localhost;user id = root; database=mlr1";


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
            // string req = "select * from Personnel order by nom;";
            string req = "SELECT personnel.IDPERSONNEL,personnel.NOM, personnel.PRENOM ,  service.NOMSERVICE ,personnel.TEL, personnel.MAIL FROM personnel INNER JOIN service ON personnel.IDSERVICE = service.IDSERVICE ORDER BY personnel.NOM; ";

            Singleton curs = Singleton.GetInstance(AccesDonnes.connectionString);
            curs.ReqSelect(req, null);
            while (curs.Read())
            {
                Personnel personnel = new Personnel ((int)curs.Field("idpersonnel"), (string)curs.Field("nom") , (string)curs.Field("prenom"),
               (string)curs.Field("nomservice"), (string)curs.Field("tel"), (string)curs.Field("mail"));
                lesPersonnels.Add(personnel);
            }
            curs.Close();
            return lesPersonnels;

        }
        /// <summary>
        /// Récupère les données de la table personnel pour inserer dans la DataGridView Personnel
        /// </summary>
        /// <returns> nom, prénom, tel, mail, nomservice </returns>

      ///  public static List<Personnel> GetListePersonneldtg()
      ///  {

       // }

        public static List<Absence> GetLesAbsences()

        {
            List<Absence> lesAbsences = new List<Absence>();
            MySqlConnection connectionnbdd = new MySqlConnection("server=localhost;user id=root;database=mlr1");
            connectionnbdd.Open();
            string req= "SELECT absence.idAbsence, absence.IDPERSONNEL, personnel.NOM, personnel.PRENOM, absence.DATEDEBUT, absence.IDMOTIF, motif.LIBELLE, absence.DATEFIN FROM     absence INNER JOIN personnel ON absence.IDPERSONNEL = personnel.IDPERSONNEL INNER JOIN motif ON absence.IDMOTIF = motif.IDMOTIF; ";
            MySqlCommand command = new MySqlCommand(req, connectionnbdd);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())

                lesAbsences.Add(new Absence((int)reader.GetValue(0),/* Personnel */ (int)reader.GetValue(1), (string)reader.GetValue(2), (string)reader.GetValue(3), (DateTime)reader.GetValue(4), (int)reader.GetValue(5),
                 (string)reader.GetValue(6), (DateTime)reader.GetValue(7)));

            reader.Close();

            return lesAbsences;




            /*
            List<Absence> lesAbsences = new List<Absence>();
            Singleton curs = Singleton.GetInstance(AccesDonnes.connectionString);
              string req = "SELECT absence.idAbsence, absence.IDPERSONNEL, personnel.NOM, personnel.PRENOM, absence.DATEDEBUT, absence.IDMOTIF, motif.LIBELLE, absence.DATEFIN FROM     absence INNER JOIN personnel ON absence.IDPERSONNEL = personnel.IDPERSONNEL INNER JOIN motif ON absence.IDMOTIF = motif.IDMOTIF; ";
            ///string req = "SELECT absence.idAbsence,  absence.DATEDEBUT, absence.IDMOTIF, motif.LIBELLE, absence.DATEFIN FROM    absence INNER JOIN personnel ON absence.IDPERSONNEL = personnel.IDPERSONNEL INNER JOIN motif ON absence.IDMOTIF = motif.IDMOTIF; ";
            curs.
            curs.
            while (curs.Read())
            {
               /// lesAbsences.Add
               ///    (new Absence((int)curs.Field("idabsence"), Personnel , (DateTime)curs.Field("datebut"), (int)curs.Field("idmotif"),
               //        (string)curs.Field("LIBELLE"), (DateTime)curs.Field("Datefin"))));

                lesAbsences.Add(new Absence((int)curs.GetValue(0),/* Personnel */ //(int)curs.GetValue(1), (string)curs.GetValue(2), (string)curs.GetValue(3), (DateTime)curs.GetValue(4), (int)curs.GetValue(5), (string)curs.GetValue(6), (DateTime)curs.GetValue(7)));


            /// lesAbsences.Add(  new Absence((int)curs.Field("idabsence"),/* Personnel */ (int)curs.Field("absence.IDPERSONNEL"),(string)curs.Field("personnel.nom"), (string)curs.Field("personnel.prenom"), (DateTime)curs.Field("datebut"), (int)curs.Field("idmotif"),
            ///     (string)curs.Field("LIBELLE"), (DateTime)curs.Field("Datefin")));

            //  }
            ///curs.Close();
            /*  curs.ReqSelect(req, null);
              while (curs.Read())
              {
                // (DateTime)cmd.Parameters["@v_Hire_Date"].Value;
                  var cultureInfo = new CultureInfo("fr-FR");
                  string formatmysql = curs.GetString(2);
                  DateTime datetime = DateTime.Parse(, cultureInfo)
                  Absence absence= new Absence((int)curs.Field("idabsence"), (int)curs.Field("idpersonnel"), (string)curs.Field("nom"), (string)curs.Field("prenom"), (DateTime)curs.Field("datebut"), (int)curs.Field("idmotif"),
                 (string)curs.Field("libelle"), (DateTime)curs.Field("Datefin").Value);
                  lesAbsences.Add(absence);
              }

              curs.Close();
             */


            return lesAbsences;
            
        
}
    


       










    }
}
