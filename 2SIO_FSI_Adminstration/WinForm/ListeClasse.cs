using _2SIO_FSI_Adminstration.Classe;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class ListeClasses : Form

    {
        Utilisateur x;
        public ListeClasses(Utilisateur utiConnecte)
        {
            InitializeComponent();
            x = utiConnecte;

            // Contrôle de la connexion
            string Conx = "Server=localhost;Port=5432;Database=fsi_administration;User Id=postgres;Password=Enzo.2508;";
            NpgsqlConnection MyCnx = new NpgsqlConnection(Conx);
            MyCnx.Open();

            // Requête pour récupérer la liste des classes
            string select = "SELECT * FROM section;";
            NpgsqlCommand MyCmd = new NpgsqlCommand(select, MyCnx);
            NpgsqlDataReader dr = MyCmd.ExecuteReader();
            List<Classe.Classe> mesClasses = new List<Classe.Classe>();
            while (dr.Read())
            {
                int idClasse = dr.GetInt32(0);
                string libelleClasse = dr.GetString(1);
                Classe.Classe uneClasse = new Classe.Classe(idClasse, libelleClasse);
                mesClasses.Add(uneClasse);

            }


            // Affichage dans le DataGridView
            foreach (Classe.Classe classe in mesClasses)
            {
                dgvClasse.Rows.Add(classe.libelleclasse);


            }

            MyCnx.Close();
        }

        private void bFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
