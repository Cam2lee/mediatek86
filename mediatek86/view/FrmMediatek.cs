using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mediatek86.controller;
using mediatek86.modele;

namespace mediatek86.view
{
    /// <summary>
    /// Fenêtre princpal (liste du personnel, avec options de modifier/ajouter et supprimer)
    /// </summary>
    public partial class FrmMediatek : Form
    {
        /// <summary>
        /// Booléen pour savoir si une modification est demandée
        /// </summary>
        private Boolean enCoursDeModifPersonnel = false;
        /// <summary>
        /// Objet pour gérer la liste des personnel
        /// </summary>
        private readonly BindingSource bdgPersonnel = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des services
        /// </summary>
        private readonly BindingSource bdgService = new BindingSource();
        /// <summary>
        /// /// Controleur de la fenêtre
        /// </summary>
        private FrmMediatekController controller;
        /// <summary>
        /// Titre des fenêtres d'information
        /// </summary>
        private readonly String titreFenetreInformation = "Information";
        /// <summary>
        /// Conrtuction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FrmMediatek()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialisations :
        /// Création du controleur et remplissage des listes
        /// </summary>
        private void Init()
        {
            controller = new FrmMediatekController();
            RemplirListePersonnel();
            RemplirListeService();
            EnCourseModifPersonnel(false);
        }

        /// <summary>
        /// Affiche le personnel
        /// </summary>
        private void RemplirListePersonnel()
        {
            List<Personnel> lesPersonnel = controller.GetLesPersonnel();
            bdgPersonnel.DataSource = lesPersonnel;
            dgvPersonnel.DataSource = bdgPersonnel;
            dgvPersonnel.Columns["idpersonnel"].Visible = false;
            dgvPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Affiche les services
        /// </summary>
        private void RemplirListeService()
        {
            List<Service> lesService = controller.GetLesService();
            bdgService.DataSource = lesService;
            comboBoxService.DataSource = bdgService;
        }

        /// <summary>
        ///  Demande de modification d'un membre du personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                EnCourseModifPersonnel(true);
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                textNom.Text = personnel.Nom;
                textPrenom.Text = personnel.Prenom;
                textTel.Text = personnel.Tel;
                textMail.Text = personnel.Mail;
                comboBoxService.SelectedIndex = comboBoxService.FindStringExact(personnel.Service.Nom);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", titreFenetreInformation);
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + personnel.Nom + " " + personnel.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelPersonnel(personnel);
                    RemplirListePersonnel();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", titreFenetreInformation);
            }
        }

        /// <summary>
        /// Demande d'enregistrement de l'ajout ou de la modification d'un membre du personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {
            if (!textNom.Text.Equals("") && !textPrenom.Text.Equals("") && !textTel.Text.Equals("") && !textMail.Text.Equals("") && comboBoxService.SelectedIndex != -1)
            {
                Service service = (Service)bdgService.List[bdgService.Position];
                if (enCoursDeModifPersonnel)
                {
                    Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                    personnel.Nom = textNom.Text;
                    personnel.Prenom = textPrenom.Text;
                    personnel.Tel = textTel.Text;
                    personnel.Mail = textMail.Text;
                    personnel.Service = service;
                    controller.UpdatePersonnel(personnel);
                }
                else
                {
                    Personnel personnel = new Personnel(0, textNom.Text, textPrenom.Text, textTel.Text, textMail.Text, service);
                    controller.AddPersonnel(personnel);
                }
                RemplirListePersonnel();
                EnCourseModifPersonnel(false);
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", titreFenetreInformation);
            }
        }

        /// <summary>
        /// Annule la demande d'ajout ou de modification d'un membre du personnel
        /// Vide les zones de saisie du membre du personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCourseModifPersonnel(false);
            }
        }

        private void EnCourseModifPersonnel(Boolean modif)
        {
            enCoursDeModifPersonnel = modif;
            groupBoxPersonnel.Enabled = !modif;
            if (modif)
            {
                groupBoxAjouter.Text = "modifier un membre";
            }
            else
            {
                groupBoxAjouter.Text = "ajouter un membre";
                textNom.Text = "";
                textPrenom.Text = "";
                textTel.Text = "";
                textMail.Text = "";
            }
        }
    }
}
