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
    public partial class FormAdmin : Form
    {
        private Admin admin;
        public FormAdmin(Admin admin)
        {
            this.admin = admin; 

            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void FormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.admin.Connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FormRace(this.admin).Show();
        }

        private void btnGestionUsers_Click(object sender, EventArgs e)
        {
            new FormUtilisateur(this.admin).Show();
        }

        private void btnGestionRegion_Click(object sender, EventArgs e)
        {
            new FormRegion(this.admin).Show();
        }
    }
}
