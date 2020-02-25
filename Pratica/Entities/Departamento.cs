using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica.Entities
{
    public class Departamento
    {
        public string NomeDepart { get; set; }

        /// <summary>
        /// Informe o nome do departamento
        /// </summary>
        /// <param name="nomeDepart">nome do departamento</param>
        public Departamento(string nomeDepart)
        {
            this.NomeDepart = nomeDepart;
        }
    }
}
