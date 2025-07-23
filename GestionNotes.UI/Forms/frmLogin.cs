using System;
using System.Windows.Forms;

namespace ISGA.GestionNotes.UI.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);

            // Centrer la carte et le logo
            card.Location = new Point(
                (this.ClientSize.Width - card.Width) / 2,
                (this.ClientSize.Height - card.Height) / 2
            );
            lblLogo.Location = new Point((header.Width - lblLogo.Width) / 2, 8);
        }

        private void btnLogin_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Veuillez saisir votre nom d'utilisateur et votre mot de passe.", "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors de la connexion : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuit_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void card_Paint(object? sender, PaintEventArgs e)
        {

        }

        private void lblLogo_Click(object? sender, EventArgs e)
        {

        }
    }
}