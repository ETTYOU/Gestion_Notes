
using ISGA.GestionNotes.BO;
using ISGA.GestionNotes.DAL;

namespace ISGA.GestionNotes.BLL
{
    public class GestionNotesService
    {
        private readonly NoteDAO _noteDAO;

        public GestionNotesService()
        {
            _noteDAO = new NoteDAO();
        }

        public void AddNote(Note note)
        {
            _noteDAO.AddNote(note);
        }

        public Note? GetNote(int id)
        {
            return _noteDAO.GetNote(id);
        }

        public List<Note> GetAllNotes()
        {
            return _noteDAO.GetAllNotes();
        }

        public void UpdateNote(Note note)
        {
            _noteDAO.UpdateNote(note);
        }

        public void DeleteNote(int id)
        {
            _noteDAO.DeleteNote(id);
        }

        public double CalculerMoyenne(int idEtudiant, List<Matiere> matieres)
        {
            var notes = _noteDAO.GetAllNotes().Where(n => n.ID_Etudiant == idEtudiant).ToList();
            if (notes.Any())
            {
                double totalPoints = 0;
                double totalCoefficients = 0;
                foreach (var note in notes)
                {
                    Matiere? matiere = matieres.FirstOrDefault(m => m.ID_Matiere == note.ID_Matiere);
                    if (matiere != null)
                    {
                        totalPoints += note.Valeur * (double)matiere.Coefficient;
                        totalCoefficients += (double)matiere.Coefficient;
                    }
                }
                return totalCoefficients > 0 ? totalPoints / totalCoefficients : 0;
            }
            return 0;
        }

        public int GetMatiereCount()
        {
            return _noteDAO.GetDistinctMatiereCount();
        }
    }
}
