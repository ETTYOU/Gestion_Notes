
namespace ISGA.GestionNotes.UI.Forms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionEtudiantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionFilieresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saisieNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impressionRelevesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistiquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionEtudiantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionFilieresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saisieNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impressionRelevesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionEtudiantsToolStripMenuItem,
            this.gestionFilieresToolStripMenuItem,
            this.saisieNotesToolStripMenuItem,
            this.impressionRelevesToolStripMenuItem,
            this.statistiquesToolStripMenuItem});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.gestionToolStripMenuItem.Text = "Gestion";
            // 
            // gestionEtudiantsToolStripMenuItem
            // 
            this.gestionEtudiantsToolStripMenuItem.Name = "gestionEtudiantsToolStripMenuItem";
            this.gestionEtudiantsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionEtudiantsToolStripMenuItem.Text = "Gestion Etudiants";
            this.gestionEtudiantsToolStripMenuItem.Click += new System.EventHandler(this.gestionEtudiantsToolStripMenuItem_Click);
            // 
            // gestionFilieresToolStripMenuItem
            // 
            this.gestionFilieresToolStripMenuItem.Name = "gestionFilieresToolStripMenuItem";
            this.gestionFilieresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionFilieresToolStripMenuItem.Text = "Gestion Filières";
            this.gestionFilieresToolStripMenuItem.Click += new System.EventHandler(this.gestionFilieresToolStripMenuItem_Click);
            // 
            // saisieNotesToolStripMenuItem
            // 
            this.saisieNotesToolStripMenuItem.Name = "saisieNotesToolStripMenuItem";
            this.saisieNotesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saisieNotesToolStripMenuItem.Text = "Saisie Notes";
            this.saisieNotesToolStripMenuItem.Click += new System.EventHandler(this.saisieNotesToolStripMenuItem_Click);
            // 
            // impressionRelevesToolStripMenuItem
            // 
            this.impressionRelevesToolStripMenuItem.Name = "impressionRelevesToolStripMenuItem";
            this.impressionRelevesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.impressionRelevesToolStripMenuItem.Text = "Impression Relevés";
            this.impressionRelevesToolStripMenuItem.Click += new System.EventHandler(this.impressionRelevesToolStripMenuItem_Click);
            // 
            // statistiquesToolStripMenuItem
            // 
            this.statistiquesToolStripMenuItem.Name = "statistiquesToolStripMenuItem";
            this.statistiquesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.statistiquesToolStripMenuItem.Text = "Statistiques";
            this.statistiquesToolStripMenuItem.Click += new System.EventHandler(this.statistiquesToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
