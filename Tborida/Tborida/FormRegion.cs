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
    public partial class FormRegion : Form
    {
        private Admin admin;

        public FormRegion(Admin admin)
        {
            this.admin = admin;
            InitializeComponent();
           
        }

        private void FormRegion_Load(object sender, EventArgs e)
        {
            try
            {
                //this.dataGridView1.DataSource= this.admin.chargerRegions();
                this.admin.chargerRegions();
                this.dataGridView1.DataSource = this.admin.Regions;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                this.admin.enregistrerRegions();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
    }
}
