namespace mediatek86.view
{
    partial class FrmAbsence
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
            this.buttonEnregistrer = new System.Windows.Forms.Button();
            this.labelTel = new System.Windows.Forms.Label();
            this.groupBoxAjouter = new System.Windows.Forms.GroupBox();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.labelDatedebut = new System.Windows.Forms.Label();
            this.labelMotifAbsences = new System.Windows.Forms.Label();
            this.buttonSupprimerAbsences = new System.Windows.Forms.Button();
            this.buttonModifierAbsences = new System.Windows.Forms.Button();
            this.groupBoxAbsences = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxMotif = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFin = new System.Windows.Forms.DateTimePicker();
            this.groupBoxAjouter.SuspendLayout();
            this.groupBoxAbsences.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEnregistrer
            // 
            this.buttonEnregistrer.Location = new System.Drawing.Point(25, 103);
            this.buttonEnregistrer.Name = "buttonEnregistrer";
            this.buttonEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.buttonEnregistrer.TabIndex = 11;
            this.buttonEnregistrer.Text = "Enregistrer";
            this.buttonEnregistrer.UseVisualStyleBackColor = true;
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(447, 66);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(59, 13);
            this.labelTel.TabIndex = 9;
            this.labelTel.Text = "Date de fin";
            // 
            // groupBoxAjouter
            // 
            this.groupBoxAjouter.Controls.Add(this.dateTimeFin);
            this.groupBoxAjouter.Controls.Add(this.dateTimePicker1);
            this.groupBoxAjouter.Controls.Add(this.comboBoxMotif);
            this.groupBoxAjouter.Controls.Add(this.buttonAnnuler);
            this.groupBoxAjouter.Controls.Add(this.buttonEnregistrer);
            this.groupBoxAjouter.Controls.Add(this.labelTel);
            this.groupBoxAjouter.Controls.Add(this.labelDatedebut);
            this.groupBoxAjouter.Controls.Add(this.labelMotifAbsences);
            this.groupBoxAjouter.Location = new System.Drawing.Point(12, 325);
            this.groupBoxAjouter.Name = "groupBoxAjouter";
            this.groupBoxAjouter.Size = new System.Drawing.Size(931, 137);
            this.groupBoxAjouter.TabIndex = 3;
            this.groupBoxAjouter.TabStop = false;
            this.groupBoxAjouter.Text = "Ajouter une absence";
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(108, 103);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 12;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            // 
            // labelDatedebut
            // 
            this.labelDatedebut.AutoSize = true;
            this.labelDatedebut.Location = new System.Drawing.Point(447, 30);
            this.labelDatedebut.Name = "labelDatedebut";
            this.labelDatedebut.Size = new System.Drawing.Size(78, 13);
            this.labelDatedebut.TabIndex = 8;
            this.labelDatedebut.Text = "Date de début ";
            // 
            // labelMotifAbsences
            // 
            this.labelMotifAbsences.AutoSize = true;
            this.labelMotifAbsences.Location = new System.Drawing.Point(26, 30);
            this.labelMotifAbsences.Name = "labelMotifAbsences";
            this.labelMotifAbsences.Size = new System.Drawing.Size(30, 13);
            this.labelMotifAbsences.TabIndex = 7;
            this.labelMotifAbsences.Text = "Motif";
            // 
            // buttonSupprimerAbsences
            // 
            this.buttonSupprimerAbsences.Location = new System.Drawing.Point(108, 260);
            this.buttonSupprimerAbsences.Name = "buttonSupprimerAbsences";
            this.buttonSupprimerAbsences.Size = new System.Drawing.Size(83, 27);
            this.buttonSupprimerAbsences.TabIndex = 3;
            this.buttonSupprimerAbsences.Text = "Supprimer";
            this.buttonSupprimerAbsences.UseVisualStyleBackColor = true;
            // 
            // buttonModifierAbsences
            // 
            this.buttonModifierAbsences.Location = new System.Drawing.Point(19, 260);
            this.buttonModifierAbsences.Name = "buttonModifierAbsences";
            this.buttonModifierAbsences.Size = new System.Drawing.Size(83, 27);
            this.buttonModifierAbsences.TabIndex = 1;
            this.buttonModifierAbsences.Text = "Modifier";
            this.buttonModifierAbsences.UseVisualStyleBackColor = true;
            // 
            // groupBoxAbsences
            // 
            this.groupBoxAbsences.Controls.Add(this.buttonSupprimerAbsences);
            this.groupBoxAbsences.Controls.Add(this.buttonModifierAbsences);
            this.groupBoxAbsences.Controls.Add(this.dataGridView1);
            this.groupBoxAbsences.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAbsences.Name = "groupBoxAbsences";
            this.groupBoxAbsences.Size = new System.Drawing.Size(931, 307);
            this.groupBoxAbsences.TabIndex = 2;
            this.groupBoxAbsences.TabStop = false;
            this.groupBoxAbsences.Text = "Liste des absences";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(870, 235);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBoxMotif
            // 
            this.comboBoxMotif.FormattingEnabled = true;
            this.comboBoxMotif.Location = new System.Drawing.Point(71, 27);
            this.comboBoxMotif.Name = "comboBoxMotif";
            this.comboBoxMotif.Size = new System.Drawing.Size(149, 21);
            this.comboBoxMotif.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(531, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // dateTimeFin
            // 
            this.dateTimeFin.Location = new System.Drawing.Point(531, 63);
            this.dateTimeFin.Name = "dateTimeFin";
            this.dateTimeFin.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFin.TabIndex = 16;
            // 
            // FrmAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 483);
            this.Controls.Add(this.groupBoxAjouter);
            this.Controls.Add(this.groupBoxAbsences);
            this.Name = "FrmAbsence";
            this.Text = "Absence";
            this.groupBoxAjouter.ResumeLayout(false);
            this.groupBoxAjouter.PerformLayout();
            this.groupBoxAbsences.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEnregistrer;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.GroupBox groupBoxAjouter;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Label labelDatedebut;
        private System.Windows.Forms.Label labelMotifAbsences;
        private System.Windows.Forms.Button buttonSupprimerAbsences;
        private System.Windows.Forms.Button buttonModifierAbsences;
        private System.Windows.Forms.GroupBox groupBoxAbsences;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxMotif;
        private System.Windows.Forms.DateTimePicker dateTimeFin;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}