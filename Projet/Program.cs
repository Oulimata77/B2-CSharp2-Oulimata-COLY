using Projet.Model;
using Projet.Service;
using Projet.Services;
using System;
using System.Collections.Generic;
namespace Projet
{
    class Program
    {
        private static DemandeAUtilisateur _DemandeAUtilisateur = new DemandeAUtilisateur();
        private static CommuneService _CommuneService = new CommuneService(_DemandeAUtilisateur);
        /*private static object _CommmuneService;*/

        static void Main(string[] args)
        {
            CommuneService _CommuneService = new CommuneService(_DemandeAUtilisateur);
            DepartementService _DepartementService = new DepartementService(_DemandeAUtilisateur, _CommuneService);
            RegionService _RegionService = new RegionService(_DemandeAUtilisateur, _DepartementService);
            
            Console.WriteLine("Hello World!");
            while (true)
            {
                string choixUtilisateur = MenuUtilisateur();

                if (choixUtilisateur == "1")
                {
                    _RegionService.CreateRegion();
                }
                else if (choixUtilisateur == "2")
                {
                    _RegionService.AfficheRegion();
                }
                else if (choixUtilisateur == "3")
                {
                    
                    _DepartementService.CreerDepartement();
                }
                else if (choixUtilisateur == "4")
                {

                }
                else if (choixUtilisateur == "5")
                {
                    _CommmuneService.ajouterCommune();
                   
                }
                else if (choixUtilisateur == "Q")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Je n'ai pas compris");
                }
            }
            // pour laisser la fenetre ouverte et attendre 
            // que l'utilisateur ferme
            Console.ReadKey();
        }
        public static int ModifieNum(ref int num1, int num2)
        {


            num1 = num1 + 1;
            return num1 + num2;
        }
        private static string MenuUtilisateur()
        {
            Console.WriteLine("Que voulez-vous faire ?");
            Console.WriteLine("1. Créer une personne");
            Console.WriteLine("2. Afficher la liste des personnes");
            Console.WriteLine("3. Créer une matière");
            Console.WriteLine("4. Afficher les matières");
            Console.WriteLine("5. Créer une salle");
            Console.WriteLine("Q. Quitter");
            string choixUtilisateur = _DemandeAUtilisateur.DemandeString("");
            return choixUtilisateur;
        }
    }
  
}


