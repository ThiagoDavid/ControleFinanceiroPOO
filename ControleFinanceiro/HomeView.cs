using System.Collections;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;

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
            CarregaGrid();                          // Pode carregar o Grid com Dados
        }

        private void CarregaGrid()                       // Função para Carregar/Montar Grid
        {
            if (controller.Dados.Receitas.Count != 0)
                carregaGridReceitas();
            if (controller.Dados.Receitas.Count != 0)
                carregaGridDespesas();
        }

        private void carregaGridReceitas()
        {
            dataGridReceitas.DataSource = null;
            dataGridReceitas.DataSource = controller.Dados.Receitas;
            setupGridStyle(dataGridReceitas);
        }
        private void carregaGridDespesas()
        {
            dataGridDespesas.DataSource = null;
            dataGridDespesas.DataSource = controller.Dados.Despesas;
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
            controller.Add(new Receita("", 0.0, new DateTime()));
            carregaGridReceitas();
        }

        private void buttonAddDespesa_Click(object sender, EventArgs e)
        {
            controller.Add(new Despesa("", 0.0, new DateTime()));
            carregaGridDespesas();
        }

        private void dataGridReceitas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Lancamento novaReceita = new Receita();
            novaReceita.Descricao = Convert.ToString(dataGridReceitas.CurrentRow.Cells[0].Value);
            novaReceita.Value = Convert.ToDouble(dataGridReceitas.CurrentRow.Cells[1].Value);
            novaReceita.Data = DateTime.Now; // trocar posteriormente por data selecionada

            controller.UpdateData(novaReceita, dataGridReceitas.CurrentRow.Index);
        }

        private void dataGridDespesas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Lancamento novaDespesa = new Despesa();
            novaDespesa.Descricao = Convert.ToString(dataGridDespesas.CurrentRow.Cells[0].Value);
            novaDespesa.Value = Convert.ToDouble(dataGridDespesas.CurrentRow.Cells[1].Value);
            novaDespesa.Data = DateTime.Now; // trocar posteriormente por data selecionada

            controller.UpdateData( novaDespesa, dataGridDespesas.CurrentRow.Index);
        }

        private void btnRemoverEntrada_Click(object sender, EventArgs e)
        {
            if (dataGridReceitas.CurrentRow == null)
                return; // do nothing

            controller.RemoveReceita(dataGridReceitas.CurrentRow.Index);
            carregaGridReceitas();
        }

        private void btnRemoverSaida_Click(object sender, EventArgs e)
        {
            if (dataGridDespesas.CurrentRow == null)
                return; // do nothing

            controller.RemoveDespesas(dataGridDespesas.CurrentRow.Index);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}