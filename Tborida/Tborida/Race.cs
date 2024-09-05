using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tborida
{
    public class Race
    {
        private Int32 idRace;
        private String nom;

        public Race(int idRace, string nom)
        {
            this.idRace = idRace;
            this.nom = nom;
        }

        public Race(int idRace)
        {
            this.idRace = idRace;
           
        }



        public int IdRace { get =>  this.idRace; set => idRace = value; }
        public string Nom { get => nom; set => nom = value; }
    }
}
