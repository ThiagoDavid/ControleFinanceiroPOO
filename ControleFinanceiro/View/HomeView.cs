using System.Collections;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;
using ControleFinanceiro.Model;
using ControleFinanceiro.Controller;

namespace ControleFinanceiro
{
    public partial class HomeView : Form
    {
        HomeViewController controller;
        public HomeView()
        {
            controller = new HomeViewController();
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {                       
            SetupDate();
            CarregaGrid();  
        }
        private void SetupDate()
        {
            numericUpDownAno.Value = DateTime.Now.Year;
            comboBoxMes.SelectedIndex = DateTime.Now.Month-1;
        }

        private void CarregaGrid()                       // Função para Carregar/Montar Grid
        {
            if (controller.Dados.Receitas.Count != 0)
                carregaGridReceitas();
            if (controller.Dados.Receitas.Count != 0)
                carregaGridDespesas();
            atualizarSaldo();
        }

        private void carregaGridReceitas(int mes = 0, int ano = 0)
        {
            if(ano == 0 )
                ano = (int)numericUpDownAno.Value;
            if(mes == 0 )
                mes = comboBoxMes.SelectedIndex + 1;

            dataGridReceitas.DataSource = null;
            dataGridReceitas.DataSource = controller.GetReceitas(mes, ano);
            setupGridStyle(dataGridReceitas);
        }
        private void carregaGridDespesas(int mes = 0, int ano = 0)
        {
            if (ano == 0)
                ano = (int)numericUpDownAno.Value;
            if (mes == 0)
                mes = comboBoxMes.SelectedIndex + 1;

            dataGridDespesas.DataSource = null;
            dataGridDespesas.DataSource = controller.GetDespesas(mes, ano);
            setupGridStyle(dataGridDespesas);
        }
        private void setupGridStyle(DataGridView dataGrid)
        {
            dataGrid.ClearSelection();
            if (dataGrid.Columns.Count > 0)
            {
                dataGrid.Columns[0].Width = 380;
                dataGrid.Columns[1].Width = 80;
                dataGrid.Columns[2].Visible = false;
                dataGrid.Columns[3].Visible = false; // deabilita id
                dataGrid.Columns[4].Visible = false; // esabilita categoria
            } else
            {
                Console.WriteLine("Log - Tentou carregar datagrid com dados vazios.");
            }
        }

        private void buttonAddReceita_Click(object sender, EventArgs e)
        {
            int ano = (int)numericUpDownAno.Value;
            int mes = comboBoxMes.SelectedIndex + 1;
            DateTime data = new DateTime(ano, mes, 1);

            controller.Add(new Receita("", 0.0, data ));
            carregaGridReceitas();
        }

        private void buttonAddDespesa_Click(object sender, EventArgs e)
        {
            int ano = (int)numericUpDownAno.Value;
            int mes = comboBoxMes.SelectedIndex + 1;
            controller.Add(new Despesa("", 0.0, new DateTime(ano, mes, 1)));
            carregaGridDespesas();
        }

        private void dataGridReceitas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Lancamento novaReceita = new Receita();
            novaReceita.Descricao = Convert.ToString(dataGridReceitas.CurrentRow.Cells[0].Value);
            novaReceita.Value = Convert.ToDouble(dataGridReceitas.CurrentRow.Cells[1].Value);
            novaReceita.Data = DateTime.Now; // trocar posteriormente por data selecionada

            controller.UpdateData(novaReceita, Convert.ToString(dataGridReceitas.CurrentRow.Cells[3].Value));
            atualizarSaldo();
        }

        private void dataGridDespesas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Lancamento novaDespesa = new Despesa();
            novaDespesa.Descricao = Convert.ToString(dataGridDespesas.CurrentRow.Cells[0].Value);
            novaDespesa.Value = Convert.ToDouble(dataGridDespesas.CurrentRow.Cells[1].Value);
            novaDespesa.Data = DateTime.Now; // trocar posteriormente por data selecionada

            controller.UpdateData( novaDespesa, Convert.ToString(dataGridDespesas.CurrentRow.Cells[3].Value));
            atualizarSaldo();
        }

        private void btnRemoverEntrada_Click(object sender, EventArgs e)
        {
            if (dataGridReceitas.CurrentRow == null)
            {
                MessageBox.Show("A planilha já está vazia", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // do nothing
            }

            controller.RemoveReceita(Convert.ToString(dataGridReceitas.CurrentRow.Cells[3].Value));
            carregaGridReceitas();
        }

        private void btnRemoverSaida_Click(object sender, EventArgs e)
        {
            if (dataGridDespesas.CurrentRow == null)
            {
                MessageBox.Show("A planilha já esta vazia", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // do nothing
            }
            controller.RemoveDespesas(Convert.ToString(dataGridDespesas.CurrentRow.Cells[3].Value));
            carregaGridDespesas();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            controller.SalvarDados();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void comboBoxMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            atualizarSaldo();
            carregaGridReceitas();
            carregaGridDespesas();
        }
        private void atualizarSaldo()
        {
            int ano = (int)numericUpDownAno.Value;
            int mes = comboBoxMes.SelectedIndex + 1;
            labelEntradasTotaisValor.Text = $"{controller.TotalDeReceitas(mes, ano).ToString("C")}";        
            labelSaidasTotaisValor.Text = $"{controller.TodalDeDespesas(mes, ano).ToString("C")}";
            double saldo = controller.TotalDeSaldo(mes, ano);
            labelSaldoTotal.Text = $"{saldo.ToString("C")}";
            if (saldo > 0)
                labelSaldoTotal.ForeColor = Color.DarkOliveGreen;
            else if (saldo < 0)
                labelSaldoTotal.ForeColor = Color.DarkRed;
        }
    }
}