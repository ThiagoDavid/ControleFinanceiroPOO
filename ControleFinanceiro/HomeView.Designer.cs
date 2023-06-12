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
            this.labelSaldo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblAddReceitas = new System.Windows.Forms.Label();
            this.lblRemoverReceitas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAddSaida = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReceitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDespesas)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAno)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridReceitas
            // 
            this.dataGridReceitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.toolStrip1.Size = new System.Drawing.Size(1110, 28);
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
            this.searchTextField.Size = new System.Drawing.Size(90, 28);
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
            this.labelEntradasTotais.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEntradasTotais.Location = new System.Drawing.Point(22, 460);
            this.labelEntradasTotais.Name = "labelEntradasTotais";
            this.labelEntradasTotais.Size = new System.Drawing.Size(154, 21);
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
            this.labelSaidasTotais.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSaidasTotais.Location = new System.Drawing.Point(570, 460);
            this.labelSaidasTotais.Name = "labelSaidasTotais";
            this.labelSaidasTotais.Size = new System.Drawing.Size(127, 21);
            this.labelSaidasTotais.TabIndex = 3;
            this.labelSaidasTotais.Text = "SAÍDAS TOTAIS:";
            // 
            // labelEntradasTotaisValor
            // 
            this.labelEntradasTotaisValor.AutoSize = true;
            this.labelEntradasTotaisValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEntradasTotaisValor.ForeColor = System.Drawing.Color.Green;
            this.labelEntradasTotaisValor.Location = new System.Drawing.Point(201, 460);
            this.labelEntradasTotaisValor.Name = "labelEntradasTotaisValor";
            this.labelEntradasTotaisValor.Size = new System.Drawing.Size(60, 21);
            this.labelEntradasTotaisValor.TabIndex = 3;
            this.labelEntradasTotaisValor.Text = "R$0,00";
            // 
            // labelSaidasTotaisValor
            // 
            this.labelSaidasTotaisValor.AutoSize = true;
            this.labelSaidasTotaisValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSaidasTotaisValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelSaidasTotaisValor.Location = new System.Drawing.Point(716, 460);
            this.labelSaidasTotaisValor.Name = "labelSaidasTotaisValor";
            this.labelSaidasTotaisValor.Size = new System.Drawing.Size(60, 21);
            this.labelSaidasTotaisValor.TabIndex = 3;
            this.labelSaidasTotaisValor.Text = "R$0,00";
            // 
            // numericUpDownAno
            // 
            this.numericUpDownAno.Location = new System.Drawing.Point(606, 4);
            this.numericUpDownAno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.numericUpDownAno.Size = new System.Drawing.Size(131, 23);
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
            this.comboBoxMes.Location = new System.Drawing.Point(402, 3);
            this.comboBoxMes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMes.Name = "comboBoxMes";
            this.comboBoxMes.Size = new System.Drawing.Size(133, 23);
            this.comboBoxMes.TabIndex = 6;
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
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSaldo.Location = new System.Drawing.Point(912, 460);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(66, 21);
            this.labelSaldo.TabIndex = 9;
            this.labelSaldo.Text = "SALDO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1001, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "R$0,00";
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
            // lblAddReceitas
            // 
            this.lblAddReceitas.AutoSize = true;
            this.lblAddReceitas.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddReceitas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblAddReceitas.ImageIndex = 0;
            this.lblAddReceitas.ImageList = this.imageList1;
            this.lblAddReceitas.Location = new System.Drawing.Point(254, 97);
            this.lblAddReceitas.Name = "lblAddReceitas";
            this.lblAddReceitas.Size = new System.Drawing.Size(118, 25);
            this.lblAddReceitas.TabIndex = 11;
            this.lblAddReceitas.Text = "     Adicionar";
            this.lblAddReceitas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblAddReceitas.Click += new System.EventHandler(this.buttonAddReceita_Click);
            // 
            // lblRemoverReceitas
            // 
            this.lblRemoverReceitas.AutoSize = true;
            this.lblRemoverReceitas.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRemoverReceitas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblRemoverReceitas.ImageIndex = 2;
            this.lblRemoverReceitas.ImageList = this.imageList1;
            this.lblRemoverReceitas.Location = new System.Drawing.Point(378, 98);
            this.lblRemoverReceitas.Name = "lblRemoverReceitas";
            this.lblRemoverReceitas.Size = new System.Drawing.Size(110, 25);
            this.lblRemoverReceitas.TabIndex = 12;
            this.lblRemoverReceitas.Text = "     Remover";
            this.lblRemoverReceitas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblRemoverReceitas.Click += new System.EventHandler(this.btnRemoverEntrada_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.ImageIndex = 2;
            this.label1.ImageList = this.imageList1;
            this.label1.Location = new System.Drawing.Point(951, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "     Remover";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.btnRemoverSaida_Click);
            // 
            // lblAddSaida
            // 
            this.lblAddSaida.AutoSize = true;
            this.lblAddSaida.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddSaida.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblAddSaida.ImageIndex = 0;
            this.lblAddSaida.ImageList = this.imageList1;
            this.lblAddSaida.Location = new System.Drawing.Point(827, 99);
            this.lblAddSaida.Name = "lblAddSaida";
            this.lblAddSaida.Size = new System.Drawing.Size(118, 25);
            this.lblAddSaida.TabIndex = 13;
            this.lblAddSaida.Text = "     Adicionar";
            this.lblAddSaida.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblAddSaida.Click += new System.EventHandler(this.buttonAddDespesa_Click);
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1110, 507);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAddSaida);
            this.Controls.Add(this.lblRemoverReceitas);
            this.Controls.Add(this.lblAddReceitas);
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
        private Label labelSaldo;
        private Label label2;
        private ImageList imageList1;
        private Label lblAddReceitas;
        private Label lblRemoverReceitas;
        private Label label1;
        private Label lblAddSaida;
    }
}