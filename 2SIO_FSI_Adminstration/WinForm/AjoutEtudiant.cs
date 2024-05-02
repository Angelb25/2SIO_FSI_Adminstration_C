using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class AjoutEtudiant : Form
    {
        NpgsqlConnection maConnexion;
        NpgsqlCommand commande;
        public AjoutEtudiant()
        {
            InitializeComponent();
            //Contrôle de la connexion
            string Conx = "Server=localhost;Port=5432;Database=fsi_administration;User Id=postgres;Password=Enzo.2508;";
            NpgsqlConnection MyCnx = new NpgsqlConnection(Conx);
            MyCnx = new NpgsqlConnection(Conx);
            MyCnx.Open();
            string select = "SELECT * FROM section";
            NpgsqlCommand MyCmd = new NpgsqlCommand(select, MyCnx);
            NpgsqlDataReader dr = MyCmd.ExecuteReader();

            List<Classe.Classe> mesClasses = new List<Classe.Classe>();
            while (dr.Read())
            {
                // Création de l'objet classe
                int idClasse = dr.GetInt32(0);
                string libelleclasse = dr.GetString(1);

                Classe.Classe uneClasse = new Classe.Classe(idClasse, libelleclasse);
                mesClasses.Add(uneClasse);

            }

            //Affichage dans le dataGridView
            foreach (Classe.Classe classe in mesClasses)
            {
                cbClasse.Items.Add(classe.libelleclasse);

            }


            MyCnx.Close();
        }

        private NpgsqlCommand GetCommande()
        {
            return commande;
        }

        private void bouton3_Click(object sender, EventArgs e, NpgsqlCommand commande)
        {
            string a = tbAENom.Text;
            string z = tbAEPrenom.Text;



            if (!string.IsNullOrEmpty(tbAENom.Text) && !string.IsNullOrEmpty(tbAEPrenom.Text))
            {
                try
                {
                    string connexion = "Server=localhost;Port=5432;Database=fsi_administration;User Id=postgres;Password=Enzo.2508;";
                    maConnexion = new NpgsqlConnection(connexion);
                    maConnexion = new NpgsqlConnection(connexion);
                    maConnexion.Open();
                    string pufff = "INSERT INTO etudiant (nomEtudiant, prenometudiant, idSection) values ( :1, :2, :3);";
                    commande = new NpgsqlCommand(pufff, maConnexion);
                    commande.Parameters.Add(new NpgsqlParameter("1", NpgsqlDbType.Varchar)).Value = a;
                    commande.Parameters.Add(new NpgsqlParameter("2", NpgsqlDbType.Varchar)).Value = z;
                    commande.Prepare();
                    commande.CommandType = CommandType.Text;
                    commande.ExecuteNonQuery();
                    MessageBox.Show("Etudiant ajouté");
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
        private void reInitialisation()
        {
            tbAENom.Text = "";
            tbAEPrenom.Text = "";
            cbClasse.Text = "";
        }

        private void bouton1_Click(object sender, EventArgs e)
        {
            reInitialisation();
        }

        private void bouton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
