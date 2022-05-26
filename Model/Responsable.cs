using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek86.Model
{/// <summary>
 /// classe metier  source table responsable base de données
 /// </summary
    public class Responsable
    {
        private string login;
        private string pwd;

        public Responsable(string login, string pwd)
        {
            this.login = login;
            this.pwd = pwd;
        }

        public string Login { get => login; set => login = value; }
        public string Pwd { get => pwd; set => pwd = value; }



    }
}
