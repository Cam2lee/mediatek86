using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek86.modele
{
    /// <summary>
    /// Classe métier de Service
    /// </summary>
    public class Service
    {
        /// <summary>
        /// Attributs idService de la table service
        /// </summary>
        public int IdService { get; }
        /// <summary>
        /// Attributs Nom de la table service
        /// </summary>
        public string Nom { get; }

        /// <summary>
        /// Valorise les propriétés 
        /// </summary>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        public Service(int idservice, string nom)
        {
            this.IdService = idservice;
            this.Nom = nom;
        }

        /// <summary>
        /// Retourne le nom du service
        /// </summary>
        /// <returns>Le nom du service</returns>
        public override string ToString()
        {
            return this.Nom;
        }
    }
}
