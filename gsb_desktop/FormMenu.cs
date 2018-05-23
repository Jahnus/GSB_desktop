using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsb_desktop
{
    public partial class FormMenu : Form
    {
        private ModelGSB BD;
        public FormMenu()
        {
            InitializeComponent();
            BD = new ModelGSB();
        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {            
            string appelant = e.CloseReason.ToString();
            if (appelant == "UserClosing")
            {
                e.Cancel = true;
                Application.Exit();
            }
            else if (MessageBox.Show("Etes-vous sûr(e) de vouloir quitter ?", "Demande de confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void connexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Connexion = new FormConnexion(this);
            Connexion.ShowDialog();
        }

        public void connecte(string role)
        {
            if (role == "A")
            {
                visiteurToolStripMenuItem.Visible = true;
            }
            lbBienvenue.Visible = true;
            deconnexionToolStripMenuItem.Visible = true;
            connexionToolStripMenuItem.Visible = false;
        }

        private void deconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbBienvenue.Visible = false;
            deconnexionToolStripMenuItem.Visible = false;
            connexionToolStripMenuItem.Visible = true;
            visiteurToolStripMenuItem.Visible = false;
        }

        private void rechercherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form RechercheVisiteur = new FormRechercher(BD);
            RechercheVisiteur.ShowDialog();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form detailsVisiteur = new FormVisiteur(BD);
            detailsVisiteur.Text = "Ajout d'un visiteur";
            detailsVisiteur.ShowDialog();
        }
    }
}
