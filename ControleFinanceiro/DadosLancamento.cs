using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Reflection;

namespace ControleFinanceiro
{
    class DadosLancamento
    {
        ArrayList _receitas = new ArrayList();
        ArrayList _despesas = new ArrayList();

        public DadosLancamento()
        {
            Receitas = new ArrayList();
            Despesas = new ArrayList();
        }

        public ArrayList Receitas { get => _receitas; set => _receitas = value; }
        public ArrayList Despesas { get => _despesas; set => _despesas = value; }

        public void Add(Lancamento lancamneto)
        {
            if (lancamneto.GetType().Equals(typeof(ControleFinanceiro.Receita)))
            {
                this._receitas.Add(lancamneto);
            }
            else
            {
                this._despesas.Add(lancamneto);
            }
        }

        public void Salvar()
        {
            SalvarDespesas();
            SalvarReceitas();
        }

        public int SalvarDespesas()
        {
            string folderPath = @"F:\DadosLancamentos";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string filePath = "F:\\DadosLancamentos\\Despesas.xml";

            TextWriter MeuWriter = new StreamWriter(filePath);

            Despesa[] ListaLancamentoVetor = (Despesa[])Despesas.ToArray(typeof(Despesa));

            // Serialização
            XmlSerializer Serialização = new XmlSerializer(ListaLancamentoVetor.GetType());

            //Serializa usando o TextWriter
            Serialização.Serialize(MeuWriter, ListaLancamentoVetor);

            MeuWriter.Close();

            return Despesas.Count;
        }
        public int SalvarReceitas()
        {
            string folderPath = @"F:\DadosLancamentos";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            string filePath = "F:\\DadosLancamentos\\Receitas.xml";
            TextWriter MeuWriter = new StreamWriter(filePath);

            Receita[] ListaLancamentoVetor = (Receita[])Receitas.ToArray(typeof(Receita));

            // Serialização
            XmlSerializer Serialização = new XmlSerializer(ListaLancamentoVetor.GetType());

            //Serializa usando o TextWriter
            Serialização.Serialize(MeuWriter, ListaLancamentoVetor);

            MeuWriter.Close();

            return Receitas.Count;
        }
    }
}
