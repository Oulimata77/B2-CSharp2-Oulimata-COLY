using Projet.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet.Service
{
   public class RegionService
    {
        private DemandeAUtilisateur _DemandeAUtilisateur;
        private DepartementService _DepartementService;
        private List<Region> ListeRegion = new List<Region>();
       // private object _RegionServices;

        /// <summary>
        /// Constructeur => permet d'imposer le fait qu'on doive fournir
        /// Un objet de type DemandeALutilisateur lors de l'instanciation de l'objet
        /// </summary>
        /// <param name="demandeALutilisateur"></param>
        public RegionService(DemandeAUtilisateur demandeAUtilisateur, DepartementService DepartementService)
        {
            _DemandeAUtilisateur = demandeAUtilisateur;
            _DepartementService = DepartementService;
        }

       


        /// <summary>
        /// Affiche la liste des regions
        /// </summary>
        /// <param name="Departement"></param>
        public void AfficheRegion()
        {
            // affichage des regions
            foreach (Region r in ListeRegion)
            {
                Console.WriteLine(r.nom);
                Console.WriteLine("Les departements: ");
                // affichage des regions
                if (r.Departements != null)
                {

                    foreach (Departement m in r.Departements)
                    {
                        Console.WriteLine(m.Nom);
                    }

                }
            }
        }

        public Region CreateRegion()
        {
 
            Region r = new Region();
            r.nom = _DemandeAUtilisateur.DemandeString("Quelle est le nom de la région ?");
            // demande des autres informations
            r.lieu = _DemandeAUtilisateur.DemandeString("Quel est son lieu ?");
            ListeRegion.Add(r);
            return r;
        }


        public Region DemandeRegion()
        {
            Console.WriteLine("Veuille indiquer le nom de la region");

            
            Region result = null;
            while (result == null)
            {
                string nom= Console.ReadLine();
                if (nom == "Q")
                {
                    break;
                }
                foreach (Region m in ListeRegion)
                {
                    if (m.nom == nom)
                    {
                        result = m;
                    }
                }

                if (result == null)
                {
                    Console.WriteLine("Je n'ai pas compris, veuillez recommencer");
                }
            }

            // on renvoie le résultat
            return result;
        }

    }
}
