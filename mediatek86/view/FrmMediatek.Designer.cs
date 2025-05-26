namespace mediatek86
{
    partial class FrmMediatek
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxPersonnel = new System.Windows.Forms.GroupBox();
            this.buttonAbsences = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxAjouter = new System.Windows.Forms.GroupBox();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonEnregistrer = new System.Windows.Forms.Button();
            this.labelService = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.comboBoxService = new System.Windows.Forms.ComboBox();
            this.textTel = new System.Windows.Forms.TextBox();
            this.textMail = new System.Windows.Forms.TextBox();
            this.textPrenom = new System.Windows.Forms.TextBox();
            this.textNom = new System.Windows.Forms.TextBox();
            this.groupBoxPersonnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxAjouter.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPersonnel
            // 
            this.groupBoxPersonnel.Controls.Add(this.buttonAbsences);
            this.groupBoxPersonnel.Controls.Add(this.buttonSupprimer);
            this.groupBoxPersonnel.Controls.Add(this.buttonModifier);
            this.groupBoxPersonnel.Controls.Add(this.dataGridView1);
            this.groupBoxPersonnel.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPersonnel.Name = "groupBoxPersonnel";
            this.groupBoxPersonnel.Size = new System.Drawing.Size(931, 307);
            this.groupBoxPersonnel.TabIndex = 0;
            this.groupBoxPersonnel.TabStop = false;
            this.groupBoxPersonnel.Text = "Personnel";
            // 
            // buttonAbsences
            // 
            this.buttonAbsences.Location = new System.Drawing.Point(806, 260);
            this.buttonAbsences.Name = "buttonAbsences";
            this.buttonAbsences.Size = new System.Drawing.Size(83, 27);
            this.buttonAbsences.TabIndex = 4;
            this.buttonAbsences.Text = "Absences";
            this.buttonAbsences.UseVisualStyleBackColor = true;
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(108, 260);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(83, 27);
            this.buttonSupprimer.TabIndex = 3;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(19, 260);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(83, 27);
            this.buttonModifier.TabIndex = 1;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(870, 235);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBoxAjouter
            // 
            this.groupBoxAjouter.Controls.Add(this.buttonAnnuler);
            this.groupBoxAjouter.Controls.Add(this.buttonEnregistrer);
            this.groupBoxAjouter.Controls.Add(this.labelService);
            this.groupBoxAjouter.Controls.Add(this.labelTel);
            this.groupBoxAjouter.Controls.Add(this.labelMail);
            this.groupBoxAjouter.Controls.Add(this.labelPrenom);
            this.groupBoxAjouter.Controls.Add(this.labelNom);
            this.groupBoxAjouter.Controls.Add(this.comboBoxService);
            this.groupBoxAjouter.Controls.Add(this.textTel);
            this.groupBoxAjouter.Controls.Add(this.textMail);
            this.groupBoxAjouter.Controls.Add(this.textPrenom);
            this.groupBoxAjouter.Controls.Add(this.textNom);
            this.groupBoxAjouter.Location = new System.Drawing.Point(12, 325);
            this.groupBoxAjouter.Name = "groupBoxAjouter";
            this.groupBoxAjouter.Size = new System.Drawing.Size(931, 176);
            this.groupBoxAjouter.TabIndex = 1;
            this.groupBoxAjouter.TabStop = false;
            this.groupBoxAjouter.Text = "Ajouter un membre";
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(108, 137);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 12;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            // 
            // buttonEnregistrer
            // 
            this.buttonEnregistrer.Location = new System.Drawing.Point(25, 137);
            this.buttonEnregistrer.Name = "buttonEnregistrer";
            this.buttonEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.buttonEnregistrer.TabIndex = 11;
            this.buttonEnregistrer.Text = "Enregistrer";
            this.buttonEnregistrer.UseVisualStyleBackColor = true;
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Location = new System.Drawing.Point(482, 102);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(43, 13);
            this.labelService.TabIndex = 10;
            this.labelService.Text = "Service";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(482, 68);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(22, 13);
            this.labelTel.TabIndex = 9;
            this.labelTel.Text = "Tel";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(482, 30);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(26, 13);
            this.labelMail.TabIndex = 8;
            this.labelMail.Text = "Mail";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(22, 65);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(43, 13);
            this.labelPrenom.TabIndex = 7;
            this.labelPrenom.Text = "Prenom";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(21, 30);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(29, 13);
            this.labelNom.TabIndex = 6;
            this.labelNom.Text = "Nom";
            // 
            // comboBoxService
            // 
            this.comboBoxService.FormattingEnabled = true;
            this.comboBoxService.Location = new System.Drawing.Point(531, 99);
            this.comboBoxService.Name = "comboBoxService";
            this.comboBoxService.Size = new System.Drawing.Size(120, 21);
            this.comboBoxService.TabIndex = 4;
            // 
            // textTel
            // 
            this.textTel.Location = new System.Drawing.Point(531, 62);
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(335, 20);
            this.textTel.TabIndex = 3;
            // 
            // textMail
            // 
            this.textMail.Location = new System.Drawing.Point(531, 27);
            this.textMail.Name = "textMail";
            this.textMail.Size = new System.Drawing.Size(335, 20);
            this.textMail.TabIndex = 2;
            // 
            // textPrenom
            // 
            this.textPrenom.Location = new System.Drawing.Point(71, 62);
            this.textPrenom.Name = "textPrenom";
            this.textPrenom.Size = new System.Drawing.Size(335, 20);
            this.textPrenom.TabIndex = 1;
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(71, 27);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(335, 20);
            this.textNom.TabIndex = 0;
            // 
            // FrmMediatek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 521);
            this.Controls.Add(this.groupBoxAjouter);
            this.Controls.Add(this.groupBoxPersonnel);
            this.Name = "FrmMediatek";
            this.Text = "Personnel";
            this.groupBoxPersonnel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxAjouter.ResumeLayout(false);
            this.groupBoxAjouter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPersonnel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.GroupBox groupBoxAjouter;
        private System.Windows.Forms.Label labelService;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.ComboBox comboBoxService;
        private System.Windows.Forms.TextBox textTel;
        private System.Windows.Forms.TextBox textMail;
        private System.Windows.Forms.TextBox textPrenom;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonEnregistrer;
        private System.Windows.Forms.Button buttonAbsences;
    }
}

