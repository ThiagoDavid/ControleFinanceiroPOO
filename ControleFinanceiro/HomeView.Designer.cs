namespace ControleFinanceiro
{
    partial class HomeView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeView));
            this.dataGridReceitas = new System.Windows.Forms.DataGridView();
            this.dataGridDespesas = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.buttonSave = new System.Windows.Forms.ToolStripButton();
            this.buttonAddReceita = new System.Windows.Forms.ToolStripButton();
            this.btnRemoverEntrada = new System.Windows.Forms.ToolStripButton();
            this.searchTextField = new System.Windows.Forms.ToolStripTextBox();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.buttonAddDespesa = new System.Windows.Forms.ToolStripButton();
            this.btnRemoverSaida = new System.Windows.Forms.ToolStripButton();
            this.labelEntradas = new System.Windows.Forms.Label();
            this.labelSaidas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReceitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDespesas)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridReceitas
            // 
            this.dataGridReceitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReceitas.Location = new System.Drawing.Point(22, 68);
            this.dataGridReceitas.Name = "dataGridReceitas";
            this.dataGridReceitas.RowTemplate.Height = 25;
            this.dataGridReceitas.Size = new System.Drawing.Size(500, 324);
            this.dataGridReceitas.TabIndex = 0;
            this.dataGridReceitas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridReceitas_CellEndEdit);
            // 
            // dataGridDespesas
            // 
            this.dataGridDespesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDespesas.Location = new System.Drawing.Point(570, 68);
            this.dataGridDespesas.Name = "dataGridDespesas";
            this.dataGridDespesas.RowTemplate.Height = 25;
            this.dataGridDespesas.Size = new System.Drawing.Size(500, 324);
            this.dataGridDespesas.TabIndex = 1;
            this.dataGridDespesas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDespesas_CellEndEdit);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonSave,
            this.buttonAddReceita,
            this.btnRemoverEntrada,
            this.searchTextField,
            this.btnSearch,
            this.buttonAddDespesa,
            this.btnRemoverSaida});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1110, 37);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // buttonSave
            // 
            this.buttonSave.AccessibleDescription = "Button to save data grid";
            this.buttonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonSave.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(24, 34);
            this.buttonSave.Text = "toolStripButton1";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonAddReceita
            // 
            this.buttonAddReceita.AccessibleDescription = "Botão para adicionar nova receita";
            this.buttonAddReceita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonAddReceita.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddReceita.Image")));
            this.buttonAddReceita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonAddReceita.Name = "buttonAddReceita";
            this.buttonAddReceita.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.buttonAddReceita.Size = new System.Drawing.Size(44, 34);
            this.buttonAddReceita.Tag = "adicionarReceita";
            this.buttonAddReceita.Text = "Inserir Receita (entrada)";
            this.buttonAddReceita.Click += new System.EventHandler(this.buttonAddReceita_Click);
            // 
            // btnRemoverEntrada
            // 
            this.btnRemoverEntrada.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRemoverEntrada.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoverEntrada.Image")));
            this.btnRemoverEntrada.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemoverEntrada.Name = "btnRemoverEntrada";
            this.btnRemoverEntrada.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.btnRemoverEntrada.Size = new System.Drawing.Size(54, 34);
            this.btnRemoverEntrada.Tag = "removerReceita";
            this.btnRemoverEntrada.Text = "Remover Receita ";
            this.btnRemoverEntrada.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRemoverEntrada.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnRemoverEntrada.Click += new System.EventHandler(this.btnRemoverEntrada_Click);
            // 
            // searchTextField
            // 
            this.searchTextField.Name = "searchTextField";
            this.searchTextField.Size = new System.Drawing.Size(100, 37);
            // 
            // btnSearch
            // 
            this.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSearch.Size = new System.Drawing.Size(34, 34);
            this.btnSearch.Text = "toolStripButton1";
            // 
            // buttonAddDespesa
            // 
            this.buttonAddDespesa.AccessibleDescription = "Botão para adicionar nova despesa";
            this.buttonAddDespesa.AccessibleName = "buttonAddDespesa";
            this.buttonAddDespesa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonAddDespesa.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddDespesa.Image")));
            this.buttonAddDespesa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonAddDespesa.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.buttonAddDespesa.Name = "buttonAddDespesa";
            this.buttonAddDespesa.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonAddDespesa.Size = new System.Drawing.Size(44, 34);
            this.buttonAddDespesa.Text = "Inserir Despesa (saida)";
            this.buttonAddDespesa.Click += new System.EventHandler(this.buttonAddDespesa_Click);
            // 
            // btnRemoverSaida
            // 
            this.btnRemoverSaida.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRemoverSaida.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoverSaida.Image")));
            this.btnRemoverSaida.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemoverSaida.Name = "btnRemoverSaida";
            this.btnRemoverSaida.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnRemoverSaida.Size = new System.Drawing.Size(44, 34);
            this.btnRemoverSaida.Text = "Remover Despesa";
            this.btnRemoverSaida.Click += new System.EventHandler(this.btnRemoverSaida_Click);
            // 
            // labelEntradas
            // 
            this.labelEntradas.AutoSize = true;
            this.labelEntradas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEntradas.Location = new System.Drawing.Point(22, 41);
            this.labelEntradas.Name = "labelEntradas";
            this.labelEntradas.Size = new System.Drawing.Size(76, 21);
            this.labelEntradas.TabIndex = 3;
            this.labelEntradas.Text = "Entradas";
            // 
            // labelSaidas
            // 
            this.labelSaidas.AutoSize = true;
            this.labelSaidas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSaidas.Location = new System.Drawing.Point(570, 41);
            this.labelSaidas.Name = "labelSaidas";
            this.labelSaidas.Size = new System.Drawing.Size(59, 21);
            this.labelSaidas.TabIndex = 4;
            this.labelSaidas.Text = "Saidas";
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 507);
            this.Controls.Add(this.labelSaidas);
            this.Controls.Add(this.labelEntradas);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridDespesas);
            this.Controls.Add(this.dataGridReceitas);
            this.Name = "HomeView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReceitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDespesas)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridReceitas;
        private DataGridView dataGridDespesas;
        private ToolStrip toolStrip1;
        private ToolStripButton buttonAddReceita;
        private ToolStripButton buttonAddDespesa;
        private ToolStripButton btnRemoverEntrada;
        private ToolStripTextBox searchTextField;
        private ToolStripButton btnRemoverSaida;
        private Label labelEntradas;
        private Label labelSaidas;
        private ToolStripButton buttonSave;
        private ToolStripButton btnSearch;
    }
}