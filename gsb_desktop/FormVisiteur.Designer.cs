namespace gsb_desktop
{
    partial class FormVisiteur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVisiteur));
            this.lbNom = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.lbAdresse = new System.Windows.Forms.Label();
            this.tbAdresse = new System.Windows.Forms.TextBox();
            this.lbPrenom = new System.Windows.Forms.Label();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.lbCp = new System.Windows.Forms.Label();
            this.tbCp = new System.Windows.Forms.TextBox();
            this.lbVille = new System.Windows.Forms.Label();
            this.tbVille = new System.Windows.Forms.TextBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lbLogin = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lbMdp = new System.Windows.Forms.Label();
            this.tbMdp = new System.Windows.Forms.TextBox();
            this.Lblabo = new System.Windows.Forms.Label();
            this.cbLabo = new System.Windows.Forms.ComboBox();
            this.lbSecteur = new System.Windows.Forms.Label();
            this.cbSecteur = new System.Windows.Forms.ComboBox();
            this.btValider = new System.Windows.Forms.Button();
            this.btRetour = new System.Windows.Forms.Button();
            this.btSupp = new System.Windows.Forms.Button();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.lbInfoLogin = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Location = new System.Drawing.Point(48, 45);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(116, 37);
            this.lbNom.TabIndex = 0;
            this.lbNom.Text = "Nom* :";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(360, 42);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(339, 44);
            this.tbNom.TabIndex = 1;
            this.tbNom.Text = "Saisir un nom";
            this.tbNom.Enter += new System.EventHandler(this.tbNom_Enter);
            this.tbNom.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbNom_KeyUp);
            this.tbNom.Leave += new System.EventHandler(this.tbNom_Leave);
            // 
            // lbAdresse
            // 
            this.lbAdresse.AutoSize = true;
            this.lbAdresse.Location = new System.Drawing.Point(48, 125);
            this.lbAdresse.Name = "lbAdresse";
            this.lbAdresse.Size = new System.Drawing.Size(152, 37);
            this.lbAdresse.TabIndex = 2;
            this.lbAdresse.Text = "Adresse :";
            // 
            // tbAdresse
            // 
            this.tbAdresse.Location = new System.Drawing.Point(360, 122);
            this.tbAdresse.Name = "tbAdresse";
            this.tbAdresse.Size = new System.Drawing.Size(877, 44);
            this.tbAdresse.TabIndex = 5;
            this.tbAdresse.Text = "Saisir une adresse (N° + rue)";
            this.tbAdresse.Enter += new System.EventHandler(this.tbAdresse_Enter);
            this.tbAdresse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAdresse_KeyDown);
            this.tbAdresse.Leave += new System.EventHandler(this.tbAdresse_Leave);
            // 
            // lbPrenom
            // 
            this.lbPrenom.AutoSize = true;
            this.lbPrenom.Location = new System.Drawing.Point(745, 45);
            this.lbPrenom.Name = "lbPrenom";
            this.lbPrenom.Size = new System.Drawing.Size(147, 37);
            this.lbPrenom.TabIndex = 4;
            this.lbPrenom.Text = "Prénom :";
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(898, 42);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(339, 44);
            this.tbPrenom.TabIndex = 3;
            this.tbPrenom.Text = "Saisir un prénom";
            this.tbPrenom.Enter += new System.EventHandler(this.tbPrenom_Enter);
            this.tbPrenom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPrenom_KeyDown);
            this.tbPrenom.Leave += new System.EventHandler(this.tbPrenom_Leave);
            // 
            // lbCp
            // 
            this.lbCp.AutoSize = true;
            this.lbCp.Location = new System.Drawing.Point(48, 205);
            this.lbCp.Name = "lbCp";
            this.lbCp.Size = new System.Drawing.Size(206, 37);
            this.lbCp.TabIndex = 6;
            this.lbCp.Text = "Code postal :";
            // 
            // tbCp
            // 
            this.tbCp.Location = new System.Drawing.Point(360, 202);
            this.tbCp.MaxLength = 5;
            this.tbCp.Name = "tbCp";
            this.tbCp.Size = new System.Drawing.Size(119, 44);
            this.tbCp.TabIndex = 7;
            this.tbCp.Text = "CP";
            this.tbCp.Enter += new System.EventHandler(this.tbCp_Enter);
            this.tbCp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCp_KeyDown);
            this.tbCp.Leave += new System.EventHandler(this.tbCp_Leave);
            // 
            // lbVille
            // 
            this.lbVille.AutoSize = true;
            this.lbVille.Location = new System.Drawing.Point(745, 205);
            this.lbVille.Name = "lbVille";
            this.lbVille.Size = new System.Drawing.Size(95, 37);
            this.lbVille.TabIndex = 8;
            this.lbVille.Text = "Ville :";
            // 
            // tbVille
            // 
            this.tbVille.Location = new System.Drawing.Point(857, 202);
            this.tbVille.Name = "tbVille";
            this.tbVille.Size = new System.Drawing.Size(380, 44);
            this.tbVille.TabIndex = 9;
            this.tbVille.Text = "Saisir une ville";
            this.tbVille.Enter += new System.EventHandler(this.tbVille_Enter);
            this.tbVille.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbVille_KeyDown);
            this.tbVille.Leave += new System.EventHandler(this.tbVille_Leave);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(48, 285);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(285, 37);
            this.lbDate.TabIndex = 10;
            this.lbDate.Text = "Date d\'embauche :";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(360, 279);
            this.dtpDate.MaxDate = new System.DateTime(2018, 1, 18, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(250, 44);
            this.dtpDate.TabIndex = 11;
            this.dtpDate.Value = new System.DateTime(2018, 1, 18, 0, 0, 0, 0);
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(48, 445);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(126, 37);
            this.lbLogin.TabIndex = 12;
            this.lbLogin.Text = "Login* :";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(360, 442);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(352, 44);
            this.tbLogin.TabIndex = 17;
            this.tbLogin.Text = "Saisir un login";
            this.tbLogin.Enter += new System.EventHandler(this.tbLogin_Enter);
            this.tbLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbLogin_KeyDown);
            this.tbLogin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbLogin_KeyUp);
            this.tbLogin.Leave += new System.EventHandler(this.tbLogin_Leave);
            // 
            // lbMdp
            // 
            this.lbMdp.AutoSize = true;
            this.lbMdp.Location = new System.Drawing.Point(48, 525);
            this.lbMdp.Name = "lbMdp";
            this.lbMdp.Size = new System.Drawing.Size(238, 37);
            this.lbMdp.TabIndex = 14;
            this.lbMdp.Text = "Mot de passe* :";
            // 
            // tbMdp
            // 
            this.tbMdp.Location = new System.Drawing.Point(360, 522);
            this.tbMdp.Name = "tbMdp";
            this.tbMdp.Size = new System.Drawing.Size(352, 44);
            this.tbMdp.TabIndex = 19;
            this.tbMdp.Text = "Saisir un mot de passe";
            this.tbMdp.Enter += new System.EventHandler(this.tbMdp_Enter);
            this.tbMdp.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbMdp_KeyUp);
            this.tbMdp.Leave += new System.EventHandler(this.tbMdp_Leave);
            // 
            // Lblabo
            // 
            this.Lblabo.AutoSize = true;
            this.Lblabo.Location = new System.Drawing.Point(48, 365);
            this.Lblabo.Name = "Lblabo";
            this.Lblabo.Size = new System.Drawing.Size(198, 37);
            this.Lblabo.TabIndex = 16;
            this.Lblabo.Text = "Laboratoire :";
            // 
            // cbLabo
            // 
            this.cbLabo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLabo.FormattingEnabled = true;
            this.cbLabo.Location = new System.Drawing.Point(360, 362);
            this.cbLabo.Name = "cbLabo";
            this.cbLabo.Size = new System.Drawing.Size(250, 45);
            this.cbLabo.TabIndex = 13;
            this.cbLabo.SelectedIndexChanged += new System.EventHandler(this.cbLabo_SelectedIndexChanged);
            // 
            // lbSecteur
            // 
            this.lbSecteur.AutoSize = true;
            this.lbSecteur.Location = new System.Drawing.Point(745, 365);
            this.lbSecteur.Name = "lbSecteur";
            this.lbSecteur.Size = new System.Drawing.Size(144, 37);
            this.lbSecteur.TabIndex = 18;
            this.lbSecteur.Text = "Secteur :";
            // 
            // cbSecteur
            // 
            this.cbSecteur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSecteur.FormattingEnabled = true;
            this.cbSecteur.Location = new System.Drawing.Point(987, 362);
            this.cbSecteur.Name = "cbSecteur";
            this.cbSecteur.Size = new System.Drawing.Size(250, 45);
            this.cbSecteur.TabIndex = 15;
            this.cbSecteur.SelectedIndexChanged += new System.EventHandler(this.cbSecteur_SelectedIndexChanged);
            // 
            // btValider
            // 
            this.btValider.Enabled = false;
            this.btValider.Location = new System.Drawing.Point(113, 738);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(220, 70);
            this.btValider.TabIndex = 20;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // btRetour
            // 
            this.btRetour.Location = new System.Drawing.Point(672, 738);
            this.btRetour.Name = "btRetour";
            this.btRetour.Size = new System.Drawing.Size(220, 70);
            this.btRetour.TabIndex = 21;
            this.btRetour.Text = "Retour liste";
            this.btRetour.UseVisualStyleBackColor = true;
            this.btRetour.Visible = false;
            this.btRetour.Click += new System.EventHandler(this.btRetour_Click);
            // 
            // btSupp
            // 
            this.btSupp.Location = new System.Drawing.Point(390, 738);
            this.btSupp.Name = "btSupp";
            this.btSupp.Size = new System.Drawing.Size(220, 70);
            this.btSupp.TabIndex = 22;
            this.btSupp.Text = "Supprimer";
            this.btSupp.UseVisualStyleBackColor = true;
            this.btSupp.Visible = false;
            this.btSupp.Click += new System.EventHandler(this.btSupp_Click);
            // 
            // btAnnuler
            // 
            this.btAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAnnuler.Location = new System.Drawing.Point(953, 738);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(220, 70);
            this.btAnnuler.TabIndex = 23;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            // 
            // lbInfoLogin
            // 
            this.lbInfoLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInfoLogin.AutoSize = true;
            this.lbInfoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfoLogin.Location = new System.Drawing.Point(510, 617);
            this.lbInfoLogin.Name = "lbInfoLogin";
            this.lbInfoLogin.Size = new System.Drawing.Size(305, 40);
            this.lbInfoLogin.TabIndex = 24;
            this.lbInfoLogin.Text = "Login déjà utilisé !";
            this.lbInfoLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbInfoLogin.Visible = false;
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.Location = new System.Drawing.Point(523, 676);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(275, 40);
            this.lbInfo.TabIndex = 25;
            this.lbInfo.Text = "* champs requis";
            // 
            // FormVisiteur
            // 
            this.AcceptButton = this.btValider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(288F, 288F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.CancelButton = this.btAnnuler;
            this.ClientSize = new System.Drawing.Size(1308, 870);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.lbInfoLogin);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btSupp);
            this.Controls.Add(this.btRetour);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.cbSecteur);
            this.Controls.Add(this.lbSecteur);
            this.Controls.Add(this.cbLabo);
            this.Controls.Add(this.Lblabo);
            this.Controls.Add(this.tbMdp);
            this.Controls.Add(this.lbMdp);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.tbVille);
            this.Controls.Add(this.lbVille);
            this.Controls.Add(this.tbCp);
            this.Controls.Add(this.lbCp);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.lbPrenom);
            this.Controls.Add(this.tbAdresse);
            this.Controls.Add(this.lbAdresse);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lbNom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVisiteur";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label lbAdresse;
        private System.Windows.Forms.TextBox tbAdresse;
        private System.Windows.Forms.Label lbPrenom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.Label lbCp;
        private System.Windows.Forms.TextBox tbCp;
        private System.Windows.Forms.Label lbVille;
        private System.Windows.Forms.TextBox tbVille;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lbMdp;
        private System.Windows.Forms.TextBox tbMdp;
        private System.Windows.Forms.Label Lblabo;
        private System.Windows.Forms.ComboBox cbLabo;
        private System.Windows.Forms.Label lbSecteur;
        private System.Windows.Forms.ComboBox cbSecteur;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Button btRetour;
        private System.Windows.Forms.Button btSupp;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.Label lbInfoLogin;
        private System.Windows.Forms.Label lbInfo;
    }
}