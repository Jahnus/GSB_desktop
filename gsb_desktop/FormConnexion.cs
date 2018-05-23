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
    public partial class FormConnexion : Form
    {
        private FormMenu LeFormMenu;
        public FormConnexion(FormMenu formMenu)
        {
            InitializeComponent();
            LeFormMenu = formMenu;
        }

        private void tbMdp_Enter(object sender, EventArgs e)
        {
            if (tbMdp.Text == "Entrer mot de passe")
            {
                tbMdp.Text = "";
                tbMdp.PasswordChar = '*';
            }            
        }

        private void tbMdp_Leave(object sender, EventArgs e)
        {
            if (tbMdp.Text == "")
            {
                tbMdp.PasswordChar = '\0';
                tbMdp.Text = "Entrer mot de passe";
                btValiderConnexion.Enabled = false;
            }
            if (lbErreurConnexion.Text == "Mot de passe incorrect !")
            {
                lbErreurConnexion.Visible = false;
            }
        }

        private void tbLogin_Enter(object sender, EventArgs e)
        {
            if (tbLogin.Text == "Entrer login")
            {
                tbLogin.Text = "";
            }
        }

        private void tbLogin_Leave(object sender, EventArgs e)
        {
            if (tbLogin.Text == "")
            {
                tbLogin.Text = "Entrer login";
                btValiderConnexion.Enabled = false;
            }
            if (lbErreurConnexion.Text == "Login inconnu !")
            {
                lbErreurConnexion.Visible = false;
            }
        }
                
        private void tbLogin_TextChanged(object sender, EventArgs e)
        {
            if (tbLogin.Text != "" && tbMdp.PasswordChar == '*')
            {
                btValiderConnexion.Enabled = true;
            }
            else if (tbLogin.Text == "")
            {
                btValiderConnexion.Enabled = false;
            }
        }

        private void tbMdp_TextChanged(object sender, EventArgs e)
        {
            if (tbMdp.Text != "" && tbLogin.Text != "Entrer login")
            {
                btValiderConnexion.Enabled = true;
            }
            else if (tbMdp.Text == "")
            {
                btValiderConnexion.Enabled = false;
            }
        }

        private void btAnnulerConnexion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btValiderConnexion_Click(object sender, EventArgs e)
        {
            string login = tbLogin.Text;
            string mdp = tbMdp.Text;
            bool verif = false;
            bool logVerif = false;
            
            using (ModelGSB BD = new ModelGSB())
            {
                var req = from visiteur in BD.visiteur
                          where visiteur.login_visiteur == login
                          select visiteur;

                if (req.LongCount() == 0)
                {
                    lbErreurConnexion.Text = "Login inconnu !";
                } 
                else
                {
                    logVerif = true;
                    foreach (visiteur unVisiteur in req)
                    {
                        if (unVisiteur.pwd_visiteur == mdp)
                        {
                            verif = true;
                            this.Close();
                            LeFormMenu.connecte(unVisiteur.type_visiteur);
                        }
                        lbErreurConnexion.Text = "Mot de passe incorrect !";
                    }
                }
                if (!verif)
                {
                    if (logVerif)
                    {
                        tbMdp.Text = "";
                        tbMdp.Select();                        
                    } 
                    else
                    {
                        tbLogin.Text = "";
                        tbLogin.Select();
                        tbMdp.PasswordChar = '\0';
                        tbMdp.Text = "Entrer mot de passe";
                    }
                    lbErreurConnexion.Visible = true;
                    btValiderConnexion.Enabled = false;
                }
            }
        }

        private void tbLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (lbErreurConnexion.Text == "Login inconnu !")
            {
                lbErreurConnexion.Visible = false;
            }
        }

        private void tbMdp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (lbErreurConnexion.Text == "Mot de passe incorrect !")
            {
                lbErreurConnexion.Visible = false;
            }
        }

        
    }
}
