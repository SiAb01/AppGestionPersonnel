
namespace Mediatek86.Vue 
{
    partial class FrmAbsence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbsence));
            this.PicIcone = new System.Windows.Forms.PictureBox();
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
            this.dtgAbsence = new System.Windows.Forms.DataGridView();
            this.bdgAbsence = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PicIcone)).BeginInit();
            this.grpAjoutAbsence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAbsence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgAbsence)).BeginInit();
            this.SuspendLayout();
            // 
            // PicIcone
            // 
            this.PicIcone.Image = ((System.Drawing.Image)(resources.GetObject("PicIcone.Image")));
            this.PicIcone.Location = new System.Drawing.Point(14, 32);
            this.PicIcone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PicIcone.Name = "PicIcone";
            this.PicIcone.Size = new System.Drawing.Size(176, 198);
            this.PicIcone.TabIndex = 1;
            this.PicIcone.TabStop = false;
            this.PicIcone.Click += new System.EventHandler(this.PicIcone_Click);
            // 
            // lblNomPrenom
            // 
            this.lblNomPrenom.AutoSize = true;
            this.lblNomPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomPrenom.Location = new System.Drawing.Point(53, 245);
            this.lblNomPrenom.Name = "lblNomPrenom";
            this.lblNomPrenom.Size = new System.Drawing.Size(121, 20);
            this.lblNomPrenom.TabIndex = 3;
            this.lblNomPrenom.Text = "NOM Prénom";
            // 
            // lblfonction
            // 
            this.lblfonction.AutoSize = true;
            this.lblfonction.Location = new System.Drawing.Point(79, 270);
            this.lblfonction.Name = "lblfonction";
            this.lblfonction.Size = new System.Drawing.Size(85, 20);
            this.lblfonction.TabIndex = 4;
            this.lblfonction.Text = "(Fonction)";
            // 
            // btnAjouterAbs
            // 
            this.btnAjouterAbs.Location = new System.Drawing.Point(196, 62);
            this.btnAjouterAbs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAjouterAbs.Name = "btnAjouterAbs";
            this.btnAjouterAbs.Size = new System.Drawing.Size(148, 50);
            this.btnAjouterAbs.TabIndex = 5;
            this.btnAjouterAbs.Text = "Ajouter Absence";
            this.btnAjouterAbs.UseVisualStyleBackColor = true;
            this.btnAjouterAbs.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Date Debut";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DatepDatedebut
            // 
            this.DatepDatedebut.Location = new System.Drawing.Point(15, 44);
            this.DatepDatedebut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DatepDatedebut.Name = "DatepDatedebut";
            this.DatepDatedebut.Size = new System.Drawing.Size(224, 26);
            this.DatepDatedebut.TabIndex = 7;
            this.DatepDatedebut.ValueChanged += new System.EventHandler(this.DatepDatedebut_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Date  Fin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(15, 111);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(224, 26);
            this.dateTimePicker2.TabIndex = 9;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // cbxMotifAbsence
            // 
            this.cbxMotifAbsence.FormattingEnabled = true;
            this.cbxMotifAbsence.Location = new System.Drawing.Point(15, 189);
            this.cbxMotifAbsence.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxMotifAbsence.Name = "cbxMotifAbsence";
            this.cbxMotifAbsence.Size = new System.Drawing.Size(200, 28);
            this.cbxMotifAbsence.TabIndex = 10;
            this.cbxMotifAbsence.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Motif Absence";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnValiderAbsence
            // 
            this.btnValiderAbsence.Location = new System.Drawing.Point(68, 228);
            this.btnValiderAbsence.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnValiderAbsence.Name = "btnValiderAbsence";
            this.btnValiderAbsence.Size = new System.Drawing.Size(84, 29);
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
            this.grpAjoutAbsence.Location = new System.Drawing.Point(15, 291);
            this.grpAjoutAbsence.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpAjoutAbsence.Name = "grpAjoutAbsence";
            this.grpAjoutAbsence.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpAjoutAbsence.Size = new System.Drawing.Size(270, 268);
            this.grpAjoutAbsence.TabIndex = 13;
            this.grpAjoutAbsence.TabStop = false;
            this.grpAjoutAbsence.Visible = false;
            // 
            // btnModifierAbs
            // 
            this.btnModifierAbs.Location = new System.Drawing.Point(196, 134);
            this.btnModifierAbs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModifierAbs.Name = "btnModifierAbs";
            this.btnModifierAbs.Size = new System.Drawing.Size(148, 29);
            this.btnModifierAbs.TabIndex = 14;
            this.btnModifierAbs.Text = "Modifier";
            this.btnModifierAbs.UseVisualStyleBackColor = true;
            this.btnModifierAbs.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnSupprAbs
            // 
            this.btnSupprAbs.Location = new System.Drawing.Point(196, 185);
            this.btnSupprAbs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSupprAbs.Name = "btnSupprAbs";
            this.btnSupprAbs.Size = new System.Drawing.Size(148, 29);
            this.btnSupprAbs.TabIndex = 15;
            this.btnSupprAbs.Text = "Supprimer";
            this.btnSupprAbs.UseVisualStyleBackColor = true;
            this.btnSupprAbs.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(855, 22);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(38, 40);
            this.btnRetour.TabIndex = 16;
            this.btnRetour.Text = "<";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // dtgAbsence
            // 
            this.dtgAbsence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAbsence.Location = new System.Drawing.Point(362, 62);
            this.dtgAbsence.Name = "dtgAbsence";
            this.dtgAbsence.RowHeadersWidth = 51;
            this.dtgAbsence.RowTemplate.Height = 28;
            this.dtgAbsence.Size = new System.Drawing.Size(495, 463);
            this.dtgAbsence.TabIndex = 17;
            // 
            // FrmAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.dtgAbsence);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnSupprAbs);
            this.Controls.Add(this.btnModifierAbs);
            this.Controls.Add(this.grpAjoutAbsence);
            this.Controls.Add(this.btnAjouterAbs);
            this.Controls.Add(this.lblfonction);
            this.Controls.Add(this.lblNomPrenom);
            this.Controls.Add(this.PicIcone);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmAbsence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "absence";
            this.Load += new System.EventHandler(this.absence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicIcone)).EndInit();
            this.grpAjoutAbsence.ResumeLayout(false);
            this.grpAjoutAbsence.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAbsence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgAbsence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicIcone;
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
        private System.Windows.Forms.DataGridView dtgAbsence;
        private System.Windows.Forms.BindingSource bdgAbsence;
    }
}