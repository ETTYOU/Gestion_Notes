
using ISGA.GestionNotes.BO;
using ISGA.GestionNotes.DAL;

namespace ISGA.GestionNotes.BLL
{
    public class GestionUtilisateurService
    {
        public Utilisateur? Authentifier(string email, string motDePasse)
        {
            var utilisateurDAO = new UtilisateurDAO();
            var utilisateur = utilisateurDAO.GetUtilisateurByEmail(email);

            if (utilisateur != null && utilisateur.MotDePasseHash == motDePasse) // ATTENTION: Mot de passe en clair
            {
                return utilisateur;
            }

            return null;
        }
        public int GetUtilisateurCountByRole(int roleId)
        {
            var utilisateurDAO = new UtilisateurDAO();
            return utilisateurDAO.GetUtilisateurCountByRole(roleId);
        }
    }
}
