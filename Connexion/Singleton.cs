using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Mediatek86.Model;
using System.Globalization;

namespace Mediatek86.Connexion
{ 





    /// <summary>
    /// Contient juste une classe Singleton qui va gérer l'accès à la base de données
    /// </summary>
public class Singleton
    {
        /// <summary>
        /// Unique instance de la classe
        /// </summary>
        private static Singleton instance = null;
        /// <summary>
        /// objet de connexion à la BDD à partir d'une chaîne de connexion
        /// </summary>
        private MySqlConnection connection;
        /// <summary>
        /// objet pour exécuter une requête SQL
        /// </summary>
        private MySqlCommand command;
        /// <summary>
        /// objet contenant le résultat d'une requête "select" (curseur)
        /// </summary>
        private MySqlDataReader reader;

        /// <summary>
        /// Constructeur privé pour créer la connexion à la BDD et l'ouvrir
        /// </summary>
        /// <param name="stringConnect">chaine de connexion</param>
        /// <returns>instance unique de la classe</returns>
        private Singleton (string stringConnect)
        {
            try
            {
                connection = new MySqlConnection(stringConnect);
                connection.Open();
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Application.Exit();
            }
        }

        /// <summary>
        /// Crée une instance unique de la classe
        /// </summary>
        /// <param name="stringConnect">chaine de connexion</param>
        /// <returns>instance unique de la classe</returns>
        public static Singleton GetInstance(string stringConnect)
        {
            if (instance is null)
            {
                instance = new Singleton(stringConnect);
            }
            return instance;
        }







        /* public static void getdatagrid (string requetedata)
         {
            var connectiondtb = GetInstance("server=localhost;user id=root;database=mlr1") ;
             connectiondtb.connection.Open();
             MySqlDataAdapter reqdataAdapter = new MySqlDataAdapter(requetedata, connectiondtb);


         }
        */


        /// <summary>
        /// Exécution d'une requête autre que "select"
        /// </summary>
        /// <param name="stringQuery">requête autre que select</param>
        /// <param name="parameters">dictionnire contenant les parametres</param>
        /// <returns> une requete préparé qui va s'exuter</returns>
        public void ReqUpdate(string stringQuery, Dictionary<string, object> parameters)
        {
            try
            {
                command = new MySqlCommand(stringQuery, connection);
                if (!(parameters is null))
                {
                    foreach (KeyValuePair<string, object> parameter in parameters)
                    {
                        command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                    }
                }
                command.Prepare();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
       

        /// <summary>
        /// Faire une requete préparé select
        /// </summary>
        /// <param name="stringQuery">requete sql ds une chaine de caractère</param>
        /// <param name="parameters">element du dictionnaire parameters qui sera l'objet à associé</param>
        public void ReqSelect(string stringQuery, Dictionary<string, object> parameters)
        {
            try
            {
                command = new MySqlCommand(stringQuery, connection);
                if (!(parameters is null))
                {
                    foreach (KeyValuePair<string, object> parameter in parameters)
                    {
                        command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                    }
                }
                command.Prepare();
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Tente de lire la ligne suivante du curseur
        /// </summary>
        /// <returns>false si fin de curseur atteinte</returns>
        public bool Read()
        {
            if (reader is null)
            {
                return false;
            }
            try
            {
                return reader.Read();
            }
            catch
            {
                return false;
            }
        }

      /// <summary>
      /// Recuperer un champs de la bdd
      /// </summary>
      /// <param name="indicechamps"> le numéro de la colonne dans la requete</param>
      /// <returns> obtenir la valeur d'un champs</returns>
        public object Field(/*string nameField*/int indicechamps)
        {
            if (reader is null)
            {
                return null;
            }
            try
            {
                // return reader[nameField];
                return reader.GetValue(indicechamps);
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// fermeture curseur
        /// </summary>
        ///  <returns>false si fin de curseur atteinte</returns>

        public void Close()
        {
            if (!(reader is null))
            {
                reader.Close();
            }
        }

    }

}
