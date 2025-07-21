
namespace ISGA.GestionNotes.BO
{
    public class Utilisateur
    {
        public int ID_Utilisateur { get; set; }
        public string Nom { get; set; } = string.Empty;
        public string Prenom { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string MotDePasseHash { get; set; } = string.Empty;
        public int ID_Role { get; set; }
    }
}
