using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Tborida
{
    public class User
    {
        private SqlConnection connection = DatabaseConnection.connection;
        private String login;
        private String password;
        private String type;
        private DataTable regions = new DataTable();
        private Region currentRegion;
        private DataTable races = new DataTable();
        private SqlDataAdapter dataAdapterRace;

        private SqlDataAdapter dataAdapterRegion;



        public User(string login, string password, string type) :
            this(login, password)
        {
            this.Type = type;
        }

        public User(string login, string password)
        {
            this.Login = login;
            this.Password = password;

        }

        public string Login
        {
            get
            {
                return this.login;
            }
            set
            {
                if (!value.Equals(""))
                {
                    this.login = value;
                }
                else
                {
                    throw new Exception("Attention le login ne doit pas être vide ! ");

                }

            }

        }
        public string Password { get => password; set => password = value; }
        public string Type { get => type; set => type = value; }
        public SqlConnection Connection { get => connection; set => connection = value; }
        public DataTable Regions { get => regions; set => regions = value; }
        public SqlDataAdapter DataAdapterRegion { get => dataAdapterRegion; set => dataAdapterRegion = value; }
        public DataTable Races { get => races; set => races = value; }
        public SqlDataAdapter DataAdapterRace { get => dataAdapterRace; set => dataAdapterRace = value; }
        public Region CurrentRegion { get => currentRegion; set => currentRegion = value; }

        public override string ToString()
        {
            return this.login + '\t' + this.password + '\t' + this.type;

        }

        public void authentifier()
        {
            this.Connection.Open();
            SqlCommand cmd = new SqlCommand("select type from users where login=@login and password=@password", this.Connection);
            cmd.Parameters.AddWithValue("@login", this.login);
            cmd.Parameters.AddWithValue("@password", this.password);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                String type = dr.GetString(0);
                User u = null;
                switch (type)
                {
                    case "admin":
                        u = new Admin(this.login, this.password);
                        break;
                    case "respins":
                        u = new ResponsableIns(this.login, this.password);
                        break;
                    case "respprog":
                        u = new ResponsableProg(this.login, this.password);
                        break;

                }
                if (u != null)
                {
                    u.afficherInterface();
                }


            }
            else
            {
                throw new Exception("Login ou passeord incorrect !");
            }
            dr.Close();



        }
        public virtual void afficherInterface()
        {

        }
        public DataTable chargerRegions()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM regions", this.connection);
            this.dataAdapterRegion = new SqlDataAdapter(cmd);
            this.regions.Clear();
            this.dataAdapterRegion.Fill(this.regions);

            return this.regions;
        }

        public DataTable chargerRaces()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM races", this.connection);
            this.dataAdapterRace = new SqlDataAdapter(cmd);
            this.races.Clear();
            this.dataAdapterRace.Fill(this.races);

            return this.races;



        }
    }
}
