
using ISGA.GestionNotes.BO;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ISGA.GestionNotes.DAL
{
    public class FiliereDAO
    {
        public void AddFiliere(Filiere filiere)
        {
            using (var connection = ConnexionDB.GetConnection())
            {
                var command = new SqlCommand("INSERT INTO Filieres (NomFiliere, Cycle) VALUES (@NomFiliere, @Cycle)", connection);
                command.Parameters.AddWithValue("@NomFiliere", filiere.NomFiliere);
                command.Parameters.AddWithValue("@Cycle", filiere.Cycle);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public Filiere? GetFiliere(int id)
        {
            using (var connection = ConnexionDB.GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM Filieres WHERE ID_Filiere = @ID_Filiere", connection);
                command.Parameters.AddWithValue("@ID_Filiere", id);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Filiere
                        {
                            ID_Filiere = (int)reader["ID_Filiere"],
                            NomFiliere = (string)reader["NomFiliere"],
                            Cycle = (string)reader["Cycle"]
                        };
                    }
                }
            }
            return null;
        }

        public List<Filiere> GetAllFilieres()
        {
            var filieres = new List<Filiere>();
            using (var connection = ConnexionDB.GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM Filieres", connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        filieres.Add(new Filiere
                        {
                            ID_Filiere = (int)reader["ID_Filiere"],
                            NomFiliere = (string)reader["NomFiliere"],
                            Cycle = (string)reader["Cycle"]
                        });
                    }
                }
            }
            return filieres;
        }

        public void UpdateFiliere(Filiere filiere)
        {
            using (var connection = ConnexionDB.GetConnection())
            {
                var command = new SqlCommand("UPDATE Filiere SET NomFiliere = @NomFiliere, Cycle = @Cycle WHERE ID_Filiere = @ID_Filiere", connection);
                command.Parameters.AddWithValue("@NomFiliere", filiere.NomFiliere);
                command.Parameters.AddWithValue("@Cycle", filiere.Cycle);
                command.Parameters.AddWithValue("@ID_Filiere", filiere.ID_Filiere);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteFiliere(int id)
        {
            using (var connection = ConnexionDB.GetConnection())
            {
                var command = new SqlCommand("DELETE FROM Filieres WHERE ID_Filiere = @ID_Filiere", connection);
                command.Parameters.AddWithValue("@ID_Filiere", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public int GetFiliereCount()
        {
            using (var connection = ConnexionDB.GetConnection())
            {
                var command = new SqlCommand("SELECT COUNT(*) FROM Filieres", connection);
                connection.Open();
                return (int)command.ExecuteScalar();
            }
        }
    }
}
