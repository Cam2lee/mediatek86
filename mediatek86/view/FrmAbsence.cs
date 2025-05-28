using mediatek86.controller;
using mediatek86.modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace mediatek86.view
{
    /// <summary>
    /// Fenêtre des absences
    /// </summary>
    public partial class FrmAbsence : Form
    {
        /// <summary>
        /// Personnel dont on affiche les absences
        /// </summary>
        private Personnel personnelSelectionne;

        /// <summary>
        /// Absence en cours de modification
        /// </summary>
        private Absence absenceEnModification = null;

        /// <summary>
        /// Date de début originale pour la modification
        /// </summary>
        private DateTime dateDebutOriginale;

        /// <summary>
        /// Objet pour gérer la liste des absences
        /// </summary>
        private readonly BindingSource bdgAbsences = new BindingSource();

        /// <summary>
        /// Objet pour gérer la liste des motifs
        /// </summary>
        private readonly BindingSource bdgMotifs = new BindingSource();

        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmAbsenceController controller;

        /// <summary>
        /// Titre des fenêtres d'information
        /// </summary>
        private readonly String titreFenetreInformation = "Avertissement";


        /// <summary>
        /// Conrtuction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FrmAbsence(Personnel personnel)
        {
            InitializeComponent();
            this.FormClosing += FrmAbsence_FormClosing;

            personnelSelectionne = personnel;
            Init();

            EnCoursDeModifAbsence(false);
        }

        /// <summary>
        /// Initialisations
        /// </summary>
        private void Init()
        {
            controller = new FrmAbsenceController();
            groupBoxAbsences.Text = $"Absences de {personnelSelectionne.Prenom} {personnelSelectionne.Nom}";
            RemplirListeAbsences();
            RemplirListeMotifs();
        }

        /// <summary>
        /// Affiche les absences du personnel
        /// </summary>
        private void RemplirListeAbsences()
        {
            List<Absence> lesAbsences = controller.GetAbsencesByPersonnel(personnelSelectionne.Idpersonnel);
            bdgAbsences.DataSource = lesAbsences;
            dataGridViewAbsence.DataSource = bdgAbsences;

            if (dataGridViewAbsence.Columns.Count > 0)
            {
                dataGridViewAbsence.Columns["IdPersonnel"].Visible = false;
                dataGridViewAbsence.Columns["DateDebut"].HeaderText = "Date début";
                dataGridViewAbsence.Columns["DateDebut"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridViewAbsence.Columns["DateFin"].Visible = false;
                dataGridViewAbsence.Columns["DateFinAffichage"].HeaderText = "Date fin";
                dataGridViewAbsence.Columns["Motif"].Visible = false;
                dataGridViewAbsence.Columns["MotifLibelle"].HeaderText = "Motif";
            }

            dataGridViewAbsence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            if (dataGridViewAbsence.Rows.Count > 0)
            {
                dataGridViewAbsence.Rows[0].Selected = true;
            }
        }

        /// <summary>
        /// Affiche les motifs
        /// </summary>
        private void RemplirListeMotifs()
        {
            List<Motif> lesMotifs = controller.GetLesMotifs();
            bdgMotifs.DataSource = lesMotifs;
            comboBoxMotif.DataSource = bdgMotifs;
            comboBoxMotif.DisplayMember = "Libelle";
            comboBoxMotif.ValueMember = "IdMotif";
        }

        /// <summary>
        /// Gestion du mode modification/ajout
        /// </summary>
        /// <param name="modif">true si en mode modification</param>
        private void EnCoursDeModifAbsence(Boolean modif)
        {
            if (modif)
            {
                groupBoxAjouterAbs.Text =
                    (absenceEnModification == null) ? "Ajouter une absence" : "Modifier une absence";
            }
            else
            {
                groupBoxAjouterAbs.Text = "Ajouter une absence";
                ViderChamps();
                absenceEnModification = null;
            }
            
        }
        

        /// <summary>
        /// Vide les champs de saisie
        /// </summary>
        private void ViderChamps()
        {
            dateTimePickerDebut.Value = DateTime.Now;
            dateTimePickerFin.Value = DateTime.Now;
            comboBoxMotif.SelectedIndex = -1;
        }

        /// <summary>
        /// Bouton pour ajouter une nouvelle absence
        /// </summary>
        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            EnCoursDeModifAbsence(true);
            ViderChamps();
        }

        /// <summary>
        /// Bouton pour modifier une absence existante
        /// </summary>
        private void buttonModifierAbsences_Click(object sender, EventArgs e)
        {
            if (dataGridViewAbsence.SelectedRows.Count > 0)
            {
                EnCoursDeModifAbsence(true);

                absenceEnModification = (Absence)bdgAbsences.Current;

                dateDebutOriginale = absenceEnModification.DateDebut;

                dateTimePickerDebut.Value = absenceEnModification.DateDebut;
                dateTimePickerFin.Value = absenceEnModification.DateFin != DateTime.MinValue
                    ? absenceEnModification.DateFin
                    : DateTime.Now;
                comboBoxMotif.SelectedValue = absenceEnModification.Motif.IdMotif;
            }
            EnCoursDeModifAbsence(true);
        }

        /// <summary>
        /// Bouton pour supprimer une absence
        /// </summary>
        private void buttonSupprimerAbsences_Click(object sender, EventArgs e)
        {
            if (dataGridViewAbsence.SelectedRows.Count > 0)
            {
                Absence absenceASupprimer = (Absence)bdgAbsences.Current;

                if (MessageBox.Show("Voulez-vous vraiment supprimer cette absence ?",
                    "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        controller.DelAbsence(absenceASupprimer);

                        RemplirListeAbsences();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erreur lors de la suppression : {ex.Message}",
                            titreFenetreInformation);
                    }
                }
            }
        }

        /// <summary>
        /// Bouton pour enregistrer une nouvelle absence ou modifier une existante
        /// </summary>
        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {
            {
                {
                    if (dateTimePickerFin.Value < dateTimePickerDebut.Value)
                    {
                        MessageBox.Show("La date de fin ne peut pas être antérieure à la date de début.",
                                        titreFenetreInformation);
                        return;
                    }

                    DateTime? dateDebutExclue = null;
                    DateTime? dateFinExclue = null;
                    Motif motifExclu = null;

                    if (absenceEnModification != null)
                    {
                        dateDebutExclue = dateDebutOriginale;
                        dateFinExclue = absenceEnModification.DateFin;
                        motifExclu = absenceEnModification.Motif;
                    }

                    if (VerifierChevauchementAbsences(dateDebutExclue, dateFinExclue, motifExclu))
                    {
                        MessageBox.Show("Une absence se chevauche avec une autre absence existante.", titreFenetreInformation);
                        return;
                    }


                    if (comboBoxMotif.SelectedIndex == -1)
                    {
                        MessageBox.Show("Veuillez sélectionner un motif.", titreFenetreInformation);
                        return;
                    }

                    string messageConfirmation = (absenceEnModification == null)
                        ? "Voulez-vous vraiment ajouter cette absence ?"
                        : "Voulez-vous enregistrer cette absence ?";

                    DialogResult confirmation = MessageBox.Show(
                        messageConfirmation,
                        "Confirmation",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (confirmation == DialogResult.Yes)
                    {
                        Motif motifSelectionne = (Motif)comboBoxMotif.SelectedItem;

                        if (absenceEnModification == null)
                        {
                            Absence nouvelleAbsence = new Absence(
                                personnelSelectionne.Idpersonnel,
                                dateTimePickerDebut.Value,
                                dateTimePickerFin.Value,
                                motifSelectionne
                            );

                            controller.AddAbsence(nouvelleAbsence);
                        }
                        else
                        {
                            absenceEnModification.DateDebut = dateTimePickerDebut.Value;
                            absenceEnModification.DateFin = dateTimePickerFin.Value;
                            absenceEnModification.Motif = motifSelectionne;

                            controller.UpdateAbsence(absenceEnModification, dateDebutOriginale);
                        }

                        RemplirListeAbsences();
                        EnCoursDeModifAbsence(false);
                    }
                }
            }
        }
        /// <summary>
        /// Bouton Annuler
        /// </summary>
        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCoursDeModifAbsence(false);
            }
        }

        /// <summary>
        /// Vérifie s'il existe des absences qui se chevauchent
        /// </summary>
        private bool VerifierChevauchementAbsences(DateTime? dateDebutExclue = null, DateTime? dateFinExclue = null, Motif motifExclu = null)
        {
            List<Absence> absences = controller.GetAbsencesByPersonnel(personnelSelectionne.Idpersonnel);
            DateTime nouveauDebut = dateTimePickerDebut.Value;
            DateTime nouvelleFin = dateTimePickerFin.Value;

            foreach (var a in absences)
            {
                // Affiche les infos pour débogage
                Console.WriteLine($"Test absence : Début={a.DateDebut}, Fin={a.DateFin}, Motif={a.Motif.Libelle}");

                // Exclusion complète sur 3 critères (date début, date fin, motif)
                bool estExclusion = false;
                if (dateDebutExclue != null && dateFinExclue != null && motifExclu != null)
                {
                    estExclusion = a.DateDebut == dateDebutExclue && a.DateFin == dateFinExclue && a.Motif.Libelle == motifExclu.Libelle;
                    if (estExclusion)
                        Console.WriteLine("==> Absence exclue du test (modification en cours)");
                }

                if (estExclusion)
                    continue;

                // Test chevauchement
                bool chevauche =
                    (nouveauDebut >= a.DateDebut && nouveauDebut <= a.DateFin) ||
                    (nouvelleFin >= a.DateDebut && nouvelleFin <= a.DateFin) ||
                    (nouveauDebut <= a.DateDebut && nouvelleFin >= a.DateFin);

                if (chevauche)
                {
                    Console.WriteLine("==> Chevauchement détecté !");
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Demande une confirmation avant de fermer la fenêtre
        /// </summary>
        private void FrmAbsence_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Voulez-vous vraiment fermer cette fenêtre ?",
                "Confirmation de fermeture",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }

}

