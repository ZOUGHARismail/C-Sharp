using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Tborida
{
    public class Troupe
    {
        private Int32 idTroupe;
        private String nom;
        private Region region;
        private DataTable cavaliers=new DataTable();
        private Cavalier currentCavalier= null;
        private SqlDataAdapter dataAdapterCavaliers = null;
        private DataTable chevaux = new DataTable();
        private Cheval currentCheval = null;
        private SqlDataAdapter dataAdapterChevaux = null;





        public Troupe(int idTroupe, string nom, Region region)
        {
            this.IdTroupe = idTroupe;
            this.Nom = nom;
            this.Region = region;
        }
        public Troupe(string nom)
        {
            
            this.Nom = nom;
            
        }
        public Troupe(int id)
        {

            this.idTroupe = id;

        }

        public int IdTroupe { get => idTroupe; set => idTroupe = value; }
        public string Nom { get => nom; set => nom = value; }
        public Region Region { get => region; set => region = value; }
        public DataTable Cavaliers { get => cavaliers; set => cavaliers = value; }
        public Cavalier CurrentCavalier { get => currentCavalier; set => currentCavalier = value; }
        public DataTable Chevaux { get => chevaux; set => chevaux = value; }
        public Cheval CurrentCheval { get => currentCheval; set => currentCheval = value; }
        public SqlDataAdapter DataAdapterCavaliers { get => dataAdapterCavaliers; set => dataAdapterCavaliers = value; }
        public SqlDataAdapter DataAdapterChevaux { get => dataAdapterChevaux; set => dataAdapterChevaux = value; }
    
    public DataTable chargerCavaliers()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM cavaliers WHERE idTroupe=@idTroupe", DatabaseConnection.connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@idTroupe", this.idTroupe);
            this.dataAdapterCavaliers=new SqlDataAdapter(cmd);
            this.cavaliers.Clear();
            this.dataAdapterCavaliers.Fill(this.cavaliers);
            SqlCommandBuilder builder= new SqlCommandBuilder(this.dataAdapterCavaliers);
            this.dataAdapterCavaliers.InsertCommand = builder.GetInsertCommand();
            this.dataAdapterCavaliers.UpdateCommand = builder.GetUpdateCommand();
            this.dataAdapterCavaliers.DeleteCommand = builder.GetDeleteCommand();

            return this.cavaliers;

        }

        public DataTable chargerChevaux()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM chevaux WHERE idTroupe=@idTroupe", DatabaseConnection.connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@idTroupe", this.idTroupe);
            this.dataAdapterChevaux = new SqlDataAdapter(cmd);
            this.chevaux.Clear();
            this.dataAdapterChevaux.Fill(this.chevaux);
            SqlCommandBuilder builder = new SqlCommandBuilder(this.dataAdapterChevaux);
            this.dataAdapterChevaux.InsertCommand = builder.GetInsertCommand();
            this.dataAdapterChevaux.UpdateCommand = builder.GetUpdateCommand();
            this.dataAdapterChevaux.DeleteCommand = builder.GetDeleteCommand();

            return this.chevaux;

        }

        public void enregistrerCavaliers()
        {
            this.dataAdapterCavaliers.Update(this.cavaliers);
        }

        public void enregistrerChevaux()
        {
            try
            {
                this.dataAdapterChevaux.Update(this.chevaux);

            }
            catch (Exception)
            {

                
            }
            
        }


    }
}
