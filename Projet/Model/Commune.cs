using System;
using System.Collections.Generic;
using System.Text;
using Projet.Model;
namespace Projet.Model
{
    public class Commune
    {
        public string Nom { get; set; }
        public int NbH { get; set; }
        public int CodePost { get; set; }
        public object Departement { get; internal set; }
    }
}
