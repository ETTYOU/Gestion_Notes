namespace ISGA.GestionNotes.UI.Forms
{
    partial class frmLogin
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
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            chkRemember = new CheckBox();
            btnLogin = new Button();
            btnQuit = new Button();
            lblError = new Label();
            card = new Panel();
            header = new Panel();
            lblLogo = new Label();
            lblTitle = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            card.SuspendLayout();
            header.SuspendLayout();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(20, 160);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(360, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(20, 220);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(360, 27);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // chkRemember
            // 
            chkRemember.AutoSize = true;
            chkRemember.Location = new Point(20, 280);
            chkRemember.Name = "chkRemember";
            chkRemember.Size = new Size(157, 24);
            chkRemember.TabIndex = 7;
            chkRemember.Text = "Se souvenir de moi";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(227, 6, 19);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(20, 320);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(165, 40);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Connexion";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnQuit
            // 
            btnQuit.BackColor = Color.FromArgb(90, 90, 90);
            btnQuit.FlatStyle = FlatStyle.Flat;
            btnQuit.ForeColor = Color.White;
            btnQuit.Location = new Point(215, 320);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(165, 40);
            btnQuit.TabIndex = 9;
            btnQuit.Text = "Quitter";
            btnQuit.UseVisualStyleBackColor = false;
            // 
            // lblError
            // 
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(20, 250);
            lblError.Name = "lblError";
            lblError.Size = new Size(360, 20);
            lblError.TabIndex = 6;
            // 
            // card
            // 
            card.Anchor = AnchorStyles.None;
            card.BackColor = Color.White;
            card.BorderStyle = BorderStyle.FixedSingle;
            card.Controls.Add(header);
            card.Controls.Add(lblTitle);
            card.Controls.Add(lblEmail);
            card.Controls.Add(txtEmail);
            card.Controls.Add(lblPassword);
            card.Controls.Add(txtPassword);
            card.Controls.Add(lblError);
            card.Controls.Add(chkRemember);
            card.Controls.Add(btnLogin);
            card.Controls.Add(btnQuit);
            card.Location = new Point(536, 40);
            card.Name = "card";
            card.Padding = new Padding(20);
            card.Size = new Size(400, 430);
            card.TabIndex = 0;
            // 
            // header
            // 
            header.BackColor = Color.FromArgb(33, 37, 41);
            header.Controls.Add(lblLogo);
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(400, 80);
            header.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.BackColor = Color.FromArgb(227, 6, 19);
            lblLogo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(166, 10);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(79, 37);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "ISGA";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            lblLogo.Click += lblLogo_Click;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(33, 37, 41);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(0, 100, 0, 20);
            lblTitle.Size = new Size(358, 23);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Système de gestion des notes";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(20, 140);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(360, 20);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email d'utilisateur";
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(20, 200);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(360, 20);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Mot de passe";
            // 
            // frmLogin
            // 
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(941, 503);
            Controls.Add(card);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Authentification ISGA";
            card.ResumeLayout(false);
            card.PerformLayout();
            header.ResumeLayout(false);
            header.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkRemember;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Panel card;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
    }
}