using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tborida
{
    public class Cavalier
    {
        private Int32 idCavalier;
        private String nom;
        private String prenom;
        private DateTime dateNaissance;

        public Cavalier(int idCavalier, string nom, string prenom, DateTime dateNaissance)
        {
            this.idCavalier = idCavalier;
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;

        }

        public Cavalier(int idCavalier)
        {
            this.idCavalier = idCavalier;
            

        }
        public int IdCavalier { get => idCavalier; set => idCavalier = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public DateTime DateNaissance { get => dateNaissance; set => dateNaissance = value; }
    }
}
