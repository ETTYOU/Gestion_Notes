
using ISGA.GestionNotes.BO;
using System.Data.SqlClient;

namespace ISGA.GestionNotes.DAL
{
    public class UtilisateurDAO
    {
        public Utilisateur? GetUtilisateurByEmail(string email)
        {
            using (var connection = ConnexionDB.GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM Utilisateurs WHERE Email = @Email", connection);
                command.Parameters.AddWithValue("@Email", email);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Utilisateur
                        {
                            ID_Utilisateur = (int)reader["ID_Utilisateur"],
                            Nom = (string)reader["Nom"],
                            Prenom = (string)reader["Prenom"],
                            Email = (string)reader["Email"],
                            MotDePasseHash = (string)reader["MotDePasseHash"],
                            ID_Role = (int)reader["ID_Role"]
                        };
                    }
                }
            }
            return null;
        }

        public void AddUtilisateur(Utilisateur utilisateur)
        {
            using (var connection = ConnexionDB.GetConnection())
            {
                var command = new SqlCommand("INSERT INTO Utilisateurs (Nom, Prenom, Email, MotDePasseHash, ID_Role) VALUES (@Nom, @Prenom, @Email, @MotDePasseHash, @ID_Role)", connection);
                command.Parameters.AddWithValue("@Nom", utilisateur.Nom);
                command.Parameters.AddWithValue("@Prenom", utilisateur.Prenom);
                command.Parameters.AddWithValue("@Email", utilisateur.Email);
                command.Parameters.AddWithValue("@MotDePasseHash", utilisateur.MotDePasseHash);
                command.Parameters.AddWithValue("@ID_Role", utilisateur.ID_Role);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void UpdateUtilisateur(Utilisateur utilisateur)
        {
            using (var connection = ConnexionDB.GetConnection())
            {
                var command = new SqlCommand("UPDATE Utilisateurs SET Nom = @Nom, Prenom = @Prenom, Email = @Email, MotDePasseHash = @MotDePasseHash, ID_Role = @ID_Role WHERE ID_Utilisateur = @ID_Utilisateur", connection);
                command.Parameters.AddWithValue("@Nom", utilisateur.Nom);
                command.Parameters.AddWithValue("@Prenom", utilisateur.Prenom);
                command.Parameters.AddWithValue("@Email", utilisateur.Email);
                command.Parameters.AddWithValue("@MotDePasseHash", utilisateur.MotDePasseHash);
                command.Parameters.AddWithValue("@ID_Role", utilisateur.ID_Role);
                command.Parameters.AddWithValue("@ID_Utilisateur", utilisateur.ID_Utilisateur);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteUtilisateur(int id)
        {
            using (var connection = ConnexionDB.GetConnection())
            {
                var command = new SqlCommand("DELETE FROM Utilisateurs WHERE ID_Utilisateur = @ID_Utilisateur", connection);
                command.Parameters.AddWithValue("@ID_Utilisateur", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Utilisateur> GetAllUtilisateurs()
        {
            List<Utilisateur> utilisateurs = new List<Utilisateur>();
            using (var connection = ConnexionDB.GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM Utilisateurs", connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        utilisateurs.Add(new Utilisateur
                        {
                            ID_Utilisateur = (int)reader["ID_Utilisateur"],
                            Nom = (string)reader["Nom"],
                            Prenom = (string)reader["Prenom"],
                            Email = (string)reader["Email"],
                            MotDePasseHash = (string)reader["MotDePasseHash"],
                            ID_Role = (int)reader["ID_Role"]
                        });
                    }
                }
            }
            return utilisateurs;
        }
    }
}
