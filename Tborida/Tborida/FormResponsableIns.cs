using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tborida
{
    public partial class FormResponsableIns : Form
    {
        private ResponsableIns resIns;
        public FormResponsableIns(ResponsableIns resIns)
        {
            this.resIns = resIns;
            InitializeComponent();
        }

        private void FormResponsableIns_Load(object sender, EventArgs e)
        {

        }

        private void FormResponsableIns_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.resIns.Connection.Close();
        }

        private void btnGererTroupe_Click(object sender, EventArgs e)
        {
            new FormTroupe(this.resIns).Show();
        }
    }
}
