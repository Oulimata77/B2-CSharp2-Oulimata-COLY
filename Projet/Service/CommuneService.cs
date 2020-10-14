using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Projet.Service;
using Projet.Model;

namespace Projet.Services
{
    public class CommuneService
    {

        private DemandeAUtilisateur _DemandeAUtilisateur;
        private List<Commune> ListeCommune = new List<Commune>();
        public CommuneService(DemandeAUtilisateur demandeAUtilisateur)
        {
            this._DemandeAUtilisateur = demandeAUtilisateur;
        }
        public Commune ajouterCommune()
        {
            Commune c = new Commune();
            c.Nom = _DemandeAUtilisateur.DemandeString("Quel est le nom de votre ville ?");
            c.CodePost =_DemandeAUtilisateur.DemandeEntier("Quel est de code postal ?");
            c.NbH = _DemandeAUtilisateur.DemandeEntier("Combie y a-t-il d'habitants ?");

            return c;
        }

        public void calculNbtotalHabs(List<Commune> listcommunes)
        {
            int Nbtot = 0;
            foreach (Commune c in listcommunes)
            {
                Nbtot = Nbtot + c.NbH;
            }
            var culture = CultureInfo.GetCultureInfo("en-GB");
            string nb = string.Format(culture, "{0:n0}", Nbtot);
            nb = nb.Replace(",", ".");
            string message = "Nombre total d'habitants: " + nb;
            Console.WriteLine(message);
        }

        public void affiche(List<Commune> listcommunes)
        {
            Console.WriteLine("Liste des communes créées:");
            foreach (Commune c in listcommunes)
            {
                var culture = CultureInfo.GetCultureInfo("en-GB");
                string nb = string.Format(culture, "{0:n0}", c.NbH);
                nb = nb.Replace(",", ".");
                string message_p1 = "Nom: " + c.Nom + " Code Postal: " + c.CodePost;
                string message_p2 = "Nombre d'habitants: " + nb;
                Console.WriteLine(message_p1);
                Console.WriteLine(message_p2);
            }
        }
    }
}
