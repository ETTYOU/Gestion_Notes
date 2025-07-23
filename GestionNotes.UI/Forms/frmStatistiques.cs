
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
            var matieres = _gestionAcademiqueService.GetAllMatieres();
            var statistiques = etudiants.Select(e => new
            {
                e.Matricule,
                e.Nom,
                e.Prenom,
                Moyenne = (double)_gestionNotesService.CalculerMoyenne(e.ID_Etudiant, matieres.Where(m => m.ID_Filiere == e.ID_Filiere).ToList())
            }).ToList();

            dgvStatistiques.DataSource = statistiques;
        }
    }
}
