using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleFinanceiro.Model;
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

        public void UpdateData(Lancamento lancamento, int index)
        {
            if (lancamento.GetType().Equals(typeof(Despesa)))
            {
                Dados.Despesas[index] = lancamento;
                Console.WriteLine("Debug: DESPESA ATUALIZADA!!!");
            }
            else if (lancamento.GetType().Equals(typeof(Receita)))
            {
                Dados.Receitas[index] = lancamento;
                Console.WriteLine("Debug: RECEITA ATUALIZADA!!!");
            }
        }

        public void RemoveReceita(string id)
        {
            try
            {
                foreach (Receita x in Dados.Receitas)
                    if (x.Id.ToString() == id)
                    {
                        Dados.Receitas.Remove(x);
                        break;
                    }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro ao tentar remover receita {e}", "Erro inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RemoveDespesas(string id)
        {
            try
            {
                foreach (Despesa x in Dados.Despesas)
                    if (x.Id.ToString() == id)
                    {
                        Dados.Despesas.Remove(x);
                        break;
                    }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro ao tentar remover despesas {e}", "Erro inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            return new ArrayList(dados.Cast<Receita>().Where(objeto => objeto.Data.Month == mes && objeto.Data.Year == ano).ToList());
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

        public double TotalDeReceitas()
        {
            Receita[] receitas = (Receita[])Dados.Receitas.ToArray(typeof(Receita));
            double sum = receitas.Sum(obj => obj.Value);

            return sum;
        }

        public double TodalDeDespesas()
        {
            Despesa[] despesas = (Despesa[])Dados.Despesas.ToArray(typeof(Despesa));
            double sum = despesas.Sum(obj => obj.Value);

            return sum;
        }

        public double TotalDeSaldo()
        {
            return TotalDeReceitas() - TodalDeDespesas();
        }
    }
}
