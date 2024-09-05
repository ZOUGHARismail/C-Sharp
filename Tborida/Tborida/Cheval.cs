using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tborida
{
    public class Cheval
    {
        private Int32 idCheval;
        private String nom;
        private Race race;

        public Cheval(int idCheval, string nom, Race race)
        {
            this.idCheval = idCheval;
            this.nom = nom;
            this.race = race;
        }

        public Cheval(int idCheval)
        {
            this.idCheval = idCheval;
           
        }

        public int IdCheval { get => idCheval; set => idCheval = value; }
        public string Nom { get => nom; set => nom = value; }
        public Race Race { get => race; set => race = value; }
    }
}
