
namespace Mediatek86.Vue
{/// <summary>
/// Form de connexion
/// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAuthentification));
            this.lbllogo1 = new System.Windows.Forms.Label();
            this.lbllogo2 = new System.Windows.Forms.Label();
            this.lbllogin = new System.Windows.Forms.Label();
            this.labelmdp = new System.Windows.Forms.Label();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.txtmotdepasse = new System.Windows.Forms.TextBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbllogo1
            // 
            this.lbllogo1.AutoSize = true;
            this.lbllogo1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogo1.Location = new System.Drawing.Point(588, 0);
            this.lbllogo1.Name = "lbllogo1";
            this.lbllogo1.Size = new System.Drawing.Size(242, 44);
            this.lbllogo1.TabIndex = 0;
            this.lbllogo1.Text = "MEDIATEK48";
            this.lbllogo1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbllogo1.Click += new System.EventHandler(this.lbllogo1_Click);
            // 
            // lbllogo2
            // 
            this.lbllogo2.AutoSize = true;
            this.lbllogo2.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogo2.Location = new System.Drawing.Point(517, 44);
            this.lbllogo2.Name = "lbllogo2";
            this.lbllogo2.Size = new System.Drawing.Size(430, 44);
            this.lbllogo2.TabIndex = 1;
            this.lbllogo2.Text = "Gestion Administrative";
            this.lbllogo2.Click += new System.EventHandler(this.lbllogo2_Click);
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogin.Location = new System.Drawing.Point(181, 163);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(53, 21);
            this.lbllogin.TabIndex = 2;
            this.lbllogin.Text = "Login";
            // 
            // labelmdp
            // 
            this.labelmdp.AutoSize = true;
            this.labelmdp.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmdp.Location = new System.Drawing.Point(154, 287);
            this.labelmdp.Name = "labelmdp";
            this.labelmdp.Size = new System.Drawing.Size(125, 21);
            this.labelmdp.TabIndex = 3;
            this.labelmdp.Text = "Mot de Passe";
            this.labelmdp.Click += new System.EventHandler(this.labelmdp_Click);
            // 
            // txtlogin
            // 
            this.txtlogin.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlogin.Location = new System.Drawing.Point(85, 205);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(261, 23);
            this.txtlogin.TabIndex = 4;
            this.txtlogin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtmotdepasse
            // 
            this.txtmotdepasse.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmotdepasse.Location = new System.Drawing.Point(85, 342);
            this.txtmotdepasse.Name = "txtmotdepasse";
            this.txtmotdepasse.Size = new System.Drawing.Size(261, 23);
            this.txtmotdepasse.TabIndex = 5;
            this.txtmotdepasse.ModifiedChanged += new System.EventHandler(this.txtmotdepasse_ModifiedChanged);
            // 
            // btnConnexion
            // 
            this.btnConnexion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnexion.Location = new System.Drawing.Point(146, 412);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(144, 37);
            this.btnConnexion.TabIndex = 6;
            this.btnConnexion.Text = "Se Connecter";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.Btn_Connection_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.lbllogo2);
            this.panel1.Controls.Add(this.lbllogo1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1491, 97);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnConnexion);
            this.panel2.Controls.Add(this.txtmotdepasse);
            this.panel2.Controls.Add(this.txtlogin);
            this.panel2.Controls.Add(this.labelmdp);
            this.panel2.Controls.Add(this.lbllogin);
            this.panel2.Location = new System.Drawing.Point(501, 248);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(436, 535);
            this.panel2.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(146, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(609, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Authentification";
            // 
            // FrmAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1482, 1055);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAuthentification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mediatek - Gestion du Personnel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

