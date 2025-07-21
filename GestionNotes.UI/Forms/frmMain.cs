
using System.Windows.Forms;

namespace ISGA.GestionNotes.UI.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(frmMain_FormClosing);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void gestionEtudiantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionEtudiants frm = new frmGestionEtudiants();
            frm.Show();
        }

        private void gestionFilieresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionFilieres frm = new frmGestionFilieres();
            frm.Show();
        }

        private void saisieNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaisieNotes frm = new frmSaisieNotes();
            frm.Show();
        }

        private void impressionRelevesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImpressionReleves frm = new frmImpressionReleves();
            frm.Show();
        }

        private void statistiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStatistiques frm = new frmStatistiques();
            frm.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
