using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Mediatek86.Connexion
{
    /*  public class SingletonConnexion
      {

          private static SingletonConnexion instance = null;

          private SingletonConnexion() { }


          public static SingletonConnexion GetInstance() 

          { if (SingletonConnexion.instance == null)

              { SingletonConnexion.instance = new SingletonConnexion("database=mlr1; server=localhost ; user id=root ; pwd") ; }

              else
              { return SingletonConnexion.instance; }

          }









      }
    */
    public class ConnexionBDD
    {

        private static ConnexionBDD instance = null;
        private MySqlConnection connection;
        private MySqlCommand command;

        private MySqlDataReader reader;


        private ConnexionBDD(string stringConnect)
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


        public static ConnexionBDD GetInstance(string stringConnect)
        {
            if (instance is null)
            {
                instance = new ConnexionBDD(stringConnect);
            }
            return instance;
        }
        public void ReqUpdate(string stringQuery, Dictionary<string, object> parameters)
        {
            try
            {
                command = new MySqlCommand(stringQuery, connection);
                foreach (KeyValuePair<string, object> parameter in parameters)
                {
                    command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
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
        /// Exécute une requête type "select" et valorise le curseur
        /// </summary>
        /// <param name="stringQuery">requête select</param>
        public void ReqSelect(string stringQuery)
        {
            try
            {
                command = new MySqlCommand(stringQuery, connection);
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
        /// Retourne le contenu d'un champ dont le nom est passé en paramètre
        /// </summary>
        /// <param name="nameField">nom du champ</param>
        /// <returns>valeur du champ</returns>
        public object Field(string nameField)
        {
            if (reader is null)
            {
                return null;
            }
            try
            {
                return reader[nameField];
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Fermeture du curseur
        /// </summary>
        public void Close()
        {
            if (!(reader is null))
            {
                reader.Close();
            }
        }
    }




}



