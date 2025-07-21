
using System.Data.SqlClient;
using System.Configuration;

namespace ISGA.GestionNotes.DAL
{
    public class ConnexionDB
    {
        private static readonly string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ISGA_NotesDB"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
