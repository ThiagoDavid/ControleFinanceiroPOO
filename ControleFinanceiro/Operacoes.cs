using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro
{
    internal class Operacoes
    {
        public void Inserir(Lancamento MeuLancamento, Dados MeusDados)
        {
            MeuLancamento.LêDados();

            MeusDados.InserirLancamento(MeuLancamento);
        }

        public void Alterar(string CódPesq, Lancamento MeuLancamento, Lancamento MeuLancamentoAlterado, Dados MeusDados)
        {
            MeuLancamento = MeusDados.PesquisarLancamento(CódPesq);

            if (MeuLancamento != null)
            {
                MeuLancamento.MostraDados();

                Console.WriteLine("Dados de Atualização:\n");

                MeuLancamentoAlterado.LêDados();

               // MeuLancamentoAlterado.Código = MeuLancamento.Código;

                MeusDados.AlterarLancamento(MeuLancamento, MeuLancamentoAlterado);

                Console.Write("\nDados atualizados!");
                Console.ReadKey();
            }
            else
            {
                Console.Write("\nLancamento não encontrado no Cadastro de Lancamentos!");
                Console.ReadKey();
            }
        }

        public void Excluir(string CódPesq, Lancamento MeuLancamento, Dados MeusDados)
        {
            MeuLancamento = MeusDados.PesquisarLancamento(CódPesq);

            if (MeuLancamento != null)
            {
                MeuLancamento.MostraDados();

                MeusDados.ExcluirLancamento(MeuLancamento);

                Console.Write("Lancamento excluído!");
                Console.ReadKey();
            }
            else
            {
                Console.Write("Lancamento não encontrado no Cadastro de Lancamentos!");
                Console.ReadKey();
            }
        }

        public void Pesquisar(string CódPesq, Lancamento MeuLancamento, Dados MeusDados)
        {
            MeuLancamento = MeusDados.PesquisarLancamento(CódPesq);

            if (MeuLancamento != null)
            {
                MeuLancamento.MostraDados();
            }
            else
            {
                Console.Write("\nLancamento não encontrado no Cadastro de Lancamentos!");
            }

            Console.ReadKey();
        }

        public void Listar(Dados MeusDados)
        {
            ArrayList Lista;

            Lista = MeusDados.ListarLancamentos();

            foreach (Lancamento x in Lista)
            {
                x.MostraDados();
            }

            Console.ReadKey();
        }

        public void Ordenar(Dados MeusDados)
        {
            int Registros;

            Registros = MeusDados.OrdenarLancamentos();

            Console.Write("Total de Registros: {0}", Registros);

            Console.ReadKey();
        }

        public void SalvarXML(Dados MeusDados)
        {
            int TotReg;

            TotReg = MeusDados.SalvarArquivo();

            Console.WriteLine("Arquivo XML gerado com sucesso!");
            Console.WriteLine("Total de Registros: {0}", TotReg);

            Console.ReadKey();
        }

        public void LerXML(Dados MeusDados)
        {
            int TotReg;

            TotReg = MeusDados.LerArquivo();

            Console.WriteLine("Arquivo XML carregado com sucesso!");
            Console.WriteLine("Total de Registros: {0}", TotReg);

            Console.ReadKey();
        }
    }
}
