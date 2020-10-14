using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Projet.Model;
using System.Runtime.CompilerServices;
using Projet.Services;

namespace Projet.Service
{
    public class DepartementService
    {
        
        private DemandeAUtilisateur _demandeAUtilisateur;
       private CommuneService _CommuneService;
        private List<Commune> listCommune = new List<Commune>();

        private List<Departement> ListeDepartement = new List<Departement>();
        public DepartementService(DemandeAUtilisateur demandeAUtilisateur, CommuneService CommuneService)
        {
            _demandeAUtilisateur = demandeAUtilisateur;
            _CommuneService = CommuneService;
        }
        
        public Departement CreerDepartement()
        { 
            Departement d = new Departement();
            // renseigner les champs
            d.Code = _demandeAUtilisateur.DemandeEntier("Code du departement?");
            d.Nom = _demandeAUtilisateur.DemandeString("Nom du département ?");

            ListeDepartement.Add(d);
            return d;
        }

        private static void ShowDepartmentInformation(Departement d)
        {
            Console.WriteLine($"Department : {d.Nom} " +
            $"({d.Code})");
            // count number of people living here
            int nbPeople = 0;
            foreach (var c in d.Communes)
                nbPeople += c.NbH;
            // writing number
            Console.WriteLine($"People : {nbPeople}");
        }
        private static Departement DemandeAUtilisateur_ForDepartment(string msg,
List<Departement> departments)
        {
            Console.WriteLine(msg);
            do
            {
                string value = Console.ReadLine();
                int intValue;
                if (!string.IsNullOrEmpty(value)
                && int.TryParse(value, out intValue)
                && departments.Any(d => d.Code == intValue))
                {
                    // we got the result => return the department
                    return departments.First(d => d.Code == intValue);
                }
                else
                {
                    Console.WriteLine("incorrect, please try again");
                }
            } while (true);
        }


    }
}

    