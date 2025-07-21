
namespace ISGA.GestionNotes.BO
{
    public class Etudiant
    {
        public int ID_Etudiant { get; set; }
        public string Matricule { get; set; } = string.Empty;
        public string Nom { get; set; } = string.Empty;
        public string Prenom { get; set; } = string.Empty;
        public DateTime DateNaissance { get; set; }
        public int ID_Filiere { get; set; }
    }
}
