
using ISGA.GestionNotes.BO;
using ISGA.GestionNotes.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ISGA.GestionNotes.UI.Forms
{
    public partial class frmSaisieNotes : Form
    {
        private GestionNotesService _gestionNotesService;
        private GestionAcademiqueService _gestionAcademiqueService;

        public frmSaisieNotes()
        {
            InitializeComponent();
            _gestionNotesService = new GestionNotesService();
            _gestionAcademiqueService = new GestionAcademiqueService();
        }

        private void frmSaisieNotes_Load(object sender, EventArgs e)
        {
            LoadNotes();
            LoadEtudiants();
        }

        private void LoadNotes()
        {
            try
            {
                dgvNotes.DataSource = _gestionNotesService.GetAllNotes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des notes : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadEtudiants()
        {
            cmbEtudiant.DataSource = _gestionAcademiqueService.GetAllEtudiants();
            cmbEtudiant.DisplayMember = "Nom"; // Assuming Etudiant has a 'Nom' property
            cmbEtudiant.ValueMember = "ID_Etudiant";
            cmbEtudiant.SelectedIndexChanged += CmbEtudiant_SelectedIndexChanged;
        }

        private void CmbEtudiant_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cmbEtudiant.SelectedValue != null)
            {
                int selectedEtudiantId = (int)cmbEtudiant.SelectedValue;
                Etudiant selectedEtudiant = _gestionAcademiqueService.GetEtudiant(selectedEtudiantId);
                if (selectedEtudiant != null)
                {
                    LoadMatieres(selectedEtudiant.ID_Filiere);
                }
            }
        }

        private void LoadMatieres(int idFiliere)
        {
            cmbMatiere.DataSource = _gestionAcademiqueService.GetMatieresByFiliere(idFiliere);
            cmbMatiere.DisplayMember = "NomMatiere";
            cmbMatiere.ValueMember = "ID_Matiere";
        }

        private void dgvNotes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNotes.SelectedRows.Count > 0)
            {
                if (dgvNotes.SelectedRows[0].DataBoundItem is Note selectedNote)
                {
                    cmbEtudiant.SelectedValue = selectedNote.ID_Etudiant;
                    cmbMatiere.SelectedValue = selectedNote.ID_Matiere;
                    numValeur.Value = (decimal)Convert.ToDouble(selectedNote.Valeur);
                    dtpDateNote.Value = selectedNote.DateNote;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Note newNote = new Note
            {
                ID_Etudiant = cmbEtudiant.SelectedValue != null ? (int)cmbEtudiant.SelectedValue : 0,
                ID_Matiere = cmbMatiere.SelectedValue != null ? (int)cmbMatiere.SelectedValue : 0,
                Valeur = (double)numValeur.Value,
                DateNote = dtpDateNote.Value
            };
            _gestionNotesService.AddNote(newNote);
            LoadNotes();
            ClearForm();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvNotes.SelectedRows.Count > 0)
            {
                Note? selectedNote = (Note?)dgvNotes.SelectedRows[0].DataBoundItem;
                selectedNote.ID_Etudiant = cmbEtudiant.SelectedValue != null ? (int)cmbEtudiant.SelectedValue : 0;
                selectedNote.ID_Matiere = cmbMatiere.SelectedValue != null ? (int)cmbMatiere.SelectedValue : 0;
                selectedNote.Valeur = (double)numValeur.Value;
                selectedNote.DateNote = dtpDateNote.Value;
                _gestionNotesService.UpdateNote(selectedNote);
                LoadNotes();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une note à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvNotes.SelectedRows.Count > 0)
            {
                Note? selectedNote = (Note?)dgvNotes.SelectedRows[0].DataBoundItem;
                _gestionNotesService.DeleteNote(selectedNote.ID_Note);
                LoadNotes();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une note à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            cmbEtudiant.SelectedIndex = -1;
            cmbMatiere.SelectedIndex = -1;
            numValeur.Value = 0;
            dtpDateNote.Value = DateTime.Now;
        }
    }
}
