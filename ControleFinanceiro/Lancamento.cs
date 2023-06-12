using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro
{
    public abstract class Lancamento
    {
        protected string _descricao;
        protected double _value;
        protected DateTime _data;
        public double publicValue;
        protected Lancamento() { }
        protected Lancamento(string descricao, double value, DateTime date)
        {
            _descricao = descricao;
            _value = value;
            _data = date;
            publicValue = value;
        }
        public void LêDados()
        {

            Console.Write("Descricao: ");
            Descricao = Console.ReadLine();

            try
            {
                Console.Write("Valor.....: ");
                this._value = Double.Parse(Console.ReadLine());

                Console.Write("Data.........: ");
                _data = Convert.ToDateTime(Console.Read);
            } catch(Exception e)
            {
                Console.WriteLine($"Ocorreu um erro: {e}");
            }
        }
        public void MostraDados()
        {
            Console.WriteLine("Nome do Aluno: {0}, {1}, {3}", Descricao, _value, Data);
        }
        public string Descricao { get => _descricao; set => _descricao = value; }
        public double Value { get => this._value; set => this._value = value; }
        public DateTime Data { get => _data; set => _data = value; }
        public int Id { get; set; }
        public string? Categoria { get; set; }
    }
}
