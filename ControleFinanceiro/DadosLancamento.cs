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
            LerArquivo();
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
            string dataPath = Constantes.dataPath;
            if (!Directory.Exists(dataPath))
            {
                Directory.CreateDirectory(dataPath);
            }

            TextWriter MeuWriter = new StreamWriter(Constantes.despesasFilePath);

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
            string dataPath = Constantes.dataPath; // testar sem arquivo.
            if (!Directory.Exists(dataPath))
            {
                Directory.CreateDirectory(dataPath);
            }
            string filePath = Constantes.receitasFilePath;
            TextWriter MeuWriter = new StreamWriter(filePath);

            Receita[] ListaLancamentoVetor = (Receita[])Receitas.ToArray(typeof(Receita));

            // Serialização
            XmlSerializer Serialização = new XmlSerializer(ListaLancamentoVetor.GetType());

            //Serializa usando o TextWriter
            Serialização.Serialize(MeuWriter, ListaLancamentoVetor);

            MeuWriter.Close();

            return Receitas.Count;
        }

        public void LerArquivo()
        {
            LerReceitas();
            LerDespesas();
        }

        public int LerReceitas()
        {
            // se não encontar a pasta não vai tentar carregar nada.

            string filePath = Constantes.receitasFilePath;

            if (!Directory.Exists(Constantes.dataPath) || !File.Exists(filePath))
            {
                return -1;
            }

            int Reg;

            FileStream Arquivo = new FileStream(filePath, FileMode.Open);

            Receita[] ListaAlunoVetor = (Receita[])Receitas.ToArray(typeof(Receita));

            XmlSerializer Serialização = new XmlSerializer(ListaAlunoVetor.GetType());

            ListaAlunoVetor = (Receita[])Serialização.Deserialize(Arquivo);

            Receitas.Clear();

            Receitas.AddRange(ListaAlunoVetor);

            Reg = Receitas.Count;

            Arquivo.Close();

            return Reg;
        }
        public int LerDespesas()
        {
            string filePath = Constantes.despesasFilePath;

            if (!Directory.Exists(Constantes.dataPath) || !File.Exists(filePath))
            {
                return -1;
            }

            int Reg;

            FileStream Arquivo = new FileStream(filePath, FileMode.Open);

            Despesa[] ListaAlunoVetor = (Despesa[])Despesas.ToArray(typeof(Despesa));

            XmlSerializer Serialização = new XmlSerializer(ListaAlunoVetor.GetType());

            ListaAlunoVetor = (Despesa[])Serialização.Deserialize(Arquivo);

            Despesas.Clear();

            Despesas.AddRange(ListaAlunoVetor);

            Reg = Despesas.Count;

            Arquivo.Close();

            return Reg;
        }
    }
}
