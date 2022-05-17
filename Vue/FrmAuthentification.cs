using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mediatek86.Connexion;
using Mediatek86.Model;
using Mediatek86.Dal;


namespace Mediatek86.Vue 
{
    public partial class FrmAuthentification : Form
    {
        public FrmAuthentification()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbllogo1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelmdp_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           FrmPersonnel  frmPersonnel = new FrmPersonnel();
            frmPersonnel.Show();
            this.Hide();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          
               
            
            
            
                  

















            }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblstringcheck_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            FrmAbsence frmAbsence = new FrmAbsence();
            frmAbsence.Show();
            this.Hide();
        }
    }
} 
