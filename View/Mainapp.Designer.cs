
namespace Mediatek86
{
    partial class Mainapp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainapp));
            this.PicIcone = new System.Windows.Forms.PictureBox();
            this.lstpersonnel = new System.Windows.Forms.ListBox();
            this.lblNomPrenom = new System.Windows.Forms.Label();
            this.lblfonction = new System.Windows.Forms.Label();
            this.lbltelephone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnModifFiche = new System.Windows.Forms.Button();
            this.btnSupprimerFiche = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpaffichecontact = new System.Windows.Forms.GroupBox();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxservice = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txttelephone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.grpAjouterPersonnel = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicIcone)).BeginInit();
            this.grpaffichecontact.SuspendLayout();
            this.grpAjouterPersonnel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PicIcone
            // 
            this.PicIcone.Image = ((System.Drawing.Image)(resources.GetObject("PicIcone.Image")));
            this.PicIcone.Location = new System.Drawing.Point(38, 32);
            this.PicIcone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PicIcone.Name = "PicIcone";
            this.PicIcone.Size = new System.Drawing.Size(176, 198);
            this.PicIcone.TabIndex = 0;
            this.PicIcone.TabStop = false;
            // 
            // lstpersonnel
            // 
            this.lstpersonnel.FormattingEnabled = true;
            this.lstpersonnel.ItemHeight = 20;
            this.lstpersonnel.Items.AddRange(new object[] {
            "Jeanne MORAUD"});
            this.lstpersonnel.Location = new System.Drawing.Point(442, 62);
            this.lstpersonnel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstpersonnel.Name = "lstpersonnel";
            this.lstpersonnel.Size = new System.Drawing.Size(329, 464);
            this.lstpersonnel.TabIndex = 1;
            this.lstpersonnel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstpersonnel_MouseClick);
            this.lstpersonnel.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblNomPrenom
            // 
            this.lblNomPrenom.AutoSize = true;
            this.lblNomPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomPrenom.Location = new System.Drawing.Point(30, 0);
            this.lblNomPrenom.Name = "lblNomPrenom";
            this.lblNomPrenom.Size = new System.Drawing.Size(121, 20);
            this.lblNomPrenom.TabIndex = 2;
            this.lblNomPrenom.Text = "NOM Prénom";
            this.lblNomPrenom.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblfonction
            // 
            this.lblfonction.AutoSize = true;
            this.lblfonction.Location = new System.Drawing.Point(52, 28);
            this.lblfonction.Name = "lblfonction";
            this.lblfonction.Size = new System.Drawing.Size(85, 20);
            this.lblfonction.TabIndex = 3;
            this.lblfonction.Text = "(Fonction)";
            this.lblfonction.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbltelephone
            // 
            this.lbltelephone.AutoSize = true;
            this.lbltelephone.Location = new System.Drawing.Point(17, 72);
            this.lbltelephone.Name = "lbltelephone";
            this.lbltelephone.Size = new System.Drawing.Size(96, 20);
            this.lbltelephone.TabIndex = 4;
            this.lbltelephone.Text = "Téléphone :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(17, 138);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(61, 20);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email :";
            // 
            // btnModifFiche
            // 
            this.btnModifFiche.Location = new System.Drawing.Point(20, 234);
            this.btnModifFiche.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModifFiche.Name = "btnModifFiche";
            this.btnModifFiche.Size = new System.Drawing.Size(84, 38);
            this.btnModifFiche.TabIndex = 6;
            this.btnModifFiche.Text = "Modifier Fiche";
            this.btnModifFiche.UseVisualStyleBackColor = true;
            this.btnModifFiche.Click += new System.EventHandler(this.btnModifFiche_Click);
            // 
            // btnSupprimerFiche
            // 
            this.btnSupprimerFiche.Location = new System.Drawing.Point(134, 235);
            this.btnSupprimerFiche.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSupprimerFiche.Name = "btnSupprimerFiche";
            this.btnSupprimerFiche.Size = new System.Drawing.Size(96, 36);
            this.btnSupprimerFiche.TabIndex = 7;
            this.btnSupprimerFiche.Text = "Supprimer";
            this.btnSupprimerFiche.UseVisualStyleBackColor = true;
            this.btnSupprimerFiche.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(483, 11);
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
            this.grpaffichecontact.Location = new System.Drawing.Point(37, 252);
            this.grpaffichecontact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpaffichecontact.Name = "grpaffichecontact";
            this.grpaffichecontact.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpaffichecontact.Size = new System.Drawing.Size(241, 281);
            this.grpaffichecontact.TabIndex = 10;
            this.grpaffichecontact.TabStop = false;
            this.grpaffichecontact.Visible = false;
            this.grpaffichecontact.Enter += new System.EventHandler(this.grpaffichecontact_Enter);
            // 
            // txtprenom
            // 
            this.txtprenom.Location = new System.Drawing.Point(110, 61);
            this.txtprenom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(166, 26);
            this.txtprenom.TabIndex = 11;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(110, 19);
            this.txtnom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(166, 26);
            this.txtnom.TabIndex = 12;
            this.txtnom.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Prénom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Service";
            // 
            // cbxservice
            // 
            this.cbxservice.FormattingEnabled = true;
            this.cbxservice.Location = new System.Drawing.Point(110, 104);
            this.cbxservice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxservice.Name = "cbxservice";
            this.cbxservice.Size = new System.Drawing.Size(166, 28);
            this.cbxservice.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Télephone";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Email";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txttelephone
            // 
            this.txttelephone.Location = new System.Drawing.Point(110, 148);
            this.txttelephone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttelephone.Name = "txttelephone";
            this.txttelephone.Size = new System.Drawing.Size(166, 26);
            this.txttelephone.TabIndex = 21;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(110, 195);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(166, 26);
            this.txtEmail.TabIndex = 22;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(53, 240);
            this.btnValider.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(158, 34);
            this.btnValider.TabIndex = 23;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpAjouterPersonnel
            // 
            this.grpAjouterPersonnel.Controls.Add(this.btnValider);
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
            this.grpAjouterPersonnel.Location = new System.Drawing.Point(37, 252);
            this.grpAjouterPersonnel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpAjouterPersonnel.Name = "grpAjouterPersonnel";
            this.grpAjouterPersonnel.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpAjouterPersonnel.Size = new System.Drawing.Size(304, 288);
            this.grpAjouterPersonnel.TabIndex = 24;
            this.grpAjouterPersonnel.TabStop = false;
            this.grpAjouterPersonnel.Visible = false;
            this.grpAjouterPersonnel.Enter += new System.EventHandler(this.grpAjouterPersonnel_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 115);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 31);
            this.button1.TabIndex = 25;
            this.button1.Text = "Ajouter Personnel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(234, 174);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 29);
            this.button2.TabIndex = 26;
            this.button2.Text = "Absences";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnGererAbs);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(747, 11);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 29);
            this.button3.TabIndex = 27;
            this.button3.Text = "Se Deconnecter";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Mainapp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpAjouterPersonnel);
            this.Controls.Add(this.grpaffichecontact);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstpersonnel);
            this.Controls.Add(this.PicIcone);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Mainapp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mainapp";
            ((System.ComponentModel.ISupportInitialize)(this.PicIcone)).EndInit();
            this.grpaffichecontact.ResumeLayout(false);
            this.grpaffichecontact.PerformLayout();
            this.grpAjouterPersonnel.ResumeLayout(false);
            this.grpAjouterPersonnel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicIcone;
        private System.Windows.Forms.ListBox lstpersonnel;
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
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.GroupBox grpAjouterPersonnel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}