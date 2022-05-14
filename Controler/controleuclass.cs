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
    class controleuclass
    {
        
           




        public static void AfficherDtgPersonnel ()
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
