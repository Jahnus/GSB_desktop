namespace gsb_desktop
{
    partial class FormConnexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConnexion));
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbMdp = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbMdp = new System.Windows.Forms.TextBox();
            this.btValiderConnexion = new System.Windows.Forms.Button();
            this.btAnnulerConnexion = new System.Windows.Forms.Button();
            this.lbErreurConnexion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(137, 100);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(114, 37);
            this.lbLogin.TabIndex = 0;
            this.lbLogin.Text = "Login :";
            // 
            // lbMdp
            // 
            this.lbMdp.AutoSize = true;
            this.lbMdp.Location = new System.Drawing.Point(137, 185);
            this.lbMdp.Name = "lbMdp";
            this.lbMdp.Size = new System.Drawing.Size(226, 37);
            this.lbMdp.TabIndex = 1;
            this.lbMdp.Text = "Mot de passe :";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(487, 97);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(332, 44);
            this.tbLogin.TabIndex = 2;
            this.tbLogin.Text = "Entrer login";
            this.tbLogin.TextChanged += new System.EventHandler(this.tbLogin_TextChanged);
            this.tbLogin.Enter += new System.EventHandler(this.tbLogin_Enter);
            this.tbLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLogin_KeyPress);
            this.tbLogin.Leave += new System.EventHandler(this.tbLogin_Leave);
            // 
            // tbMdp
            // 
            this.tbMdp.Location = new System.Drawing.Point(487, 182);
            this.tbMdp.Name = "tbMdp";
            this.tbMdp.Size = new System.Drawing.Size(332, 44);
            this.tbMdp.TabIndex = 3;
            this.tbMdp.Text = "Entrer mot de passe";
            this.tbMdp.TextChanged += new System.EventHandler(this.tbMdp_TextChanged);
            this.tbMdp.Enter += new System.EventHandler(this.tbMdp_Enter);
            this.tbMdp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMdp_KeyPress);
            this.tbMdp.Leave += new System.EventHandler(this.tbMdp_Leave);
            // 
            // btValiderConnexion
            // 
            this.btValiderConnexion.Enabled = false;
            this.btValiderConnexion.Location = new System.Drawing.Point(244, 370);
            this.btValiderConnexion.Name = "btValiderConnexion";
            this.btValiderConnexion.Size = new System.Drawing.Size(200, 70);
            this.btValiderConnexion.TabIndex = 4;
            this.btValiderConnexion.Text = "Valider";
            this.btValiderConnexion.UseVisualStyleBackColor = true;
            this.btValiderConnexion.Click += new System.EventHandler(this.btValiderConnexion_Click);
            // 
            // btAnnulerConnexion
            // 
            this.btAnnulerConnexion.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAnnulerConnexion.Location = new System.Drawing.Point(529, 370);
            this.btAnnulerConnexion.Name = "btAnnulerConnexion";
            this.btAnnulerConnexion.Size = new System.Drawing.Size(200, 70);
            this.btAnnulerConnexion.TabIndex = 5;
            this.btAnnulerConnexion.Text = "Annuler";
            this.btAnnulerConnexion.UseVisualStyleBackColor = true;
            this.btAnnulerConnexion.Click += new System.EventHandler(this.btAnnulerConnexion_Click);
            // 
            // lbErreurConnexion
            // 
            this.lbErreurConnexion.AutoSize = true;
            this.lbErreurConnexion.ForeColor = System.Drawing.Color.Blue;
            this.lbErreurConnexion.Location = new System.Drawing.Point(237, 266);
            this.lbErreurConnexion.Name = "lbErreurConnexion";
            this.lbErreurConnexion.Size = new System.Drawing.Size(0, 37);
            this.lbErreurConnexion.TabIndex = 6;
            this.lbErreurConnexion.Visible = false;
            // 
            // FormConnexion
            // 
            this.AcceptButton = this.btValiderConnexion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(288F, 288F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.CancelButton = this.btAnnulerConnexion;
            this.ClientSize = new System.Drawing.Size(962, 463);
            this.Controls.Add(this.lbErreurConnexion);
            this.Controls.Add(this.btAnnulerConnexion);
            this.Controls.Add(this.btValiderConnexion);
            this.Controls.Add(this.tbMdp);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lbMdp);
            this.Controls.Add(this.lbLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(998, 566);
            this.MinimumSize = new System.Drawing.Size(998, 566);
            this.Name = "FormConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbMdp;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbMdp;
        private System.Windows.Forms.Button btValiderConnexion;
        private System.Windows.Forms.Button btAnnulerConnexion;
        private System.Windows.Forms.Label lbErreurConnexion;
    }
}