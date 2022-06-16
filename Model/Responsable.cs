using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek86.Model
{ 
/// <summary>
/// Classe metier responsable 
/// </summary>
    public class Responsable
    {
        private string login;
        private string pwd;
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="login"> login de l'user déjà crée dans la bddd</param>
        /// <param name="pwd"> mot d e passe de l'user déja créer ds bdd</param>
        public Responsable(string login, string pwd)
        {
            this.login = login;
            this.pwd = pwd;
        }
        /// <summary>
        /// valorise 
        /// </summary>
        public string Login { get => login; set => login = value; }




    }
}
