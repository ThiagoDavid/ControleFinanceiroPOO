using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro
{
    public class Lucro : Transacao
    {
        public Lucro()
        {
            Tipo = "lucro";
        }

        public string Tipo { get; set; }
    }
}
