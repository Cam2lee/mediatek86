using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek86.modele
{
    /// <summary>
    /// Classe métier de Responsable
    /// </summary>
    public class Responsable
    {
        /// <summary>
        /// Attributs Login de la table Responsable
        /// </summary>
        public string Login { get; }
        /// <summary>
        /// Attributs Pwd de la table Responsable
        /// </summary>
        public string Pwd { get; }

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        public Responsable(string login, string pwd)
        {
            this.Login = login;
            this.Pwd = pwd;
        }
    }
}
