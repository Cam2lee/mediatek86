using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mediatek86.modele;

namespace mediatek86.dal
{
    /// <summary>
    /// Classe permettant de gérer les demandes concernant les services
    /// </summary>
    public class ServiceAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public ServiceAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Récupère et retourne les services
        /// </summary>
        /// <returns>liste des services</returns>
        public List<Service> GetLesService()
        {
            List<Service> lesService = new List<Service>();
            if (access.Manager != null)
            {
                string req = "select * from service order by nom;";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        Console.WriteLine("ServiceAccess.GetLesService nb records = {0}", records.Count);
                        foreach (Object[] record in records)
                        {
                            Console.WriteLine("ServiceAccess.GetLesService id={0} nom={1}", record[0], record[1]);
                            Service service = new Service((int)record[0], (string)record[1]);
                            lesService.Add(service);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("ServiceAccess.GetLesService catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
            return lesService;
        }
    }
}
