using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SIO_FSI_Adminstration.Classe
{
    public class Etudiant
    {
        private int idEtudiant;
        private string nomEtudiant;
        private string prenomEtudiant;
        private string classeEtudiant;
        private string tel;
        private string email;
        private string adress;


        public Etudiant(int id, string nom, string prenom, string classeEtudiant, string telephone, string adressemail, string adresspostale)
        {
            this.idEtudiant = id;
            this.nomEtudiant = nom;
            this.prenomEtudiant = prenom;
            this.classeEtudiant = classeEtudiant;
            this.tel = telephone;
            this.email = adressemail;
            this.adress = adresspostale;
        }



        public int IdEtudiant { get => idEtudiant; set => idEtudiant = value; }
        public string NomEtudiant { get => nomEtudiant; set => nomEtudiant = value; }
        public string PrenomEtudiant { get => prenomEtudiant; set => prenomEtudiant = value; }

        public string telephone { get => tel; set => tel = value; }

        public string adressemail { get => email; set => email = value; }

        public string adresspostal { get => adress; set => adress = value; }

        public string ClasseEtudiant { get => classeEtudiant; set => classeEtudiant = value; }

        public override string ToString()
        {
            return "Etudiant " + NomEtudiant;

        }
    }
}
