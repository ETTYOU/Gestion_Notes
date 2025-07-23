
namespace ISGA.GestionNotes.BO
{
    public class Matiere
    {
        public int ID_Matiere { get; set; }
        public string? NomMatiere { get; set; }
        public decimal Coefficient { get; set; }
        public int ID_Filiere { get; set; }
    }
}
