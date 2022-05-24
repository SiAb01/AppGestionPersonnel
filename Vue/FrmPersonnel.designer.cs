
namespace Mediatek86.Vue
{
    partial class FrmPersonnel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonnel));
            this.PicIcone = new System.Windows.Forms.PictureBox();
            this.lblNomPrenom = new System.Windows.Forms.Label();
            this.lblfonction = new System.Windows.Forms.Label();
            this.lbltelephone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnModifFiche = new System.Windows.Forms.Button();
            this.btnSupprimerFiche = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpaffichecontact = new System.Windows.Forms.GroupBox();
            this.grpAjouterPersonnel = new System.Windows.Forms.GroupBox();
            this.btnValidModif = new System.Windows.Forms.Button();
            this.btnValidAjout = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txttelephone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxservice = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.btnAjoutPersonnel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dtgPersonnel = new System.Windows.Forms.DataGridView();
            this.btnRetour = new System.Windows.Forms.Button();
            this.bdgPersonnel = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PicIcone)).BeginInit();
            this.grpaffichecontact.SuspendLayout();
            this.grpAjouterPersonnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPersonnel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgPersonnel)).BeginInit();
            this.SuspendLayout();
            // 
            // PicIcone
            // 
            this.PicIcone.Image = ((System.Drawing.Image)(resources.GetObject("PicIcone.Image")));
            this.PicIcone.Location = new System.Drawing.Point(43, 23);
            this.PicIcone.Name = "PicIcone";
            this.PicIcone.Size = new System.Drawing.Size(156, 158);
            this.PicIcone.TabIndex = 0;
            this.PicIcone.TabStop = false;
            // 
            // lblNomPrenom
            // 
            this.lblNomPrenom.AutoSize = true;
            this.lblNomPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomPrenom.Location = new System.Drawing.Point(83, 0);
            this.lblNomPrenom.Name = "lblNomPrenom";
            this.lblNomPrenom.Size = new System.Drawing.Size(121, 20);
            this.lblNomPrenom.TabIndex = 2;
            this.lblNomPrenom.Text = "NOM Prénom";
            this.lblNomPrenom.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblfonction
            // 
            this.lblfonction.AutoSize = true;
            this.lblfonction.Location = new System.Drawing.Point(99, 20);
            this.lblfonction.Name = "lblfonction";
            this.lblfonction.Size = new System.Drawing.Size(72, 17);
            this.lblfonction.TabIndex = 3;
            this.lblfonction.Text = "(Fonction)";
            this.lblfonction.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbltelephone
            // 
            this.lbltelephone.AutoSize = true;
            this.lbltelephone.Location = new System.Drawing.Point(19, 93);
            this.lbltelephone.Name = "lbltelephone";
            this.lbltelephone.Size = new System.Drawing.Size(84, 17);
            this.lbltelephone.TabIndex = 4;
            this.lbltelephone.Text = "Téléphone :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(28, 136);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 17);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email :";
            // 
            // btnModifFiche
            // 
            this.btnModifFiche.Location = new System.Drawing.Point(22, 188);
            this.btnModifFiche.Name = "btnModifFiche";
            this.btnModifFiche.Size = new System.Drawing.Size(97, 30);
            this.btnModifFiche.TabIndex = 6;
            this.btnModifFiche.Text = "Modifier Fiche";
            this.btnModifFiche.UseVisualStyleBackColor = true;
            this.btnModifFiche.Click += new System.EventHandler(this.btnModifFiche_Click);
            // 
            // btnSupprimerFiche
            // 
            this.btnSupprimerFiche.Location = new System.Drawing.Point(151, 188);
            this.btnSupprimerFiche.Name = "btnSupprimerFiche";
            this.btnSupprimerFiche.Size = new System.Drawing.Size(117, 30);
            this.btnSupprimerFiche.TabIndex = 7;
            this.btnSupprimerFiche.Text = "Supprimer";
            this.btnSupprimerFiche.UseVisualStyleBackColor = true;
            this.btnSupprimerFiche.Click += new System.EventHandler(this.btnSupprimer_onclick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Gestion du personnel";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // grpaffichecontact
            // 
            this.grpaffichecontact.Controls.Add(this.btnSupprimerFiche);
            this.grpaffichecontact.Controls.Add(this.btnModifFiche);
            this.grpaffichecontact.Controls.Add(this.lblEmail);
            this.grpaffichecontact.Controls.Add(this.lbltelephone);
            this.grpaffichecontact.Controls.Add(this.lblfonction);
            this.grpaffichecontact.Controls.Add(this.lblNomPrenom);
            this.grpaffichecontact.Location = new System.Drawing.Point(12, 201);
            this.grpaffichecontact.Name = "grpaffichecontact";
            this.grpaffichecontact.Size = new System.Drawing.Size(311, 251);
            this.grpaffichecontact.TabIndex = 10;
            this.grpaffichecontact.TabStop = false;
            this.grpaffichecontact.Visible = false;
            this.grpaffichecontact.Enter += new System.EventHandler(this.grpaffichecontact_Enter);
            // 
            // grpAjouterPersonnel
            // 
            this.grpAjouterPersonnel.Controls.Add(this.btnValidModif);
            this.grpAjouterPersonnel.Controls.Add(this.btnValidAjout);
            this.grpAjouterPersonnel.Controls.Add(this.txtEmail);
            this.grpAjouterPersonnel.Controls.Add(this.txttelephone);
            this.grpAjouterPersonnel.Controls.Add(this.label8);
            this.grpAjouterPersonnel.Controls.Add(this.label7);
            this.grpAjouterPersonnel.Controls.Add(this.cbxservice);
            this.grpAjouterPersonnel.Controls.Add(this.label6);
            this.grpAjouterPersonnel.Controls.Add(this.label3);
            this.grpAjouterPersonnel.Controls.Add(this.label2);
            this.grpAjouterPersonnel.Controls.Add(this.txtnom);
            this.grpAjouterPersonnel.Controls.Add(this.txtprenom);
            this.grpAjouterPersonnel.Location = new System.Drawing.Point(18, 201);
            this.grpAjouterPersonnel.Name = "grpAjouterPersonnel";
            this.grpAjouterPersonnel.Size = new System.Drawing.Size(305, 261);
            this.grpAjouterPersonnel.TabIndex = 24;
            this.grpAjouterPersonnel.TabStop = false;
            this.grpAjouterPersonnel.Visible = false;
            this.grpAjouterPersonnel.Enter += new System.EventHandler(this.grpAjouterPersonnel_Enter);
            // 
            // btnValidModif
            // 
            this.btnValidModif.Location = new System.Drawing.Point(119, 218);
            this.btnValidModif.Name = "btnValidModif";
            this.btnValidModif.Size = new System.Drawing.Size(140, 27);
            this.btnValidModif.TabIndex = 24;
            this.btnValidModif.Text = "Valider";
            this.btnValidModif.UseVisualStyleBackColor = true;
            this.btnValidModif.Click += new System.EventHandler(this.btnValidModif_Click);
            // 
            // btnValidAjout
            // 
            this.btnValidAjout.Location = new System.Drawing.Point(119, 218);
            this.btnValidAjout.Name = "btnValidAjout";
            this.btnValidAjout.Size = new System.Drawing.Size(140, 27);
            this.btnValidAjout.TabIndex = 23;
            this.btnValidAjout.Text = "Valider";
            this.btnValidAjout.UseVisualStyleBackColor = true;
            this.btnValidAjout.Click += new System.EventHandler(this.btnValiderAjoutPersonel_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(98, 156);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(190, 22);
            this.txtEmail.TabIndex = 22;
            // 
            // txttelephone
            // 
            this.txttelephone.Location = new System.Drawing.Point(98, 118);
            this.txttelephone.Name = "txttelephone";
            this.txttelephone.Size = new System.Drawing.Size(190, 22);
            this.txttelephone.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Email";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Télephone";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cbxservice
            // 
            this.cbxservice.FormattingEnabled = true;
            this.cbxservice.Location = new System.Drawing.Point(98, 83);
            this.cbxservice.Name = "cbxservice";
            this.cbxservice.Size = new System.Drawing.Size(190, 24);
            this.cbxservice.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Service";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Prénom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nom";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(98, 15);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(190, 22);
            this.txtnom.TabIndex = 12;
            this.txtnom.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtprenom
            // 
            this.txtprenom.Location = new System.Drawing.Point(98, 49);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(190, 22);
            this.txtprenom.TabIndex = 11;
            // 
            // btnAjoutPersonnel
            // 
            this.btnAjoutPersonnel.Location = new System.Drawing.Point(232, 76);
            this.btnAjoutPersonnel.Name = "btnAjoutPersonnel";
            this.btnAjoutPersonnel.Size = new System.Drawing.Size(68, 25);
            this.btnAjoutPersonnel.TabIndex = 25;
            this.btnAjoutPersonnel.Text = "Ajouter Personnel";
            this.btnAjoutPersonnel.UseVisualStyleBackColor = true;
            this.btnAjoutPersonnel.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(208, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Absences";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnGererAbs);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(664, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "Se Deconnecter";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dtgPersonnel
            // 
            this.dtgPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPersonnel.Location = new System.Drawing.Point(345, 51);
            this.dtgPersonnel.Name = "dtgPersonnel";
            this.dtgPersonnel.RowHeadersWidth = 51;
            this.dtgPersonnel.RowTemplate.Height = 24;
            this.dtgPersonnel.Size = new System.Drawing.Size(460, 420);
            this.dtgPersonnel.TabIndex = 28;
            this.dtgPersonnel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPersonnel_CellClick);
            this.dtgPersonnel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(345, 6);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(57, 23);
            this.btnRetour.TabIndex = 29;
            this.btnRetour.Text = ">";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // bdgPersonnel
            // 
            this.bdgPersonnel.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.bdgPersonnelCompleteenvent);
            // 
            // FrmPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(833, 483);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.dtgPersonnel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.grpAjouterPersonnel);
            this.Controls.Add(this.btnAjoutPersonnel);
            this.Controls.Add(this.grpaffichecontact);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PicIcone);
            this.Name = "FrmPersonnel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Personnel";
            this.Load += new System.EventHandler(this.Mainapp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicIcone)).EndInit();
            this.grpaffichecontact.ResumeLayout(false);
            this.grpaffichecontact.PerformLayout();
            this.grpAjouterPersonnel.ResumeLayout(false);
            this.grpAjouterPersonnel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPersonnel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgPersonnel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicIcone;
        private System.Windows.Forms.Label lblNomPrenom;
        private System.Windows.Forms.Label lblfonction;
        private System.Windows.Forms.Label lbltelephone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnModifFiche;
        private System.Windows.Forms.Button btnSupprimerFiche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpaffichecontact;
        private System.Windows.Forms.TextBox txtprenom;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxservice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttelephone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnValidAjout;
        private System.Windows.Forms.GroupBox grpAjouterPersonnel;
        private System.Windows.Forms.Button btnAjoutPersonnel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public  System.Windows.Forms.DataGridView dtgPersonnel;
        private System.Windows.Forms.Button btnValidModif;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.BindingSource bdgPersonnel;
    }
}