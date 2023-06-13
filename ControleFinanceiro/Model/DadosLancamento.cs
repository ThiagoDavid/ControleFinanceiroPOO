using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Reflection;

namespace ControleFinanceiro.Model
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
            try
            {
                SalvarDespesas();
                SalvarReceitas();
                MessageBox.Show("Dados foram salvos.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Problemas ao salvar arquivos: {e}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SalvarDespesas()
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
        }
        public void SalvarReceitas()
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
        }

        public void LerArquivo()
        {
            try
            {
                LerReceitas();
                LerDespesas();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ocorreu um erro ao recuperar os dados: {e}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LerReceitas()
        {
            // se não encontar a pasta não vai tentar carregar nada.

            string filePath = Constantes.receitasFilePath;

            if (!Directory.Exists(Constantes.dataPath) || !File.Exists(filePath))
            {
                return;
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


        }
        public void LerDespesas()
        {
            string filePath = Constantes.despesasFilePath;

            if (!Directory.Exists(Constantes.dataPath) || !File.Exists(filePath))
            {
                return;
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
        }
    }
}
