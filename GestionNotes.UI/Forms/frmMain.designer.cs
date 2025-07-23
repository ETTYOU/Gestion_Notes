using System.Windows.Forms;

namespace ISGA.GestionNotes.UI.Forms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnStatistiques = new System.Windows.Forms.Button();
            this.btnImpressionReleves = new System.Windows.Forms.Button();
            this.btnSaisieNotes = new System.Windows.Forms.Button();
            this.btnGestionFilieres = new System.Windows.Forms.Button();
            this.btnGestionEtudiants = new System.Windows.Forms.Button();
            this.btnTableauDeBord = new System.Windows.Forms.Button();
            this.lblLogoISGA = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.mainContentPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanelStats = new System.Windows.Forms.FlowLayoutPanel();
            this.cardEtudiants = new System.Windows.Forms.Panel();
            this.lblValueEtudiants = new System.Windows.Forms.Label();
            this.lblTitleEtudiants = new System.Windows.Forms.Label();
            this.pbEtudiants = new System.Windows.Forms.PictureBox();
            this.cardFilieres = new System.Windows.Forms.Panel();
            this.lblValueFilieres = new System.Windows.Forms.Label();
            this.lblTitleFilieres = new System.Windows.Forms.Label();
            this.pbFilieres = new System.Windows.Forms.PictureBox();
            this.cardNotes = new System.Windows.Forms.Panel();
            this.lblValueNotes = new System.Windows.Forms.Label();
            this.lblTitleNotes = new System.Windows.Forms.Label();
            this.pbNotes = new System.Windows.Forms.PictureBox();
            this.cardUtilisateurs = new System.Windows.Forms.Panel();
            this.lblValueUtilisateurs = new System.Windows.Forms.Label();
            this.lblTitleUtilisateurs = new System.Windows.Forms.Label();
            this.pbUtilisateurs = new System.Windows.Forms.PictureBox();
            this.lblWelcomeSubtitle = new System.Windows.Forms.Label();
            this.lblWelcomeTitle = new System.Windows.Forms.Label();
            this.sidebarPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.mainContentPanel.SuspendLayout();
            this.flowLayoutPanelStats.SuspendLayout();
            this.cardEtudiants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEtudiants)).BeginInit();
            this.cardFilieres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilieres)).BeginInit();
            this.cardNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes)).BeginInit();
            this.cardUtilisateurs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUtilisateurs)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.White;
            this.sidebarPanel.Controls.Add(this.btnQuitter);
            this.sidebarPanel.Controls.Add(this.btnStatistiques);
            this.sidebarPanel.Controls.Add(this.btnImpressionReleves);
            this.sidebarPanel.Controls.Add(this.btnSaisieNotes);
            this.sidebarPanel.Controls.Add(this.btnGestionFilieres);
            this.sidebarPanel.Controls.Add(this.btnGestionEtudiants);
            this.sidebarPanel.Controls.Add(this.btnTableauDeBord);
            this.sidebarPanel.Controls.Add(this.lblLogoISGA);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(200, 450);
            this.sidebarPanel.TabIndex = 0;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuitter.FlatAppearance.BorderSize = 0;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuitter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnQuitter.Location = new System.Drawing.Point(0, 350);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnQuitter.Size = new System.Drawing.Size(200, 50);
            this.btnQuitter.TabIndex = 7;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // btnStatistiques
            // 
            this.btnStatistiques.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatistiques.FlatAppearance.BorderSize = 0;
            this.btnStatistiques.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistiques.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStatistiques.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnStatistiques.Location = new System.Drawing.Point(0, 300);
            this.btnStatistiques.Name = "btnStatistiques";
            this.btnStatistiques.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnStatistiques.Size = new System.Drawing.Size(200, 50);
            this.btnStatistiques.TabIndex = 6;
            this.btnStatistiques.Text = "Statistiques";
            this.btnStatistiques.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistiques.UseVisualStyleBackColor = true;
            // 
            // btnImpressionReleves
            // 
            this.btnImpressionReleves.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImpressionReleves.FlatAppearance.BorderSize = 0;
            this.btnImpressionReleves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImpressionReleves.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnImpressionReleves.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnImpressionReleves.Location = new System.Drawing.Point(0, 250);
            this.btnImpressionReleves.Name = "btnImpressionReleves";
            this.btnImpressionReleves.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnImpressionReleves.Size = new System.Drawing.Size(200, 50);
            this.btnImpressionReleves.TabIndex = 5;
            this.btnImpressionReleves.Text = "Impression Relevés";
            this.btnImpressionReleves.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImpressionReleves.UseVisualStyleBackColor = true;
            // 
            // btnSaisieNotes
            // 
            this.btnSaisieNotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSaisieNotes.FlatAppearance.BorderSize = 0;
            this.btnSaisieNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaisieNotes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaisieNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnSaisieNotes.Location = new System.Drawing.Point(0, 200);
            this.btnSaisieNotes.Name = "btnSaisieNotes";
            this.btnSaisieNotes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSaisieNotes.Size = new System.Drawing.Size(200, 50);
            this.btnSaisieNotes.TabIndex = 4;
            this.btnSaisieNotes.Text = "Saisie Notes";
            this.btnSaisieNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaisieNotes.UseVisualStyleBackColor = true;
            // 
            // btnGestionFilieres
            // 
            this.btnGestionFilieres.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionFilieres.FlatAppearance.BorderSize = 0;
            this.btnGestionFilieres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionFilieres.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGestionFilieres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnGestionFilieres.Location = new System.Drawing.Point(0, 150);
            this.btnGestionFilieres.Name = "btnGestionFilieres";
            this.btnGestionFilieres.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGestionFilieres.Size = new System.Drawing.Size(200, 50);
            this.btnGestionFilieres.TabIndex = 3;
            this.btnGestionFilieres.Text = "Gestion Filières";
            this.btnGestionFilieres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionFilieres.UseVisualStyleBackColor = true;
            // 
            // btnGestionEtudiants
            // 
            this.btnGestionEtudiants.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionEtudiants.FlatAppearance.BorderSize = 0;
            this.btnGestionEtudiants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionEtudiants.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGestionEtudiants.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnGestionEtudiants.Location = new System.Drawing.Point(0, 100);
            this.btnGestionEtudiants.Name = "btnGestionEtudiants";
            this.btnGestionEtudiants.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGestionEtudiants.Size = new System.Drawing.Size(200, 50);
            this.btnGestionEtudiants.TabIndex = 2;
            this.btnGestionEtudiants.Text = "Gestion Étudiants";
            this.btnGestionEtudiants.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionEtudiants.UseVisualStyleBackColor = true;
            // 
            // btnTableauDeBord
            // 
            this.btnTableauDeBord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(6)))), ((int)(((byte)(19)))));
            this.btnTableauDeBord.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTableauDeBord.FlatAppearance.BorderSize = 0;
            this.btnTableauDeBord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTableauDeBord.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTableauDeBord.ForeColor = System.Drawing.Color.White;
            this.btnTableauDeBord.Location = new System.Drawing.Point(0, 50);
            this.btnTableauDeBord.Name = "btnTableauDeBord";
            this.btnTableauDeBord.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTableauDeBord.Size = new System.Drawing.Size(200, 50);
            this.btnTableauDeBord.TabIndex = 1;
            this.btnTableauDeBord.Text = "Tableau de bord";
            this.btnTableauDeBord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTableauDeBord.UseVisualStyleBackColor = false;
            // 
            // lblLogoISGA
            // 
            this.lblLogoISGA.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogoISGA.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogoISGA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(6)))), ((int)(((byte)(19)))));
            this.lblLogoISGA.Location = new System.Drawing.Point(0, 0);
            this.lblLogoISGA.Name = "lblLogoISGA";
            this.lblLogoISGA.Size = new System.Drawing.Size(200, 50);
            this.lblLogoISGA.TabIndex = 0;
            this.lblLogoISGA.Text = "ISGA";
            this.lblLogoISGA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.Controls.Add(this.lblAdmin);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(200, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(600, 50);
            this.headerPanel.TabIndex = 1;
            // 
            // lblAdmin
            // 
            this.lblAdmin.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblAdmin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdmin.Location = new System.Drawing.Point(450, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblAdmin.Size = new System.Drawing.Size(150, 50);
            this.lblAdmin.TabIndex = 0;
            this.lblAdmin.Text = "Administrateur";
            this.lblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // contentPanel
            // 
            this.mainContentPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.mainContentPanel.Controls.Add(this.flowLayoutPanelStats);
            this.mainContentPanel.Controls.Add(this.lblWelcomeSubtitle);
            this.mainContentPanel.Controls.Add(this.lblWelcomeTitle);
            this.mainContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContentPanel.Location = new System.Drawing.Point(200, 50);
            this.mainContentPanel.Name = "mainContentPanel";
            this.mainContentPanel.Padding = new System.Windows.Forms.Padding(20);
            this.mainContentPanel.Size = new System.Drawing.Size(600, 400);
            this.mainContentPanel.TabIndex = 2;
            // 
            // flowLayoutPanelStats
            // 
            this.flowLayoutPanelStats.Controls.Add(this.cardEtudiants);
            this.flowLayoutPanelStats.Controls.Add(this.cardFilieres);
            this.flowLayoutPanelStats.Controls.Add(this.cardNotes);
            this.flowLayoutPanelStats.Controls.Add(this.cardUtilisateurs);
            this.flowLayoutPanelStats.Location = new System.Drawing.Point(20, 120);
            this.flowLayoutPanelStats.Name = "flowLayoutPanelStats";
            this.flowLayoutPanelStats.Size = new System.Drawing.Size(560, 260);
            this.flowLayoutPanelStats.TabIndex = 2;
            this.flowLayoutPanelStats.WrapContents = false;
            // 
            // cardEtudiants
            // 
            this.cardEtudiants.BackColor = System.Drawing.Color.White;
            this.cardEtudiants.Controls.Add(this.lblValueEtudiants);
            this.cardEtudiants.Controls.Add(this.lblTitleEtudiants);
            this.cardEtudiants.Controls.Add(this.pbEtudiants);
            this.cardEtudiants.Location = new System.Drawing.Point(3, 3);
            this.cardEtudiants.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.cardEtudiants.Name = "cardEtudiants";
            this.cardEtudiants.Size = new System.Drawing.Size(200, 80);
            this.cardEtudiants.TabIndex = 0;
            // 
            // lblValueEtudiants
            // 
            this.lblValueEtudiants.AutoSize = true;
            this.lblValueEtudiants.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValueEtudiants.Location = new System.Drawing.Point(80, 40);
            this.lblValueEtudiants.Name = "lblValueEtudiants";
            this.lblValueEtudiants.Size = new System.Drawing.Size(57, 28);
            this.lblValueEtudiants.TabIndex = 2;
            this.lblValueEtudiants.Text = "1,248";
            // 
            // lblTitleEtudiants
            // 
            this.lblTitleEtudiants.AutoSize = true;
            this.lblTitleEtudiants.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleEtudiants.Location = new System.Drawing.Point(80, 15);
            this.lblTitleEtudiants.Name = "lblTitleEtudiants";
            this.lblTitleEtudiants.Size = new System.Drawing.Size(70, 20);
            this.lblTitleEtudiants.TabIndex = 1;
            this.lblTitleEtudiants.Text = "Étudiants";
            // 
            // pbEtudiants
            // 
            this.pbEtudiants.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(6)))), ((int)(((byte)(19)))));
            this.pbEtudiants.Location = new System.Drawing.Point(0, 0);
            this.pbEtudiants.Name = "pbEtudiants";
            this.pbEtudiants.Size = new System.Drawing.Size(70, 80);
            this.pbEtudiants.TabIndex = 0;
            this.pbEtudiants.TabStop = false;
            // 
            // cardFilieres
            // 
            this.cardFilieres.BackColor = System.Drawing.Color.White;
            this.cardFilieres.Controls.Add(this.lblValueFilieres);
            this.cardFilieres.Controls.Add(this.lblTitleFilieres);
            this.cardFilieres.Controls.Add(this.pbFilieres);
            this.cardFilieres.Location = new System.Drawing.Point(216, 3);
            this.cardFilieres.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.cardFilieres.Name = "cardFilieres";
            this.cardFilieres.Size = new System.Drawing.Size(200, 80);
            this.cardFilieres.TabIndex = 1;
            // 
            // lblValueFilieres
            // 
            this.lblValueFilieres.AutoSize = true;
            this.lblValueFilieres.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValueFilieres.Location = new System.Drawing.Point(80, 40);
            this.lblValueFilieres.Name = "lblValueFilieres";
            this.lblValueFilieres.Size = new System.Drawing.Size(34, 28);
            this.lblValueFilieres.TabIndex = 2;
            this.lblValueFilieres.Text = "12";
            // 
            // lblTitleFilieres
            // 
            this.lblTitleFilieres.AutoSize = true;
            this.lblTitleFilieres.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleFilieres.Location = new System.Drawing.Point(80, 15);
            this.lblTitleFilieres.Name = "lblTitleFilieres";
            this.lblTitleFilieres.Size = new System.Drawing.Size(55, 20);
            this.lblTitleFilieres.TabIndex = 1;
            this.lblTitleFilieres.Text = "Filières";
            // 
            // pbFilieres
            // 
            this.pbFilieres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.pbFilieres.Location = new System.Drawing.Point(0, 0);
            this.pbFilieres.Name = "pbFilieres";
            this.pbFilieres.Size = new System.Drawing.Size(70, 80);
            this.pbFilieres.TabIndex = 0;
            this.pbFilieres.TabStop = false;
            // 
            // cardNotes
            // 
            this.cardNotes.BackColor = System.Drawing.Color.White;
            this.cardNotes.Controls.Add(this.lblValueNotes);
            this.cardNotes.Controls.Add(this.lblTitleNotes);
            this.cardNotes.Controls.Add(this.pbNotes);
            this.cardNotes.Location = new System.Drawing.Point(429, 3);
            this.cardNotes.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.cardNotes.Name = "cardNotes";
            this.cardNotes.Size = new System.Drawing.Size(200, 80);
            this.cardNotes.TabIndex = 2;
            // 
            // lblValueNotes
            // 
            this.lblValueNotes.AutoSize = true;
            this.lblValueNotes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValueNotes.Location = new System.Drawing.Point(80, 40);
            this.lblValueNotes.Name = "lblValueNotes";
            this.lblValueNotes.Size = new System.Drawing.Size(49, 28);
            this.lblValueNotes.TabIndex = 2;
            this.lblValueNotes.Text = "500";
            // 
            // lblTitleNotes
            // 
            this.lblTitleNotes.AutoSize = true;
            this.lblTitleNotes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleNotes.Location = new System.Drawing.Point(80, 15);
            this.lblTitleNotes.Name = "lblTitleNotes";
            this.lblTitleNotes.Size = new System.Drawing.Size(49, 20);
            this.lblTitleNotes.TabIndex = 1;
            this.lblTitleNotes.Text = "Notes";
            // 
            // pbNotes
            // 
            this.pbNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.pbNotes.Location = new System.Drawing.Point(0, 0);
            this.pbNotes.Name = "pbNotes";
            this.pbNotes.Size = new System.Drawing.Size(70, 80);
            this.pbNotes.TabIndex = 0;
            this.pbNotes.TabStop = false;
            // 
            // cardUtilisateurs
            // 
            this.cardUtilisateurs.BackColor = System.Drawing.Color.White;
            this.cardUtilisateurs.Controls.Add(this.lblValueUtilisateurs);
            this.cardUtilisateurs.Controls.Add(this.lblTitleUtilisateurs);
            this.cardUtilisateurs.Controls.Add(this.pbUtilisateurs);
            this.cardUtilisateurs.Location = new System.Drawing.Point(3, 89);
            this.cardUtilisateurs.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.cardUtilisateurs.Name = "cardUtilisateurs";
            this.cardUtilisateurs.Size = new System.Drawing.Size(200, 80);
            this.cardUtilisateurs.TabIndex = 3;
            // 
            // lblValueUtilisateurs
            // 
            this.lblValueUtilisateurs.AutoSize = true;
            this.lblValueUtilisateurs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValueUtilisateurs.Location = new System.Drawing.Point(80, 40);
            this.lblValueUtilisateurs.Name = "lblValueUtilisateurs";
            this.lblValueUtilisateurs.Size = new System.Drawing.Size(23, 28);
            this.lblValueUtilisateurs.TabIndex = 2;
            this.lblValueUtilisateurs.Text = "5";
            // 
            // lblTitleUtilisateurs
            // 
            this.lblTitleUtilisateurs.AutoSize = true;
            this.lblTitleUtilisateurs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleUtilisateurs.Location = new System.Drawing.Point(80, 15);
            this.lblTitleUtilisateurs.Name = "lblTitleUtilisateurs";
            this.lblTitleUtilisateurs.Size = new System.Drawing.Size(84, 20);
            this.lblTitleUtilisateurs.TabIndex = 1;
            this.lblTitleUtilisateurs.Text = "Utilisateurs";
            // 
            // pbUtilisateurs
            // 
            this.pbUtilisateurs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.pbUtilisateurs.Location = new System.Drawing.Point(0, 0);
            this.pbUtilisateurs.Name = "pbUtilisateurs";
            this.pbUtilisateurs.Size = new System.Drawing.Size(70, 80);
            this.pbUtilisateurs.TabIndex = 0;
            this.pbUtilisateurs.TabStop = false;
            // 
            // lblWelcomeSubtitle
            // 
            this.lblWelcomeSubtitle.AutoSize = true;
            this.lblWelcomeSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWelcomeSubtitle.Location = new System.Drawing.Point(20, 60);
            this.lblWelcomeSubtitle.Name = "lblWelcomeSubtitle";
            this.lblWelcomeSubtitle.Size = new System.Drawing.Size(539, 23);
            this.lblWelcomeSubtitle.TabIndex = 1;
            this.lblWelcomeSubtitle.Text = "Gestion académique intégrée pour L'Institut supérieur d'ingénierie et des affaires";
            // 
            // lblWelcomeTitle
            // 
            this.lblWelcomeTitle.AutoSize = true;
            this.lblWelcomeTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWelcomeTitle.Location = new System.Drawing.Point(20, 20);
            this.lblWelcomeTitle.Name = "lblWelcomeTitle";
            this.lblWelcomeTitle.Size = new System.Drawing.Size(370, 37);
            this.lblWelcomeTitle.TabIndex = 0;
            this.lblWelcomeTitle.Text = "Bienvenue dans le système ISGA";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainContentPanel);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.sidebarPanel);
            this.Name = "frmMain";
            this.Text = "Gestion des Notes ISGA";
            this.sidebarPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.mainContentPanel.ResumeLayout(false);
            this.mainContentPanel.PerformLayout();
            this.flowLayoutPanelStats.ResumeLayout(false);
            this.cardEtudiants.ResumeLayout(false);
            this.cardEtudiants.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEtudiants)).EndInit();
            this.cardFilieres.ResumeLayout(false);
            this.cardFilieres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilieres)).EndInit();
            this.cardNotes.ResumeLayout(false);
            this.cardNotes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes)).EndInit();
            this.cardUtilisateurs.ResumeLayout(false);
            this.cardUtilisateurs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUtilisateurs)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnStatistiques;
        private System.Windows.Forms.Button btnImpressionReleves;
        private System.Windows.Forms.Button btnSaisieNotes;
        private System.Windows.Forms.Button btnGestionFilieres;
        private System.Windows.Forms.Button btnGestionEtudiants;
        private System.Windows.Forms.Button btnTableauDeBord;
        private System.Windows.Forms.Label lblLogoISGA;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Panel mainContentPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelStats;
        private System.Windows.Forms.Panel cardEtudiants;
        private System.Windows.Forms.Label lblValueEtudiants;
        private System.Windows.Forms.Label lblTitleEtudiants;
        private System.Windows.Forms.PictureBox pbEtudiants;
        private System.Windows.Forms.Panel cardFilieres;
        private System.Windows.Forms.Label lblValueFilieres;
        private System.Windows.Forms.Label lblTitleFilieres;
        private System.Windows.Forms.PictureBox pbFilieres;
        private System.Windows.Forms.Panel cardNotes;
        private System.Windows.Forms.Label lblValueNotes;
        private System.Windows.Forms.Label lblTitleNotes;
        private System.Windows.Forms.PictureBox pbNotes;
        private System.Windows.Forms.Panel cardUtilisateurs;
        private System.Windows.Forms.Label lblValueUtilisateurs;
        private System.Windows.Forms.Label lblTitleUtilisateurs;
        private System.Windows.Forms.PictureBox pbUtilisateurs;
        private System.Windows.Forms.Label lblWelcomeSubtitle;
        private System.Windows.Forms.Label lblWelcomeTitle;
        #endregion
    }
}