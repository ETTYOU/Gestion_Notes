using System;
using System.Drawing;
using System.Windows.Forms;

namespace ISGA.GestionNotes.UI.Forms
{
    public partial class frmMain : Form
    {
        private Button? currentActiveButton;

        public frmMain()
        {
            InitializeComponent();
            this.Text = "Gestion des Notes ISGA";
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = new Size(1000, 600);

            // Attach event handlers
            btnTableauDeBord.Click += new EventHandler(btnSidebar_Click);
            btnGestionEtudiants.Click += new EventHandler(btnSidebar_Click);
            btnGestionFilieres.Click += new EventHandler(btnSidebar_Click);
            btnSaisieNotes.Click += new EventHandler(btnSidebar_Click);
            btnImpressionReleves.Click += new EventHandler(btnSidebar_Click);
            btnStatistiques.Click += new EventHandler(btnSidebar_Click);
            btnQuitter.Click += new EventHandler(btnSidebar_Click);

            // Set initial active button
            ActivateButton(btnTableauDeBord);

            // Initialize BLL services
            var gestionAcademiqueService = new GestionNotes.BLL.GestionAcademiqueService();
            var gestionUtilisateurService = new GestionNotes.BLL.GestionUtilisateurService();
            var gestionNotesService = new GestionNotes.BLL.GestionNotesService();

            // Populate dashboard content values from database
            lblValueEtudiants.Text = gestionAcademiqueService.GetEtudiantCount().ToString();
            lblValueFilieres.Text = gestionAcademiqueService.GetFiliereCount().ToString();
            // Assuming Role ID 2 is for Teachers/Enseignants. Adjust if necessary.
            lblValueUtilisateurs.Text = gestionUtilisateurService.GetUtilisateurCountByRole(2).ToString();
            lblValueNotes.Text = gestionNotesService.GetMatiereCount().ToString();
        }

        private void ActivateButton(Button clickedButton)
        {
            // Reset previous active button style
            if (currentActiveButton != null)
            {
                currentActiveButton.BackColor = Color.White;
                currentActiveButton.ForeColor = Color.FromArgb(51, 51, 51); // Dark gray
            }

            // Set new active button style
            clickedButton.BackColor = Color.FromArgb(227, 6, 19); // Red
            clickedButton.ForeColor = Color.White;
            currentActiveButton = clickedButton;
        }

        private void ShowFormInPanel(Form formToShow)
        {
            mainContentPanel.Controls.Clear(); // Clear existing controls
            formToShow.TopLevel = false; // Set the form to not be a top-level window
            formToShow.FormBorderStyle = FormBorderStyle.None; // Remove border
            formToShow.Dock = DockStyle.Fill; // Fill the panel
            mainContentPanel.Controls.Add(formToShow); // Add the form to the panel
            formToShow.Show(); // Show the form
        }

        private void btnSidebar_Click(object? sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                ActivateButton(clickedButton);

                // Hide dashboard elements
                lblWelcomeTitle.Visible = false;
                lblWelcomeSubtitle.Visible = false;
                flowLayoutPanelStats.Visible = false;

                if (clickedButton == btnTableauDeBord)
                {
                    lblWelcomeTitle.Visible = true;
                    lblWelcomeSubtitle.Visible = true;
                    flowLayoutPanelStats.Visible = true;
                    mainContentPanel.Controls.Clear(); // Clear any loaded form
                }
                else if (clickedButton == btnGestionEtudiants)
                {
                    ShowFormInPanel(new frmGestionEtudiants());
                }
                else if (clickedButton == btnGestionFilieres)
                {
                    ShowFormInPanel(new frmGestionFilieres());
                }
                else if (clickedButton == btnSaisieNotes)
                {
                    ShowFormInPanel(new frmSaisieNotes());
                }
                else if (clickedButton == btnImpressionReleves)
                {
                    ShowFormInPanel(new frmImpressionReleves());
                }
                else if (clickedButton == btnStatistiques)
                {
                    ShowFormInPanel(new frmStatistiques());
                }
                else if (clickedButton == btnQuitter)
                {
                    Application.Exit();
                }
            }
        }
    }
}