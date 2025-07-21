namespace ISGA.GestionNotes.UI.Forms
{
    partial class frmGestionFilieres
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.Windows.Forms.DataGridView dgvFilieres;
        private System.Windows.Forms.Label lblNomFiliere;
        private System.Windows.Forms.TextBox txtNomFiliere;
        private System.Windows.Forms.Label lblCycle;
        private System.Windows.Forms.TextBox txtCycle;
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
            this.dgvFilieres = new System.Windows.Forms.DataGridView();
            this.lblNomFiliere = new System.Windows.Forms.Label();
            this.txtNomFiliere = new System.Windows.Forms.TextBox();
            this.lblCycle = new System.Windows.Forms.Label();
            this.txtCycle = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilieres)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFilieres
            // 
            this.dgvFilieres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilieres.Location = new System.Drawing.Point(12, 12);
            this.dgvFilieres.Name = "dgvFilieres";
            this.dgvFilieres.Size = new System.Drawing.Size(776, 200);
            this.dgvFilieres.TabIndex = 0;
            this.dgvFilieres.SelectionChanged += new System.EventHandler(this.dgvFilieres_SelectionChanged);
            // 
            // lblNomFiliere
            // 
            this.lblNomFiliere.AutoSize = true;
            this.lblNomFiliere.Location = new System.Drawing.Point(12, 230);
            this.lblNomFiliere.Name = "lblNomFiliere";
            this.lblNomFiliere.Size = new System.Drawing.Size(69, 13);
            this.lblNomFiliere.TabIndex = 1;
            this.lblNomFiliere.Text = "Nom Filiere:";
            // 
            // txtNomFiliere
            // 
            this.txtNomFiliere.Location = new System.Drawing.Point(100, 227);
            this.txtNomFiliere.Name = "txtNomFiliere";
            this.txtNomFiliere.Size = new System.Drawing.Size(200, 20);
            this.txtNomFiliere.TabIndex = 2;
            // 
            // lblCycle
            // 
            this.lblCycle.AutoSize = true;
            this.lblCycle.Location = new System.Drawing.Point(12, 260);
            this.lblCycle.Name = "lblCycle";
            this.lblCycle.Size = new System.Drawing.Size(37, 13);
            this.lblCycle.TabIndex = 3;
            this.lblCycle.Text = "Cycle:";
            // 
            // txtCycle
            // 
            this.txtCycle.Location = new System.Drawing.Point(100, 257);
            this.txtCycle.Name = "txtCycle";
            this.txtCycle.Size = new System.Drawing.Size(200, 20);
            this.txtCycle.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 300);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(100, 300);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(188, 300);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmGestionFilieres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCycle);
            this.Controls.Add(this.lblCycle);
            this.Controls.Add(this.txtNomFiliere);
            this.Controls.Add(this.lblNomFiliere);
            this.Controls.Add(this.dgvFilieres);
            this.Name = "frmGestionFilieres";
            this.Text = "Gestion Filières";
            this.Load += new System.EventHandler(this.frmGestionFilieres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilieres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
