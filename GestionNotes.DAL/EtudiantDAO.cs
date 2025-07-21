
using ISGA.GestionNotes.BO;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ISGA.GestionNotes.DAL
{
    public class EtudiantDAO
    {
        public void AddEtudiant(Etudiant etudiant)
        {
            using (var connection = ConnexionDB.GetConnection())
            {
                var command = new SqlCommand("INSERT INTO Etudiants (Matricule, Nom, Prenom, DateNaissance, ID_Filiere) VALUES (@Matricule, @Nom, @Prenom, @DateNaissance, @ID_Filiere)", connection);
                command.Parameters.AddWithValue("@Matricule", etudiant.Matricule);
                command.Parameters.AddWithValue("@Nom", etudiant.Nom);
                command.Parameters.AddWithValue("@Prenom", etudiant.Prenom);
                command.Parameters.AddWithValue("@DateNaissance", etudiant.DateNaissance);
                command.Parameters.AddWithValue("@ID_Filiere", etudiant.ID_Filiere);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public Etudiant? GetEtudiant(int id)
        {
            using (var connection = ConnexionDB.GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM Etudiants WHERE ID_Etudiant = @ID_Etudiant", connection);
                command.Parameters.AddWithValue("@ID_Etudiant", id);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Etudiant
                        {
                            ID_Etudiant = (int)reader["ID_Etudiant"],
                            Matricule = (string)reader["Matricule"],
                            Nom = (string)reader["Nom"],
                            Prenom = (string)reader["Prenom"],
                            DateNaissance = (DateTime)reader["DateNaissance"],
                            ID_Filiere = (int)reader["ID_Filiere"]
                        };
                    }
                }
            }
            return null;
        }

        public List<Etudiant> GetAllEtudiants()
        {
            var etudiants = new List<Etudiant>();
            using (var connection = ConnexionDB.GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM Etudiants", connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        etudiants.Add(new Etudiant
                        {
                            ID_Etudiant = (int)reader["ID_Etudiant"],
                            Matricule = (string)reader["Matricule"],
                            Nom = (string)reader["Nom"],
                            Prenom = (string)reader["Prenom"],
                            DateNaissance = (DateTime)reader["DateNaissance"],
                            ID_Filiere = (int)reader["ID_Filiere"]
                        });
                    }
                }
            }
            return etudiants;
        }

        public void UpdateEtudiant(Etudiant etudiant)
        {
            using (var connection = ConnexionDB.GetConnection())
            {
                var command = new SqlCommand("UPDATE Etudiants SET Matricule = @Matricule, Nom = @Nom, Prenom = @Prenom, DateNaissance = @DateNaissance, ID_Filiere = @ID_Filiere WHERE ID_Etudiant = @ID_Etudiant", connection);
                command.Parameters.AddWithValue("@Matricule", etudiant.Matricule);
                command.Parameters.AddWithValue("@Nom", etudiant.Nom);
                command.Parameters.AddWithValue("@Prenom", etudiant.Prenom);
                command.Parameters.AddWithValue("@DateNaissance", etudiant.DateNaissance);
                command.Parameters.AddWithValue("@ID_Filiere", etudiant.ID_Filiere);
                command.Parameters.AddWithValue("@ID_Etudiant", etudiant.ID_Etudiant);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteEtudiant(int id)
        {
            using (var connection = ConnexionDB.GetConnection())
            {
                var command = new SqlCommand("DELETE FROM Etudiants WHERE ID_Etudiant = @ID_Etudiant", connection);
                command.Parameters.AddWithValue("@ID_Etudiant", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
