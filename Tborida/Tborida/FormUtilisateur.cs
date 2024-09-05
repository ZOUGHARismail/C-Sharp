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
    public partial class FormUtilisateur : Form
    {
        private Admin admin;
        public FormUtilisateur(Admin admin)
        {
            this.admin = admin; 
            InitializeComponent();
        }

        private void FormUtilisateur_Load(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                this.admin.ajouter(new User(this.txtLogin.Text, this.txtPassword.Text, this.txtType.Text));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                this.admin.supprimer(this.txtLogin.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
