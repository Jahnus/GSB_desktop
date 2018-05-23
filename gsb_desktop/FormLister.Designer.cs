namespace gsb_desktop
{
    partial class FormLister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLister));
            this.lbSelection = new System.Windows.Forms.Label();
            this.btValider = new System.Windows.Forms.Button();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.lvListeVisiteurs = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lbSelection
            // 
            this.lbSelection.AutoSize = true;
            this.lbSelection.Location = new System.Drawing.Point(12, 20);
            this.lbSelection.Name = "lbSelection";
            this.lbSelection.Size = new System.Drawing.Size(627, 37);
            this.lbSelection.TabIndex = 1;
            this.lbSelection.Text = "Sélectionner un visiteur pour plus d\'options";
            // 
            // btValider
            // 
            this.btValider.Enabled = false;
            this.btValider.Location = new System.Drawing.Point(457, 632);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(170, 70);
            this.btValider.TabIndex = 2;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // btAnnuler
            // 
            this.btAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAnnuler.Location = new System.Drawing.Point(719, 632);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(170, 70);
            this.btAnnuler.TabIndex = 4;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // lvListeVisiteurs
            // 
            this.lvListeVisiteurs.FullRowSelect = true;
            this.lvListeVisiteurs.GridLines = true;
            this.lvListeVisiteurs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvListeVisiteurs.Location = new System.Drawing.Point(12, 79);
            this.lvListeVisiteurs.MaximumSize = new System.Drawing.Size(1286, 522);
            this.lvListeVisiteurs.MinimumSize = new System.Drawing.Size(1286, 522);
            this.lvListeVisiteurs.MultiSelect = false;
            this.lvListeVisiteurs.Name = "lvListeVisiteurs";
            this.lvListeVisiteurs.Size = new System.Drawing.Size(1286, 522);
            this.lvListeVisiteurs.TabIndex = 5;
            this.lvListeVisiteurs.UseCompatibleStateImageBehavior = false;
            this.lvListeVisiteurs.View = System.Windows.Forms.View.Details;
            this.lvListeVisiteurs.SelectedIndexChanged += new System.EventHandler(this.lvListeVisiteurs_SelectedIndexChanged);
            this.lvListeVisiteurs.DoubleClick += new System.EventHandler(this.lvListeVisiteurs_DoubleClick);
            // 
            // FormLister
            // 
            this.AcceptButton = this.btValider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(288F, 288F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.CancelButton = this.btAnnuler;
            this.ClientSize = new System.Drawing.Size(1314, 727);
            this.Controls.Add(this.lvListeVisiteurs);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.lbSelection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1350, 830);
            this.MinimumSize = new System.Drawing.Size(1350, 830);
            this.Name = "FormLister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste visiteur(s)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSelection;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.ListView lvListeVisiteurs;
    }
}