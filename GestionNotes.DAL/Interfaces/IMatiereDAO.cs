
using ISGA.GestionNotes.BO;
using System.Collections.Generic;

namespace ISGA.GestionNotes.DAL.Interfaces
{
    public interface IMatiereDAO
    {
        void AddMatiere(Matiere matiere);
        Matiere GetMatiere(int id);
        List<Matiere> GetAllMatieres();
        List<Matiere> GetMatieresByFiliere(int idFiliere);
        void UpdateMatiere(Matiere matiere);
        void DeleteMatiere(int id);
    }
}
