using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek86.modele
{
    /// <summary>
    /// Classe métier de Personnel
    /// </summary>
    public class Personnel
    {
        /// <summary>
        /// Attributs idPersonnel de la table Personnel
        /// </summary>
        public int IdPersonnel { get; }
        /// <summary>
        /// Attributs Nom de la table Personnel
        /// </summary>
        public string Nom { get; }
        /// <summary>
        /// Attributs Prenom de la table Personnel
        /// </summary>
        public string Prenom { get; }
        /// <summary>
        /// Attributs Tel de la table Personnel
        /// </summary>
        public string Tel { get; }
        /// <summary>
        /// Attributs Mail de la table Personnel
        /// </summary>
        public string Mail { get; }
        /// <summary>
        /// Attributs idService de la table Personnel
        /// </summary>
        public int IdService { get; }

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="idservice"></param>
        public Personnel(int idpersonnel, string nom, string prenom, string tel, string mail, int idservice)
        {
            IdPersonnel = idpersonnel;
            Nom = nom;
            Prenom = prenom;
            Tel = tel;
            Mail = mail;
            IdService = idservice;
        }
    }
}
