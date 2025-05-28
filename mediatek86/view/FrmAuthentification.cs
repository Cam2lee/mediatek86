using mediatek86.modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mediatek86.dal;
using mediatek86.controller;

namespace mediatek86.view
{
    /// <summary>
    /// Fenêtre d'Authentification, les personnes ayant un login peuvent se connecter afin d'acceder à l'application
    /// </summary>
    public partial class FrmAuthentification : Form
    {
        private FrmAuthentificationController controller;
        /// <summary>
        /// Consrtuction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FrmAuthentification()
        {
            InitializeComponent();
            controller = new FrmAuthentificationController();
        }

        /// <summary>
        /// Bouton pour se connecter (vérifie si les champs sont bien remplis puis se ferme si tout est OK)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConnecter_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string pwd = textBoxPWD.Text;

            if (controller.ControleAuthentification(login, pwd))
            {
                this.Hide();
                FrmMediatek frmMediatek = new FrmMediatek();
                frmMediatek.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login ou mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
