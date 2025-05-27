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
        public DateTime DateDebut { get; }
        /// <summary>
        /// Attributs DateFin de la table Absence
        /// </summary>
        public DateTime DateFin { get; }
        /// <summary>
        /// Attributs idMotif de la table Absence
        /// </summary>
        public int IdMotif { get; }

        /// <summary>
        /// Valorise les propriétés
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
            IdMotif = idmotif;
        }
    }
}
