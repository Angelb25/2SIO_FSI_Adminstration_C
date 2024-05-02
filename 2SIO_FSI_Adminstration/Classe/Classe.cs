using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SIO_FSI_Adminstration.Classe
{
    internal class Classe
    {
        public int idclasse { get; set; }
        public string libelleclasse { get; set; }

        public Classe(int id, string classe)
        {
            this.idclasse = id;
            this.libelleclasse = classe;
        }
    }
}
