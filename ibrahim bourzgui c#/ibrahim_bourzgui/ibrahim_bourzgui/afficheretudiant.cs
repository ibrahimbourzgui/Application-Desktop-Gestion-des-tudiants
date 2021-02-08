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
    public partial class afficheretudiant : Form
    {
        SqlConnection cnx = new SqlConnection(@"server=IBRBOU;database=gestion_projets;integrated security=true");
        public afficheretudiant()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvafficher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        private void afficheretudiant_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("afficher", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            cnx.Open();
            dt.Load(cmd.ExecuteReader());
            cnx.Close();
            dgvafficher.DataSource = dt;
        }
    }
}
