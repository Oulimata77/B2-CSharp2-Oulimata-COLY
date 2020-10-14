using System;
using System.Collections.Generic;
using System.Text;

namespace Projet.Model
{
   public class Region
    {
       
    public string nom { get; set; }
     public string lieu { get; set; }
        //public List<Departement> Departement { get; set; }
        //public List<Region> Region { get; internal set; }
        public List<Departement> Departements { get; set; }
       = new List<Departement>();
    }
}
