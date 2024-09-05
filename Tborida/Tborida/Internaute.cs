using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tborida
{
    public class Internaute:User
    {
        public Internaute(string username, string password) : base(username, password)
        {

        }
        public override void afficherInterface()
        {
            new FormInternaute().Show();
        }
    }
}
