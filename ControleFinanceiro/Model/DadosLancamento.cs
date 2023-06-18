using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Reflection;
using ControleFinanceiro.Interface;

namespace ControleFinanceiro.Model
{
    class DadosLancamento
    {
        ArrayList _receitas;
        ArrayList _despesas;
        DBConnection conexaoDB;

        public DadosLancamento(DBConnection conexaoDB)
        {
            Receitas = new ArrayList();
            Despesas = new ArrayList();
            this.conexaoDB = conexaoDB;
            LerArquivo();
        }

        public ArrayList Receitas { get => _receitas; set => _receitas = value; }
        public ArrayList Despesas { get => _despesas; set => _despesas = value; }

        public void Add(Lancamento lancamneto)
        {
            if (lancamneto.GetType().Equals(typeof(Receita)))
            {
                _receitas.Add(lancamneto);
            }
            else
            {
                _despesas.Add(lancamneto);
            }
        }

        public void RemoverReceita(string id)
        {
            try
            {
                foreach (Receita x in this.Receitas)
                    if (x.Id.ToString() == id)
                    {
                        this.Receitas.Remove(x);
                        break;
                    }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro ao tentar remover receita: {e}", "Erro inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RemoverDespesa(string id)
        {
            try
            {
                foreach (Despesa x in this.Despesas)
                    if (x.Id.ToString() == id)
                    {
                        this.Despesas.Remove(x);
                        break;
                    }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro ao tentar remover despesas {e}", "Erro inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateDespesa(Lancamento lancamento, string id)
        {
            try
            {
                foreach (Despesa x in this.Despesas)
                    if (x.Id.ToString() == id)
                    {
                        x.Data = lancamento.Data;
                        x.Descricao = lancamento.Descricao;
                        x.Value = lancamento.Value;
                        break;
                    }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro ao tentar Atualizar receita {e}", "Erro inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateReceita(Lancamento lancamento, string id)
        {
            try
            {
                foreach (Receita x in this.Receitas)
                    if (x.Id.ToString() == id)
                    {
                        x.Data = lancamento.Data;
                        x.Descricao = lancamento.Descricao;
                        x.Value = lancamento.Value;
                        break;
                    }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro ao tentar Atualizar receita {e}", "Erro inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Salvar()
        {
            conexaoDB.SalvarDados(this.Receitas, this.Despesas);
        }

        public void LerArquivo()
        {
            conexaoDB.CarregarDados(this.Receitas, this.Despesas);
        }
        
    }
}
