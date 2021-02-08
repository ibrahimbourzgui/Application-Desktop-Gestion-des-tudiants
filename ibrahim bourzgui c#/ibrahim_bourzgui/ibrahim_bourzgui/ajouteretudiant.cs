using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ibrahim_bourzgui
{
    public partial class ajouteretudiant : Form
    {
        SqlConnection cnx = new SqlConnection(@"server=IBRBOU;database=gestion_projets;integrated security=true");
        public ajouteretudiant()
        {
            InitializeComponent();
        }

        private void btnfermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ajouteretudiant_Load(object sender, EventArgs e)
        {

        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            int age = (DateTime.Now.Year) - (datenaiss.Value.Year);
            if (age > 16 && age < 30) 
            {
                char sexe = 'm';
                if ((bool)rbfeminin.Checked) sexe = 'f';
                SqlCommand cmd = new SqlCommand("insert into etudiant values('"+txtnumero.Text+"','"+txtnom.Text+"','"+txtprenom.Text+"','"+datenaiss.Value.Year+"','"+sexe+"')", cnx);
                cnx.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("l'etudiant est ajouté");
                cnx.Close();
            }
            else
            {
                MessageBox.Show("vous n'avez pas l'age requis");
            }
        }
    }
}
