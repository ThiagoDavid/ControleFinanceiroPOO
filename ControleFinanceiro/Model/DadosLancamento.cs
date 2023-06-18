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
