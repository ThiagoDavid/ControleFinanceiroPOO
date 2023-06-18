using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleFinanceiro.Model;
using static System.Formats.Asn1.AsnWriter;

namespace ControleFinanceiro.Controller
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

        public void UpdateData(Lancamento lancamento, string id)
        {
            if (lancamento.GetType().Equals(typeof(Despesa)))
            {
                UpdateReceita(lancamento, id);
                Console.WriteLine("Debug: DESPESA ATUALIZADA!!!");
            }
            else if (lancamento.GetType().Equals(typeof(Receita)))
            {
                UpdateDespesa(lancamento, id);
                Console.WriteLine("Debug: RECEITA ATUALIZADA!!!");
            }
        }

        public void UpdateReceita(Lancamento lancamento, string id)
        {
            try
            {
                foreach (Receita x in Dados.Receitas)
                    if (x.Id.ToString() == id)
                    {
                        Dados.Receitas.Remove(x);
                        Dados.Receitas.Add(lancamento);
                        break;
                    }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro ao tentar Atualizar receita {e}", "Erro inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateDespesa(Lancamento lancamento, string id)
        {
            try
            {
                foreach (Despesa x in Dados.Despesas)
                    if (x.Id.ToString() == id)
                    {
                        Dados.Despesas.Remove(x);
                        Dados.Despesas.Add(lancamento);
                        break;
                    }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro ao tentar Atualizar receita {e}", "Erro inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            try
            {
                dados = new ArrayList(dados.Cast<Receita>().Where(objeto => objeto.Data.Month == mes && objeto.Data.Year == ano).ToList());
            }
            catch (InvalidCastException e)
            {
                MessageBox.Show($"Erro ao tentar converte para  receitas: {e}", "Erro inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dados;
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

        public double TotalDeReceitas(int mes, int ano)
        {
            Receita[] receitas = (Receita[])GetReceitas(mes, ano).ToArray(typeof(Receita));
            double sum = receitas.Sum(obj => obj.Value);

            return sum;
        }

        public double TodalDeDespesas(int mes, int ano)
        {
            Despesa[] despesas = (Despesa[])GetDespesas(mes, ano).ToArray(typeof(Despesa));
            double sum = despesas.Sum(obj => obj.Value);

            return sum;
        }

        public double TotalDeSaldo(int mes = 0, int ano = 0)
        {
            return TotalDeReceitas(mes, ano) - TodalDeDespesas(mes, ano);
        }
    }
}
