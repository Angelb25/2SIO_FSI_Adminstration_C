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

namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class ModifClasse : Form
    {


        List<Classe.Classe> mesClasses = new List<Classe.Classe>();
        NpgsqlConnection maConnexion;
        NpgsqlCommand commande, classe_query;
        private NpgsqlConnection classeConnexion;
        public ModifClasse()
        {
            InitializeComponent();
            string connexion_classe = "Server=localhost;Port=5432;Database=fsi_administratuin;User Id=postgres;Password=Enzo.2508;";
            string select_classe = "SELECT * from classe;";
            classeConnexion = new NpgsqlConnection(connexion_classe);
            classeConnexion.Open();
            classe_query = new NpgsqlCommand(select_classe, classeConnexion);
            NpgsqlDataReader ajouter = classe_query.ExecuteReader();


            while (ajouter.Read())
            {

                mesClasses.Add(new Classe.Classe(ajouter.GetInt32(0), ajouter.GetString(1)));

            }

            foreach (var Classe in mesClasses)
            {
                comboBox1.Items.Add(Classe.libelleclasse);
            }

        }

        private void reInitialisation()
        {
            tbAENom.Text = "";
        }

        private void bouton1_Click(object sender, EventArgs e)
        {
            reInitialisation();
        }

        private void bouton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string textclasse = "";



            foreach (var Cours in mesClasses)
            {
                if (comboBox1.SelectedItem == Cours.libelleclasse)
                {

                    textclasse = Cours.libelleclasse;

                }
            }


            tbAENom.Text = textclasse.ToString();
        }

        private void bouton2_Click(object sender, EventArgs e)
        {
            int id_classe = 0;
            string premon = tbAENom.Text;
            foreach (var Cours in mesClasses)
            {
                if (comboBox1.SelectedItem == Cours.libelleclasse)
                {

                    id_classe = Cours.idclasse;
                }
            }


            string connexion = "Server=localhost;Port=5432;Database=fsi_administration;User Id=postgres;Password=Enzo.2508;";
            maConnexion = new NpgsqlConnection(connexion);
            maConnexion.Open();
            string pufff = " UPDATE classe SET libelleclasse = @FirstName WHERE idclasse = :3 ; ";
            commande = new NpgsqlCommand(pufff, maConnexion);
            commande.Parameters.Add(new NpgsqlParameter("@FirstName", NpgsqlDbType.Varchar)).Value = premon;
            commande.Parameters.Add(new NpgsqlParameter("3", NpgsqlDbType.Integer)).Value = id_classe;
            commande.Prepare();
            commande.CommandType = CommandType.Text;
            commande.ExecuteNonQuery();

            MessageBox.Show("Classe modifier");
        }
    }

}

