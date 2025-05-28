using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek86.modele
{
    /// <summary>
    /// Classe métier de absence
    /// </summary>
    public class Absence
    {
        /// <summary>
        /// Attributs idPersonnel de la table Absence
        /// </summary>
        public int IdPersonnel { get; }
        /// <summary>
        /// Attributs DateDebut de la table Absence
        /// </summary>
        public DateTime DateDebut { get; set; }
        /// <summary>
        /// Attributs DateFin de la table Absence
        /// </summary>
        public DateTime DateFin { get; set; }
        /// <summary>
        /// Objet Motif de l'absence
        /// </summary>
        public Motif Motif { get; set; }

        /// <summary>
        /// Constructeur avec idMotif (pour compatibilité)
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="idmotif"></param>
        public Absence(int idpersonnel, DateTime datedebut, DateTime datefin, int idmotif)
        {
            IdPersonnel = idpersonnel;
            DateDebut = datedebut;
            DateFin = datefin;
            Motif = new Motif(idmotif, ""); // Temporaire
        }

        /// <summary>
        /// Constructeur avec objet Motif
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="motif"></param>
        public Absence(int idpersonnel, DateTime datedebut, DateTime datefin, Motif motif)
        {
            IdPersonnel = idpersonnel;
            DateDebut = datedebut;
            DateFin = datefin;
            Motif = motif;
        }

        /// <summary>
        /// Propriété calculée pour l'affichage de la date de fin
        /// </summary>
        public string DateFinAffichage
        {
            get
            {
                return DateFin == DateTime.MinValue ? "En cours" : DateFin.ToString("dd/MM/yyyy");
            }
        }

        /// <summary>
        /// Propriété calculée pour l'affichage du motif
        /// </summary>
        public string MotifLibelle
        {
            get
            {
                return Motif?.Libelle ?? "";
            }
        }
    }
}