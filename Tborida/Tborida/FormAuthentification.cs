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
    public partial class FormAuthentification : Form
    {
        public FormAuthentification()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {  
                if(this.txtLogin.Text=="")
                {
                    this.errorProvider1.SetError(this.txtLogin, "Vide non valide !");
                    
                }
                if ( this.txtPassoword.Text == "")
                {
                    
                    this.errorProvider1.SetError(this.txtPassoword, "Ce champs est vide");
                }

                User u = new User(this.txtLogin.Text, this.txtPassoword.Text);
                u.authentifier();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                this.txtLogin.Clear();
                this.txtPassoword.Clear();
                this.errorProvider1.SetError(this.txtPassoword, "");
                this.txtLogin.Focus();  
            }
            
        }
    }
}
