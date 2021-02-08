namespace ibrahim_bourzgui
{
    partial class ajouteretudiant
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
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.datenaiss = new System.Windows.Forms.DateTimePicker();
            this.rbmasculin = new System.Windows.Forms.RadioButton();
            this.rbfeminin = new System.Windows.Forms.RadioButton();
            this.btnajouter = new System.Windows.Forms.Button();
            this.btnfermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(93, 27);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(191, 20);
            this.txtnumero.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "date de naissance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "sexe";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(93, 76);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(191, 20);
            this.txtnom.TabIndex = 6;
            // 
            // txtprenom
            // 
            this.txtprenom.Location = new System.Drawing.Point(93, 124);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(191, 20);
            this.txtprenom.TabIndex = 7;
            // 
            // datenaiss
            // 
            this.datenaiss.Location = new System.Drawing.Point(84, 181);
            this.datenaiss.Name = "datenaiss";
            this.datenaiss.Size = new System.Drawing.Size(200, 20);
            this.datenaiss.TabIndex = 8;
            // 
            // rbmasculin
            // 
            this.rbmasculin.AutoSize = true;
            this.rbmasculin.Location = new System.Drawing.Point(84, 220);
            this.rbmasculin.Name = "rbmasculin";
            this.rbmasculin.Size = new System.Drawing.Size(66, 17);
            this.rbmasculin.TabIndex = 9;
            this.rbmasculin.TabStop = true;
            this.rbmasculin.Text = "masculin";
            this.rbmasculin.UseVisualStyleBackColor = true;
            // 
            // rbfeminin
            // 
            this.rbfeminin.AutoSize = true;
            this.rbfeminin.Location = new System.Drawing.Point(208, 222);
            this.rbfeminin.Name = "rbfeminin";
            this.rbfeminin.Size = new System.Drawing.Size(58, 17);
            this.rbfeminin.TabIndex = 10;
            this.rbfeminin.TabStop = true;
            this.rbfeminin.Text = "feminin";
            this.rbfeminin.UseVisualStyleBackColor = true;
            // 
            // btnajouter
            // 
            this.btnajouter.Location = new System.Drawing.Point(218, 261);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(75, 23);
            this.btnajouter.TabIndex = 11;
            this.btnajouter.Text = "ajouter";
            this.btnajouter.UseVisualStyleBackColor = true;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // btnfermer
            // 
            this.btnfermer.Location = new System.Drawing.Point(34, 261);
            this.btnfermer.Name = "btnfermer";
            this.btnfermer.Size = new System.Drawing.Size(75, 23);
            this.btnfermer.TabIndex = 12;
            this.btnfermer.Text = "fermer";
            this.btnfermer.UseVisualStyleBackColor = true;
            this.btnfermer.Click += new System.EventHandler(this.btnfermer_Click);
            // 
            // ajouteretudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 296);
            this.Controls.Add(this.btnfermer);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.rbfeminin);
            this.Controls.Add(this.rbmasculin);
            this.Controls.Add(this.datenaiss);
            this.Controls.Add(this.txtprenom);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnumero);
            this.Name = "ajouteretudiant";
            this.Text = "ajouteretudiant";
            this.Load += new System.EventHandler(this.ajouteretudiant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtprenom;
        private System.Windows.Forms.DateTimePicker datenaiss;
        private System.Windows.Forms.RadioButton rbmasculin;
        private System.Windows.Forms.RadioButton rbfeminin;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Button btnfermer;
    }
}