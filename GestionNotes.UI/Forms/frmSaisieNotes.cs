
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
            dgvNotes.DataSource = _gestionNotesService.GetAllNotes();
        }

        private void LoadEtudiants()
        {
            cmbEtudiant.DataSource = _gestionAcademiqueService.GetAllEtudiants();
            cmbEtudiant.DisplayMember = "Nom"; // Assuming Etudiant has a 'Nom' property
            cmbEtudiant.ValueMember = "ID_Etudiant";
        }

        private void dgvNotes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNotes.SelectedRows.Count > 0)
            {
                Note selectedNote = (Note)dgvNotes.SelectedRows[0].DataBoundItem;
                cmbEtudiant.SelectedValue = selectedNote.ID_Etudiant;
                txtMatiere.Text = selectedNote.Matiere;
                numValeur.Value = (decimal)selectedNote.Valeur;
                dtpDateNote.Value = selectedNote.DateNote;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Note newNote = new Note
            {
                ID_Etudiant = (int)cmbEtudiant.SelectedValue,
                Matiere = txtMatiere.Text,
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
                Note selectedNote = (Note)dgvNotes.SelectedRows[0].DataBoundItem;
                selectedNote.ID_Etudiant = (int)cmbEtudiant.SelectedValue;
                selectedNote.Matiere = txtMatiere.Text;
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
                Note selectedNote = (Note)dgvNotes.SelectedRows[0].DataBoundItem;
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
            txtMatiere.Text = string.Empty;
            numValeur.Value = 0;
            dtpDateNote.Value = DateTime.Now;
        }
    }
}
