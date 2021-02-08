namespace ibrahim_bourzgui
{
    partial class ajouterprojet
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtintitule = new System.Windows.Forms.TextBox();
            this.datedebut = new System.Windows.Forms.DateTimePicker();
            this.datefin = new System.Windows.Forms.DateTimePicker();
            this.btnfermer = new System.Windows.Forms.Button();
            this.btnajouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "intitule";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "date de fin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "date de debut";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(114, 6);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 20);
            this.txtnumero.TabIndex = 5;
            // 
            // txtintitule
            // 
            this.txtintitule.Location = new System.Drawing.Point(114, 51);
            this.txtintitule.Name = "txtintitule";
            this.txtintitule.Size = new System.Drawing.Size(100, 20);
            this.txtintitule.TabIndex = 6;
            // 
            // datedebut
            // 
            this.datedebut.Location = new System.Drawing.Point(114, 98);
            this.datedebut.Name = "datedebut";
            this.datedebut.Size = new System.Drawing.Size(200, 20);
            this.datedebut.TabIndex = 7;
            // 
            // datefin
            // 
            this.datefin.Location = new System.Drawing.Point(114, 141);
            this.datefin.Name = "datefin";
            this.datefin.Size = new System.Drawing.Size(200, 20);
            this.datefin.TabIndex = 8;
            this.datefin.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // btnfermer
            // 
            this.btnfermer.Location = new System.Drawing.Point(32, 225);
            this.btnfermer.Name = "btnfermer";
            this.btnfermer.Size = new System.Drawing.Size(75, 23);
            this.btnfermer.TabIndex = 10;
            this.btnfermer.Text = "Fermer";
            this.btnfermer.UseVisualStyleBackColor = true;
            // 
            // btnajouter
            // 
            this.btnajouter.Location = new System.Drawing.Point(239, 225);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(75, 23);
            this.btnajouter.TabIndex = 11;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = true;
            // 
            // ajouterprojet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 264);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.btnfermer);
            this.Controls.Add(this.datefin);
            this.Controls.Add(this.datedebut);
            this.Controls.Add(this.txtintitule);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ajouterprojet";
            this.Text = "ajouterprojet";
            this.Load += new System.EventHandler(this.ajouterprojet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.TextBox txtintitule;
        private System.Windows.Forms.DateTimePicker datedebut;
        private System.Windows.Forms.DateTimePicker datefin;
        private System.Windows.Forms.Button btnfermer;
        private System.Windows.Forms.Button btnajouter;
    }
}