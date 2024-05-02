using _2SIO_FSI_Adminstration.Classe;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class SuppressionEtudiant : Form
    {

        List<Etudiant> mesEtudiant = new List<Etudiant>();
        NpgsqlConnection maConnexion;
        NpgsqlCommand commande;
        public SuppressionEtudiant()
        {
            InitializeComponent();
        }

        private void SuppressionEtudiant_Load(object sender, EventArgs e)
        {
            {
                string connexion = "Server=localhost;Port=5432;Database=fsi_administration;User Id=postgres;Password=Enzo.2508;";
                maConnexion = new NpgsqlConnection(connexion);
                maConnexion.Open();
                string select_classe = "SELECT * from etudiant;";
                NpgsqlCommand maCommande = new NpgsqlCommand(select_classe, maConnexion);
                NpgsqlDataReader select = maCommande.ExecuteReader();

                while (select.Read())
                {
                    mesEtudiant.Add(new Etudiant(select.GetInt32(0), select.GetString(1), select.GetString(2), select.GetInt32(3).ToString(), select.GetString(4), select.GetString(5), select.GetString(6)));
                }

                foreach (var classe in mesEtudiant)
                {
                    comboBox1.Items.Add(classe.NomEtudiant);
                }
            }
        }

        private void bouton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void reInitialisation()
        {
            comboBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id_etudiant = 0;

            foreach (var Etudiant in mesEtudiant)
            {
                if (comboBox1.SelectedItem == Etudiant.NomEtudiant)
                {
                    id_etudiant = Etudiant.IdEtudiant;
                }
            }

            if (!string.IsNullOrEmpty(comboBox1.Text))
            {


                try
                {
                    string connexion = "Server=localhost;Port=5432;Database=fsi_administration;User Id=postgres;Password=Enzo.2508;";
                    maConnexion = new NpgsqlConnection(connexion);
                    maConnexion.Open();
                    string pufff = "DELETE FROM etudiant WHERE idetudiant = :id_etudiant";
                    commande = new NpgsqlCommand(pufff, maConnexion);
                    commande.Parameters.Add(new NpgsqlParameter("id_etudiant", NpgsqlDbType.Integer)).Value = id_etudiant;
                    commande.ExecuteNonQuery();


                    MessageBox.Show("Etudiant supprimé");
                    reInitialisation();
                }
                finally
                {
                    if (commande != null) commande.Dispose();
                    if (maConnexion != null) maConnexion.Close();
                }
            }
            else
            {
                MessageBox.Show("Remplir les champs");

            }
        }
    }
}
