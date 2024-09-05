using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Tborida
{
    public class Admin:User
    {
        public Admin(string username, string password):base(username, password) 
        {

        }

        public override void afficherInterface()
        {
            new FormAdmin(this).Show();
        }

        public void ajouter(User user)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO users (login,password,type) values(@login,@password,@type)",this.Connection);
            cmd.Parameters.AddWithValue("@login", user.Login);
            cmd.Parameters.AddWithValue("@password", user.Password);
            cmd.Parameters.AddWithValue("@type", user.Type);
            cmd.ExecuteNonQuery();

        }

        public void supprimer(String login)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM users WHERE login=@login", this.Connection);
            cmd.Parameters.AddWithValue("@login", login);
            cmd.ExecuteNonQuery();

        }
        public void enregistrerRegions()
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(this.DataAdapterRegion);
            this.DataAdapterRegion.InsertCommand = builder.GetInsertCommand();
            this.DataAdapterRegion.DeleteCommand = builder.GetDeleteCommand();
            this.DataAdapterRegion.UpdateCommand = builder.GetUpdateCommand();
            this.DataAdapterRegion.Update(this.Regions);
        }
        public void enregistrerRaces()
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(this.DataAdapterRace);
            this.DataAdapterRace.InsertCommand = builder.GetInsertCommand();
            this.DataAdapterRace.DeleteCommand = builder.GetDeleteCommand();
            this.DataAdapterRace.UpdateCommand = builder.GetUpdateCommand();
            this.DataAdapterRace.Update(this.Races);
        }
    }
}
