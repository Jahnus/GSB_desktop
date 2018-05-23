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
    public partial class FormLister : Form
    {
        private ModelGSB BD;
        private List<int> listIds;
        private List<visiteur> resultats;
        private visiteur leVisiteur;
        public FormLister(ModelGSB p_bd, List<visiteur> resultat)
        {
            InitializeComponent();
            resultats = resultat;
            BD = p_bd;
            CreateHeadersAndFillListView();
            PaintListView(resultat);            
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateHeadersAndFillListView()
        {            
            lvListeVisiteurs.Columns.Add("Nom", -2, HorizontalAlignment.Left);
            lvListeVisiteurs.Columns.Add("Prénom", -2, HorizontalAlignment.Left);
            lvListeVisiteurs.Columns.Add("Ville", -2, HorizontalAlignment.Left);
            lvListeVisiteurs.Columns.Add("Laboratoire", -2, HorizontalAlignment.Left);
            lvListeVisiteurs.Columns.Add("Secteur", -2, HorizontalAlignment.Left);
        }

        private void PaintListView(List<visiteur> result)
        {
            try
            {
                ListViewItem lvi;
                listIds = new List<int>();

                lvListeVisiteurs.Items.Clear();

                lvListeVisiteurs.BeginUpdate();

                foreach (visiteur v in result)
                {
                    listIds.Add(v.id_visiteur);
                    var nomLabo = from laboratoire in BD.laboratoire
                                  where laboratoire.id_laboratoire == v.id_laboratoire
                                  select laboratoire;
                    string strNom = "";
                    foreach (laboratoire lab in nomLabo)
                    {
                        strNom = lab.nom_laboratoire;                        
                    }
                    var libSecteur = from secteur in BD.secteur
                                     where secteur.id_secteur == v.id_secteur
                                     select secteur;
                    string strLib = "";
                    foreach (secteur sec in libSecteur)
                    {
                        strLib = sec.lib_secteur;
                    }
                    lvi = new ListViewItem(v.nom_visiteur);
                    lvi.Tag = v.id_visiteur;
                    lvi.SubItems.Add(v.prenom_visiteur);
                    lvi.SubItems.Add(v.ville_visiteur);
                    lvi.SubItems.Add(strNom);
                    lvi.SubItems.Add(strLib);
                    lvListeVisiteurs.Items.Add(lvi);
                }                
                lvListeVisiteurs.EndUpdate();
            }
            catch (System.Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
            }

            lvListeVisiteurs.View = View.Details;
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            rechercher();
        }

        private void lvListeVisiteurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            btValider.Enabled = true;
        }

        private void lvListeVisiteurs_DoubleClick(object sender, EventArgs e)
        {
            rechercher();         
        }

        private void rechercher()
        {
            var donnee = lvListeVisiteurs.SelectedIndices;
            foreach (int index in donnee)
            {
                int i = listIds[index];
                var req = from visiteur in BD.visiteur
                          where visiteur.id_visiteur == i
                          select visiteur;
                foreach (visiteur v in req)
                {
                    leVisiteur = v;
                    System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(details));
                    monthread.Start();
                    this.Close();
                }
            }
        }

        private void details()
        {
            Form detailsVisiteur = new FormVisiteur(BD, leVisiteur, resultats);
            detailsVisiteur.Text = "Modification/Suppression d'un visiteur";
            detailsVisiteur.ShowDialog();
        }
    }
}
