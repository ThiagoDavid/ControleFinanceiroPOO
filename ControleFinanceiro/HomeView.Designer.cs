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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeView));
            this.dataGridReceitas = new System.Windows.Forms.DataGridView();
            this.dataGridDespesas = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.buttonSave = new System.Windows.Forms.ToolStripButton();
            this.searchTextField = new System.Windows.Forms.ToolStripTextBox();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.labelSaldo = new System.Windows.Forms.Label();
            this.labelSaldoTotal = new System.Windows.Forms.Label();
            this.btnAddEntrada = new System.Windows.Forms.Button();
            this.btnAddSaida = new System.Windows.Forms.Button();
            this.btnRemoveEntrada = new System.Windows.Forms.Button();
            this.btnRemoveSaida = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReceitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDespesas)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAno)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridReceitas
            // 
            this.dataGridReceitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReceitas.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridReceitas.Location = new System.Drawing.Point(22, 128);
            this.dataGridReceitas.Name = "dataGridReceitas";
            this.dataGridReceitas.RowHeadersWidth = 51;
            this.dataGridReceitas.RowTemplate.Height = 25;
            this.dataGridReceitas.Size = new System.Drawing.Size(500, 324);
            this.dataGridReceitas.TabIndex = 0;
            this.dataGridReceitas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridReceitas_CellEndEdit);
            // 
            // dataGridDespesas
            // 
            this.dataGridDespesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDespesas.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridDespesas.Location = new System.Drawing.Point(570, 128);
            this.dataGridDespesas.Name = "dataGridDespesas";
            this.dataGridDespesas.RowHeadersWidth = 51;
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
            this.searchTextField,
            this.btnSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1157, 28);
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
            this.buttonSave.Margin = new System.Windows.Forms.Padding(20, 2, 10, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(24, 24);
            this.buttonSave.Text = "Salvar";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // searchTextField
            // 
            this.searchTextField.Name = "searchTextField";
            this.searchTextField.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.searchTextField.Size = new System.Drawing.Size(0, 28);
            // 
            // btnSearch
            // 
            this.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSearch.Size = new System.Drawing.Size(34, 25);
            this.btnSearch.Text = "toolStripButton1";
            // 
            // labelEntradas
            // 
            this.labelEntradas.AutoSize = true;
            this.labelEntradas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEntradas.Location = new System.Drawing.Point(22, 101);
            this.labelEntradas.Name = "labelEntradas";
            this.labelEntradas.Size = new System.Drawing.Size(76, 21);
            this.labelEntradas.TabIndex = 3;
            this.labelEntradas.Text = "Entradas";
            // 
            // labelEntradasTotais
            // 
            this.labelEntradasTotais.AutoSize = true;
            this.labelEntradasTotais.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEntradasTotais.Location = new System.Drawing.Point(22, 460);
            this.labelEntradasTotais.Name = "labelEntradasTotais";
            this.labelEntradasTotais.Size = new System.Drawing.Size(136, 19);
            this.labelEntradasTotais.TabIndex = 3;
            this.labelEntradasTotais.Text = "ENTRADAS TOTAIS:";
            // 
            // labelSaidas
            // 
            this.labelSaidas.AutoSize = true;
            this.labelSaidas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSaidas.Location = new System.Drawing.Point(570, 101);
            this.labelSaidas.Name = "labelSaidas";
            this.labelSaidas.Size = new System.Drawing.Size(59, 21);
            this.labelSaidas.TabIndex = 4;
            this.labelSaidas.Text = "Saídas";
            // 
            // labelSaidasTotais
            // 
            this.labelSaidasTotais.AutoSize = true;
            this.labelSaidasTotais.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSaidasTotais.Location = new System.Drawing.Point(570, 460);
            this.labelSaidasTotais.Name = "labelSaidasTotais";
            this.labelSaidasTotais.Size = new System.Drawing.Size(113, 19);
            this.labelSaidasTotais.TabIndex = 3;
            this.labelSaidasTotais.Text = "SAÍDAS TOTAIS:";
            // 
            // labelEntradasTotaisValor
            // 
            this.labelEntradasTotaisValor.AutoSize = true;
            this.labelEntradasTotaisValor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEntradasTotaisValor.ForeColor = System.Drawing.Color.Green;
            this.labelEntradasTotaisValor.Location = new System.Drawing.Point(179, 460);
            this.labelEntradasTotaisValor.Name = "labelEntradasTotaisValor";
            this.labelEntradasTotaisValor.Size = new System.Drawing.Size(52, 19);
            this.labelEntradasTotaisValor.TabIndex = 3;
            this.labelEntradasTotaisValor.Text = "R$0,00";
            // 
            // labelSaidasTotaisValor
            // 
            this.labelSaidasTotaisValor.AutoSize = true;
            this.labelSaidasTotaisValor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSaidasTotaisValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelSaidasTotaisValor.Location = new System.Drawing.Point(698, 460);
            this.labelSaidasTotaisValor.Name = "labelSaidasTotaisValor";
            this.labelSaidasTotaisValor.Size = new System.Drawing.Size(52, 19);
            this.labelSaidasTotaisValor.TabIndex = 3;
            this.labelSaidasTotaisValor.Text = "R$0,00";
            // 
            // numericUpDownAno
            // 
            this.numericUpDownAno.Location = new System.Drawing.Point(606, 4);
            this.numericUpDownAno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownAno.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownAno.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownAno.Name = "numericUpDownAno";
            this.numericUpDownAno.Size = new System.Drawing.Size(131, 23);
            this.numericUpDownAno.TabIndex = 5;
            this.numericUpDownAno.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.numericUpDownAno.ValueChanged += new System.EventHandler(this.comboBoxMes_SelectedIndexChanged);
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
            this.comboBoxMes.Location = new System.Drawing.Point(402, 3);
            this.comboBoxMes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMes.Name = "comboBoxMes";
            this.comboBoxMes.Size = new System.Drawing.Size(133, 23);
            this.comboBoxMes.TabIndex = 6;
            this.comboBoxMes.SelectedIndexChanged += new System.EventHandler(this.comboBoxMes_SelectedIndexChanged);
            // 
            // labelMes
            // 
            this.labelMes.AutoSize = true;
            this.labelMes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelMes.Location = new System.Drawing.Point(362, 7);
            this.labelMes.Name = "labelMes";
            this.labelMes.Size = new System.Drawing.Size(33, 15);
            this.labelMes.TabIndex = 7;
            this.labelMes.Text = "MÊS:";
            this.labelMes.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelAno
            // 
            this.labelAno.AutoSize = true;
            this.labelAno.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAno.Location = new System.Drawing.Point(564, 6);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(36, 15);
            this.labelAno.TabIndex = 8;
            this.labelAno.Text = "ANO:";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "plus.png");
            this.imageList1.Images.SetKeyName(1, "minus.png");
            this.imageList1.Images.SetKeyName(2, "minus-button.png");
            this.imageList1.Images.SetKeyName(3, "remove.png");
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSaldo.Location = new System.Drawing.Point(866, 470);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(79, 25);
            this.labelSaldo.TabIndex = 9;
            this.labelSaldo.Text = "SALDO:";
            // 
            // labelSaldoTotal
            // 
            this.labelSaldoTotal.AutoSize = true;
            this.labelSaldoTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSaldoTotal.ForeColor = System.Drawing.Color.Black;
            this.labelSaldoTotal.Location = new System.Drawing.Point(951, 470);
            this.labelSaldoTotal.Name = "labelSaldoTotal";
            this.labelSaldoTotal.Size = new System.Drawing.Size(73, 25);
            this.labelSaldoTotal.TabIndex = 10;
            this.labelSaldoTotal.Text = "R$0,00";
            // 
            // btnAddEntrada
            // 
            this.btnAddEntrada.BackColor = System.Drawing.Color.Transparent;
            this.btnAddEntrada.FlatAppearance.BorderSize = 5;
            this.btnAddEntrada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddEntrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEntrada.ImageKey = "plus.png";
            this.btnAddEntrada.ImageList = this.imageList1;
            this.btnAddEntrada.Location = new System.Drawing.Point(277, 92);
            this.btnAddEntrada.Name = "btnAddEntrada";
            this.btnAddEntrada.Size = new System.Drawing.Size(118, 33);
            this.btnAddEntrada.TabIndex = 15;
            this.btnAddEntrada.Text = "Adicionar";
            this.btnAddEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddEntrada.UseVisualStyleBackColor = false;
            this.btnAddEntrada.Click += new System.EventHandler(this.buttonAddReceita_Click);
            // 
            // btnAddSaida
            // 
            this.btnAddSaida.BackColor = System.Drawing.Color.Transparent;
            this.btnAddSaida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddSaida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSaida.ImageKey = "plus.png";
            this.btnAddSaida.ImageList = this.imageList1;
            this.btnAddSaida.Location = new System.Drawing.Point(827, 92);
            this.btnAddSaida.Name = "btnAddSaida";
            this.btnAddSaida.Size = new System.Drawing.Size(118, 33);
            this.btnAddSaida.TabIndex = 16;
            this.btnAddSaida.Text = "Adicionar";
            this.btnAddSaida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddSaida.UseVisualStyleBackColor = false;
            this.btnAddSaida.Click += new System.EventHandler(this.buttonAddDespesa_Click);
            // 
            // btnRemoveEntrada
            // 
            this.btnRemoveEntrada.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveEntrada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveEntrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveEntrada.ImageKey = "minus-button.png";
            this.btnRemoveEntrada.ImageList = this.imageList1;
            this.btnRemoveEntrada.Location = new System.Drawing.Point(402, 92);
            this.btnRemoveEntrada.Name = "btnRemoveEntrada";
            this.btnRemoveEntrada.Size = new System.Drawing.Size(118, 33);
            this.btnRemoveEntrada.TabIndex = 17;
            this.btnRemoveEntrada.Text = "Remover";
            this.btnRemoveEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveEntrada.UseVisualStyleBackColor = false;
            this.btnRemoveEntrada.Click += new System.EventHandler(this.btnRemoverEntrada_Click);
            // 
            // btnRemoveSaida
            // 
            this.btnRemoveSaida.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveSaida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveSaida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveSaida.ImageKey = "minus-button.png";
            this.btnRemoveSaida.ImageList = this.imageList1;
            this.btnRemoveSaida.Location = new System.Drawing.Point(951, 92);
            this.btnRemoveSaida.Name = "btnRemoveSaida";
            this.btnRemoveSaida.Size = new System.Drawing.Size(118, 33);
            this.btnRemoveSaida.TabIndex = 18;
            this.btnRemoveSaida.Text = "Remover";
            this.btnRemoveSaida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveSaida.UseVisualStyleBackColor = false;
            this.btnRemoveSaida.Click += new System.EventHandler(this.btnRemoverSaida_Click);
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1157, 600);
            this.Controls.Add(this.btnRemoveSaida);
            this.Controls.Add(this.btnRemoveEntrada);
            this.Controls.Add(this.btnAddSaida);
            this.Controls.Add(this.btnAddEntrada);
            this.Controls.Add(this.labelSaldoTotal);
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
        private ImageList imageList1;
        private Label labelSaldo;
        private Label labelSaldoTotal;
        private Button btnAddEntrada;
        private Button btnAddSaida;
        private Button btnRemoveEntrada;
        private Button btnRemoveSaida;
    }
}