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
    public partial class FormTroupe : Form
    {
        private ResponsableIns resIns;
        private Boolean status=false;
        public FormTroupe(ResponsableIns resIns)
        {
            this.resIns = resIns;
            InitializeComponent();
        }

        private void FormTroupe_Load(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = this.resIns.chargerRegions();
            this.comboBox1.DisplayMember= "nom";
            this.comboBox1.ValueMember = "idRegion";
            this.status = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.status)
            { 
            try
            {
                this.resIns.CurrentRegion = new Region(Int32.Parse(this.comboBox1.SelectedValue.ToString()));
                this.dataGridView1.DataSource= this.resIns.CurrentRegion.chargerTroupes();
                this.dataGridView1.Columns[1].Visible=false;
                this.dataGridView1.Columns[0].ReadOnly=true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.resIns.ajouterTroupe(new Troupe(this.txtNomTroupe.Text));


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            this.resIns.enregistrerTroupes();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            this.dataGridView1.CurrentRow.Cells[1].Value = this.comboBox1.SelectedValue;
        }

        private void btnCavalierChevaux_Click(object sender, EventArgs e)
        {
            this.status = false;
            new FormCavalierChevaux(this.resIns).Show();
        }
    }
}
