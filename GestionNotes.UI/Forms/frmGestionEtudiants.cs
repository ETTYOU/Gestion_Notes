
using ISGA.GestionNotes.BO;
using ISGA.GestionNotes.BLL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ISGA.GestionNotes.UI.Forms
{
    public partial class frmGestionEtudiants : Form
    {
        private GestionAcademiqueService _gestionAcademiqueService;

        public frmGestionEtudiants()
        {
            InitializeComponent();
            _gestionAcademiqueService = new GestionAcademiqueService();
        }

        private void frmGestionEtudiants_Load(object sender, EventArgs e)
        {
            LoadEtudiants();
            LoadFilieres();
        }

        private void LoadEtudiants()
        {
            dgvEtudiants.DataSource = _gestionAcademiqueService.GetAllEtudiants();
        }

        private void LoadFilieres()
        {
            cmbFiliere.DataSource = _gestionAcademiqueService.GetAllFilieres();
            cmbFiliere.DisplayMember = "NomFiliere";
            cmbFiliere.ValueMember = "ID_Filiere";
        }

        private void dgvEtudiants_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEtudiants.SelectedRows.Count > 0)
            {
                Etudiant selectedEtudiant = (Etudiant)dgvEtudiants.SelectedRows[0].DataBoundItem;
                txtMatricule.Text = selectedEtudiant.Matricule;
                txtNom.Text = selectedEtudiant.Nom;
                txtPrenom.Text = selectedEtudiant.Prenom;
                dtpDateNaissance.Value = selectedEtudiant.DateNaissance;
                cmbFiliere.SelectedValue = selectedEtudiant.ID_Filiere;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Etudiant newEtudiant = new Etudiant
            {
                Matricule = txtMatricule.Text,
                Nom = txtNom.Text,
                Prenom = txtPrenom.Text,
                DateNaissance = dtpDateNaissance.Value,
                ID_Filiere = (int)cmbFiliere.SelectedValue
            };
            _gestionAcademiqueService.AddEtudiant(newEtudiant);
            LoadEtudiants();
            ClearForm();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvEtudiants.SelectedRows.Count > 0)
            {
                Etudiant selectedEtudiant = (Etudiant)dgvEtudiants.SelectedRows[0].DataBoundItem;
                selectedEtudiant.Matricule = txtMatricule.Text;
                selectedEtudiant.Nom = txtNom.Text;
                selectedEtudiant.Prenom = txtPrenom.Text;
                selectedEtudiant.DateNaissance = dtpDateNaissance.Value;
                selectedEtudiant.ID_Filiere = (int)cmbFiliere.SelectedValue;
                _gestionAcademiqueService.UpdateEtudiant(selectedEtudiant);
                LoadEtudiants();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un étudiant à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEtudiants.SelectedRows.Count > 0)
            {
                Etudiant selectedEtudiant = (Etudiant)dgvEtudiants.SelectedRows[0].DataBoundItem;
                _gestionAcademiqueService.DeleteEtudiant(selectedEtudiant.ID_Etudiant);
                LoadEtudiants();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un étudiant à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            txtMatricule.Text = string.Empty;
            txtNom.Text = string.Empty;
            txtPrenom.Text = string.Empty;
            dtpDateNaissance.Value = DateTime.Now;
            cmbFiliere.SelectedIndex = -1;
        }
    }
}
