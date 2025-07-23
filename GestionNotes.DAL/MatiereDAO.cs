
using ISGA.GestionNotes.BO;
using ISGA.GestionNotes.DAL.Interfaces;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ISGA.GestionNotes.DAL
{
    public class MatiereDAO : IMatiereDAO
    {
        public void AddMatiere(Matiere matiere)
        {
            using (var connection = ConnexionDB.GetConnection())
            {
                var command = new SqlCommand("INSERT INTO Matieres (NomMatiere, Coefficient, ID_Filiere) VALUES (@NomMatiere, @Coefficient, @ID_Filiere)", connection);
                command.Parameters.AddWithValue("@NomMatiere", matiere.NomMatiere);
                command.Parameters.AddWithValue("@Coefficient", matiere.Coefficient);
                command.Parameters.AddWithValue("@ID_Filiere", matiere.ID_Filiere);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteMatiere(int id)
        {
            using (var connection = ConnexionDB.GetConnection())
            {
                var command = new SqlCommand("DELETE FROM Matieres WHERE ID_Matiere = @ID_Matiere", connection);
                command.Parameters.AddWithValue("@ID_Matiere", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Matiere> GetAllMatieres()
        {
            var matieres = new List<Matiere>();
            using (var connection = ConnexionDB.GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM Matieres", connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        matieres.Add(new Matiere
                        {
                            ID_Matiere = (int)reader["ID_Matiere"],
                            NomMatiere = (string)reader["NomMatiere"],
                            Coefficient = (decimal)reader["Coefficient"],
                            ID_Filiere = (int)reader["ID_Filiere"]
                        });
                    }
                }
            }
            return matieres;
        }

        public Matiere? GetMatiere(int id)
        {
            using (var connection = ConnexionDB.GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM Matieres WHERE ID_Matiere = @ID_Matiere", connection);
                command.Parameters.AddWithValue("@ID_Matiere", id);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Matiere
                        {
                            ID_Matiere = (int)reader["ID_Matiere"],
                            NomMatiere = (string)reader["NomMatiere"],
                            Coefficient = (decimal)reader["Coefficient"],
                            ID_Filiere = (int)reader["ID_Filiere"]
                        };
                    }
                }
            }
            return null;
        }

        public List<Matiere> GetMatieresByFiliere(int idFiliere)
        {
            var matieres = new List<Matiere>();
            using (var connection = ConnexionDB.GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM Matieres WHERE ID_Filiere = @ID_Filiere", connection);
                command.Parameters.AddWithValue("@ID_Filiere", idFiliere);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        matieres.Add(new Matiere
                        {
                            ID_Matiere = (int)reader["ID_Matiere"],
                            NomMatiere = (string)reader["NomMatiere"],
                            Coefficient = (decimal)reader["Coefficient"],
                            ID_Filiere = (int)reader["ID_Filiere"]
                        });
                    }
                }
            }
            return matieres;
        }

        public void UpdateMatiere(Matiere matiere)
        {
            using (var connection = ConnexionDB.GetConnection())
            {
                var command = new SqlCommand("UPDATE Matieres SET NomMatiere = @NomMatiere, Coefficient = @Coefficient, ID_Filiere = @ID_Filiere WHERE ID_Matiere = @ID_Matiere", connection);
                command.Parameters.AddWithValue("@NomMatiere", matiere.NomMatiere);
                command.Parameters.AddWithValue("@Coefficient", matiere.Coefficient);
                command.Parameters.AddWithValue("@ID_Filiere", matiere.ID_Filiere);
                command.Parameters.AddWithValue("@ID_Matiere", matiere.ID_Matiere);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
