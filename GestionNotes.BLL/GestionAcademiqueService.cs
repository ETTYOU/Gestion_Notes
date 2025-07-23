
using ISGA.GestionNotes.BO;
using ISGA.GestionNotes.DAL;

namespace ISGA.GestionNotes.BLL
{
    public class GestionAcademiqueService
    {
        private readonly EtudiantDAO _etudiantDAO;
        private readonly FiliereDAO _filiereDAO;
        private readonly MatiereDAO _matiereDAO;

        public GestionAcademiqueService()
        {
            _etudiantDAO = new EtudiantDAO();
            _filiereDAO = new FiliereDAO();
            _matiereDAO = new MatiereDAO();
        }

        public void AddEtudiant(Etudiant etudiant)
        {
            _etudiantDAO.AddEtudiant(etudiant);
        }

        public Etudiant? GetEtudiant(int id)
        {
            return _etudiantDAO.GetEtudiant(id);
        }

        public List<Etudiant> GetAllEtudiants()
        {
            return _etudiantDAO.GetAllEtudiants();
        }

        public void UpdateEtudiant(Etudiant etudiant)
        {
            _etudiantDAO.UpdateEtudiant(etudiant);
        }

        public void DeleteEtudiant(int id)
        {
            _etudiantDAO.DeleteEtudiant(id);
        }

        public void AddFiliere(Filiere filiere)
        {
            _filiereDAO.AddFiliere(filiere);
        }

        public Filiere? GetFiliere(int id)
        {
            return _filiereDAO.GetFiliere(id);
        }

        public List<Filiere> GetAllFilieres()
        {
            return _filiereDAO.GetAllFilieres();
        }

        public void UpdateFiliere(Filiere filiere)
        {
            _filiereDAO.UpdateFiliere(filiere);
        }

        public void DeleteFiliere(int id)
        {
            _filiereDAO.DeleteFiliere(id);
        }

        public int GetEtudiantCount()
        {
            return _etudiantDAO.GetEtudiantCount();
        }

        public int GetFiliereCount()
        {
            return _filiereDAO.GetFiliereCount();
        }

        public List<Matiere> GetMatieresByFiliere(int idFiliere)
        {
            return _matiereDAO.GetMatieresByFiliere(idFiliere);
        }

        public Matiere GetMatiere(int id)
        {
            return _matiereDAO.GetMatiere(id);
        }

        public List<Matiere> GetAllMatieres()
        {
            return _matiereDAO.GetAllMatieres();
        }
    }
}
