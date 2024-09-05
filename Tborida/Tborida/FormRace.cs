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
    public partial class FormRace : Form
    {
        private Admin admin;
        public FormRace(Admin admin)
        {
            this.admin = admin;
            InitializeComponent();
        }

        private void FormRace_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = this.admin.chargerRaces();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            this.admin.enregistrerRaces();  
        }
    }
}
