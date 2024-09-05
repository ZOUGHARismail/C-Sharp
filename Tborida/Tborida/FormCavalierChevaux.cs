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
    public partial class FormCavalierChevaux : Form
    {
        private ResponsableIns resIns;
        //private Boolean status=false;
        public FormCavalierChevaux(ResponsableIns resIns)
        {
            this.resIns = resIns;
            InitializeComponent();
        }

        private void FormCavalierChevaux_Load(object sender, EventArgs e)
        {
           
            try
            {
                this.comboRegion.DataSource = this.resIns.chargerRegions();
                this.comboRegion.DisplayMember = this.resIns.Regions.Columns[1].ColumnName;
                this.comboRegion.ValueMember = this.resIns.Regions.Columns[0].ColumnName;
                this.comboRaces.DataSource=this.resIns.chargerRaces();
                this.comboRaces.DisplayMember= this.resIns.Races.Columns[1].ColumnName;
                this.comboRaces.ValueMember = this.resIns.Races.Columns[0].ColumnName;
                //this.status = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (status)
            //{
                try
                {
                
                    if (this.comboRegion.SelectedValue is Int32)
                    { 
                    this.resIns.CurrentRegion = new Region(Int32.Parse(this.comboRegion.SelectedValue.ToString()));
                    this.comboTroupe.DataSource = this.resIns.CurrentRegion.chargerTroupes();
                    this.comboTroupe.DisplayMember = this.resIns.CurrentRegion.Troupes.Columns[2].ColumnName;
                    this.comboTroupe.ValueMember = this.resIns.CurrentRegion.Troupes.Columns[0].ColumnName;
                    this.comboTroupe.SelectedIndex = -1;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            //}
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            this.resIns.enregistrerCavaliers();
            this.resIns.enregistrerChevaux();
        }

        private void comboTroupe_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                try
                {
                    
                    //MessageBox.Show(this.comboTroupe.SelectedValue.ToString( ));
                    if ( this.comboTroupe.SelectedValue is Int32)
                    {
                        

                        this.resIns.CurrentRegion.CurrentTroupe = new Troupe(Int32.Parse(this.comboTroupe.SelectedValue.ToString()));
                    this.dataGridViewCavalier.DataSource = this.resIns.CurrentRegion.CurrentTroupe.chargerCavaliers();
                        this.dataGridViewChevaux.DataSource = this.resIns.CurrentRegion.CurrentTroupe.chargerChevaux();
                        this.dataGridViewCavalier.Columns[0].Visible = false;
                        this.dataGridViewCavalier.Columns[1].Visible = false;

                        this.dataGridViewChevaux.Columns[0].Visible = false;
                        this.dataGridViewChevaux.Columns[2].Visible = false;


                }


                }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void dataGridViewCavalier_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            this.dataGridViewCavalier.CurrentRow.Cells[1].Value = this.comboTroupe.SelectedValue;

        }

        private void dataGridViewChevaux_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            this.dataGridViewChevaux.CurrentRow.Cells[2].Value = this.comboTroupe.SelectedValue;
            Point p= this.dataGridViewChevaux.CurrentCell.ContentBounds.Location;
            comboRaces.Width = this.dataGridViewChevaux.Columns[2].Width;
            p.X=40+p.X+this.dataGridViewChevaux.Location.X;
            p.Y =20+ p.Y + this.dataGridViewChevaux.Location.Y+this.dataGridViewChevaux.CurrentRow.Height*this.dataGridViewChevaux.CurrentRow.Index;
            //MessageBox.Show("X="+p.X);
            //MessageBox.Show("Y=" + p.Y);
           // this.comboRaces.Size = this.dataGridViewChevaux.CurrentRow.Cells[2].Size;
            
            this.comboRaces.Location = p;
            //this.dataGridViewChevaux.CurrentRow.Cells[2].Value = this.comboRaces;
        }

        private void dataGridViewChevaux_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewChevaux_Click(object sender, EventArgs e)
        {
            this.comboRaces.Visible = true;
            this.dataGridViewChevaux.CurrentRow.Cells[2].Value = this.comboTroupe.SelectedValue;
            Point p = this.dataGridViewChevaux.CurrentCell.ContentBounds.Location;
            comboRaces.Width = this.dataGridViewChevaux.Columns[2].Width;
            p.X = 40 + p.X + this.dataGridViewChevaux.Location.X;
            p.Y = 20 + p.Y + this.dataGridViewChevaux.Location.Y + this.dataGridViewChevaux.CurrentRow.Height * this.dataGridViewChevaux.CurrentRow.Index;
            //MessageBox.Show("X="+p.X);
            //MessageBox.Show("Y=" + p.Y);
            // this.comboRaces.Size = this.dataGridViewChevaux.CurrentRow.Cells[2].Size;

            this.comboRaces.Location = p;
            //this.dataGridViewChevaux.CurrentRow.Cells[2].Value = this.comboRaces;
        }

        private void comboRaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(this.comboRaces.SelectedValue is Int32)
                this.dataGridViewChevaux.CurrentRow.Cells[1].Value = this.comboRaces.SelectedValue;
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
            
        }
    }
}
