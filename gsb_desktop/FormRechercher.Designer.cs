namespace gsb_desktop
{
    partial class FormRechercher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRechercher));
            this.lbNom = new System.Windows.Forms.Label();
            this.lbLabo = new System.Windows.Forms.Label();
            this.lbSecteur = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.cbLabo = new System.Windows.Forms.ComboBox();
            this.cbSecteur = new System.Windows.Forms.ComboBox();
            this.lbInfo = new System.Windows.Forms.Label();
            this.btRechercher = new System.Windows.Forms.Button();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.lbErreur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Location = new System.Drawing.Point(155, 109);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(104, 37);
            this.lbNom.TabIndex = 0;
            this.lbNom.Text = "Nom :";
            // 
            // lbLabo
            // 
            this.lbLabo.AutoSize = true;
            this.lbLabo.Location = new System.Drawing.Point(155, 185);
            this.lbLabo.Name = "lbLabo";
            this.lbLabo.Size = new System.Drawing.Size(198, 37);
            this.lbLabo.TabIndex = 1;
            this.lbLabo.Text = "Laboratoire :";
            // 
            // lbSecteur
            // 
            this.lbSecteur.AutoSize = true;
            this.lbSecteur.Location = new System.Drawing.Point(155, 261);
            this.lbSecteur.Name = "lbSecteur";
            this.lbSecteur.Size = new System.Drawing.Size(144, 37);
            this.lbSecteur.TabIndex = 2;
            this.lbSecteur.Text = "Secteur :";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(507, 106);
            this.tbNom.MaximumSize = new System.Drawing.Size(496, 45);
            this.tbNom.MinimumSize = new System.Drawing.Size(496, 45);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(496, 44);
            this.tbNom.TabIndex = 3;
            this.tbNom.Text = "Saisir un nom";
            this.tbNom.Enter += new System.EventHandler(this.tbNom_Enter);
            this.tbNom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNom_KeyDown);
            this.tbNom.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbNom_KeyUp);
            this.tbNom.Leave += new System.EventHandler(this.tbNom_Leave);
            // 
            // cbLabo
            // 
            this.cbLabo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLabo.FormattingEnabled = true;
            this.cbLabo.Location = new System.Drawing.Point(507, 182);
            this.cbLabo.Name = "cbLabo";
            this.cbLabo.Size = new System.Drawing.Size(496, 45);
            this.cbLabo.TabIndex = 4;
            this.cbLabo.SelectedIndexChanged += new System.EventHandler(this.cbLabo_SelectedIndexChanged);
            // 
            // cbSecteur
            // 
            this.cbSecteur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSecteur.FormattingEnabled = true;
            this.cbSecteur.Location = new System.Drawing.Point(507, 258);
            this.cbSecteur.Name = "cbSecteur";
            this.cbSecteur.Size = new System.Drawing.Size(496, 45);
            this.cbSecteur.TabIndex = 5;
            this.cbSecteur.SelectedIndexChanged += new System.EventHandler(this.cbSecteur_SelectedIndexChanged);
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.Location = new System.Drawing.Point(101, 496);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(937, 32);
            this.lbInfo.TabIndex = 6;
            this.lbInfo.Text = "Si aucun paramètre n\'est saisi, la liste de tous les visiteurs sera retournée";
            // 
            // btRechercher
            // 
            this.btRechercher.Location = new System.Drawing.Point(338, 402);
            this.btRechercher.Name = "btRechercher";
            this.btRechercher.Size = new System.Drawing.Size(230, 70);
            this.btRechercher.TabIndex = 7;
            this.btRechercher.Text = "Rechercher";
            this.btRechercher.UseVisualStyleBackColor = true;
            this.btRechercher.Click += new System.EventHandler(this.btRechercher_Click);
            // 
            // btAnnuler
            // 
            this.btAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAnnuler.Location = new System.Drawing.Point(623, 402);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(230, 70);
            this.btAnnuler.TabIndex = 8;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // lbErreur
            // 
            this.lbErreur.AutoSize = true;
            this.lbErreur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErreur.ForeColor = System.Drawing.Color.Blue;
            this.lbErreur.Location = new System.Drawing.Point(440, 330);
            this.lbErreur.Name = "lbErreur";
            this.lbErreur.Size = new System.Drawing.Size(297, 46);
            this.lbErreur.TabIndex = 9;
            this.lbErreur.Text = "Aucun résultat !";
            this.lbErreur.Visible = false;
            // 
            // FormRechercher
            // 
            this.AcceptButton = this.btRechercher;
            this.AutoScaleDimensions = new System.Drawing.SizeF(288F, 288F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.btAnnuler;
            this.ClientSize = new System.Drawing.Size(1185, 527);
            this.Controls.Add(this.lbErreur);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btRechercher);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.cbSecteur);
            this.Controls.Add(this.cbLabo);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lbSecteur);
            this.Controls.Add(this.lbLabo);
            this.Controls.Add(this.lbNom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1221, 630);
            this.MinimumSize = new System.Drawing.Size(1221, 630);
            this.Name = "FormRechercher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rechercher visiteur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Label lbLabo;
        private System.Windows.Forms.Label lbSecteur;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.ComboBox cbLabo;
        private System.Windows.Forms.ComboBox cbSecteur;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Button btRechercher;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.Label lbErreur;
    }
}