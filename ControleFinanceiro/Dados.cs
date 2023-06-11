using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ControleFinanceiro
{
    internal class Dados
    {
        private ArrayList Cadastro;

        public Dados()
        {
            Cadastro = new ArrayList();
        }

        public void InserirLancamento(Lancamento x)
        {
            Cadastro.Add(x);
        }

        public void AlterarLancamento(Lancamento x, Lancamento y)
        {
            int Posição;

            Posição = Cadastro.IndexOf(x);

            Cadastro.Remove(x);
            Cadastro.Insert(Posição, y);
        }

        public void ExcluirLancamento(Lancamento x)
        {
            Cadastro.Remove(x);
        }

        public Lancamento PesquisarLancamento(string Descricao)
        {
            foreach (Lancamento x in Cadastro)
            {
                if (x.Descricao.ToUpper() == Descricao.ToUpper())
                {
                    return x;
                }
            }

            return null;
        }

        public ArrayList ListarLancamentos()
        {
            return Cadastro;
        }

        public int OrdenarLancamentos()
        {
            Cadastro.Sort(new MinhaOrdenação());

            return Cadastro.Count;
        }

        public int SalvarArquivo()
        {
            TextWriter MeuWriter = new StreamWriter(@"D:\Lixo\CadastroLancamentos.xml");

            Lancamento[] ListaLancamentoVetor = (Lancamento[])Cadastro.ToArray(typeof(Lancamento));

            // Serialização
            XmlSerializer Serialização = new XmlSerializer(ListaLancamentoVetor.GetType());

            //Serializa usando o TextWriter
            Serialização.Serialize(MeuWriter, ListaLancamentoVetor);

            MeuWriter.Close();

            return Cadastro.Count;
        }

        public int LerArquivo()
        {
            int Reg;

            FileStream Arquivo = new FileStream(@"D:\Lixo\CadastroLancamentos.xml", FileMode.Open);

            Lancamento[] ListaLancamentoVetor = (Lancamento[])Cadastro.ToArray(typeof(Lancamento));

            XmlSerializer Serialização = new XmlSerializer(ListaLancamentoVetor.GetType());

            ListaLancamentoVetor = (Lancamento[])Serialização.Deserialize(Arquivo);

            Cadastro.Clear();

            Cadastro.AddRange(ListaLancamentoVetor);

            Reg = Cadastro.Count;

            Arquivo.Close();

            return Reg;
        }

        public class MinhaOrdenação : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                return ((Lancamento)x).Descricao.CompareTo(((Lancamento)y).Descricao);
            }
        }
    }
}
