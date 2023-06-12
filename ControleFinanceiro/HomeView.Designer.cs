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
            this.labelEntradasTotais = new System.Windows.Forms.Label();
            this.labelSaidas = new System.Windows.Forms.Label();
            this.labelSaidasTotais = new System.Windows.Forms.Label();
            this.labelEntradasTotaisValor = new System.Windows.Forms.Label();
            this.labelSaidasTotaisValor = new System.Windows.Forms.Label();
            this.numericUpDownAno = new System.Windows.Forms.NumericUpDown();
            this.comboBoxMes = new System.Windows.Forms.ComboBox();
            this.labelMes = new System.Windows.Forms.Label();
            this.labelAno = new System.Windows.Forms.Label();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReceitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDespesas)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAno)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridReceitas
            // 
            this.dataGridReceitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReceitas.Location = new System.Drawing.Point(25, 171);
            this.dataGridReceitas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridReceitas.Name = "dataGridReceitas";
            this.dataGridReceitas.RowHeadersWidth = 51;
            this.dataGridReceitas.RowTemplate.Height = 25;
            this.dataGridReceitas.Size = new System.Drawing.Size(571, 432);
            this.dataGridReceitas.TabIndex = 0;
            this.dataGridReceitas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridReceitas_CellEndEdit);
            // 
            // dataGridDespesas
            // 
            this.dataGridDespesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDespesas.Location = new System.Drawing.Point(651, 171);
            this.dataGridDespesas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridDespesas.Name = "dataGridDespesas";
            this.dataGridDespesas.RowHeadersWidth = 51;
            this.dataGridDespesas.RowTemplate.Height = 25;
            this.dataGridDespesas.Size = new System.Drawing.Size(571, 432);
            this.dataGridDespesas.TabIndex = 1;
            this.dataGridDespesas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDespesas_CellEndEdit);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonSave,
            this.buttonAddReceita,
            this.buttonAddDespesa,
            this.searchTextField,
            this.btnSearch,
            this.btnRemoverEntrada,
            this.btnRemoverSaida});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1269, 37);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // buttonSave
            // 
            this.buttonSave.AccessibleDescription = "Button to save data grid";
            this.buttonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonSave.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(29, 34);
            this.buttonSave.Text = "Salvar";
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
            this.searchTextField.Size = new System.Drawing.Size(114, 37);
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
            this.labelEntradas.Location = new System.Drawing.Point(25, 135);
            this.labelEntradas.Name = "labelEntradas";
            this.labelEntradas.Size = new System.Drawing.Size(94, 28);
            this.labelEntradas.TabIndex = 3;
            this.labelEntradas.Text = "Entradas";
            // 
            // labelEntradasTotais
            // 
            this.labelEntradasTotais.AutoSize = true;
            this.labelEntradasTotais.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEntradasTotais.Location = new System.Drawing.Point(25, 613);
            this.labelEntradasTotais.Name = "labelEntradasTotais";
            this.labelEntradasTotais.Size = new System.Drawing.Size(196, 28);
            this.labelEntradasTotais.TabIndex = 3;
            this.labelEntradasTotais.Text = "ENTRADAS TOTAIS:";
            // 
            // labelSaidas
            // 
            this.labelSaidas.AutoSize = true;
            this.labelSaidas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSaidas.Location = new System.Drawing.Point(651, 135);
            this.labelSaidas.Name = "labelSaidas";
            this.labelSaidas.Size = new System.Drawing.Size(72, 28);
            this.labelSaidas.TabIndex = 4;
            this.labelSaidas.Text = "Saídas";
            // 
            // labelSaidasTotais
            // 
            this.labelSaidasTotais.AutoSize = true;
            this.labelSaidasTotais.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSaidasTotais.Location = new System.Drawing.Point(651, 613);
            this.labelSaidasTotais.Name = "labelSaidasTotais";
            this.labelSaidasTotais.Size = new System.Drawing.Size(161, 28);
            this.labelSaidasTotais.TabIndex = 3;
            this.labelSaidasTotais.Text = "SAÍDAS TOTAIS:";
            // 
            // labelEntradasTotaisValor
            // 
            this.labelEntradasTotaisValor.AutoSize = true;
            this.labelEntradasTotaisValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEntradasTotaisValor.ForeColor = System.Drawing.Color.Green;
            this.labelEntradasTotaisValor.Location = new System.Drawing.Point(230, 613);
            this.labelEntradasTotaisValor.Name = "labelEntradasTotaisValor";
            this.labelEntradasTotaisValor.Size = new System.Drawing.Size(78, 28);
            this.labelEntradasTotaisValor.TabIndex = 3;
            this.labelEntradasTotaisValor.Text = "R$0,00";
            // 
            // labelSaidasTotaisValor
            // 
            this.labelSaidasTotaisValor.AutoSize = true;
            this.labelSaidasTotaisValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSaidasTotaisValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelSaidasTotaisValor.Location = new System.Drawing.Point(818, 613);
            this.labelSaidasTotaisValor.Name = "labelSaidasTotaisValor";
            this.labelSaidasTotaisValor.Size = new System.Drawing.Size(78, 28);
            this.labelSaidasTotaisValor.TabIndex = 3;
            this.labelSaidasTotaisValor.Text = "R$0,00";
            this.labelSaidasTotaisValor.Click += new System.EventHandler(this.labelSaidasTotaisValue_Click);
            // 
            // numericUpDownAno
            // 
            this.numericUpDownAno.Location = new System.Drawing.Point(693, 5);
            this.numericUpDownAno.Maximum = new decimal(new int[] {
            2099,
            0,
            0,
            0});
            this.numericUpDownAno.Minimum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.numericUpDownAno.Name = "numericUpDownAno";
            this.numericUpDownAno.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownAno.TabIndex = 5;
            this.numericUpDownAno.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            // 
            // comboBoxMes
            // 
            this.comboBoxMes.FormattingEnabled = true;
            this.comboBoxMes.Items.AddRange(new object[] {
            "JANEIRO",
            "FEVEREIRO",
            "MARÇO",
            "ABRIL",
            "MAIO",
            "JUNHO",
            "JULHO",
            "AGOSTO",
            "SETEMBRO",
            "OUTUBRO",
            "NOVEMBRO",
            "DEZEMBRO"});
            this.comboBoxMes.Location = new System.Drawing.Point(459, 4);
            this.comboBoxMes.Name = "comboBoxMes";
            this.comboBoxMes.Size = new System.Drawing.Size(151, 28);
            this.comboBoxMes.TabIndex = 6;
            // 
            // labelMes
            // 
            this.labelMes.AutoSize = true;
            this.labelMes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelMes.Location = new System.Drawing.Point(414, 9);
            this.labelMes.Name = "labelMes";
            this.labelMes.Size = new System.Drawing.Size(41, 20);
            this.labelMes.TabIndex = 7;
            this.labelMes.Text = "MÊS:";
            this.labelMes.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelAno
            // 
            this.labelAno.AutoSize = true;
            this.labelAno.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAno.Location = new System.Drawing.Point(645, 8);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(44, 20);
            this.labelAno.TabIndex = 8;
            this.labelAno.Text = "ANO:";
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSaldo.Location = new System.Drawing.Point(1042, 614);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(82, 28);
            this.labelSaldo.TabIndex = 9;
            this.labelSaldo.Text = "SALDO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1144, 613);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "R$0,00";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1269, 676);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelSaldo);
            this.Controls.Add(this.labelAno);
            this.Controls.Add(this.labelMes);
            this.Controls.Add(this.comboBoxMes);
            this.Controls.Add(this.numericUpDownAno);
            this.Controls.Add(this.labelSaidasTotaisValor);
            this.Controls.Add(this.labelSaidas);
            this.Controls.Add(this.labelSaidasTotais);
            this.Controls.Add(this.labelEntradasTotaisValor);
            this.Controls.Add(this.labelEntradas);
            this.Controls.Add(this.labelEntradasTotais);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridDespesas);
            this.Controls.Add(this.dataGridReceitas);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HomeView";
            this.Text = "MÊS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReceitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDespesas)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAno)).EndInit();
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
        private Label labelEntradasTotais;   // possui o texto "Entradas"
        private Label labelEntradasTotaisValor;   // valor das entradas 
        private Label labelSaidas;
        private Label labelSaidasTotais;  // possui o texto "Saidas"
        private Label labelSaidasTotaisValor;   // valor das saídas    
        private ToolStripButton buttonSave;
        private ToolStripButton btnSearch;
        private NumericUpDown numericUpDownAno;
        private ComboBox comboBoxMes;
        private Label labelMes;
        private Label labelAno;
        private Label labelSaldo;
        private Label label2;
    }
}