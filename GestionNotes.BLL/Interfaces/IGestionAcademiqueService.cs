using ISGA.GestionNotes.BO;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNotes.BLL.Interfaces
{
    public interface IGestionAcademiqueService
    {
        List<Matiere> GetMatieresByFiliere(int idFiliere);
        Matiere? GetMatiere(int id);
        List<Matiere> GetAllMatieres();
    }
}