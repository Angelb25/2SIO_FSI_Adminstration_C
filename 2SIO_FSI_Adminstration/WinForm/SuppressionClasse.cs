using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class SuppressionClasse : Form
    {

        List<Classe.Classe> mesClasses = new List<Classe.Classe>();
        NpgsqlConnection maConnexion;
        NpgsqlCommand commande;
        public SuppressionClasse()
        {
            InitializeComponent();
        }

        private void reInitialisation()
        {
            comboBox1.Text = "";
        }

        private void SuppressionClasse_Load(object sender, EventArgs e)
        {
            {
                string connexion = "Server=localhost;Port=5432;Database=fsi_administration;User Id=postgres;Password=Enzo.2508;";
                maConnexion = new NpgsqlConnection(connexion);
                maConnexion.Open();
                string select_classe = "SELECT * from classe;";
                NpgsqlCommand maCommande = new NpgsqlCommand(select_classe, maConnexion);
                NpgsqlDataReader select = maCommande.ExecuteReader();

                while (select.Read())
                {
                    mesClasses.Add(new Classe.Classe(select.GetInt32(0), select.GetString(1)));
                }

                foreach (var classe in mesClasses)
                {
                    comboBox1.Items.Add(classe.libelleclasse);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id_classe = 0;

            foreach (var Classe in mesClasses)
            {
                if (comboBox1.SelectedItem == Classe.libelleclasse)
                {
                    id_classe = Classe.idclasse;
                }
            }



            if (!string.IsNullOrEmpty(comboBox1.Text))
            {


                try
                {
                    string connexion = "Server=localhost;Port=5432;Database=fsi_administration;User Id=postgres;Password=Enzo.2508;";
                    maConnexion = new NpgsqlConnection(connexion);
                    maConnexion.Open();
                    string pufff = "DELETE FROM classe WHERE idclasse = :id_classe";
                    commande = new NpgsqlCommand(pufff, maConnexion);
                    commande.Parameters.Add(new NpgsqlParameter("id_classe", NpgsqlDbType.Integer)).Value = id_classe;
                    commande.ExecuteNonQuery();
                    MessageBox.Show("Classe Supprimé");
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

        private void bouton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
