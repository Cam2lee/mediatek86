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
            this.groupBoxAjouterAbs = new System.Windows.Forms.GroupBox();
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDebut = new System.Windows.Forms.DateTimePicker();
            this.comboBoxMotif = new System.Windows.Forms.ComboBox();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.labelDatedebut = new System.Windows.Forms.Label();
            this.labelMotifAbsences = new System.Windows.Forms.Label();
            this.buttonSupprimerAbsences = new System.Windows.Forms.Button();
            this.buttonModifierAbsences = new System.Windows.Forms.Button();
            this.groupBoxAbsences = new System.Windows.Forms.GroupBox();
            this.dataGridViewAbsence = new System.Windows.Forms.DataGridView();
            this.groupBoxAjouterAbs.SuspendLayout();
            this.groupBoxAbsences.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbsence)).BeginInit();
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
            this.buttonEnregistrer.Click += new System.EventHandler(this.buttonEnregistrer_Click);
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
            // groupBoxAjouterAbs
            // 
            this.groupBoxAjouterAbs.Controls.Add(this.dateTimePickerFin);
            this.groupBoxAjouterAbs.Controls.Add(this.dateTimePickerDebut);
            this.groupBoxAjouterAbs.Controls.Add(this.comboBoxMotif);
            this.groupBoxAjouterAbs.Controls.Add(this.buttonAnnuler);
            this.groupBoxAjouterAbs.Controls.Add(this.buttonEnregistrer);
            this.groupBoxAjouterAbs.Controls.Add(this.labelTel);
            this.groupBoxAjouterAbs.Controls.Add(this.labelDatedebut);
            this.groupBoxAjouterAbs.Controls.Add(this.labelMotifAbsences);
            this.groupBoxAjouterAbs.Location = new System.Drawing.Point(12, 325);
            this.groupBoxAjouterAbs.Name = "groupBoxAjouterAbs";
            this.groupBoxAjouterAbs.Size = new System.Drawing.Size(931, 137);
            this.groupBoxAjouterAbs.TabIndex = 3;
            this.groupBoxAjouterAbs.TabStop = false;
            this.groupBoxAjouterAbs.Text = "Ajouter une absence";
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.Location = new System.Drawing.Point(531, 63);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFin.TabIndex = 16;
            // 
            // dateTimePickerDebut
            // 
            this.dateTimePickerDebut.Location = new System.Drawing.Point(531, 27);
            this.dateTimePickerDebut.Name = "dateTimePickerDebut";
            this.dateTimePickerDebut.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDebut.TabIndex = 15;
            // 
            // comboBoxMotif
            // 
            this.comboBoxMotif.FormattingEnabled = true;
            this.comboBoxMotif.Location = new System.Drawing.Point(71, 27);
            this.comboBoxMotif.Name = "comboBoxMotif";
            this.comboBoxMotif.Size = new System.Drawing.Size(149, 21);
            this.comboBoxMotif.TabIndex = 14;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(108, 103);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 12;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
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
            this.buttonSupprimerAbsences.Click += new System.EventHandler(this.buttonSupprimerAbsences_Click);
            // 
            // buttonModifierAbsences
            // 
            this.buttonModifierAbsences.Location = new System.Drawing.Point(19, 260);
            this.buttonModifierAbsences.Name = "buttonModifierAbsences";
            this.buttonModifierAbsences.Size = new System.Drawing.Size(83, 27);
            this.buttonModifierAbsences.TabIndex = 1;
            this.buttonModifierAbsences.Text = "Modifier";
            this.buttonModifierAbsences.UseVisualStyleBackColor = true;
            this.buttonModifierAbsences.Click += new System.EventHandler(this.buttonModifierAbsences_Click);
            // 
            // groupBoxAbsences
            // 
            this.groupBoxAbsences.Controls.Add(this.buttonSupprimerAbsences);
            this.groupBoxAbsences.Controls.Add(this.buttonModifierAbsences);
            this.groupBoxAbsences.Controls.Add(this.dataGridViewAbsence);
            this.groupBoxAbsences.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAbsences.Name = "groupBoxAbsences";
            this.groupBoxAbsences.Size = new System.Drawing.Size(931, 307);
            this.groupBoxAbsences.TabIndex = 2;
            this.groupBoxAbsences.TabStop = false;
            this.groupBoxAbsences.Text = "Liste des absences";
            // 
            // dataGridViewAbsence
            // 
            this.dataGridViewAbsence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAbsence.Location = new System.Drawing.Point(19, 19);
            this.dataGridViewAbsence.MultiSelect = false;
            this.dataGridViewAbsence.Name = "dataGridViewAbsence";
            this.dataGridViewAbsence.ReadOnly = true;
            this.dataGridViewAbsence.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAbsence.Size = new System.Drawing.Size(870, 235);
            this.dataGridViewAbsence.TabIndex = 0;
            // 
            // FrmAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 483);
            this.Controls.Add(this.groupBoxAjouterAbs);
            this.Controls.Add(this.groupBoxAbsences);
            this.Name = "FrmAbsence";
            this.Text = "Absence";
            this.groupBoxAjouterAbs.ResumeLayout(false);
            this.groupBoxAjouterAbs.PerformLayout();
            this.groupBoxAbsences.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbsence)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEnregistrer;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.GroupBox groupBoxAjouterAbs;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Label labelDatedebut;
        private System.Windows.Forms.Label labelMotifAbsences;
        private System.Windows.Forms.Button buttonSupprimerAbsences;
        private System.Windows.Forms.Button buttonModifierAbsences;
        private System.Windows.Forms.GroupBox groupBoxAbsences;
        private System.Windows.Forms.DataGridView dataGridViewAbsence;
        private System.Windows.Forms.ComboBox comboBoxMotif;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerDebut;
    }
}