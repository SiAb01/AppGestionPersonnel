﻿
namespace Mediatek86
{
    partial class absence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(absence));
            this.PicIcone = new System.Windows.Forms.PictureBox();
            this.lstabsence = new System.Windows.Forms.ListBox();
            this.lblNomPrenom = new System.Windows.Forms.Label();
            this.lblfonction = new System.Windows.Forms.Label();
            this.btnAjouterAbs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DatepDatedebut = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cbxMotifAbsence = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnValiderAbsence = new System.Windows.Forms.Button();
            this.grpAjoutAbsence = new System.Windows.Forms.GroupBox();
            this.btnModifierAbs = new System.Windows.Forms.Button();
            this.btnSupprAbs = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicIcone)).BeginInit();
            this.grpAjoutAbsence.SuspendLayout();
            this.SuspendLayout();
            // 
            // PicIcone
            // 
            this.PicIcone.Image = ((System.Drawing.Image)(resources.GetObject("PicIcone.Image")));
            this.PicIcone.Location = new System.Drawing.Point(12, 26);
            this.PicIcone.Name = "PicIcone";
            this.PicIcone.Size = new System.Drawing.Size(156, 158);
            this.PicIcone.TabIndex = 1;
            this.PicIcone.TabStop = false;
            // 
            // lstabsence
            // 
            this.lstabsence.FormattingEnabled = true;
            this.lstabsence.ItemHeight = 16;
            this.lstabsence.Items.AddRange(new object[] {
            "23/04/2022  au 26/04/2022   Motif : Motif Familial",
            "23/04/2022  au 26/04/2022   Motif : Motif Familial",
            "23/04/2022  au 26/04/2022   Motif : Motif Familial"});
            this.lstabsence.Location = new System.Drawing.Point(366, 41);
            this.lstabsence.Name = "lstabsence";
            this.lstabsence.Size = new System.Drawing.Size(383, 388);
            this.lstabsence.TabIndex = 2;
            this.lstabsence.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstabsence_MouseClick);
            this.lstabsence.SelectedIndexChanged += new System.EventHandler(this.lstabsence_SelectedIndexChanged);
            // 
            // lblNomPrenom
            // 
            this.lblNomPrenom.AutoSize = true;
            this.lblNomPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomPrenom.Location = new System.Drawing.Point(47, 196);
            this.lblNomPrenom.Name = "lblNomPrenom";
            this.lblNomPrenom.Size = new System.Drawing.Size(121, 20);
            this.lblNomPrenom.TabIndex = 3;
            this.lblNomPrenom.Text = "NOM Prénom";
            // 
            // lblfonction
            // 
            this.lblfonction.AutoSize = true;
            this.lblfonction.Location = new System.Drawing.Point(70, 216);
            this.lblfonction.Name = "lblfonction";
            this.lblfonction.Size = new System.Drawing.Size(72, 17);
            this.lblfonction.TabIndex = 4;
            this.lblfonction.Text = "(Fonction)";
            // 
            // btnAjouterAbs
            // 
            this.btnAjouterAbs.Location = new System.Drawing.Point(174, 50);
            this.btnAjouterAbs.Name = "btnAjouterAbs";
            this.btnAjouterAbs.Size = new System.Drawing.Size(132, 40);
            this.btnAjouterAbs.TabIndex = 5;
            this.btnAjouterAbs.Text = "Ajouter Absence";
            this.btnAjouterAbs.UseVisualStyleBackColor = true;
            this.btnAjouterAbs.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Date Debut";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DatepDatedebut
            // 
            this.DatepDatedebut.Location = new System.Drawing.Point(13, 35);
            this.DatepDatedebut.Name = "DatepDatedebut";
            this.DatepDatedebut.Size = new System.Drawing.Size(200, 22);
            this.DatepDatedebut.TabIndex = 7;
            this.DatepDatedebut.ValueChanged += new System.EventHandler(this.DatepDatedebut_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Date  Fin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(13, 89);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 9;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // cbxMotifAbsence
            // 
            this.cbxMotifAbsence.FormattingEnabled = true;
            this.cbxMotifAbsence.Location = new System.Drawing.Point(13, 151);
            this.cbxMotifAbsence.Name = "cbxMotifAbsence";
            this.cbxMotifAbsence.Size = new System.Drawing.Size(178, 24);
            this.cbxMotifAbsence.TabIndex = 10;
            this.cbxMotifAbsence.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Motif Absence";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnValiderAbsence
            // 
            this.btnValiderAbsence.Location = new System.Drawing.Point(60, 182);
            this.btnValiderAbsence.Name = "btnValiderAbsence";
            this.btnValiderAbsence.Size = new System.Drawing.Size(75, 23);
            this.btnValiderAbsence.TabIndex = 12;
            this.btnValiderAbsence.Text = "Valider";
            this.btnValiderAbsence.UseVisualStyleBackColor = true;
            this.btnValiderAbsence.Click += new System.EventHandler(this.button2_Click);
            // 
            // grpAjoutAbsence
            // 
            this.grpAjoutAbsence.Controls.Add(this.btnValiderAbsence);
            this.grpAjoutAbsence.Controls.Add(this.label3);
            this.grpAjoutAbsence.Controls.Add(this.cbxMotifAbsence);
            this.grpAjoutAbsence.Controls.Add(this.dateTimePicker2);
            this.grpAjoutAbsence.Controls.Add(this.label2);
            this.grpAjoutAbsence.Controls.Add(this.DatepDatedebut);
            this.grpAjoutAbsence.Controls.Add(this.label1);
            this.grpAjoutAbsence.Location = new System.Drawing.Point(13, 233);
            this.grpAjoutAbsence.Name = "grpAjoutAbsence";
            this.grpAjoutAbsence.Size = new System.Drawing.Size(240, 214);
            this.grpAjoutAbsence.TabIndex = 13;
            this.grpAjoutAbsence.TabStop = false;
            this.grpAjoutAbsence.Visible = false;
            // 
            // btnModifierAbs
            // 
            this.btnModifierAbs.Location = new System.Drawing.Point(174, 107);
            this.btnModifierAbs.Name = "btnModifierAbs";
            this.btnModifierAbs.Size = new System.Drawing.Size(132, 23);
            this.btnModifierAbs.TabIndex = 14;
            this.btnModifierAbs.Text = "Modifier";
            this.btnModifierAbs.UseVisualStyleBackColor = true;
            this.btnModifierAbs.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnSupprAbs
            // 
            this.btnSupprAbs.Location = new System.Drawing.Point(174, 148);
            this.btnSupprAbs.Name = "btnSupprAbs";
            this.btnSupprAbs.Size = new System.Drawing.Size(132, 23);
            this.btnSupprAbs.TabIndex = 15;
            this.btnSupprAbs.Text = "Supprimer";
            this.btnSupprAbs.UseVisualStyleBackColor = true;
            this.btnSupprAbs.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(760, 18);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(34, 32);
            this.btnRetour.TabIndex = 16;
            this.btnRetour.Text = "<";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // absence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnSupprAbs);
            this.Controls.Add(this.btnModifierAbs);
            this.Controls.Add(this.grpAjoutAbsence);
            this.Controls.Add(this.btnAjouterAbs);
            this.Controls.Add(this.lblfonction);
            this.Controls.Add(this.lblNomPrenom);
            this.Controls.Add(this.lstabsence);
            this.Controls.Add(this.PicIcone);
            this.Name = "absence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "absence";
            ((System.ComponentModel.ISupportInitialize)(this.PicIcone)).EndInit();
            this.grpAjoutAbsence.ResumeLayout(false);
            this.grpAjoutAbsence.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicIcone;
        private System.Windows.Forms.ListBox lstabsence;
        private System.Windows.Forms.Label lblNomPrenom;
        private System.Windows.Forms.Label lblfonction;
        private System.Windows.Forms.Button btnAjouterAbs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DatepDatedebut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox cbxMotifAbsence;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnValiderAbsence;
        private System.Windows.Forms.GroupBox grpAjoutAbsence;
        private System.Windows.Forms.Button btnModifierAbs;
        private System.Windows.Forms.Button btnSupprAbs;
        private System.Windows.Forms.Button btnRetour;
    }
}