
using ISGA.GestionNotes.BO;
using ISGA.GestionNotes.BLL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ISGA.GestionNotes.UI.Forms
{
    public partial class frmGestionFilieres : Form
    {
        private GestionAcademiqueService _gestionAcademiqueService;

        public frmGestionFilieres()
        {
            InitializeComponent();
            _gestionAcademiqueService = new GestionAcademiqueService();
        }

        private void frmGestionFilieres_Load(object sender, EventArgs e)
        {
            LoadFilieres();
        }

        private void LoadFilieres()
        {
            dgvFilieres.DataSource = _gestionAcademiqueService.GetAllFilieres();
        }

        private void dgvFilieres_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFilieres.SelectedRows.Count > 0)
            {
                Filiere selectedFiliere = (Filiere)dgvFilieres.SelectedRows[0].DataBoundItem;
                txtNomFiliere.Text = selectedFiliere.NomFiliere;
                txtCycle.Text = selectedFiliere.Cycle;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Filiere newFiliere = new Filiere
            {
                NomFiliere = txtNomFiliere.Text,
                Cycle = txtCycle.Text
            };
            _gestionAcademiqueService.AddFiliere(newFiliere);
            LoadFilieres();
            ClearForm();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvFilieres.SelectedRows.Count > 0)
            {
                Filiere selectedFiliere = (Filiere)dgvFilieres.SelectedRows[0].DataBoundItem;
                selectedFiliere.NomFiliere = txtNomFiliere.Text;
                selectedFiliere.Cycle = txtCycle.Text;
                _gestionAcademiqueService.UpdateFiliere(selectedFiliere);
                LoadFilieres();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une filière à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvFilieres.SelectedRows.Count > 0)
            {
                Filiere selectedFiliere = (Filiere)dgvFilieres.SelectedRows[0].DataBoundItem;
                _gestionAcademiqueService.DeleteFiliere(selectedFiliere.ID_Filiere);
                LoadFilieres();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une filière à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            txtNomFiliere.Text = string.Empty;
            txtCycle.Text = string.Empty;
        }
    }
}
