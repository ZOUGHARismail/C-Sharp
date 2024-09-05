using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tborida
{
    public class ResponsableIns : User
    {
        public ResponsableIns(string username, string password) : base(username, password)
        {

        }
        public override void afficherInterface()
        {
            new FormResponsableIns(this).Show();
        }
        public void ajouterTroupe(Troupe troupe)
        {
            this.CurrentRegion.ajouter(troupe);

        }

        public void enregistrerTroupes()
        {
            this.CurrentRegion.enregistrerTroupes();
        }

        public void enregistrerCavaliers()
        {
            this.CurrentRegion.enregistrerCavaliers();
        }
        public void enregistrerChevaux()
        {
            this.CurrentRegion.enregistrerChevaux();
        }


    }
}
