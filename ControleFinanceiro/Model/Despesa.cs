using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Model
{
    public class Despesa : Lancamento
    {
        public Despesa()
        {
        }
        public Despesa(string descricao, double value, DateTime date) : base(descricao, value, date) { }

    }
}
