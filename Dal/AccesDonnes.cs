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
        public static string connectionString = "server=localhost;user id = root; database=mlr1 ; SslMode=none";


        /// <summary>
        ///  Methodes  des requetes pour recupérer les données de la base de données necessaire à l'app
        /// </summary>


        /// <summary>
        /// Récupère les données de la table personnel pour le mettre dans la classe personnel
        /// </summary>
        /// <returns>liste des profils</returns>
        /// 
        public static List<Personnel> GetLesPersonnels()





        {


            //Service servicepersonnel = new Service(0, "libelle");
            List<Personnel> lespersonnels = new List<Personnel>();
            MySqlConnection connectionnbdd = new MySqlConnection(AccesDonnes.connectionString);
            connectionnbdd.Open();
            string req =
            "SELECT personnel.IDPERSONNEL,    personnel.NOM, personnel.PRENOM ,  service.NOMSERVICE , personnel.IDSERVICE,personnel.TEL, personnel.MAIL FROM personnel INNER JOIN service ON personnel.IDSERVICE = service.IDSERVICE ORDER BY personnel.IDPERSONNEL ;";



            MySqlCommand macommande = new MySqlCommand(req, connectionnbdd);
            // string nomservice = "";
            // string idperson = unpersonnel.Idpersonnel.ToString();
            // int intidepersoonne = unpersonnel.Idpersonnel;




            //macommande.Parameters.Add(new MySqlParameter("@idunpersonnel", idperson));
            // macommande.Prepare();
            MySqlDataReader reader = macommande.ExecuteReader();

            while (reader.Read())
            {
                //  servicepersonnel.Idservice =(int) reader.GetValue(4);
                // servicepersonnel.Nom = (string)reader.GetValue(3);
                Personnel personnel = new Personnel
                 (
                 (int)reader.GetValue(0), (string)reader.GetValue(1), (string)reader.GetValue(2), (string)reader.GetValue(3) /*servicepersonnel*/,
                 (string)reader.GetValue(5), (string)reader.GetValue(6)
                 );
                lespersonnels.Add(personnel);



            }
            reader.Close();

            return lespersonnels;










            //Service servicedupersonnel = new Service(0, "nom");
            //List<Personnel> lesPersonnels = new List<Personnel>();
            //// string req = "select * from Personnel order by nom;";
            //string req =
            //    "SELECT personnel.IDPERSONNEL,personnel.NOM, personnel.PRENOM ,  service.NOMSERVICE ,personnel.TEL, personnel.MAIL FROM personnel INNER JOIN service ON personnel.IDSERVICE = service.IDSERVICE ORDER BY personnel.IDPERSONNEL ";

            //Singleton curs = Singleton.GetInstance(AccesDonnes.connectionString);
            //curs.ReqSelect(req, null);
            //while (curs.Read())

            //{   /// Recuper l'objet service grace à la valeur nommotif récupére dans la requete
            //    string nomservice = (string)curs.Field(3);
            //    /////L'objet nouvellement déclaré  motifabs fera une réference à l'un des objets membres statiques de la classes Motif selon la valeur obtenu dans le champs idmotif
            //    switch (nomservice)
            //    {
            //        case "administratif":
            //            servicedupersonnel.Idservice = 1;
            //            //Service.Service1Administratif.Idservice; 
            //            servicedupersonnel.Nom = "administratif";
            //            // Service.Service1Administratif.Nom;


            //            break;
            //        case "médiation culturelle":
            //            servicedupersonnel.Idservice = 2;

            //            // Service.Service2MediationCult.Idservice.;
            //            servicedupersonnel.Nom = "médiation culturelle";
            //            //Service.Service2MediationCult.Nom;

            //            break;

            //        case "pret":
            //            servicedupersonnel.Idservice = 3;
            //            //Service.Service3Pret.Idservice;
            //            servicedupersonnel.Nom = "pret";
            //            //Service.Service3Pret.Nom;


            //            break;

            //    }


            //    /// Personnel personnel = new Personnel ((int)curs.Field("idpersonnel"), (string)curs.Field("nom") , (string)curs.Field("prenom"),
            //    ///* (string)curs.Field("nomservice")*/, (string)curs.Field("tel"), (string)curs.Field("mail"));
            //    Personnel personnel = new Personnel
            // (
            // (int)curs.Field(0), (string)curs.Field(1), (string)curs.Field(2), servicedupersonnel,
            // (string)curs.Field(4), (string)curs.Field(5)
            // );
            //    lesPersonnels.Add(personnel);
            //}
            //curs.Close();
            //return lesPersonnels;

            //Service servicedupersonnel = new Service(0, "nom");
            //List<Personnel> lesPersonnels = new List<Personnel>();
            //string nomservice = "";
            //string req = "select * from Personnel order by nom;";
            //string req =
            //    "SELECT personnel.IDPERSONNEL,personnel.NOM, personnel.PRENOM ,  service.NOMSERVICE ,personnel.TEL, personnel.MAIL FROM personnel INNER JOIN service ON personnel.IDSERVICE = service.IDSERVICE ORDER BY personnel.IDPERSONNEL ";

            //Singleton curs = Singleton.GetInstance(AccesDonnes.connectionString);
            //curs.ReqSelect(req, null);
            //while (curs.Read())

            //{   /// Recuper l'objet service grace à la valeur nommotif récupére dans la requete
            //    nomservice = (string)curs.Field(3);

            //    / Teste de la valeur de nom service
            //    / Console.WriteLine("nomservice avant switch " + nomservice);




            //    ///L'objet nouvellement déclaré  motifabs fera une réference à l'un des objets membres statiques de la classes Motif selon la valeur obtenu dans le champs idmotif
            //    switch (nomservice)
            //    {
            //        case "administratif":
            //            servicedupersonnel.Idservice = 1;
            //            //Service.Service1Administratif.Idservice; 
            //            servicedupersonnel.Nom = "administratif";
            //            // Service.Service1Administratif.Nom;


            //            break;
            //        case "médiation culturelle":
            //            servicedupersonnel.Idservice = 2;

            //            // Service.Service2MediationCult.Idservice.;
            //            servicedupersonnel.Nom = "médiation culturelle";
            //            //Service.Service2MediationCult.Nom;

            //            break;

            //        case "pret":
            //            servicedupersonnel.Idservice = 3;
            //            //Service.Service3Pret.Idservice;
            //            servicedupersonnel.Nom = "pret";
            //            //Service.Service3Pret.Nom;


            //            break;

            //    }
            //    servicedupersonnel.Nom = nomservice;

            //    Personnel personnel = new Personnel
            //     (
            //     (int)curs.Field(0), (string)curs.Field(1), (string)curs.Field(2), servicedupersonnel,
            //     (string)curs.Field(4), (string)curs.Field(5)
            //     );
            //    lesPersonnels.Add(personnel);


            //   Service servicedupersonnel = new Service(0, "nom");
            //List<Personnel> lesPersonnels = new List<Personnel>();
            //Personnel personnel;
            //// string req = "select * from Personnel order by nom;";
            //string req =
            //    "SELECT personnel.IDPERSONNEL,personnel.NOM, personnel.PRENOM ,  service.NOMSERVICE ,personnel.TEL, personnel.MAIL FROM personnel INNER JOIN service ON personnel.IDSERVICE = service.IDSERVICE ORDER BY personnel.IDPERSONNEL ";

            //Singleton curs = Singleton.GetInstance(AccesDonnes.connectionString);
            //curs.ReqSelect(req, null);
            //while (curs.Read())

            //{   /// Recuper l'objet service grace à la valeur nommotif récupére dans la requete
            //    string nomservice = (string)curs.Field(3);

            //    ///Teste de la valeur de nom service 
            //  ///  Console.WriteLine("nomservice avant switch "+ nomservice);




            //    /////L'objet nouvellement déclaré  motifabs fera une réference à l'un des objets membres statiques de la classes Motif selon la valeur obtenu dans le champs idmotif
            //    switch (nomservice)
            //    {
            //        case "administratif":
            //            servicedupersonnel.Idservice = 1;
            //            //Service.Service1Administratif.Idservice; 
            //            servicedupersonnel.Nom = "administratif";
            //            // Service.Service1Administratif.Nom;

            //            ///////////// Création objet ///////////////
            //            lesPersonnels.Add(new Personnel
            //           (
            //            (int)curs.Field(0), (string)curs.Field(1), (string)curs.Field(2), servicedupersonnel,
            //            (string)curs.Field(4), (string)curs.Field(5)
            //             ));
            //            //////////////   Ajout liste ////////////


            //            break;
            //        case "médiation culturelle":
            //            servicedupersonnel.Idservice = 2;

            //            // Service.Service2MediationCult.Idservice.;
            //            servicedupersonnel.Nom = "médiation culturelle";
            //            //Service.Service2MediationCult.Nom;

            //            ///////////// Création objet ///////////////
            //            lesPersonnels.Add(new Personnel
            //           (
            //            (int)curs.Field(0), (string)curs.Field(1), (string)curs.Field(2), servicedupersonnel,
            //            (string)curs.Field(4), (string)curs.Field(5)
            //             ));
            //            //////////////   Ajout liste ////////////

            //            break;

            //        case "pret":
            //            servicedupersonnel.Idservice = 3;
            //            //Service.Service3Pret.Idservice;
            //            servicedupersonnel.Nom = "pret";
            //            //Service.Service3Pret.Nom;

            //            ///////////// Création objet ///////////////
            //            lesPersonnels.Add(new Personnel
            //           (
            //            (int)curs.Field(0), (string)curs.Field(1), (string)curs.Field(2), servicedupersonnel,
            //            (string)curs.Field(4), (string)curs.Field(5)
            //             ));
            //            //////////////   Ajout liste ////////////

            //            break;

            //    }


            //}
            //curs.Close();
            //return lesPersonnels;


        }


        //public static Motif GetServicePersonnel(Singleton reader, Service servicepersonnel)



        //{  
        //    string nomservice = (string)reader.GetValue(3);
        //    /////L'objet nouvellement déclaré  motifabs fera une réference à l'un des objets membres statiques de la classes Motif selon la valeur obtenu dans le champs idmotif
        //    switch (nomservice)
        //    {
        //        case "administratif":
        //            servicepersonnel.Idservice = Service.ServiceAdministratif.Idservice ;
        //            servicepersonnel.Nom =Service.ServiceAdministratif.Nom ;


        //            break;
        //        case "médiation culturelle":
        //            servicepersonnel.Idservice = Service.ServiceAdministratif.Idservice;
        //            servicepersonnel.Nom = Service.ServiceAdministratif.Nom;

        //            break;
        //        case "pret":
        //            servicepersonnel.Idservice = Service.ServiceAdministratif.Idservice;
        //            servicepersonnel.Nom = Service.ServiceAdministratif.Nom;


        //            break;

        //    }
        //    return servicepersonnel;

        //}

        /// <summary>
        /// Récupère les données de la table personnel pour inserer dans la DataGridView Personnel
        /// </summary>
        /// <returns> nom, prénom, tel, mail, nomservice </returns>

        ///  public static List<Personnel> GetListePersonneldtg()
        ///  {

        // }



        
        
        public static void AjoutPersonnel(Personnel personnel, int idservice)
        { int ideservice = 0;
            string req = "INSERT INTO `personnel`( `IDSERVICE`, `NOM`, `PRENOM`, `TEL`, `MAIL`) ";
            req += "values (@idservice, @nom, @prenom, @tel, @mail);";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@nom", personnel.Nom);
            parameters.Add("@prenom", personnel.Prenom);
            parameters.Add("@tel", personnel.Tel);
            parameters.Add("@mail", personnel.Mail);

            //switch (personnel.Nomservice)
            //{
            //    case "administratif":
            //        ideservice = Service.Service1Administratif.Idservice;
            //        break;

            //    case "médiation culturelle":
            //        ideservice = Service.Service2MediationCult.Idservice;
            //        break;
            //    case "pret":
            //        ideservice = Service.Service3Pret.Idservice;
            //        break;


            //}
            parameters.Add("@idservice", ideservice);
            Singleton connection = Singleton.GetInstance(connectionString);
            connection.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Mets à jour le personnel sélectionné dans la base de données
        /// </summary>
        /// <param name="personnel"></param>
        public static void MajduPersonnel(Personnel personnel, int ideservice)
        {
            // int ideservice = 0;
            string req =
                " update personnel set `IDSERVICE` = @idservice, `NOM` = @nom, `PRENOM`=@prenom , `TEL` = @tel, `MAIL` = @mail  where `IDPERSONNEL` = @idpersonnel; ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add(" @idpersonnel", personnel.Idpersonnel);
            parameters.Add("@nom", personnel.Nom);
            parameters.Add("@prenom", personnel.Prenom);
            parameters.Add("@tel", personnel.Tel);
            parameters.Add("@mail", personnel.Mail);
            

            //switch (personnel.Nomservice)
            //{
            //    case "administratif":
            //        ideservice = Service.Service1Administratif.Idservice;
            //        break;

            //    case "médiation culturelle":
            //        ideservice = Service.Service2MediationCult.Idservice;
            //        break;
            //    case "pret":
            //        ideservice = Service.Service3Pret.Idservice;
            //        break;


            //}
            parameters.Add("@idservice", ideservice);
            Singleton connection = Singleton.GetInstance(connectionString);
            connection.ReqUpdate(req, parameters);

        }

        /// <summary>
        /// Supprime unpersonnel
        /// </summary>
        /// <param name="personnel"></param>
        public static void SupprPersonnel(Personnel personnel)
        {
            string req = "delete from personnel where IDPERSONNEL = @idpersonnel;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.Idpersonnel);
            Singleton conn = Singleton.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);
        }



        ///retourne l'objet motif pour l'ajouter à l'objet absence , à appliquer dans GetAbsense
        public static Motif GetMotifabs(MySqlDataReader reader, Motif unmotifsabs)

        {   /// On instancie l'objet motifabsenpour pouvoir récupérer les valeurs des propriétés des Motiif Motif1Maladie pour éviter que motifabs soit une réferences
           // unmotifsabs = new Motif(0, "libelle");
            /////         -                                   Recupération de l'objet Motif associé à la requete            -
            ///// Declarer un objet motifabs qui aura comme réference à la fin des instructions l'un des objet Motif déjà créer qui sont membres statiques ex Motif motiffamiliale

            /////Recuperer la valeur obtenue du champs "idmotif"
            int idmotifabs = (int)reader.GetValue(5);
            /////L'objet nouvellement déclaré  motifabs fera une réference à l'un des objets membres statiques de la classes Motif selon la valeur obtenu dans le champs idmotif
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
            {     /// On récupere l'id personnel qu'on a obtenue dans la requete
                idunpersonnel = (int)reader.GetValue(1);
                ///On récupère l'objet motif associé à la requete
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
        /// <param name="unpersonnel"></param>
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
        /// supprimer une babsence d'une personnel ds bddd
        /// </summary>
        /// <param name="personnelgere"></param>
        /// <param name="absencepersonnel"></param>
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
        /// <param name="personnelgere"></param>
        /// <param name="absence"></param>
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
        /// <param name="personnelgere"></param>
        /// <param name="absence"></param>
        public static void SupprAbsence (Personnel personnelgere , Absence absence)
        {
          string req = "DELETE FROM `absence` WHERE `idAbsence`=@idabsence ;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idabsence", absence.Idabsence);
            Singleton connection = Singleton.GetInstance(AccesDonnes.connectionString);
            connection.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Boolean qui vérifié si le login et pwd saisie sont bien dans la bdd
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="pwd"></param>
        /// <returns > True si le curseur trouve une ligne , False ssi pas de ligne</returns>
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




















    }
}
