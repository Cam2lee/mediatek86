using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace mediatek86.bddmanager
{
    /// <summary>
    /// connexion à la base de données
    /// </summary>
    public class BddManager
    {
        /// <summary>
        ///  Instance unique de la classe
        /// </summary>
        private static BddManager instance = null;
        /// <summary>
        /// objet de connexion à la BDD à partir d'une chaine de connexion
        /// </summary>
        private readonly MySqlConnection connection;

        /// <summary>
        /// Création de la connexion à la BDD
        /// </summary>
        /// <param name="stringConnect">Chaine de connexion</param>
        private BddManager(string stringConnect)
        {
            connection = new MySqlConnection(stringConnect);
            connection.Open();
        }

        /// <summary>
        /// Création d'une instance de la classe
        /// </summary>
        /// <param name="stringConnect">Chaine de connexion</param>
        /// <returns></returns>
        public static BddManager GetInstance(string stringConnect)
        {
            if (instance == null)
            {
                instance = new BddManager(stringConnect);
            }
            return instance;
        }

        /// <summary>
        /// Exécution d'une requête de type LCT (begin transaction...)
        /// </summary>
        /// <param name="stringQuery">requête</param>
        public void ReqControle(string stringQuery)
        {
            MySqlCommand command = new MySqlCommand(stringQuery, connection);
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Exécution d'une requête de type LMD (insert, update, delete)
        /// </summary>
        /// <param name="stringQuery">requête</param>
        /// <param name="parameters">dictionnire contenant les parametres</param>
        public void ReqUpdate(string stringQuery, Dictionary<string, object> parameters = null)
        {
            MySqlCommand command = new MySqlCommand(stringQuery, connection);
            if (parameters != null)
            {
                foreach (KeyValuePair<string, object> parameter in parameters)
                {
                    command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                }
            }
            command.Prepare();
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Execution d'une requête de type LID (select)
        /// </summary>
        /// <param name="stringQuery">requête</param>
        /// <param name="parameters">dictoinnaire contenant les parametres</param>
        /// <returns>liste de tableaux d'objets contenant les valeurs des colonnes</returns>
        public List<object[]> ReqSelect(string stringQuery, Dictionary<string, object> parameters = null)
        {
            List<object[]> records = new List<object[]>();

            using (MySqlCommand command = new MySqlCommand(stringQuery, connection))
            {
                if (parameters != null)
                {
                    foreach (KeyValuePair<string, object> parameter in parameters)
                    {
                        command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                    }
                }

                command.Prepare();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    int nbCols = reader.FieldCount;

                    while (reader.Read())
                    {
                        object[] attributs = new object[nbCols];
                        reader.GetValues(attributs);
                        records.Add(attributs);
                    }
                    reader.Close();
                }

            }
            return records;
        }

    }
}
