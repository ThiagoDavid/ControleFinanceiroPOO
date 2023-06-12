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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeView));
            dataGridReceitas = new DataGridView();
            dataGridDespesas = new DataGridView();
            toolStrip1 = new ToolStrip();
            buttonSave = new ToolStripButton();
            searchTextField = new ToolStripTextBox();
            btnSearch = new ToolStripButton();
            labelEntradas = new Label();
            labelEntradasTotais = new Label();
            labelSaidas = new Label();
            labelSaidasTotais = new Label();
            labelEntradasTotaisValor = new Label();
            labelSaidasTotaisValor = new Label();
            numericUpDownAno = new NumericUpDown();
            comboBoxMes = new ComboBox();
            labelMes = new Label();
            labelAno = new Label();
            labelSaldo = new Label();
            labelSaldoTotal = new Label();
            imageList1 = new ImageList(components);
            lblAddReceitas = new Label();
            lblRemoverReceitas = new Label();
            label1 = new Label();
            lblAddSaida = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridReceitas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridDespesas).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAno).BeginInit();
            SuspendLayout();
            // 
            // dataGridReceitas
            // 
            dataGridReceitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridReceitas.Location = new Point(22, 128);
            dataGridReceitas.Name = "dataGridReceitas";
            dataGridReceitas.RowHeadersWidth = 51;
            dataGridReceitas.RowTemplate.Height = 25;
            dataGridReceitas.Size = new Size(500, 324);
            dataGridReceitas.TabIndex = 0;
            dataGridReceitas.CellEndEdit += dataGridReceitas_CellEndEdit;
            // 
            // dataGridDespesas
            // 
            dataGridDespesas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDespesas.Location = new Point(570, 128);
            dataGridDespesas.Name = "dataGridDespesas";
            dataGridDespesas.RowHeadersWidth = 51;
            dataGridDespesas.RowTemplate.Height = 25;
            dataGridDespesas.Size = new Size(500, 324);
            dataGridDespesas.TabIndex = 1;
            dataGridDespesas.CellEndEdit += dataGridDespesas_CellEndEdit;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { buttonSave, searchTextField, btnSearch });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1110, 28);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // buttonSave
            // 
            buttonSave.AccessibleDescription = "Button to save data grid";
            buttonSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.ImageTransparentColor = Color.Magenta;
            buttonSave.Margin = new Padding(20, 2, 10, 2);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(24, 24);
            buttonSave.Text = "Salvar";
            buttonSave.Click += buttonSave_Click;
            // 
            // searchTextField
            // 
            searchTextField.Name = "searchTextField";
            searchTextField.Padding = new Padding(10, 0, 0, 0);
            searchTextField.Size = new Size(80, 28);
            // 
            // btnSearch
            // 
            btnSearch.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.ImageTransparentColor = Color.Magenta;
            btnSearch.Name = "btnSearch";
            btnSearch.Padding = new Padding(10, 0, 0, 0);
            btnSearch.Size = new Size(34, 25);
            btnSearch.Text = "toolStripButton1";
            // 
            // labelEntradas
            // 
            labelEntradas.AutoSize = true;
            labelEntradas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelEntradas.Location = new Point(22, 101);
            labelEntradas.Name = "labelEntradas";
            labelEntradas.Size = new Size(76, 21);
            labelEntradas.TabIndex = 3;
            labelEntradas.Text = "Entradas";
            // 
            // labelEntradasTotais
            // 
            labelEntradasTotais.AutoSize = true;
            labelEntradasTotais.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelEntradasTotais.Location = new Point(22, 460);
            labelEntradasTotais.Name = "labelEntradasTotais";
            labelEntradasTotais.Size = new Size(154, 21);
            labelEntradasTotais.TabIndex = 3;
            labelEntradasTotais.Text = "ENTRADAS TOTAIS:";
            // 
            // labelSaidas
            // 
            labelSaidas.AutoSize = true;
            labelSaidas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSaidas.Location = new Point(570, 101);
            labelSaidas.Name = "labelSaidas";
            labelSaidas.Size = new Size(59, 21);
            labelSaidas.TabIndex = 4;
            labelSaidas.Text = "Saídas";
            // 
            // labelSaidasTotais
            // 
            labelSaidasTotais.AutoSize = true;
            labelSaidasTotais.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSaidasTotais.Location = new Point(570, 460);
            labelSaidasTotais.Name = "labelSaidasTotais";
            labelSaidasTotais.Size = new Size(127, 21);
            labelSaidasTotais.TabIndex = 3;
            labelSaidasTotais.Text = "SAÍDAS TOTAIS:";
            // 
            // labelEntradasTotaisValor
            // 
            labelEntradasTotaisValor.AutoSize = true;
            labelEntradasTotaisValor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelEntradasTotaisValor.ForeColor = Color.Green;
            labelEntradasTotaisValor.Location = new Point(201, 460);
            labelEntradasTotaisValor.Name = "labelEntradasTotaisValor";
            labelEntradasTotaisValor.Size = new Size(60, 21);
            labelEntradasTotaisValor.TabIndex = 3;
            labelEntradasTotaisValor.Text = "R$0,00";
            // 
            // labelSaidasTotaisValor
            // 
            labelSaidasTotaisValor.AutoSize = true;
            labelSaidasTotaisValor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSaidasTotaisValor.ForeColor = Color.FromArgb(192, 0, 0);
            labelSaidasTotaisValor.Location = new Point(716, 460);
            labelSaidasTotaisValor.Name = "labelSaidasTotaisValor";
            labelSaidasTotaisValor.Size = new Size(60, 21);
            labelSaidasTotaisValor.TabIndex = 3;
            labelSaidasTotaisValor.Text = "R$0,00";
            // 
            // numericUpDownAno
            // 
            numericUpDownAno.Location = new Point(606, 4);
            numericUpDownAno.Margin = new Padding(3, 2, 3, 2);
            numericUpDownAno.Maximum = new decimal(new int[] { 2099, 0, 0, 0 });
            numericUpDownAno.Minimum = new decimal(new int[] { 2023, 0, 0, 0 });
            numericUpDownAno.Name = "numericUpDownAno";
            numericUpDownAno.Size = new Size(131, 23);
            numericUpDownAno.TabIndex = 5;
            numericUpDownAno.Value = new decimal(new int[] { 2023, 0, 0, 0 });
            // 
            // comboBoxMes
            // 
            comboBoxMes.FormattingEnabled = true;
            comboBoxMes.Items.AddRange(new object[] { "JANEIRO", "FEVEREIRO", "MARÇO", "ABRIL", "MAIO", "JUNHO", "JULHO", "AGOSTO", "SETEMBRO", "OUTUBRO", "NOVEMBRO", "DEZEMBRO" });
            comboBoxMes.Location = new Point(402, 3);
            comboBoxMes.Margin = new Padding(3, 2, 3, 2);
            comboBoxMes.Name = "comboBoxMes";
            comboBoxMes.Size = new Size(133, 23);
            comboBoxMes.TabIndex = 6;
            // 
            // labelMes
            // 
            labelMes.AutoSize = true;
            labelMes.BackColor = SystemColors.ButtonFace;
            labelMes.Location = new Point(362, 7);
            labelMes.Name = "labelMes";
            labelMes.Size = new Size(33, 15);
            labelMes.TabIndex = 7;
            labelMes.Text = "MÊS:";
            labelMes.Click += label1_Click;
            // 
            // labelAno
            // 
            labelAno.AutoSize = true;
            labelAno.BackColor = SystemColors.ButtonFace;
            labelAno.Location = new Point(564, 6);
            labelAno.Name = "labelAno";
            labelAno.Size = new Size(36, 15);
            labelAno.TabIndex = 8;
            labelAno.Text = "ANO:";
            // 
            // labelSaldo
            // 
            labelSaldo.AutoSize = true;
            labelSaldo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSaldo.Location = new Point(912, 460);
            labelSaldo.Name = "labelSaldo";
            labelSaldo.Size = new Size(66, 21);
            labelSaldo.TabIndex = 9;
            labelSaldo.Text = "SALDO:";
            // 
            // labelSaldoTotal
            // 
            labelSaldoTotal.AutoSize = true;
            labelSaldoTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSaldoTotal.ForeColor = Color.Black;
            labelSaldoTotal.Location = new Point(1001, 460);
            labelSaldoTotal.Name = "labelSaldoTotal";
            labelSaldoTotal.Size = new Size(60, 21);
            labelSaldoTotal.TabIndex = 10;
            labelSaldoTotal.Text = "R$0,00";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "plus.png");
            imageList1.Images.SetKeyName(1, "minus.png");
            imageList1.Images.SetKeyName(2, "minus-button.png");
            imageList1.Images.SetKeyName(3, "remove.png");
            // 
            // lblAddReceitas
            // 
            lblAddReceitas.AutoSize = true;
            lblAddReceitas.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddReceitas.ImageAlign = ContentAlignment.TopLeft;
            lblAddReceitas.ImageIndex = 0;
            lblAddReceitas.ImageList = imageList1;
            lblAddReceitas.Location = new Point(254, 97);
            lblAddReceitas.Name = "lblAddReceitas";
            lblAddReceitas.Size = new Size(118, 25);
            lblAddReceitas.TabIndex = 11;
            lblAddReceitas.Text = "     Adicionar";
            lblAddReceitas.TextAlign = ContentAlignment.TopCenter;
            lblAddReceitas.Click += buttonAddReceita_Click;
            // 
            // lblRemoverReceitas
            // 
            lblRemoverReceitas.AutoSize = true;
            lblRemoverReceitas.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblRemoverReceitas.ImageAlign = ContentAlignment.TopLeft;
            lblRemoverReceitas.ImageIndex = 2;
            lblRemoverReceitas.ImageList = imageList1;
            lblRemoverReceitas.Location = new Point(378, 98);
            lblRemoverReceitas.Name = "lblRemoverReceitas";
            lblRemoverReceitas.Size = new Size(110, 25);
            lblRemoverReceitas.TabIndex = 12;
            lblRemoverReceitas.Text = "     Remover";
            lblRemoverReceitas.TextAlign = ContentAlignment.TopCenter;
            lblRemoverReceitas.Click += btnRemoverEntrada_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.TopLeft;
            label1.ImageIndex = 2;
            label1.ImageList = imageList1;
            label1.Location = new Point(951, 100);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 14;
            label1.Text = "     Remover";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += btnRemoverSaida_Click;
            // 
            // lblAddSaida
            // 
            lblAddSaida.AutoSize = true;
            lblAddSaida.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddSaida.ImageAlign = ContentAlignment.TopLeft;
            lblAddSaida.ImageIndex = 0;
            lblAddSaida.ImageList = imageList1;
            lblAddSaida.Location = new Point(827, 99);
            lblAddSaida.Name = "lblAddSaida";
            lblAddSaida.Size = new Size(118, 25);
            lblAddSaida.TabIndex = 13;
            lblAddSaida.Text = "     Adicionar";
            lblAddSaida.TextAlign = ContentAlignment.TopCenter;
            lblAddSaida.Click += buttonAddDespesa_Click;
            // 
            // HomeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1110, 507);
            Controls.Add(label1);
            Controls.Add(lblAddSaida);
            Controls.Add(lblRemoverReceitas);
            Controls.Add(lblAddReceitas);
            Controls.Add(labelSaldoTotal);
            Controls.Add(labelSaldo);
            Controls.Add(labelAno);
            Controls.Add(labelMes);
            Controls.Add(comboBoxMes);
            Controls.Add(numericUpDownAno);
            Controls.Add(labelSaidasTotaisValor);
            Controls.Add(labelSaidas);
            Controls.Add(labelSaidasTotais);
            Controls.Add(labelEntradasTotaisValor);
            Controls.Add(labelEntradas);
            Controls.Add(labelEntradasTotais);
            Controls.Add(toolStrip1);
            Controls.Add(dataGridDespesas);
            Controls.Add(dataGridReceitas);
            Name = "HomeView";
            Text = "MÊS";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridReceitas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridDespesas).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAno).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridReceitas;
        private DataGridView dataGridDespesas;
        private ToolStrip toolStrip1;
        private ToolStripTextBox searchTextField;
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
        private Label labelSaldoTotal;
        private ImageList imageList1;
        private Label lblAddReceitas;
        private Label lblRemoverReceitas;
        private Label label1;
        private Label lblAddSaida;
    }
}