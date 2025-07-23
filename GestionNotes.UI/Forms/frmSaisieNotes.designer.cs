
namespace ISGA.GestionNotes.UI.Forms
{
    partial class frmSaisieNotes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.Windows.Forms.DataGridView dgvNotes;
        private System.Windows.Forms.Label lblEtudiant;
        private System.Windows.Forms.ComboBox cmbEtudiant;
        private System.Windows.Forms.Label lblMatiere;
        private System.Windows.Forms.ComboBox cmbMatiere;
        private System.Windows.Forms.Label lblValeur;
        private System.Windows.Forms.NumericUpDown numValeur;
        private System.Windows.Forms.Label lblDateNote;
        private System.Windows.Forms.DateTimePicker dtpDateNote;
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
            this.dgvNotes = new System.Windows.Forms.DataGridView();
            this.lblEtudiant = new System.Windows.Forms.Label();
            this.cmbEtudiant = new System.Windows.Forms.ComboBox();
            this.lblMatiere = new System.Windows.Forms.Label();
            this.cmbMatiere = new System.Windows.Forms.ComboBox();
            this.lblValeur = new System.Windows.Forms.Label();
            this.numValeur = new System.Windows.Forms.NumericUpDown();
            this.lblDateNote = new System.Windows.Forms.Label();
            this.dtpDateNote = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValeur)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNotes
            // 
            this.dgvNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotes.Location = new System.Drawing.Point(12, 12);
            this.dgvNotes.Name = "dgvNotes";
            this.dgvNotes.Size = new System.Drawing.Size(776, 200);
            this.dgvNotes.TabIndex = 0;
            this.dgvNotes.SelectionChanged += new System.EventHandler(this.dgvNotes_SelectionChanged);
            // 
            // lblEtudiant
            // 
            this.lblEtudiant.AutoSize = true;
            this.lblEtudiant.Location = new System.Drawing.Point(12, 230);
            this.lblEtudiant.Name = "lblEtudiant";
            this.lblEtudiant.Size = new System.Drawing.Size(49, 13);
            this.lblEtudiant.TabIndex = 1;
            this.lblEtudiant.Text = "Etudiant:";
            // 
            // cmbEtudiant
            // 
            this.cmbEtudiant.FormattingEnabled = true;
            this.cmbEtudiant.Location = new System.Drawing.Point(100, 227);
            this.cmbEtudiant.Name = "cmbEtudiant";
            this.cmbEtudiant.Size = new System.Drawing.Size(200, 21);
            this.cmbEtudiant.TabIndex = 2;
            // 
            // lblMatiere
            // 
            this.lblMatiere.AutoSize = true;
            this.lblMatiere.Location = new System.Drawing.Point(12, 260);
            this.lblMatiere.Name = "lblMatiere";
            this.lblMatiere.Size = new System.Drawing.Size(47, 13);
            this.lblMatiere.TabIndex = 3;
            this.lblMatiere.Text = "Matiere:";
            // 
            // txtMatiere
            // 
            this.cmbMatiere.FormattingEnabled = true;
            this.cmbMatiere.Location = new System.Drawing.Point(100, 257);
            this.cmbMatiere.Name = "cmbMatiere";
            this.cmbMatiere.Size = new System.Drawing.Size(200, 21);
            this.cmbMatiere.TabIndex = 4;
            // 
            // lblValeur
            // 
            this.lblValeur.AutoSize = true;
            this.lblValeur.Location = new System.Drawing.Point(12, 290);
            this.lblValeur.Name = "lblValeur";
            this.lblValeur.Size = new System.Drawing.Size(43, 13);
            this.lblValeur.TabIndex = 5;
            this.lblValeur.Text = "Valeur:";
            // 
            // numValeur
            // 
            this.numValeur.DecimalPlaces = 2;
            this.numValeur.Location = new System.Drawing.Point(100, 287);
            this.numValeur.Name = "numValeur";
            this.numValeur.Size = new System.Drawing.Size(200, 20);
            this.numValeur.TabIndex = 6;
            // 
            // lblDateNote
            // 
            this.lblDateNote.AutoSize = true;
            this.lblDateNote.Location = new System.Drawing.Point(12, 320);
            this.lblDateNote.Name = "lblDateNote";
            this.lblDateNote.Size = new System.Drawing.Size(59, 13);
            this.lblDateNote.TabIndex = 7;
            this.lblDateNote.Text = "Date Note:";
            // 
            // dtpDateNote
            // 
            this.dtpDateNote.Location = new System.Drawing.Point(100, 317);
            this.dtpDateNote.Name = "dtpDateNote";
            this.dtpDateNote.Size = new System.Drawing.Size(200, 20);
            this.dtpDateNote.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 360);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(100, 360);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(188, 360);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmSaisieNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpDateNote);
            this.Controls.Add(this.lblDateNote);
            this.Controls.Add(this.numValeur);
            this.Controls.Add(this.lblValeur);
            this.Controls.Add(this.cmbMatiere);
            this.Controls.Add(this.lblMatiere);
            this.Controls.Add(this.cmbEtudiant);
            this.Controls.Add(this.lblEtudiant);
            this.Controls.Add(this.dgvNotes);
            this.Name = "frmSaisieNotes";
            this.Text = "Saisie Notes";
            this.Load += new System.EventHandler(this.frmSaisieNotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValeur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
