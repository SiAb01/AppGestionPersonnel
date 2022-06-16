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


{

    //  
    //The<see cref="Mediatek86.Dal"/> Classe regroupant requetes permettant d'accèder aux données provenant de base de données
    // 
    //  [System.Runtime.CompilerServices.CompilerGenerated]



    /// <summary>
    ///  Classe regroupant requetes permettant d'accèder aux données provenant de base de données
    /// </summary>
    public class AccesDonnes
    {
        /// <summary>
        /// Chaine de connection qui permet d'accèder à la base donnée
        /// </summary>
        public static string connectionString = "server=localhost;user id = root; database=mlr1 ; SslMode=none";


        /// <summary>
        ///  LES PERSONNELS 
        /// </summary>







        /// <summary>
        /// Récupère les données de la table personnel pour le mettre dans la classe personnel
        /// On récupere les valeurs de chaque colonne concernée dans la requete pour les transferer dans un instance un classe Personnel , valeur  d'1 colonne = propriété de l'obje
        /// liste des profils
        /// </summary>

        /// 




        ///
        public static List<Personnel> GetLesPersonnels()


        {


            List<Personnel> lespersonnels = new List<Personnel>();
            MySqlConnection connectionnbdd = new MySqlConnection(AccesDonnes.connectionString);
            connectionnbdd.Open();
            string req =
            "SELECT personnel.IDPERSONNEL,    personnel.NOM, personnel.PRENOM ,  service.NOMSERVICE , personnel.IDSERVICE,personnel.TEL, personnel.MAIL FROM personnel INNER JOIN service ON personnel.IDSERVICE = service.IDSERVICE ORDER BY personnel.IDPERSONNEL ;";



            MySqlCommand macommande = new MySqlCommand(req, connectionnbdd);
            MySqlDataReader reader = macommande.ExecuteReader();


            while (reader.Read())
            {   
                Personnel personnel = new Personnel
                 (
                 (int)reader.GetValue(0), (string)reader.GetValue(1), (string)reader.GetValue(2), (string)reader.GetValue(3) ,(int)reader.GetValue(4)/*servicepersonnel*/,
                 (string)reader.GetValue(5), (string)reader.GetValue(6)
                 );
                lespersonnels.Add(personnel);



            }
            reader.Close();

            return lespersonnels;
         

        }


        /// <summary>
        /// Requete préparé sql Insert qui ajoute un personnel
        /// </summary>
        /// <param name="personnel"> personnel</param>
        /// <param name="idservice"> idservice</param>
        public static void AjoutPersonnel(Personnel personnel, int idservice)
        { 
            string req = "INSERT INTO `personnel`( `IDSERVICE`, `NOM`, `PRENOM`, `TEL`, `MAIL`) ";
            req += "values (@idservice, @nom, @prenom, @tel, @mail);";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@nom", personnel.Nom);
            parameters.Add("@prenom", personnel.Prenom);
            parameters.Add("@tel", personnel.Tel);
            parameters.Add("@mail", personnel.Mail);
            parameters.Add("@idservice", idservice);
            Singleton connection = Singleton.GetInstance(connectionString);
            connection.ReqUpdate(req, parameters);
        }

       /// <summary>
       /// Requete préparée type update sql qui va modifier un personnel
       /// </summary>
       /// <param name="personnel"> personnel</param>
       /// <param name="ideservice">idservice</param>
        public static void MajduPersonnel(Personnel personnel, int ideservice)
        {
            
            string req =
                " update personnel set `IDSERVICE` = @idservice, `NOM` = @nom, `PRENOM`=@prenom , `TEL` = @tel, `MAIL` =@mail  where `IDPERSONNEL` = @idpersonnel; ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.Idpersonnel);
            parameters.Add("@nom", personnel.Nom);
            parameters.Add("@prenom", personnel.Prenom);
            parameters.Add("@tel", personnel.Tel);
            parameters.Add("@mail", personnel.Mail);
            parameters.Add("@idservice", ideservice);
            Singleton connection = Singleton.GetInstance(connectionString);
            connection.ReqUpdate(req, parameters);

        }

        /// <summary>
        /// Requete sql préparée type delete qui vaSupprime unpersonne
        /// </summary>
        /// <param name="personnel">personnel</param>
        public static void SupprPersonnel(Personnel personnel)
        {
            string req = "delete from personnel where IDPERSONNEL = @idpersonnel;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.Idpersonnel);
            Singleton conn = Singleton.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);
        }


       

        /// <summary>
        /// pas utilisé permet d'obtenir un objet motif
        /// </summary>
        /// <param name="reader">reader</param>
        /// <param name="unmotifsabs"> objet motif</param>
        /// <returns></returns>
        public static Motif GetMotifabs(MySqlDataReader reader, Motif unmotifsabs)

        {   // On instancie l'objet motifabsenpour pouvoir récupérer les valeurs des propriétés des Motiif Motif1Maladie pour éviter que motifabs soit une réferences
           // unmotifsabs = new Motif(0, "libelle");
          //         -                                   Recupération de l'objet Motif associé à la requete            -
            // Declarer un objet motifabs qui aura comme réference à la fin des instructions l'un des objet Motif déjà créer qui sont membres statiques ex Motif motiffamiliale

            //Recuperer la valeur obtenue du champs "idmotif"
            int idmotifabs = (int)reader.GetValue(5);
            //L'objet nouvellement déclaré  motifabs fera une réference à l'un des objets membres statiques de la classes Motif selon la valeur obtenu dans le champs idmotif
            switch (idmotifabs)
            {
                case 1:
                    unmotifsabs.Libelle = Motif.Motif1Vacances.Libelle;
                    unmotifsabs.Idmotif = Motif.Motif1Vacances.Idmotif;


                    break;
                case 2:
                    unmotifsabs.Libelle = Motif.Moti2fMaladie.Libelle;
                    unmotifsabs.Idmotif = Motif.Moti2fMaladie.Idmotif;

                    break;
                case 3:
                    unmotifsabs.Libelle = Motif.Motif3Familiale.Libelle;
                    unmotifsabs.Idmotif = Motif.Motif3Familiale.Idmotif;



                    break;
                case 4:
                    unmotifsabs.Libelle = Motif.Motif4CongeParental.Libelle;
                    unmotifsabs.Idmotif = Motif.Motif4CongeParental.Idmotif;

                    break;
            }
            return unmotifsabs;

        }
        /// <summary>
        /// Requete qui permet de récuper les absence d'une seul ^personnel
        /// </summary>
        /// <returns></returns>
        public static List<Absence> GetLesAbsences()

        {
            Personnel unpersonnel;
            Motif motifabs = new Motif(0, "libelle");
            List<Absence> lesAbsences = new List<Absence>();
            MySqlConnection connectionnbdd = new MySqlConnection(AccesDonnes.connectionString);
            connectionnbdd.Open();
            string req =
                " SELECT absence.idAbsence, absence.IDPERSONNEL, personnel.NOM, personnel.PRENOM, absence.DATEDEBUT, absence.IDMOTIF, motif.LIBELLE, absence.DATEFIN FROM     absence INNER JOIN personnel ON absence.IDPERSONNEL = personnel.IDPERSONNEL INNER JOIN motif ON absence.IDMOTIF = motif.IDMOTIF ORDER BY  absence.IDPERSONNEL;";
            MySqlCommand command = new MySqlCommand(req, connectionnbdd);
            MySqlDataReader reader = command.ExecuteReader();
            // Personnel personnel;
            int idunpersonnel = 0;
            while (reader.Read())
            {     // On récupere l'id personnel qu'on a obtenue dans la requete
                idunpersonnel = (int)reader.GetValue(1);
                //On récupère l'objet motif associé à la requete
                motifabs = AccesDonnes.GetMotifabs(reader, motifabs);



                // On cherche à trouver l'indice de l'objet persoonel qui possede le même idpersonnel  que celui récolté dans la requete sql ,dans la liste GetPersonnem
                int index = GetLesPersonnels().FindIndex(obj => obj.Idpersonnel == (int)reader.GetValue(1));
                //if ( index ==-1)
                //{
                //    break;
                //}

                unpersonnel = GetLesPersonnels()[index];

                lesAbsences.Add(new Absence((int)reader.GetValue(0), unpersonnel,/*(int)reader.GetValue(1), (string)reader.GetValue(2), (string)reader.GetValue(3)*/ (DateTime)reader.GetValue(4), (int)reader.GetValue(5),
                    (string)reader.GetValue(6),/*motifabs*/(DateTime)reader.GetValue(7)));


            }
            reader.Close();




            return lesAbsences;

        }
        /// <summary>
        /// Liste des absences pour un seul personnel qui est inséré en parametre de la fonction
        /// </summary>
        /// <param name="unpersonnel"> personnel dont on va gerer les absence</param>
        /// <returns> un liste d'infos sur sur 1 absence </returns>
        public static List<Absence> Liste1PersonlelAbsence(Personnel unpersonnel)
        {
            Motif motifabs = new Motif(0, "libelle");
            List<Absence> personnelabsence = new List<Absence>();
            MySqlConnection connectionnbdd = new MySqlConnection(AccesDonnes.connectionString);
            connectionnbdd.Open();
            string req =
         //      " SELECT absence.idAbsence, absence.IDPERSONNEL, personnel.NOM, personnel.PRENOM, absence.DATEDEBUT, absence.IDMOTIF, motif.LIBELLE, absence.DATEFIN FROM     absence INNER JOIN personnel ON absence.IDPERSONNEL = personnel.IDPERSONNEL INNER JOIN motif ON absence.IDMOTIF = motif.IDMOTIF WHERE absence.IDPERSONNEL=5  ORDER BY  absence.DATEDEBUT; ";
         " SELECT absence.idAbsence,  absence.IDPERSONNEL, personnel.NOM,  personnel.PRENOM , absence.DATEDEBUT, absence.IDMOTIF, motif.LIBELLE, absence.DATEFIN FROM     absence INNER JOIN personnel ON absence.IDPERSONNEL = personnel.IDPERSONNEL INNER JOIN motif ON absence.IDMOTIF = motif.IDMOTIF WHERE absence.IDPERSONNEL= @idunpersonnel  ORDER BY  absence.DATEDEBUT; ";

            MySqlCommand macommande = new MySqlCommand(req, connectionnbdd);
            string idperson = unpersonnel.Idpersonnel.ToString();
            int intidepersoonne = unpersonnel.Idpersonnel;




            macommande.Parameters.Add(new MySqlParameter("@idunpersonnel", idperson));
            macommande.Prepare();
            MySqlDataReader reader = macommande.ExecuteReader();

            while (reader.Read())
            {
                motifabs = AccesDonnes.GetMotifabs(reader, motifabs);

                personnelabsence.Add(new Absence((int)reader.GetValue(0), unpersonnel /*(int)reader.GetValue(1), (string)reader.GetValue(2), (string)reader.GetValue(3)*/, (DateTime)reader.GetValue(4), (int)reader.GetValue(5),
                        (string)reader.GetValue(6)/*motifabs*/, (DateTime)reader.GetValue(7)));

            }
            reader.Close();

            return personnelabsence;


        }
        /// <summary>
        ///  supprimer une absence d'une personnel ds bddd
        /// </summary>
        /// <param name="personnelgere"> personnel géré pour absence</param>
        /// <param name="absence">une absence d'1 personnel</param>
        public static void InsertAbsence(Personnel personnelgere, Absence absence)

        {
            string req =
                        // requete testé sur  sql et fonctionne
                        "INSERT INTO `absence`( `IDPERSONNEL`, `DATEDEBUT`, `IDMOTIF`, `DATEFIN`)  VALUES (@idpersonnel, @datedebut , @idmotif, @datefin);  ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@idpersonnel", absence.Unpersonnel.Idpersonnel);
            parameters.Add("@datedebut", absence.Datedebut);
            parameters.Add("@idmotif", absence.Idmotif);
            parameters.Add("@datefin", absence.Datefin);

            Singleton connection = Singleton.GetInstance(AccesDonnes.connectionString);
            connection.ReqUpdate(req, parameters);


        }
        /// <summary>
        /// Mets à jour une absence d'un personnel dans la base de données
        /// </summary>
        /// <param name="personnelgere">personnelgere</param>
        /// <param name="absence"> une absence d'1 personnel</param>
        public static void UpdateAbsence(Personnel personnelgere, Absence absence)
        {
            string req = "UPDATE `absence` SET `DATEDEBUT`=@datedebut,`IDMOTIF`= @idmotif,`DATEFIN`=@datefin WHERE  idAbsence =@idabsence ; ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();

           
           // parameters.Add("@idpersonnel", absence.Unpersonnel.Idpersonnel);
            parameters.Add("@datedebut", absence.Datedebut);
            parameters.Add("@idmotif", absence.Idmotif);
            parameters.Add("@datefin", absence.Datefin);
            parameters.Add("@idabsence", absence.Idabsence);


            Singleton connection = Singleton.GetInstance(AccesDonnes.connectionString);
            connection.ReqUpdate(req, parameters);




        }

        /// <summary>
        /// Supprime une absence dans la base de données
        /// </summary>
        /// <param name="personnelgere">personnelgere</param>
        /// <param name="absence">absence</param>
        public static void SupprAbsence (Personnel personnelgere , Absence absence)
        {
          string req = "DELETE FROM `absence` WHERE `idAbsence`=@idabsence ;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idabsence", absence.Idabsence);
            Singleton connection = Singleton.GetInstance(AccesDonnes.connectionString);
            connection.ReqUpdate(req, parameters);
        }
        /// <summary>
        ///  /// Boolean qui vérifié si le login et pwd saisie sont bien dans la bdd
        /// </summary>
        /// <param name="login"> login déja initialisé dans base de donnée</param>
        /// <param name="pwd"> pwd déjà defini</param>
        /// <returns></returns>
        public static Boolean ControleAuthentification(string login, string pwd)
        {
            string req = "select * from responsable  where  login = @logininput and pwd=SHA2 (@pwdinput, 256); ";
           // req += "where d.nom=@nom and d.prenom=@prenom and pwd=SHA2(@pwd, 256) and p.nom='admin';";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@logininput", login);
            parameters.Add("@pwdinput", pwd);
            Singleton curs = Singleton.GetInstance(connectionString);
            curs.ReqSelect(req, parameters);
            if (curs.Read())
            {
                curs.Close();
                return true;
            }
            else
            {
                curs.Close();
                return false;
            }
        }

       



















    }
}
