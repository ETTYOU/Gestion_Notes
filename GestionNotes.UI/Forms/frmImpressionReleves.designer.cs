namespace ISGA.GestionNotes.UI.Forms
{
    partial class frmImpressionReleves
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.Windows.Forms.Label lblEtudiant;
        private System.Windows.Forms.ComboBox cmbEtudiant;
        private System.Windows.Forms.Button btnGenererReleve;
        private System.Windows.Forms.RichTextBox rtbReleve;
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
            this.lblEtudiant = new System.Windows.Forms.Label();
            this.cmbEtudiant = new System.Windows.Forms.ComboBox();
            this.btnGenererReleve = new System.Windows.Forms.Button();
            this.rtbReleve = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblEtudiant
            // 
            this.lblEtudiant.AutoSize = true;
            this.lblEtudiant.Location = new System.Drawing.Point(12, 15);
            this.lblEtudiant.Name = "lblEtudiant";
            this.lblEtudiant.Size = new System.Drawing.Size(49, 13);
            this.lblEtudiant.TabIndex = 0;
            this.lblEtudiant.Text = "Etudiant:";
            // 
            // cmbEtudiant
            // 
            this.cmbEtudiant.FormattingEnabled = true;
            this.cmbEtudiant.Location = new System.Drawing.Point(67, 12);
            this.cmbEtudiant.Name = "cmbEtudiant";
            this.cmbEtudiant.Size = new System.Drawing.Size(200, 21);
            this.cmbEtudiant.TabIndex = 1;
            // 
            // btnGenererReleve
            // 
            this.btnGenererReleve.Location = new System.Drawing.Point(280, 10);
            this.btnGenererReleve.Name = "btnGenererReleve";
            this.btnGenererReleve.Size = new System.Drawing.Size(120, 23);
            this.btnGenererReleve.TabIndex = 2;
            this.btnGenererReleve.Text = "Générer Relevé";
            this.btnGenererReleve.UseVisualStyleBackColor = true;
            this.btnGenererReleve.Click += new System.EventHandler(this.btnGenererReleve_Click);
            // 
            // rtbReleve
            // 
            this.rtbReleve.Location = new System.Drawing.Point(12, 45);
            this.rtbReleve.Name = "rtbReleve";
            this.rtbReleve.Size = new System.Drawing.Size(776, 393);
            this.rtbReleve.TabIndex = 3;
            this.rtbReleve.Text = "";
            // 
            // frmImpressionReleves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbReleve);
            this.Controls.Add(this.btnGenererReleve);
            this.Controls.Add(this.cmbEtudiant);
            this.Controls.Add(this.lblEtudiant);
            this.Name = "frmImpressionReleves";
            this.Text = "Impression Relevés";
            this.Load += new System.EventHandler(this.frmImpressionReleves_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
