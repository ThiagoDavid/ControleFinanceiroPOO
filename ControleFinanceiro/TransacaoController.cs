using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro
{
    public class TransacaoController
    {
        private List<Transacao> dadosTransacao;

        public TransacaoController()
        {
            dadosTransacao = new List<Transacao>();
        }

        // Adicionar uma nova transação
        public void AdicionarTransacao(Transacao transacao)
        {
            dadosTransacao.Add(transacao);
        }

        // Editar uma transação existente
        public void EditarTransacao(Transacao transacao)
        {
            int index = dadosTransacao.FindIndex(t => t.Id == transacao.Id);

            if (index >= 0)
            {
                dadosTransacao[index] = transacao;
            }
        }

        // Listar todas as transações
        public List<Transacao> ListarTransacoes()
        {
            return dadosTransacao;
        }

        // Excluir uma transação existente
        public void ExcluirTransacao(int id)
        {
            Transacao transacao = dadosTransacao.Find(t => t.Id == id);

            if (transacao != null)
            {
                dadosTransacao.Remove(transacao);
            }
        }

        // Filtrar transações pelo tipo (Despesa ou Lucro)
        public List<Transacao> FiltrarTransacoesPorTipo(string tipo)
        {
            return dadosTransacao.FindAll(t => t.GetType().Name == tipo);
        }

        // Filtrar transações por categoria
        public List<Transacao> FiltrarTransacoesPorCategoria(string categoria)
        {
            return dadosTransacao.FindAll(t => t.Categoria == categoria);
        }

        // Filtrar transações por data
        public List<Transacao> FiltrarTransacoesPorData(DateTime data)
        {
            return dadosTransacao.FindAll(t => t.Data.Date == data.Date);
        }

        // Ordenar transações por valor ascendente
        public void OrdenarTransacoesPorValorAscendente()
        {
            dadosTransacao.Sort((t1, t2) => t1.Valor.CompareTo(t2.Valor));
        }

        // Ordenar transações por valor descendente
        public void OrdenarTransacoesPorValorDescendente()
        {
            dadosTransacao.Sort((t1, t2) => t2.Valor.CompareTo(t1.Valor));
        }
    }
}
