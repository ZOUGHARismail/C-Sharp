using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Tborida
{
    public class Region
    {
        private Int32 id;
        private String nom;
        private DataTable troupes=new DataTable();
        private Troupe currentTroupe=null;
        private SqlDataAdapter dataAdapterTroupe;

        public Region(int id, string nom)
        {
            this.id = id;
            this.nom = nom;
        }
        public Region(int id)
        {
            this.id = id;
            
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public DataTable Troupes { get => troupes; set => troupes = value; }
        public SqlDataAdapter DataAdapterTroupe { get => dataAdapterTroupe; set => dataAdapterTroupe = value; }
        public Troupe CurrentTroupe { get => currentTroupe; set => currentTroupe = value; }

        public void ajouter(Troupe troupe)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO troupes(idRegion,nom)VALUES(@idRegion,@nom)", DatabaseConnection.connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@idRegion",this.id);
            cmd.Parameters.AddWithValue("@nom",troupe.Nom);
            cmd.ExecuteNonQuery();
        }

        public DataTable chargerTroupes()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM troupes WHERE idRegion=@idRegion", DatabaseConnection.connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@idRegion", this.id);
            this.dataAdapterTroupe=new SqlDataAdapter(cmd);
            this.dataAdapterTroupe.Fill(this.troupes);
            SqlCommandBuilder cb = new SqlCommandBuilder(this.dataAdapterTroupe);
            this.dataAdapterTroupe.InsertCommand = cb.GetInsertCommand();
            this.dataAdapterTroupe.UpdateCommand = cb.GetUpdateCommand();
            this.dataAdapterTroupe.DeleteCommand = cb.GetDeleteCommand();

            return this.troupes;
        }
        public void enregistrerTroupes()
        {
            this.dataAdapterTroupe.Update(this.troupes);
        }

        public void enregistrerCavaliers()
        {
            this.currentTroupe.enregistrerCavaliers();
        }

        public void enregistrerChevaux()
        {
            this.currentTroupe.enregistrerChevaux();
        }
    }
}
