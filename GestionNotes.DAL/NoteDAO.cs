
using ISGA.GestionNotes.BO;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ISGA.GestionNotes.DAL
{
    public class NoteDAO
    {
        public void AddNote(Note note)
        {
            using (var connection = ConnexionDB.GetConnection())
            {
                var command = new SqlCommand("INSERT INTO Notes (ID_Etudiant, ID_Matiere, Valeur, DateNote) VALUES (@ID_Etudiant, @ID_Matiere, @Valeur, @DateNote)", connection);
                command.Parameters.AddWithValue("@ID_Etudiant", note.ID_Etudiant);
                command.Parameters.AddWithValue("@ID_Matiere", note.ID_Matiere);
                command.Parameters.AddWithValue("@Valeur", note.Valeur);
                command.Parameters.AddWithValue("@DateNote", note.DateNote);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public Note? GetNote(int id)
        {
            using (var connection = ConnexionDB.GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM Notes WHERE ID_Note = @ID_Note", connection);
                command.Parameters.AddWithValue("@ID_Note", id);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Note
                        {
                            ID_Note = (int)reader["ID_Note"],
                            ID_Etudiant = (int)reader["ID_Etudiant"],
                            ID_Matiere = (int)reader["ID_Matiere"],
                            Valeur = Convert.ToDouble(reader["ValeurNote"]),
                            DateNote = (DateTime)reader["DateSaisie"]
                        };
                    }
                }
            }
            return null;
        }

        public List<Note> GetAllNotes()
        {
            var notes = new List<Note>();
            using (var connection = ConnexionDB.GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM Notes", connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        notes.Add(new Note
                        {
                            ID_Note = (int)reader["ID_Note"],
                            ID_Etudiant = (int)reader["ID_Etudiant"],
                            ID_Matiere = (int)reader["ID_Matiere"],
                            Valeur = Convert.ToDouble(reader["ValeurNote"]),
                            DateNote = (DateTime)reader["DateSaisie"]
                        });
                    }
                }
            }
            return notes;
        }

        public void UpdateNote(Note note)
        {
            using (var connection = ConnexionDB.GetConnection())
            {
                var command = new SqlCommand("UPDATE Notes SET ID_Etudiant = @ID_Etudiant, ID_Matiere = @ID_Matiere, Valeur = @Valeur, DateNote = @DateNote WHERE ID_Note = @ID_Note", connection);
                command.Parameters.AddWithValue("@ID_Etudiant", note.ID_Etudiant);
                command.Parameters.AddWithValue("@ID_Matiere", note.ID_Matiere);
                command.Parameters.AddWithValue("@Valeur", note.Valeur);
                command.Parameters.AddWithValue("@DateNote", note.DateNote);
                command.Parameters.AddWithValue("@ID_Note", note.ID_Note);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteNote(int id)
        {
            using (var connection = ConnexionDB.GetConnection())
            {
                var command = new SqlCommand("DELETE FROM Notes WHERE ID_Note = @ID_Note", connection);
                command.Parameters.AddWithValue("@ID_Note", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public int GetDistinctMatiereCount()
        {
            using (var connection = ConnexionDB.GetConnection())
            {
                var command = new SqlCommand("SELECT COUNT(DISTINCT ID_Matiere) FROM Notes", connection);
                connection.Open();
                return (int)command.ExecuteScalar();
            }
        }
    }
}
