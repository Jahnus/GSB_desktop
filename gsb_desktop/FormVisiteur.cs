using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsb_desktop
{
    public partial class FormVisiteur : Form
    {
        private ModelGSB BD;
        private List<visiteur> retourRes;
        private visiteur leVisiteur;
        public FormVisiteur(ModelGSB p_bd, visiteur v, List<visiteur> resultats)
        {
            InitializeComponent();
            BD = p_bd;
            initCbs();
            retourRes = resultats;
            leVisiteur = v;
            btValider.Location = new Point(55, 245);
            btSupp.Location = new Point(140, 245);
            btSupp.Visible = true;
            btRetour.Location = new Point(225, 245);
            btRetour.Visible = true;
            btAnnuler.Location = new Point(310, 245);         
            remplirForm(v);
        }

        public FormVisiteur(ModelGSB p_bd, visiteur v)
        {
            InitializeComponent();
            BD = p_bd;
            initCbs();
            leVisiteur = v;
            btValider.Location = new Point(98, 245);
            btSupp.Location = new Point(183, 245);
            btSupp.Visible = true;
            btAnnuler.Location = new Point(268, 245);
            remplirForm(v);
        }

        public FormVisiteur(ModelGSB p_bd, List<visiteur> resultats)
        {
            InitializeComponent();
            BD = p_bd;
            initCbs();
            retourRes = resultats;
            btValider.Location = new Point(98, 245);
            btValider.Text = "Ajouter";
            btRetour.Location = new Point(183, 245);
            btRetour.Visible = true;
            btAnnuler.Location = new Point(268, 245);
            dtpDate.MaxDate = System.DateTime.Now.Date;
            dtpDate.Value = System.DateTime.Now.Date;
        }

        public FormVisiteur(ModelGSB p_bd)
        {
            InitializeComponent();
            BD = p_bd;
            initCbs();
            btValider.Location = new Point(140, 245);
            btValider.Text = "Ajouter";
            btAnnuler.Location = new Point(225, 245);
            dtpDate.MaxDate = System.DateTime.Now.Date;
            dtpDate.Value = System.DateTime.Now.Date;
        }

        private void initCbs()
        {
            var reqLabo = from laboratoire in BD.laboratoire
                          select laboratoire;
            cbLabo.DisplayMember = "NomLabo";
            cbLabo.ValueMember = "IdLabo";
            cbLabo.Items.Add(new unLabo() { NomLabo = "Sélectionner", IdLabo = 0 });
            foreach (laboratoire labo in reqLabo)
            {
                cbLabo.Items.Add(new unLabo() { NomLabo = labo.nom_laboratoire, IdLabo = labo.id_laboratoire });
            }
            cbLabo.SelectedIndex = 0;

            var reqSecteur = from secteur in BD.secteur
                             select secteur;
            cbSecteur.DisplayMember = "LibSecteur";
            cbSecteur.ValueMember = "IdSecteur";
            cbSecteur.Items.Add(new unSecteur() { LibSecteur = "Sélectionner", IdSecteur = 0 });
            foreach (secteur sect in reqSecteur)
            {
                cbSecteur.Items.Add(new unSecteur() { LibSecteur = sect.lib_secteur, IdSecteur = sect.id_secteur });
            }
            cbSecteur.SelectedIndex = 0;
        }

        private void remplirForm(visiteur v)
        {
            tbNom.Text = v.nom_visiteur;
            tbPrenom.Text = v.prenom_visiteur;
            if (v.adresse_visiteur != null && v.adresse_visiteur != "") { tbAdresse.Text = v.adresse_visiteur; }
            if (v.cp_visiteur != null && v.cp_visiteur != "     " && v.cp_visiteur != "") { tbCp.Text = v.cp_visiteur; }
            if (v.ville_visiteur != null && v.ville_visiteur != "") { tbVille.Text = v.ville_visiteur; }
            dtpDate.MaxDate = System.DateTime.Now.Date;
            dtpDate.Value = v.date_embauche.GetValueOrDefault();
            if (v.id_laboratoire != null) { cbLabo.SelectedIndex = v.id_laboratoire.Value; }
            if (v.id_secteur != null) { cbSecteur.SelectedIndex = v.id_secteur.Value; }
            if (v.login_visiteur != null && v.login_visiteur != "") { tbLogin.Text = v.login_visiteur; }
            if (v.pwd_visiteur != null && v.pwd_visiteur != "") { tbMdp.Text = v.pwd_visiteur; }
        }

        public class unLabo
        {
            public string NomLabo { get; set; }
            public int IdLabo { get; set; }
        }

        public class unSecteur
        {
            public string LibSecteur { get; set; }
            public int IdSecteur { get; set; }
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            if (btValider.Text == "Ajouter")
            {
                prepAjoutVisiteur();
            } 
            else
            {
                prepModifVisiteur();
            }
        }

        private void btSupp_Click(object sender, EventArgs e)
        {            
            if (MessageBox.Show("Etes-vous sûr(e) de vouloir supprimer ce visiteur ?", "Demande de confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var suppTrav = from travailler in BD.travailler
                               where travailler.id_visiteur == leVisiteur.id_visiteur
                               select travailler;
                foreach (travailler trav in suppTrav)
                {
                    BD.travailler.Remove(trav);
                }
                var suppVis = from visiteur in BD.visiteur
                              where visiteur.id_visiteur == leVisiteur.id_visiteur
                              select visiteur;
                foreach (visiteur v in suppVis)
                {
                    BD.visiteur.Remove(v);                    
                    if (retourRes != null && retourRes.LongCount() > 0)
                    {
                        int index = 0;
                        bool verif = false;
                        foreach (visiteur unVisi in retourRes)
                        {
                            if (unVisi.id_visiteur == v.id_visiteur)
                            {
                                verif = true;
                                break;
                            }
                            index++;
                        }
                        if (verif)
                        {
                            retourRes.RemoveAt(index);
                        }                        
                    }
                }
                bool flag = false;
                try
                {
                    BD.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Le visiteur n'a pas pu être supprimé !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    flag = true;
                }
                if (!flag)
                {
                    if (retourRes == null || retourRes.LongCount() == 0)
                    {
                        MessageBox.Show("Le visiteur a bien été supprimé, vous pouvez en créer un nouveau.", "Confirmation de suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(nouveauFormAjout));
                        monthread.Start();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Le visiteur a bien été supprimé, vous pouvez en créer un nouveau ou retourner à la liste de recherche.", "Confirmation de suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(nouveauFormAjoutList));
                        monthread.Start();
                        this.Close();
                    }
                }                
            }
        }

        private void btRetour_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(lister));
            monthread.Start();
            this.Close();
        }

        private void lister()
        {
            Form listResultat = new FormLister(BD, retourRes);
            listResultat.ShowDialog();
        }

        private void nouveauFormAjout()
        {
            Form visit = new FormVisiteur(BD);
            visit.Text = "Ajout d'un visiteur";
            visit.ShowDialog();            
        }

        private void nouveauFormAjoutList()
        {
            Form visit = new FormVisiteur(BD, retourRes);
            visit.Text = "Ajout d'un visiteur";
            visit.ShowDialog();
        }

        private void prepAjoutVisiteur()
        {
            var verifLogin = from visiteur in BD.visiteur
                             where visiteur.login_visiteur == tbLogin.Text
                             select visiteur;
            if (verifLogin.LongCount() != 0)
            {
                lbInfoLogin.Visible = true;
                tbLogin.Text = "";
                tbLogin.Focus();
            } else
            {
                ajoutVisiteur();
            }            
        }

        private void ajoutVisiteur()
        {
            visiteur nouveauVisiteur = new visiteur();
            nouveauVisiteur.id_visiteur = 0;
            nouveauVisiteur.nom_visiteur = tbNom.Text;
            if (tbPrenom.Text != "Saisir un prénom") { nouveauVisiteur.prenom_visiteur = tbPrenom.Text; }
            if (tbAdresse.Text != "Saisir une adresse (N° + rue)") { nouveauVisiteur.adresse_visiteur = tbAdresse.Text; }
            if (tbCp.Text != "CP") { nouveauVisiteur.cp_visiteur = tbCp.Text; }
            if (tbVille.Text != "Saisir une ville") { nouveauVisiteur.ville_visiteur = tbVille.Text; }
            DateTime dateEmb = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day);
            nouveauVisiteur.date_embauche = dateEmb;
            if (cbLabo.SelectedIndex != 0) { nouveauVisiteur.id_laboratoire = cbLabo.SelectedIndex; }
            if (cbSecteur.SelectedIndex != 0) { nouveauVisiteur.id_secteur = cbSecteur.SelectedIndex; }
            nouveauVisiteur.login_visiteur = tbLogin.Text;
            nouveauVisiteur.pwd_visiteur = tbMdp.Text;
            nouveauVisiteur.type_visiteur = "V";
            BD.visiteur.Add(nouveauVisiteur);
            bool flag = false;
            try
            {
                BD.SaveChanges();
            }
            catch 
            {
                MessageBox.Show("Le visiteur n'a pas pu être créé !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                flag = true;
            }
            leVisiteur = nouveauVisiteur;
            if (!flag)
            {
                if (retourRes != null && retourRes.LongCount() > 0)
                {
                    MessageBox.Show("Le visiteur a bien été ajouté, vous pouvez maintenant le modifier.", "Confirmation d'ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(nouveauFormModifList));
                    monthread.Start();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Le visiteur a bien été ajouté, vous pouvez maintenant le modifier.", "Confirmation d'ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(nouveauFormModif));
                    monthread.Start();
                    this.Close();
                }
            }            
        }

        private void nouveauFormModif()
        {
            Form visit = new FormVisiteur(BD, leVisiteur);
            visit.Text = "Modification/Suppression d'un visiteur";
            visit.ShowDialog();            
        }

        private void nouveauFormModifList()
        {
            Form visit = new FormVisiteur(BD, leVisiteur, retourRes);
            visit.Text = "Modification/Suppression d'un visiteur";
            visit.ShowDialog();            
        }

        private void prepModifVisiteur()
        {
            if (leVisiteur.login_visiteur != tbLogin.Text)
            {
                var verifLogin = from visiteur in BD.visiteur
                                 where visiteur.login_visiteur == tbLogin.Text
                                 select visiteur;
                if (verifLogin.LongCount() != 0)
                {
                    lbInfoLogin.Visible = true;
                    tbLogin.Text = "";
                    tbLogin.Focus();
                }
                else
                {
                    modifVisiteur();
                }
            }
            else
            {
                modifVisiteur();
            }            
        }

        private void modifVisiteur()
        {

            using (ModelGSB bdd = new ModelGSB())
            {
                visiteur visi = (from visiteur in bdd.visiteur
                                 where visiteur.id_visiteur == leVisiteur.id_visiteur
                                 select visiteur).FirstOrDefault();

                visi.nom_visiteur = tbNom.Text;
                if (visi.prenom_visiteur != tbPrenom.Text) { if (tbPrenom.Text == "Saisir un prénom") { visi.prenom_visiteur = null; } else { visi.prenom_visiteur = tbPrenom.Text; } }
                if (visi.adresse_visiteur != tbAdresse.Text) { if (tbAdresse.Text == "Saisir une adresse (N° + rue)") { visi.adresse_visiteur = null; } else { visi.adresse_visiteur = tbAdresse.Text; } }
                if (visi.cp_visiteur != tbCp.Text) { if (tbCp.Text == "CP") { visi.cp_visiteur = null; } else { visi.cp_visiteur = tbCp.Text; } }
                if (visi.ville_visiteur != tbVille.Text) { if (tbVille.Text == "Saisir une ville") { visi.ville_visiteur = null; } else { visi.ville_visiteur = tbVille.Text; } }
                DateTime dateEmb = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day);
                if (visi.date_embauche != dateEmb) { visi.date_embauche = dateEmb; }
                if (visi.id_laboratoire != cbLabo.SelectedIndex) { if (cbLabo.SelectedIndex == 0) { visi.id_laboratoire = null; } else { visi.id_laboratoire = cbLabo.SelectedIndex; } }
                if (visi.id_secteur != cbSecteur.SelectedIndex) { if (cbSecteur.SelectedIndex == 0) { visi.id_secteur = null; } else { visi.id_secteur = cbSecteur.SelectedIndex; } }
                leVisiteur = visi;
                if (retourRes != null && retourRes.LongCount() > 0)
                {
                    int index = 0;
                    bool verif = false;
                    foreach (visiteur unVisi in retourRes)
                    {
                        if (unVisi.id_visiteur == visi.id_visiteur)
                        {
                            verif = true;
                            break;
                        }
                        index++;
                    }
                    if (verif)
                    {
                        retourRes.RemoveAt(index);
                        retourRes.Add(visi);
                        retourRes.Sort(delegate(visiteur vis1, visiteur vis2) { return string.Compare(vis1.nom_visiteur, vis2.nom_visiteur); });
                    }
                }
                bool flag = false;
                try
                {
                    bdd.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("La modification n'a pas pu être enregistrée !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    flag = true;
                }
                if (!flag)
                {
                    if (retourRes != null && retourRes.LongCount() > 0)
                    {
                        MessageBox.Show("Le visiteur a bien été modifié !", "Confirmation de modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(nouveauFormModifList));
                        monthread.Start();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Le visiteur a bien été modifié !", "Confirmation de modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(nouveauFormModif));
                        monthread.Start();
                        this.Close();
                    }
                }
            }            
        }

        private void tbLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (lbInfoLogin.Visible == true)
            {
                lbInfoLogin.Visible = false;
            }                        
        }

        private void tbNom_Enter(object sender, EventArgs e)
        {
            if (tbNom.Text == "Saisir un nom")
            {
                tbNom.Text = "";
            }
        }

        private void tbNom_Leave(object sender, EventArgs e)
        {
            if (tbNom.Text == "")
            {
                tbNom.Text = "Saisir un nom";
            }
        }

        private void tbPrenom_Enter(object sender, EventArgs e)
        {
            if (tbPrenom.Text == "Saisir un prénom")
            {
                tbPrenom.Text = "";
            }
        }

        private void tbPrenom_Leave(object sender, EventArgs e)
        {
            if (tbPrenom.Text == "")
            {
                tbPrenom.Text = "Saisir un prénom";
            }
        }

        private void tbAdresse_Enter(object sender, EventArgs e)
        {
            if (tbAdresse.Text == "Saisir une adresse (N° + rue)")
            {
                tbAdresse.Text = "";
            }
        }

        private void tbAdresse_Leave(object sender, EventArgs e)
        {
            if (tbAdresse.Text == "")
            {
                tbAdresse.Text = "Saisir une adresse (N° + rue)";
            }
        }

        private void tbCp_Enter(object sender, EventArgs e)
        {
            if (tbCp.Text == "CP")
            {
                tbCp.Text = "";
            }
        }

        private void tbCp_Leave(object sender, EventArgs e)
        {
            if (tbCp.Text == "")
            {
                tbCp.Text = "CP";
            }
        }

        private void tbVille_Enter(object sender, EventArgs e)
        {
            if (tbVille.Text == "Saisir une ville")
            {
                tbVille.Text = "";
            }
        }

        private void tbVille_Leave(object sender, EventArgs e)
        {
            if (tbVille.Text == "")
            {
                tbVille.Text = "Saisir une ville";
            }
        }

        private void tbLogin_Enter(object sender, EventArgs e)
        {
            if (tbLogin.Text == "Saisir un login")
            {
                tbLogin.Text = "";
            }
        }

        private void tbLogin_Leave(object sender, EventArgs e)
        {
            if (tbLogin.Text == "")
            {
                tbLogin.Text = "Saisir un login";
            }
        }

        private void tbMdp_Enter(object sender, EventArgs e)
        {
            if (tbMdp.Text == "Saisir un mot de passe")
            {
                tbMdp.Text = "";
            }
        }

        private void tbMdp_Leave(object sender, EventArgs e)
        {
            if (tbMdp.Text == "")
            {
                tbMdp.Text = "Saisir un mot de passe";
            }
        }

        private void tbNom_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbLogin.Text != "Saisir un login" && tbNom.Text != "" && tbMdp.Text != "Saisir un mot de passe")
            {
                btValider.Enabled = true;
            }
            else
            {
                btValider.Enabled = false;
            }
        }

        private void tbLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbLogin.Text != "" && tbNom.Text != "Saisir un nom" && tbMdp.Text != "Saisir un mot de passe")
            {
                btValider.Enabled = true;
            }
            else
            {
                btValider.Enabled = false;
            }
        }

        private void tbMdp_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbLogin.Text != "Saisir un login" && tbNom.Text != "Saisir un nom" && tbMdp.Text != "")
            {
                btValider.Enabled = true;
            }
            else
            {
                btValider.Enabled = false;
            }
        }

        private void tbPrenom_KeyDown(object sender, KeyEventArgs e)
        {
            if (btValider.Text == "Valider" && tbLogin.Text != "Saisir un login" && tbNom.Text != "Saisir un nom" && tbMdp.Text != "Saisir un mot de passe")
            {
                btValider.Enabled = true;
            }
        }

        private void tbAdresse_KeyDown(object sender, KeyEventArgs e)
        {
            if (btValider.Text == "Valider" && tbLogin.Text != "Saisir un login" && tbNom.Text != "Saisir un nom" && tbMdp.Text != "Saisir un mot de passe")
            {
                btValider.Enabled = true;
            }
        }

        private void tbCp_KeyDown(object sender, KeyEventArgs e)
        {
            if (btValider.Text == "Valider" && tbLogin.Text != "Saisir un login" && tbNom.Text != "Saisir un nom" && tbMdp.Text != "Saisir un mot de passe")
            {
                btValider.Enabled = true;
            }
        }

        private void tbVille_KeyDown(object sender, KeyEventArgs e)
        {
            if (btValider.Text == "Valider" && tbLogin.Text != "Saisir un login" && tbNom.Text != "Saisir un nom" && tbMdp.Text != "Saisir un mot de passe")
            {
                btValider.Enabled = true;
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            if (btValider.Text == "Valider" && tbLogin.Text != "Saisir un login" && tbNom.Text != "Saisir un nom" && tbMdp.Text != "Saisir un mot de passe")
            {
                btValider.Enabled = true;
            }
        }

        private void cbLabo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btValider.Text == "Valider" && tbLogin.Text != "Saisir un login" && tbNom.Text != "Saisir un nom" && tbMdp.Text != "Saisir un mot de passe")
            {
                btValider.Enabled = true;
            }
        }

        private void cbSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btValider.Text == "Valider" && tbLogin.Text != "Saisir un login" && tbNom.Text != "Saisir un nom" && tbMdp.Text != "Saisir un mot de passe")
            {
                btValider.Enabled = true;
            }
        }        
    }
}
