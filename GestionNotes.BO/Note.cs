
namespace ISGA.GestionNotes.BO
{
    public class Note
    {
        public int ID_Note { get; set; }
        public int ID_Etudiant { get; set; }
        public string Matiere { get; set; } = string.Empty;
        public double Valeur { get; set; }
        public DateTime DateNote { get; set; }
    }
}
