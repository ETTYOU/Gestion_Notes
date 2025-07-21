namespace ISGA.GestionNotes.UI.Forms
{
    partial class frmGestionEtudiants
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.Windows.Forms.DataGridView dgvEtudiants;
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblDateNaissance;
        private System.Windows.Forms.DateTimePicker dtpDateNaissance;
        private System.Windows.Forms.Label lblFiliere;
        private System.Windows.Forms.ComboBox cmbFiliere;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
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
            this.components = new System.ComponentModel.Container();
            this.dgvEtudiants = new System.Windows.Forms.DataGridView();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblDateNaissance = new System.Windows.Forms.Label();
            this.dtpDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.lblFiliere = new System.Windows.Forms.Label();
            this.cmbFiliere = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtudiants)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEtudiants
            // 
            this.dgvEtudiants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEtudiants.Location = new System.Drawing.Point(12, 12);
            this.dgvEtudiants.Name = "dgvEtudiants";
            this.dgvEtudiants.Size = new System.Drawing.Size(776, 200);
            this.dgvEtudiants.TabIndex = 0;
            this.dgvEtudiants.SelectionChanged += new System.EventHandler(this.dgvEtudiants_SelectionChanged);
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Location = new System.Drawing.Point(12, 230);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(53, 13);
            this.lblMatricule.TabIndex = 1;
            this.lblMatricule.Text = "Matricule:";
            // 
            // txtMatricule
            // 
            this.txtMatricule.Location = new System.Drawing.Point(100, 227);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(200, 20);
            this.txtMatricule.TabIndex = 2;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(12, 260);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(32, 13);
            this.lblNom.TabIndex = 3;
            this.lblNom.Text = "Nom:";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(100, 257);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(200, 20);
            this.txtNom.TabIndex = 4;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(12, 290);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(46, 13);
            this.lblPrenom.TabIndex = 5;
            this.lblPrenom.Text = "Prenom:";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(100, 287);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(200, 20);
            this.txtPrenom.TabIndex = 6;
            // 
            // lblDateNaissance
            // 
            this.lblDateNaissance.AutoSize = true;
            this.lblDateNaissance.Location = new System.Drawing.Point(12, 320);
            this.lblDateNaissance.Name = "lblDateNaissance";
            this.lblDateNaissance.Size = new System.Drawing.Size(82, 13);
            this.lblDateNaissance.TabIndex = 7;
            this.lblDateNaissance.Text = "Date Naissance:";
            // 
            // dtpDateNaissance
            // 
            this.dtpDateNaissance.Location = new System.Drawing.Point(100, 317);
            this.dtpDateNaissance.Name = "dtpDateNaissance";
            this.dtpDateNaissance.Size = new System.Drawing.Size(200, 20);
            this.dtpDateNaissance.TabIndex = 8;
            // 
            // lblFiliere
            // 
            this.lblFiliere.AutoSize = true;
            this.lblFiliere.Location = new System.Drawing.Point(12, 350);
            this.lblFiliere.Name = "lblFiliere";
            this.lblFiliere.Size = new System.Drawing.Size(42, 13);
            this.lblFiliere.TabIndex = 9;
            this.lblFiliere.Text = "Filiere:";
            // 
            // cmbFiliere
            // 
            this.cmbFiliere.FormattingEnabled = true;
            this.cmbFiliere.Location = new System.Drawing.Point(100, 347);
            this.cmbFiliere.Name = "cmbFiliere";
            this.cmbFiliere.Size = new System.Drawing.Size(200, 21);
            this.cmbFiliere.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 390);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(100, 390);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(188, 390);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmGestionEtudiants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbFiliere);
            this.Controls.Add(this.lblFiliere);
            this.Controls.Add(this.dtpDateNaissance);
            this.Controls.Add(this.lblDateNaissance);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtMatricule);
            this.Controls.Add(this.lblMatricule);
            this.Controls.Add(this.dgvEtudiants);
            this.Name = "frmGestionEtudiants";
            this.Text = "Gestion Etudiants";
            this.Load += new System.EventHandler(this.frmGestionEtudiants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtudiants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
