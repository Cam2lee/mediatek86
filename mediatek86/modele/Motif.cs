using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek86.modele
{
    /// <summary>
    /// Classe métier de Motif
    /// </summary>
    public class Motif
    {
        /// <summary>
        /// Attributs idMotif de la table Motif
        /// </summary>
        public int IdMotif { get; }
        /// <summary>
        /// Attributs Libelle de la table Motif
        /// </summary>
        public string Libelle { get; }

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idmotif"></param>
        /// <param name="libelle"></param>
        public Motif(int idmotif, string libelle)
        {
            IdMotif = idmotif;
            Libelle = libelle;
        }
    }
}
