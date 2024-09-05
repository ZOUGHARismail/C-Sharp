using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tborida
{
    public class ResponsableProg:User
    {
        public ResponsableProg(string username, string password) : base(username, password)
        {

        }
        public override void afficherInterface()
        {
            new FormResonsableProg(this).Show();
        }
    }
}
