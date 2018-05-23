using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace gsb_desktop
{
    public partial class FormRechercher : Form
    {
        AutoCompleteStringCollection coll = new AutoCompleteStringCollection(); 
        private ModelGSB BD;
        private List<visiteur> resultat;

        public FormRechercher(ModelGSB p_bd)
        {
            InitializeComponent();
            BD = p_bd;
            resultat = new List<visiteur>();
            auto();

            var reqLabo = from laboratoire in BD.laboratoire
                          select laboratoire;
            cbLabo.DisplayMember = "NomLabo";
            cbLabo.ValueMember = "IdLabo";
            cbLabo.Items.Add(new unLabo() { NomLabo = "Sélectionner un laboratoire", IdLabo = 0 });
            cbLabo.SelectedIndex = 0;
            foreach (laboratoire labo in reqLabo)
            {
                cbLabo.Items.Add(new unLabo() { NomLabo = labo.nom_laboratoire, IdLabo = labo.id_laboratoire });
            }

            var reqSecteur = from secteur in BD.secteur
                             select secteur;
            cbSecteur.DisplayMember = "LibSecteur";
            cbSecteur.ValueMember = "IdSecteur";
            cbSecteur.Items.Add(new unSecteur() { LibSecteur = "Sélectionner un secteur", IdSecteur = 0 });
            cbSecteur.SelectedIndex = 0;
            foreach (secteur sect in reqSecteur)
            {
                cbSecteur.Items.Add(new unSecteur() { LibSecteur = sect.lib_secteur, IdSecteur = sect.id_secteur });
            }
        }

        private void auto()
        {
            var req = from visiteur in BD.visiteur
                      where visiteur.type_visiteur == "V"
                      orderby visiteur.nom_visiteur
                      select visiteur.nom_visiteur;
            var listNoms = new string[req.LongCount()];
            var i = 0;
            foreach (string nom in req)
            {
                listNoms.SetValue(nom, i);
                i++;
            }
            coll.AddRange(listNoms);
            tbNom.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbNom.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbNom.AutoCompleteCustomSource = coll;
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void tbNom_KeyDown(object sender, KeyEventArgs e)
        {
            if (tbNom.Text != "")
            {
                lbInfo.Visible = false;
            }
            else if (cbLabo.SelectedIndex == 0 && cbSecteur.SelectedIndex == 0)
            {
                lbInfo.Visible = true;
            }
            if (lbErreur.Visible == true)
            {
                lbErreur.Visible = false;
            }
        }

        private void tbNom_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbNom.Text == "Saisir un nom")
            {
                tbNom.Text = "";
            }
            if (tbNom.Text != "")
            {
                lbInfo.Visible = false;
            }
            else if (cbLabo.SelectedIndex == 0 && cbSecteur.SelectedIndex == 0)
            {
                lbInfo.Visible = true;
            }
            if (lbErreur.Visible == true)
            {
                lbErreur.Visible = false;
            }
        }  

        private void cbLabo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLabo.SelectedIndex != 0)
            {
                lbInfo.Visible = false;
            }
            else if (tbNom.Text == "Saisir un nom" && cbSecteur.SelectedIndex == 0)
            {
                lbInfo.Visible = true;
            }
            if (lbErreur.Visible == true)
            {
                lbErreur.Visible = false;
            }
        }

        private void cbSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSecteur.SelectedIndex != 0)
            {
                lbInfo.Visible = false;
            }
            else if (tbNom.Text == "Saisir un nom" && cbLabo.SelectedIndex == 0)
            {
                lbInfo.Visible = true;
            }
            if (lbErreur.Visible == true)
            {
                lbErreur.Visible = false;
            }
        }

        private void btRechercher_Click(object sender, EventArgs e)
        {
            if ((tbNom.Text != "Saisir un nom" && tbNom.Text != "") && cbLabo.SelectedIndex != 0 && cbSecteur.SelectedIndex != 0)
            {
                rechNomLabSec();
            }
            else if ((tbNom.Text != "Saisir un nom" && tbNom.Text != "") && cbLabo.SelectedIndex != 0)
            {
                rechNomLab();
            }
            else if ((tbNom.Text != "Saisir un nom" && tbNom.Text != "") && cbSecteur.SelectedIndex != 0)
            {
                rechNomSec();
            }
            else if (cbLabo.SelectedIndex != 0 && cbSecteur.SelectedIndex != 0)
            {
                rechLabSec();
            }
            else if (tbNom.Text != "Saisir un nom" && tbNom.Text != "")
            {
                rechNom();
            }
            else if (cbLabo.SelectedIndex != 0)
            {
                rechLab();
            }
            else if (cbSecteur.SelectedIndex != 0)
            {
                rechSec();
            }
            else
            {
                tousVisiteurs();
            }
        }

        private void rechNomLabSec()
        {
            var req = from visiteur in BD.visiteur
                      where visiteur.type_visiteur == "V"
                      where visiteur.nom_visiteur == tbNom.Text
                      where visiteur.id_laboratoire == cbLabo.SelectedIndex
                      where visiteur.id_secteur == cbSecteur.SelectedIndex
                      orderby visiteur.nom_visiteur
                      select visiteur;
            if (req.LongCount() != 0)
            {
                foreach (visiteur v in req)
                {
                    resultat.Add(v);
                }
                System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(lister));
                monthread.Start();
                this.Close();
            }
            else
            {
                reinitialiser();
            }
        }

        private void rechNomLab()
        {
            var req = from visiteur in BD.visiteur
                      where visiteur.type_visiteur == "V"
                      where visiteur.nom_visiteur == tbNom.Text
                      where visiteur.id_laboratoire == cbLabo.SelectedIndex
                      orderby visiteur.nom_visiteur
                      select visiteur;
            if (req.LongCount() != 0)
            {
                foreach (visiteur v in req)
                {
                    resultat.Add(v);
                }
                System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(lister));
                monthread.Start();
                this.Close();
            }
            else
            {
                reinitialiser();
            }
        }

        private void rechNomSec()
        {
            var req = from visiteur in BD.visiteur
                      where visiteur.type_visiteur == "V"
                      where visiteur.nom_visiteur == tbNom.Text
                      where visiteur.id_secteur == cbSecteur.SelectedIndex
                      orderby visiteur.nom_visiteur
                      select visiteur;
            if (req.LongCount() != 0)
            {
                foreach (visiteur v in req)
                {
                    resultat.Add(v);
                }
                System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(lister));
                monthread.Start();
                this.Close();
            }
            else
            {
                reinitialiser();
            }
        }

        private void rechLabSec()
        {
            var req = from visiteur in BD.visiteur
                      where visiteur.type_visiteur == "V"
                      where visiteur.id_laboratoire == cbLabo.SelectedIndex
                      where visiteur.id_secteur == cbSecteur.SelectedIndex
                      orderby visiteur.nom_visiteur
                      select visiteur;
            if (req.LongCount() != 0)
            {
                foreach (visiteur v in req)
                {
                    resultat.Add(v);
                }
                System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(lister));
                monthread.Start();
                this.Close();
            }
            else
            {
                reinitialiser();
            }
        }

        private void rechNom()
        {            
            var req = from visiteur in BD.visiteur
                      where visiteur.type_visiteur == "V"
                      where visiteur.nom_visiteur == tbNom.Text
                      orderby visiteur.nom_visiteur
                      select visiteur;
            if (req.LongCount() != 0)
            {
                foreach (visiteur v in req)
                {
                    resultat.Add(v);
                }
                System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(lister));
                monthread.Start();
                this.Close();
            }
            else
            {
                reinitialiser();
            }
        }

        private void rechLab()
        {
            var req = from visiteur in BD.visiteur
                      where visiteur.type_visiteur == "V"
                      where visiteur.id_laboratoire == cbLabo.SelectedIndex
                      orderby visiteur.nom_visiteur
                      select visiteur;
            if (req.LongCount() != 0)
            {
                foreach (visiteur v in req)
                {
                    resultat.Add(v);
                }
                System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(lister));
                monthread.Start();
                this.Close();
            }
            else
            {
                reinitialiser();
            }
        }

        private void rechSec()
        {
            var req = from visiteur in BD.visiteur
                      where visiteur.type_visiteur == "V"
                      where visiteur.id_secteur == cbSecteur.SelectedIndex
                      orderby visiteur.nom_visiteur
                      select visiteur;
            if (req.LongCount() != 0)
            {
                foreach (visiteur v in req)
                {
                    resultat.Add(v);
                }
                System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(lister));
                monthread.Start();
                this.Close();
            }
            else
            {
                reinitialiser();
            }
        }

        private void tousVisiteurs()
        {
            var req = from visiteur in BD.visiteur
                      where visiteur.type_visiteur == "V"
                      orderby visiteur.nom_visiteur
                      select visiteur;
            if (req.LongCount() != 0)
            {                
                foreach (visiteur v in req)
                {
                    resultat.Add(v);                    
                }
                System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(lister));
                monthread.Start();
                this.Close();                
            }
            else
            {
                reinitialiser();
            }
        }

        private void reinitialiser()
        {
            tbNom.Text = "Saisir un nom";
            cbLabo.SelectedIndex = 0;
            cbSecteur.SelectedIndex = 0;
            lbErreur.Visible = true;
        }

        private void lister()
        {            
            Form listResultat = new FormLister(BD, resultat);
            listResultat.ShowDialog();            
        }
    }
}
