
using ISGA.GestionNotes.BLL;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ISGA.GestionNotes.UI.Forms
{
    public partial class frmStatistiques : Form
    {
        private GestionAcademiqueService _gestionAcademiqueService;
        private GestionNotesService _gestionNotesService;

        public frmStatistiques()
        {
            InitializeComponent();
            _gestionAcademiqueService = new GestionAcademiqueService();
            _gestionNotesService = new GestionNotesService();
        }

        private void frmStatistiques_Load(object sender, EventArgs e)
        {
            LoadStatistiques();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStatistiques();
        }

        private void LoadStatistiques()
        {
            var etudiants = _gestionAcademiqueService.GetAllEtudiants();
            var statistiques = etudiants.Select(e => new
            {
                e.Matricule,
                e.Nom,
                e.Prenom,
                Moyenne = _gestionNotesService.CalculerMoyenne(e.ID_Etudiant)
            }).ToList();

            dgvStatistiques.DataSource = statistiques;
        }
    }
}
