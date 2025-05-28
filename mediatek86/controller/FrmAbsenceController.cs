using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mediatek86.dal;
using mediatek86.modele;

namespace mediatek86.controller
{
    /// <summary>
    /// Contrôleur pour la gestion des absences
    /// </summary>
    public class FrmAbsenceController
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur Absence
        /// </summary>
        private readonly AbsenceAccess absenceAccess;

        /// <summary>
        /// Récupère l'accès aux données
        /// </summary>
        public FrmAbsenceController()
        {
            absenceAccess = new AbsenceAccess();
        }

        /// <summary>
        /// Récupère et retourne les absences d'un personnel
        /// </summary>
        /// <param name="idPersonnel">ID du personnel</param>
        /// <returns>liste des absences du personnel</returns>
        public List<Absence> GetAbsencesByPersonnel(int idPersonnel)
        {
            return absenceAccess.GetAbsencesByPersonnel(idPersonnel);
        }

        /// <summary>
        /// Récupère et retourne tous les motifs
        /// </summary>
        /// <returns>liste des motifs</returns>
        public List<Motif> GetLesMotifs()
        {
            return absenceAccess.GetLesMotifs();
        }

        /// <summary>
        /// Demande d'ajout d'une absence
        /// </summary>
        /// <param name="absence">objet absence à ajouter</param>
        public void AddAbsence(Absence absence)
        {
            absenceAccess.AddAbsence(absence);
        }

        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="absence">objet absence à modifier</param>
        /// <param name="ancienneDateDebut">ancienne date de début</param>
        public void UpdateAbsence(Absence absence, DateTime ancienneDateDebut)
        {
            absenceAccess.UpdateAbsence(absence, ancienneDateDebut);
        }

        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="absence">objet absence à supprimer</param>
        public void DelAbsence(Absence absence)
        {
            absenceAccess.DelAbsence(absence);
        }
    }
}
