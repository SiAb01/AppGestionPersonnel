
namespace Mediatek86.Vue
{
    partial class FrmAuthentification
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbllogo1 = new System.Windows.Forms.Label();
            this.lbllogo2 = new System.Windows.Forms.Label();
            this.lbllogin = new System.Windows.Forms.Label();
            this.labelmdp = new System.Windows.Forms.Label();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.txtmotdepasse = new System.Windows.Forms.TextBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbllogo1
            // 
            this.lbllogo1.AutoSize = true;
            this.lbllogo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogo1.Location = new System.Drawing.Point(266, 31);
            this.lbllogo1.Name = "lbllogo1";
            this.lbllogo1.Size = new System.Drawing.Size(354, 61);
            this.lbllogo1.TabIndex = 0;
            this.lbllogo1.Text = "MEDIATEK48";
            this.lbllogo1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbllogo1.Click += new System.EventHandler(this.lbllogo1_Click);
            // 
            // lbllogo2
            // 
            this.lbllogo2.AutoSize = true;
            this.lbllogo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbllogo2.Location = new System.Drawing.Point(302, 110);
            this.lbllogo2.Name = "lbllogo2";
            this.lbllogo2.Size = new System.Drawing.Size(286, 31);
            this.lbllogo2.TabIndex = 1;
            this.lbllogo2.Text = "Gestion Administrative";
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Location = new System.Drawing.Point(428, 302);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(50, 20);
            this.lbllogin.TabIndex = 2;
            this.lbllogin.Text = "Login";
            // 
            // labelmdp
            // 
            this.labelmdp.AutoSize = true;
            this.labelmdp.Location = new System.Drawing.Point(412, 394);
            this.labelmdp.Name = "labelmdp";
            this.labelmdp.Size = new System.Drawing.Size(112, 20);
            this.labelmdp.TabIndex = 3;
            this.labelmdp.Text = "Mot de Passe";
            this.labelmdp.Click += new System.EventHandler(this.labelmdp_Click);
            // 
            // txtlogin
            // 
            this.txtlogin.Location = new System.Drawing.Point(342, 348);
            this.txtlogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(241, 26);
            this.txtlogin.TabIndex = 4;
            this.txtlogin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtmotdepasse
            // 
            this.txtmotdepasse.Location = new System.Drawing.Point(342, 439);
            this.txtmotdepasse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmotdepasse.Name = "txtmotdepasse";
            this.txtmotdepasse.Size = new System.Drawing.Size(241, 26);
            this.txtmotdepasse.TabIndex = 5;
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(394, 488);
            this.btnConnexion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(134, 34);
            this.btnConnexion.TabIndex = 6;
            this.btnConnexion.Text = "Se Connecter";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.txtmotdepasse);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.labelmdp);
            this.Controls.Add(this.lbllogin);
            this.Controls.Add(this.lbllogo2);
            this.Controls.Add(this.lbllogo1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmAuthentification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mediatek - Gestion du Personnel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllogo1;
        private System.Windows.Forms.Label lbllogo2;
        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.Label labelmdp;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.TextBox txtmotdepasse;
        private System.Windows.Forms.Button btnConnexion;
    }
}

