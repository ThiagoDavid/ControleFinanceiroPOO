using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro
{
    internal class HomeViewController
    {
        DadosLancamento dados;

        internal DadosLancamento Dados { get => dados; set => dados = value; }

        public HomeViewController()
        {
            Dados = new DadosLancamento();
        }

        public void Add(Lancamento lancamento)
        {
            Console.WriteLine($"DEBUG - {lancamento.GetType()} Adicionado");
            Dados.Add(lancamento);
        }

        public void UpdateData(Lancamento lancamento , int index)
        {
            if (lancamento.GetType().Equals(typeof(ControleFinanceiro.Despesa)))
            {
                Dados.Despesas[index] = lancamento;
                Console.WriteLine("Debug: DESPESA ATUALIZADA!!!");
            }
            else if (lancamento.GetType().Equals(typeof(ControleFinanceiro.Receita)))
            {
                Dados.Receitas[index] = lancamento;
                Console.WriteLine("Debug: RECEITA ATUALIZADA!!!");
            }
        }

        public void RemoveReceita(int index)
        {
            if (index >= Dados.Receitas.Count || index < 0 || Dados.Receitas.Count == 0)
                return; // não remove nada

            Dados.Receitas.RemoveAt(index);
        }

        public void RemoveDespesas(int index)
        {
            if (index >= Dados.Despesas.Count || index < 0 || Dados.Despesas.Count == 0)
                return; // não remove nada

            Dados.Despesas.RemoveAt(index);
        }

        public double TotalDeReceitas()
        {
            double total = 0;

            foreach (Receita receita in Dados.Receitas)
            {
                total += receita.Value;

            }
        
            return total;
        }

        public double TodalDeDespesas()
        {
            double total = 0;

            foreach (Despesa despesa in Dados.Despesas)
            {
                total += despesa.Value;
            }

            return total;
        }

        public double TotalDeSaldo()
        {
            return TotalDeReceitas() - TodalDeDespesas();
        }

        public void SalvarDados()
        {
            dados.Salvar();
        }
    }
}
