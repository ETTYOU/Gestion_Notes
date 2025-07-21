
using System.Windows.Forms;

namespace ISGA.GestionNotes.UI.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            GestionNotes.BLL.GestionUtilisateurService service = new GestionNotes.BLL.GestionUtilisateurService();
            GestionNotes.BO.Utilisateur? user = service.Authentifier(email, password);

            if (user != null)
            {
                MessageBox.Show("Connexion réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMain mainForm = new frmMain();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email ou mot de passe incorrect.", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
