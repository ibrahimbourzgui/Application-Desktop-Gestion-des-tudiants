using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ibrahim_bourzgui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ajouterEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ajouteretudiant frm = new ajouteretudiant();
            frm.Show();
        }

        private void afficherEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afficheretudiant frm = new afficheretudiant();
            frm.Show();
        }
    }
}
