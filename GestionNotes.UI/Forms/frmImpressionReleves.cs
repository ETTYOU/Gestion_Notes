
using ISGA.GestionNotes.BO;
using ISGA.GestionNotes.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ISGA.GestionNotes.UI.Forms
{
    public partial class frmImpressionReleves : Form
    {
        private GestionAcademiqueService _gestionAcademiqueService;
        private GestionNotesService _gestionNotesService;

        public frmImpressionReleves()
        {
            InitializeComponent();
            _gestionAcademiqueService = new GestionAcademiqueService();
            _gestionNotesService = new GestionNotesService();
        }

        private void frmImpressionReleves_Load(object sender, EventArgs e)
        {
            LoadEtudiants();
        }

        private void LoadEtudiants()
        {
            cmbEtudiant.DataSource = _gestionAcademiqueService.GetAllEtudiants();
            cmbEtudiant.DisplayMember = "Nom"; // Assuming Etudiant has a 'Nom' property
            cmbEtudiant.ValueMember = "ID_Etudiant";
        }

        private void btnGenererReleve_Click(object sender, EventArgs e)
        {
            if (cmbEtudiant.SelectedValue != null)
            {
                int etudiantId = (int)cmbEtudiant.SelectedValue;
                Etudiant? etudiant = _gestionAcademiqueService.GetEtudiant(etudiantId);
                List<Note> notes = _gestionNotesService.GetAllNotes().Where(n => n.ID_Etudiant == etudiantId).ToList();
                double moyenne = _gestionNotesService.CalculerMoyenne(etudiantId);

                rtbReleve.Clear();
                if (etudiant != null)
                {
                    rtbReleve.AppendText($"Relevé de notes pour {etudiant.Nom} {etudiant.Prenom} (Matricule: {etudiant.Matricule})\n");
                    rtbReleve.AppendText("----------------------------------------\n");
                    foreach (var note in notes)
                    {
                        rtbReleve.AppendText($"Matière: {note.Matiere}, Note: {note.Valeur}, Date: {note.DateNote.ToShortDateString()}\n");
                    }
                    rtbReleve.AppendText("----------------------------------------\n");
                    rtbReleve.AppendText($"Moyenne Générale: {moyenne:F2}\n");
                }
                else
                {
                    rtbReleve.AppendText("Étudiant non trouvé.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un étudiant.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
