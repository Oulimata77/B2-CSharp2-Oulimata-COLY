using Projet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet.Service
{
    public class DemandeAUtilisateur
    {
        public int DemandeEntier(string message)
        {
            Console.WriteLine(message);
            string code;
            code = Console.ReadLine();
            int intValue;
            while (!int.TryParse(code, out intValue))
            {
                Console.WriteLine("la saisie est invalide");
                code = Console.ReadLine();
            }
            return intValue;
        }

        public string DemandeString(string message)
        {
            Console.WriteLine(message);
            string saisieUtilisateur = Console.ReadLine();
            while (string.IsNullOrEmpty(saisieUtilisateur))
            {
                Console.WriteLine("la saisie est invalide");
                saisieUtilisateur = Console.ReadLine();
            }
            return saisieUtilisateur;
        }
        



    }
}
