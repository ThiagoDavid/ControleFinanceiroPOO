
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.Model
{
    interface DBConnection
    {
        public abstract void SalvarDados(ArrayList Receitas, ArrayList Despesas);
        public abstract void CarregarDados(ArrayList Receitas, ArrayList Despesas);
    }
}
