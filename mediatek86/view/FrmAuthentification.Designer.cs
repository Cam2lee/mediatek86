namespace mediatek86.view
{
    partial class FrmAuthentification
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
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPWD = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPWD = new System.Windows.Forms.Label();
            this.buttonConnecter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(134, 82);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(226, 20);
            this.textBoxLogin.TabIndex = 0;
            // 
            // textBoxPWD
            // 
            this.textBoxPWD.Location = new System.Drawing.Point(134, 120);
            this.textBoxPWD.Name = "textBoxPWD";
            this.textBoxPWD.Size = new System.Drawing.Size(226, 20);
            this.textBoxPWD.TabIndex = 1;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(48, 85);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(39, 13);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "Login :";
            // 
            // labelPWD
            // 
            this.labelPWD.AutoSize = true;
            this.labelPWD.Location = new System.Drawing.Point(48, 123);
            this.labelPWD.Name = "labelPWD";
            this.labelPWD.Size = new System.Drawing.Size(80, 13);
            this.labelPWD.TabIndex = 3;
            this.labelPWD.Text = "Mot de passe : ";
            // 
            // buttonConnecter
            // 
            this.buttonConnecter.Location = new System.Drawing.Point(259, 165);
            this.buttonConnecter.Name = "buttonConnecter";
            this.buttonConnecter.Size = new System.Drawing.Size(101, 23);
            this.buttonConnecter.TabIndex = 4;
            this.buttonConnecter.Text = "Se connecter";
            this.buttonConnecter.UseVisualStyleBackColor = true;
            // 
            // FrmAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 250);
            this.Controls.Add(this.buttonConnecter);
            this.Controls.Add(this.labelPWD);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxPWD);
            this.Controls.Add(this.textBoxLogin);
            this.Name = "FrmAuthentification";
            this.Text = "Connexion...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPWD;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPWD;
        private System.Windows.Forms.Button buttonConnecter;
    }
}