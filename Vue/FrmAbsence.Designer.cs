
namespace Mediatek86.Vue 
{/// <summary>
/// Form qui va gérer les absence d'un personnel
/// </summary>
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PicIcone = new System.Windows.Forms.PictureBox();
            this.lblNomPrenom = new System.Windows.Forms.Label();
            this.lblfonction = new System.Windows.Forms.Label();
            this.btnAjouterAbs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DatepDatedebut = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.DatepDateFin = new System.Windows.Forms.DateTimePicker();
            this.cbxMotifAbsence = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnValidAjoutAbs = new System.Windows.Forms.Button();
            this.grpAjoutAbsence = new System.Windows.Forms.GroupBox();
            this.btnValidModif = new System.Windows.Forms.Button();
            this.btnModifierAbs = new System.Windows.Forms.Button();
            this.btnSupprAbs = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.dtgAbsence = new System.Windows.Forms.DataGridView();
            this.bdgAbsence = new System.Windows.Forms.BindingSource(this.components);
            this.lbltitreabsence = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicIcone)).BeginInit();
            this.grpAjoutAbsence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAbsence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgAbsence)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PicIcone
            // 
            this.PicIcone.Image = ((System.Drawing.Image)(resources.GetObject("PicIcone.Image")));
            this.PicIcone.Location = new System.Drawing.Point(151, 136);
            this.PicIcone.Name = "PicIcone";
            this.PicIcone.Size = new System.Drawing.Size(156, 158);
            this.PicIcone.TabIndex = 1;
            this.PicIcone.TabStop = false;
            // 
            // lblNomPrenom
            // 
            this.lblNomPrenom.AutoSize = true;
            this.lblNomPrenom.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomPrenom.Location = new System.Drawing.Point(163, 306);
            this.lblNomPrenom.Name = "lblNomPrenom";
            this.lblNomPrenom.Size = new System.Drawing.Size(132, 23);
            this.lblNomPrenom.TabIndex = 3;
            this.lblNomPrenom.Text = "NOM Prénom";
            // 
            // lblfonction
            // 
            this.lblfonction.AutoSize = true;
            this.lblfonction.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfonction.Location = new System.Drawing.Point(181, 342);
            this.lblfonction.Name = "lblfonction";
            this.lblfonction.Size = new System.Drawing.Size(76, 17);
            this.lblfonction.TabIndex = 4;
            this.lblfonction.Text = "(Fonction)";
            // 
            // btnAjouterAbs
            // 
            this.btnAjouterAbs.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterAbs.Location = new System.Drawing.Point(367, 132);
            this.btnAjouterAbs.Name = "btnAjouterAbs";
            this.btnAjouterAbs.Size = new System.Drawing.Size(132, 40);
            this.btnAjouterAbs.TabIndex = 5;
            this.btnAjouterAbs.Text = "Ajouter Absence";
            this.btnAjouterAbs.UseVisualStyleBackColor = true;
            this.btnAjouterAbs.Click += new System.EventHandler(this.btnajouterabs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Date Debut";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DatepDatedebut
            // 
            this.DatepDatedebut.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatepDatedebut.Location = new System.Drawing.Point(55, 73);
            this.DatepDatedebut.Name = "DatepDatedebut";
            this.DatepDatedebut.Size = new System.Drawing.Size(263, 23);
            this.DatepDatedebut.TabIndex = 7;
            this.DatepDatedebut.ValueChanged += new System.EventHandler(this.DatepDatedebut_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Date  Fin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DatepDateFin
            // 
            this.DatepDateFin.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatepDateFin.Location = new System.Drawing.Point(55, 150);
            this.DatepDateFin.Name = "DatepDateFin";
            this.DatepDateFin.Size = new System.Drawing.Size(263, 23);
            this.DatepDateFin.TabIndex = 9;
            this.DatepDateFin.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // cbxMotifAbsence
            // 
            this.cbxMotifAbsence.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMotifAbsence.FormattingEnabled = true;
            this.cbxMotifAbsence.Location = new System.Drawing.Point(55, 220);
            this.cbxMotifAbsence.Name = "cbxMotifAbsence";
            this.cbxMotifAbsence.Size = new System.Drawing.Size(263, 25);
            this.cbxMotifAbsence.TabIndex = 10;
            this.cbxMotifAbsence.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Motif Absence";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnValidAjoutAbs
            // 
            this.btnValidAjoutAbs.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidAjoutAbs.Location = new System.Drawing.Point(141, 296);
            this.btnValidAjoutAbs.Name = "btnValidAjoutAbs";
            this.btnValidAjoutAbs.Size = new System.Drawing.Size(85, 39);
            this.btnValidAjoutAbs.TabIndex = 12;
            this.btnValidAjoutAbs.Text = "Valider";
            this.btnValidAjoutAbs.UseVisualStyleBackColor = true;
            this.btnValidAjoutAbs.Click += new System.EventHandler(this.btnValidAjoutAbsence_Click);
            // 
            // grpAjoutAbsence
            // 
            this.grpAjoutAbsence.Controls.Add(this.btnValidModif);
            this.grpAjoutAbsence.Controls.Add(this.btnValidAjoutAbs);
            this.grpAjoutAbsence.Controls.Add(this.label3);
            this.grpAjoutAbsence.Controls.Add(this.label2);
            this.grpAjoutAbsence.Controls.Add(this.cbxMotifAbsence);
            this.grpAjoutAbsence.Controls.Add(this.DatepDateFin);
            this.grpAjoutAbsence.Controls.Add(this.DatepDatedebut);
            this.grpAjoutAbsence.Controls.Add(this.label1);
            this.grpAjoutAbsence.Location = new System.Drawing.Point(43, 381);
            this.grpAjoutAbsence.Name = "grpAjoutAbsence";
            this.grpAjoutAbsence.Size = new System.Drawing.Size(369, 371);
            this.grpAjoutAbsence.TabIndex = 13;
            this.grpAjoutAbsence.TabStop = false;
            this.grpAjoutAbsence.Visible = false;
            // 
            // btnValidModif
            // 
            this.btnValidModif.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidModif.Location = new System.Drawing.Point(141, 296);
            this.btnValidModif.Name = "btnValidModif";
            this.btnValidModif.Size = new System.Drawing.Size(85, 39);
            this.btnValidModif.TabIndex = 13;
            this.btnValidModif.Text = "Valider";
            this.btnValidModif.UseVisualStyleBackColor = true;
            this.btnValidModif.Click += new System.EventHandler(this.btnValidModif_Click);
            // 
            // btnModifierAbs
            // 
            this.btnModifierAbs.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierAbs.Location = new System.Drawing.Point(367, 217);
            this.btnModifierAbs.Name = "btnModifierAbs";
            this.btnModifierAbs.Size = new System.Drawing.Size(132, 36);
            this.btnModifierAbs.TabIndex = 14;
            this.btnModifierAbs.Text = "Modifier";
            this.btnModifierAbs.UseVisualStyleBackColor = true;
            this.btnModifierAbs.Click += new System.EventHandler(this.btnModifierAbs_Click_1);
            // 
            // btnSupprAbs
            // 
            this.btnSupprAbs.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprAbs.Location = new System.Drawing.Point(367, 274);
            this.btnSupprAbs.Name = "btnSupprAbs";
            this.btnSupprAbs.Size = new System.Drawing.Size(132, 32);
            this.btnSupprAbs.TabIndex = 15;
            this.btnSupprAbs.Text = "Supprimer";
            this.btnSupprAbs.UseVisualStyleBackColor = true;
            this.btnSupprAbs.Click += new System.EventHandler(this.btnSupprAbs_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.Location = new System.Drawing.Point(1010, 3);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(196, 90);
            this.btnRetour.TabIndex = 16;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click_1);
            // 
            // dtgAbsence
            // 
            this.dtgAbsence.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgAbsence.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgAbsence.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgAbsence.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgAbsence.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtgAbsence.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgAbsence.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgAbsence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgAbsence.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgAbsence.EnableHeadersVisualStyles = false;
            this.dtgAbsence.Location = new System.Drawing.Point(539, 217);
            this.dtgAbsence.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgAbsence.MultiSelect = false;
            this.dtgAbsence.Name = "dtgAbsence";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgAbsence.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgAbsence.RowHeadersVisible = false;
            this.dtgAbsence.RowHeadersWidth = 51;
            this.dtgAbsence.RowTemplate.Height = 28;
            this.dtgAbsence.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dtgAbsence.Size = new System.Drawing.Size(800, 383);
            this.dtgAbsence.TabIndex = 17;
            this.dtgAbsence.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAbsence_CellContentClick_1);
            this.dtgAbsence.SelectionChanged += new System.EventHandler(this.dtgAbsence_SelectionChanged);
            // 
            // bdgAbsence
            // 
            this.bdgAbsence.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.bdgAbsence_BindingComplete);
            // 
            // lbltitreabsence
            // 
            this.lbltitreabsence.AutoSize = true;
            this.lbltitreabsence.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitreabsence.Location = new System.Drawing.Point(820, 132);
            this.lbltitreabsence.Name = "lbltitreabsence";
            this.lbltitreabsence.Size = new System.Drawing.Size(84, 19);
            this.lbltitreabsence.TabIndex = 18;
            this.lbltitreabsence.Text = "Absence";
            this.lbltitreabsence.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnRetour);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1528, 93);
            this.panel1.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(564, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(338, 37);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gestion des Absences";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1482, 1055);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbltitreabsence);
            this.Controls.Add(this.dtgAbsence);
            this.Controls.Add(this.btnSupprAbs);
            this.Controls.Add(this.btnModifierAbs);
            this.Controls.Add(this.grpAjoutAbsence);
            this.Controls.Add(this.btnAjouterAbs);
            this.Controls.Add(this.lblNomPrenom);
            this.Controls.Add(this.lblfonction);
            this.Controls.Add(this.PicIcone);
            this.Name = "FrmAbsence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "absence";
            this.Load += new System.EventHandler(this.absence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicIcone)).EndInit();
            this.grpAjoutAbsence.ResumeLayout(false);
            this.grpAjoutAbsence.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAbsence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgAbsence)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker DatepDateFin;
        private System.Windows.Forms.ComboBox cbxMotifAbsence;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnValidAjoutAbs;
        private System.Windows.Forms.GroupBox grpAjoutAbsence;
        private System.Windows.Forms.Button btnModifierAbs;
        private System.Windows.Forms.Button btnSupprAbs;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.DataGridView dtgAbsence;
        private System.Windows.Forms.BindingSource bdgAbsence;
        private System.Windows.Forms.Button btnValidModif;
        private System.Windows.Forms.Label lbltitreabsence;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}