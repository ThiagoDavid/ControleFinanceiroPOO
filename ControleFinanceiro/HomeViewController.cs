using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

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

        public void SalvarDados()
        {
            dados.Salvar();
        }

        public ArrayList GetReceitas(int mes = 0, int ano = 0)
        {
            if (mes == 0)
                mes = DateTime.Now.Month;
            if (ano == 0)
                ano = DateTime.Now.Year;
            ArrayList dados = this.dados.Receitas;

            return  new ArrayList(dados.Cast<Receita>().Where(objeto => objeto.Data.Month == mes && objeto.Data.Year == ano).ToList());
        }

        public ArrayList GetDespesas(int mes = 0, int ano = 0)
        {
            if (mes == 0)
                mes = DateTime.Now.Month;
            if (ano == 0)
                ano = DateTime.Now.Year;
            ArrayList dados = this.dados.Despesas;

            return new ArrayList(dados.Cast<Despesa>().Where(objeto => objeto.Data.Month == mes && objeto.Data.Year == ano).ToList());
        }
    }
}
