namespace ibrahim_bourzgui
{
    partial class afficheretudiant
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
            this.dgvafficher = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvafficher)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvafficher
            // 
            this.dgvafficher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvafficher.Location = new System.Drawing.Point(3, 43);
            this.dgvafficher.Name = "dgvafficher";
            this.dgvafficher.Size = new System.Drawing.Size(425, 186);
            this.dgvafficher.TabIndex = 0;
            this.dgvafficher.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvafficher_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "fermer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "liste des etudiants";
            // 
            // afficheretudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvafficher);
            this.Name = "afficheretudiant";
            this.Text = "afficheretudiant";
            this.Load += new System.EventHandler(this.afficheretudiant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvafficher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvafficher;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}