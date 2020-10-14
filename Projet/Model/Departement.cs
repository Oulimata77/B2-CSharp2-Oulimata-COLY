using System;
using System.Collections.Generic;
using System.Text;
using Projet.Model;
namespace Projet.Model
{
    public class Departement
    {
        public string Nom { get; set; }
        public int Code { get; set; }
        public List<Commune> Communes { get; set; }
        = new List<Commune>();
       
    }
}
