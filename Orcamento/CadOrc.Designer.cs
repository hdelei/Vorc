namespace Orcamento
{
    partial class CadOrc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadOrc));
            this.gboxDatagrid = new System.Windows.Forms.GroupBox();
            this.lblPorcento = new System.Windows.Forms.Label();
            this.btnDesconto = new System.Windows.Forms.Button();
            this.tbCustoFinal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tbDesconto = new System.Windows.Forms.TextBox();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.dgvpProd = new System.Windows.Forms.DataGridView();
            this.gboxCliente = new System.Windows.Forms.GroupBox();
            this.tipoDinamico = new System.Windows.Forms.Label();
            this.nomeDinamico = new System.Windows.Forms.Label();
            this.btConfirma = new System.Windows.Forms.Button();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblLocal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxNome = new System.Windows.Forms.ComboBox();
            this.cboxTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelOrcamento = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnImprime = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.visualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkCalc = new System.Windows.Forms.LinkLabel();
            this.gboxProduto = new System.Windows.Forms.GroupBox();
            this.rdNovo = new System.Windows.Forms.RadioButton();
            this.rdExistente = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.lblQuant = new System.Windows.Forms.Label();
            this.cboxQuant = new System.Windows.Forms.ComboBox();
            this.btRemoveProd = new System.Windows.Forms.Button();
            this.btIncluiProd = new System.Windows.Forms.Button();
            this.tbPrecoProposta = new System.Windows.Forms.TextBox();
            this.tbPrecoCadastro = new System.Windows.Forms.TextBox();
            this.lblPrecoProp = new System.Windows.Forms.Label();
            this.lblPrecoCad = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.cboxProduto = new System.Windows.Forms.ComboBox();
            this.btCancela = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblItems = new System.Windows.Forms.Label();
            this.gboxDatagrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpProd)).BeginInit();
            this.gboxCliente.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gboxProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxDatagrid
            // 
            this.gboxDatagrid.Controls.Add(this.lblPorcento);
            this.gboxDatagrid.Controls.Add(this.btnDesconto);
            this.gboxDatagrid.Controls.Add(this.tbCustoFinal);
            this.gboxDatagrid.Controls.Add(this.lblTotal);
            this.gboxDatagrid.Controls.Add(this.tbDesconto);
            this.gboxDatagrid.Controls.Add(this.lblDesconto);
            this.gboxDatagrid.Controls.Add(this.dgvpProd);
            this.gboxDatagrid.Location = new System.Drawing.Point(13, 185);
            this.gboxDatagrid.Name = "gboxDatagrid";
            this.gboxDatagrid.Size = new System.Drawing.Size(959, 386);
            this.gboxDatagrid.TabIndex = 5;
            this.gboxDatagrid.TabStop = false;
            this.gboxDatagrid.Text = "Produtos e serviços";
            // 
            // lblPorcento
            // 
            this.lblPorcento.AutoSize = true;
            this.lblPorcento.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblPorcento.Location = new System.Drawing.Point(367, 349);
            this.lblPorcento.Name = "lblPorcento";
            this.lblPorcento.Size = new System.Drawing.Size(83, 13);
            this.lblPorcento.TabIndex = 8;
            this.lblPorcento.Text = "0% de desconto";
            // 
            // btnDesconto
            // 
            this.btnDesconto.Location = new System.Drawing.Point(209, 345);
            this.btnDesconto.Name = "btnDesconto";
            this.btnDesconto.Size = new System.Drawing.Size(106, 23);
            this.btnDesconto.TabIndex = 6;
            this.btnDesconto.Text = "Aplicar desconto";
            this.toolTip1.SetToolTip(this.btnDesconto, "Função indisponível.");
            this.btnDesconto.UseVisualStyleBackColor = true;
            this.btnDesconto.Click += new System.EventHandler(this.btnDesconto_Click);
            // 
            // tbCustoFinal
            // 
            this.tbCustoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustoFinal.Location = new System.Drawing.Point(725, 344);
            this.tbCustoFinal.Name = "tbCustoFinal";
            this.tbCustoFinal.ReadOnly = true;
            this.tbCustoFinal.Size = new System.Drawing.Size(214, 29);
            this.tbCustoFinal.TabIndex = 5;
            this.tbCustoFinal.Text = "0";
            this.tbCustoFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.tbCustoFinal, "Custo final da proposta.");
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(605, 347);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(114, 24);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Custo Final: ";
            // 
            // tbDesconto
            // 
            this.tbDesconto.Location = new System.Drawing.Point(92, 347);
            this.tbDesconto.Name = "tbDesconto";
            this.tbDesconto.Size = new System.Drawing.Size(100, 20);
            this.tbDesconto.TabIndex = 3;
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(18, 350);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(70, 13);
            this.lblDesconto.TabIndex = 1;
            this.lblDesconto.Text = "Desconto R$";
            // 
            // dgvpProd
            // 
            this.dgvpProd.AllowUserToResizeColumns = false;
            this.dgvpProd.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvpProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpProd.Location = new System.Drawing.Point(18, 19);
            this.dgvpProd.Name = "dgvpProd";
            this.dgvpProd.ReadOnly = true;
            this.dgvpProd.RowHeadersVisible = false;
            this.dgvpProd.Size = new System.Drawing.Size(923, 313);
            this.dgvpProd.TabIndex = 0;
            this.dgvpProd.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvpProd_RowsAdded);
            this.dgvpProd.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvpProd_RowsRemoved);
            // 
            // gboxCliente
            // 
            this.gboxCliente.Controls.Add(this.tipoDinamico);
            this.gboxCliente.Controls.Add(this.nomeDinamico);
            this.gboxCliente.Controls.Add(this.btConfirma);
            this.gboxCliente.Controls.Add(this.lblEndereco);
            this.gboxCliente.Controls.Add(this.lblLocal);
            this.gboxCliente.Controls.Add(this.label4);
            this.gboxCliente.Controls.Add(this.label2);
            this.gboxCliente.Controls.Add(this.cboxNome);
            this.gboxCliente.Controls.Add(this.cboxTipo);
            this.gboxCliente.Controls.Add(this.label1);
            this.gboxCliente.Controls.Add(this.labelOrcamento);
            this.gboxCliente.Controls.Add(this.lblNumero);
            this.gboxCliente.Controls.Add(this.label3);
            this.gboxCliente.Location = new System.Drawing.Point(13, 41);
            this.gboxCliente.Name = "gboxCliente";
            this.gboxCliente.Size = new System.Drawing.Size(492, 136);
            this.gboxCliente.TabIndex = 4;
            this.gboxCliente.TabStop = false;
            this.gboxCliente.Text = "Selecionar Cliente";
            // 
            // tipoDinamico
            // 
            this.tipoDinamico.AutoSize = true;
            this.tipoDinamico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoDinamico.Location = new System.Drawing.Point(128, 111);
            this.tipoDinamico.Name = "tipoDinamico";
            this.tipoDinamico.Size = new System.Drawing.Size(88, 13);
            this.tipoDinamico.TabIndex = 10;
            this.tipoDinamico.Text = "Tipo Dinamico";
            this.tipoDinamico.Visible = false;
            // 
            // nomeDinamico
            // 
            this.nomeDinamico.AutoSize = true;
            this.nomeDinamico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeDinamico.Location = new System.Drawing.Point(58, 30);
            this.nomeDinamico.Name = "nomeDinamico";
            this.nomeDinamico.Size = new System.Drawing.Size(93, 13);
            this.nomeDinamico.TabIndex = 10;
            this.nomeDinamico.Text = "Nome dinamico";
            this.nomeDinamico.Visible = false;
            // 
            // btConfirma
            // 
            this.btConfirma.Location = new System.Drawing.Point(390, 26);
            this.btConfirma.Name = "btConfirma";
            this.btConfirma.Size = new System.Drawing.Size(83, 58);
            this.btConfirma.TabIndex = 9;
            this.btConfirma.Text = "Confirmar";
            this.btConfirma.UseVisualStyleBackColor = true;
            this.btConfirma.Click += new System.EventHandler(this.btConfirma_Click);
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(76, 60);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(14, 13);
            this.lblEndereco.TabIndex = 8;
            this.lblEndereco.Text = "a";
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.Location = new System.Drawing.Point(56, 86);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(14, 13);
            this.lblLocal.TabIndex = 8;
            this.lblLocal.Text = "a";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Endereço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Local:";
            // 
            // cboxNome
            // 
            this.cboxNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxNome.DisplayMember = "nome";
            this.cboxNome.FormattingEnabled = true;
            this.cboxNome.Location = new System.Drawing.Point(56, 26);
            this.cboxNome.Name = "cboxNome";
            this.cboxNome.Size = new System.Drawing.Size(317, 21);
            this.cboxNome.TabIndex = 6;
            this.cboxNome.ValueMember = "id";
            this.cboxNome.SelectedIndexChanged += new System.EventHandler(this.cboxNome_SelectedIndexChanged);
            // 
            // cboxTipo
            // 
            this.cboxTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxTipo.DisplayMember = "nome";
            this.cboxTipo.FormattingEnabled = true;
            this.cboxTipo.Location = new System.Drawing.Point(125, 107);
            this.cboxTipo.Name = "cboxTipo";
            this.cboxTipo.Size = new System.Drawing.Size(181, 21);
            this.cboxTipo.TabIndex = 5;
            this.cboxTipo.ValueMember = "id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo de orçamento:";
            // 
            // labelOrcamento
            // 
            this.labelOrcamento.AutoSize = true;
            this.labelOrcamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrcamento.ForeColor = System.Drawing.Color.Green;
            this.labelOrcamento.Location = new System.Drawing.Point(329, 110);
            this.labelOrcamento.Name = "labelOrcamento";
            this.labelOrcamento.Size = new System.Drawing.Size(115, 13);
            this.labelOrcamento.TabIndex = 3;
            this.labelOrcamento.Text = "orçamento número:";
            this.labelOrcamento.Visible = false;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.ForeColor = System.Drawing.Color.Maroon;
            this.lblNumero.Location = new System.Drawing.Point(445, 110);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(14, 13);
            this.lblNumero.TabIndex = 2;
            this.lblNumero.Text = "_";
            this.lblNumero.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nome:";
            // 
            // btnLimpa
            // 
            this.btnLimpa.Location = new System.Drawing.Point(175, 582);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(179, 23);
            this.btnLimpa.TabIndex = 7;
            this.btnLimpa.Text = "Revover itens";
            this.toolTip1.SetToolTip(this.btnLimpa, "Limpa todos os itens do orçamento.");
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // btnImprime
            // 
            this.btnImprime.Location = new System.Drawing.Point(13, 582);
            this.btnImprime.Name = "btnImprime";
            this.btnImprime.Size = new System.Drawing.Size(137, 23);
            this.btnImprime.TabIndex = 8;
            this.btnImprime.Text = "Visualizar";
            this.toolTip1.SetToolTip(this.btnImprime, "Abre o orçamento em modo de impressão.");
            this.btnImprime.UseVisualStyleBackColor = true;
            this.btnImprime.Click += new System.EventHandler(this.btnImprime_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSalmon;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarToolStripMenuItem,
            this.statusToolStripMenuItem,
            this.toolStripStatus,
            this.fecharToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // visualizarToolStripMenuItem
            // 
            this.visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            this.visualizarToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.visualizarToolStripMenuItem.Text = "- Visualizar -";
            this.visualizarToolStripMenuItem.Click += new System.EventHandler(this.visualizarToolStripMenuItem_Click);
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.statusToolStripMenuItem.Text = "- Status -";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Aprovado",
            "Reprovado",
            "Pendente"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.Text = "Selecione";
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.BackColor = System.Drawing.Color.MistyRose;
            this.toolStripStatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(12, 20);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.fecharToolStripMenuItem.Text = "- Fechar -";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // linkCalc
            // 
            this.linkCalc.AutoSize = true;
            this.linkCalc.Location = new System.Drawing.Point(891, 574);
            this.linkCalc.Name = "linkCalc";
            this.linkCalc.Size = new System.Drawing.Size(63, 13);
            this.linkCalc.TabIndex = 10;
            this.linkCalc.TabStop = true;
            this.linkCalc.Text = "Calculadora";
            this.linkCalc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // gboxProduto
            // 
            this.gboxProduto.Controls.Add(this.rdNovo);
            this.gboxProduto.Controls.Add(this.rdExistente);
            this.gboxProduto.Controls.Add(this.label5);
            this.gboxProduto.Controls.Add(this.lblQuant);
            this.gboxProduto.Controls.Add(this.cboxQuant);
            this.gboxProduto.Controls.Add(this.btRemoveProd);
            this.gboxProduto.Controls.Add(this.btIncluiProd);
            this.gboxProduto.Controls.Add(this.tbPrecoProposta);
            this.gboxProduto.Controls.Add(this.tbPrecoCadastro);
            this.gboxProduto.Controls.Add(this.lblPrecoProp);
            this.gboxProduto.Controls.Add(this.lblPrecoCad);
            this.gboxProduto.Controls.Add(this.lblProduto);
            this.gboxProduto.Controls.Add(this.cboxProduto);
            this.gboxProduto.Enabled = false;
            this.gboxProduto.Location = new System.Drawing.Point(510, 41);
            this.gboxProduto.Name = "gboxProduto";
            this.gboxProduto.Size = new System.Drawing.Size(461, 136);
            this.gboxProduto.TabIndex = 11;
            this.gboxProduto.TabStop = false;
            this.gboxProduto.Text = "Adicionar Produtos no Orçamento";
            // 
            // rdNovo
            // 
            this.rdNovo.AutoSize = true;
            this.rdNovo.Location = new System.Drawing.Point(132, 18);
            this.rdNovo.Name = "rdNovo";
            this.rdNovo.Size = new System.Drawing.Size(49, 17);
            this.rdNovo.TabIndex = 9;
            this.rdNovo.Text = "novo";
            this.rdNovo.UseVisualStyleBackColor = true;
            this.rdNovo.CheckedChanged += new System.EventHandler(this.rdNovo_CheckedChanged);
            // 
            // rdExistente
            // 
            this.rdExistente.AutoSize = true;
            this.rdExistente.Checked = true;
            this.rdExistente.Location = new System.Drawing.Point(58, 18);
            this.rdExistente.Name = "rdExistente";
            this.rdExistente.Size = new System.Drawing.Size(75, 17);
            this.rdExistente.TabIndex = 9;
            this.rdExistente.TabStop = true;
            this.rdExistente.Text = "existente /";
            this.rdExistente.UseVisualStyleBackColor = true;
            this.rdExistente.CheckedChanged += new System.EventHandler(this.rdExistente_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Preço:";
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.Location = new System.Drawing.Point(372, 20);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(65, 13);
            this.lblQuant.TabIndex = 7;
            this.lblQuant.Text = "Quantidade:";
            // 
            // cboxQuant
            // 
            this.cboxQuant.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboxQuant.FormattingEnabled = true;
            this.cboxQuant.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cboxQuant.Location = new System.Drawing.Point(364, 36);
            this.cboxQuant.Name = "cboxQuant";
            this.cboxQuant.Size = new System.Drawing.Size(77, 21);
            this.cboxQuant.TabIndex = 6;
            this.cboxQuant.Text = "1";
            this.cboxQuant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboxQuant_KeyPress);
            // 
            // btRemoveProd
            // 
            this.btRemoveProd.Location = new System.Drawing.Point(279, 82);
            this.btRemoveProd.Name = "btRemoveProd";
            this.btRemoveProd.Size = new System.Drawing.Size(87, 46);
            this.btRemoveProd.TabIndex = 5;
            this.btRemoveProd.Text = "Excluir item";
            this.btRemoveProd.UseVisualStyleBackColor = true;
            this.btRemoveProd.Click += new System.EventHandler(this.btRemoveProd_Click);
            // 
            // btIncluiProd
            // 
            this.btIncluiProd.Location = new System.Drawing.Point(171, 82);
            this.btIncluiProd.Name = "btIncluiProd";
            this.btIncluiProd.Size = new System.Drawing.Size(93, 46);
            this.btIncluiProd.TabIndex = 5;
            this.btIncluiProd.Text = "Incluir item";
            this.btIncluiProd.UseVisualStyleBackColor = true;
            this.btIncluiProd.Click += new System.EventHandler(this.btIncluiProd_Click);
            // 
            // tbPrecoProposta
            // 
            this.tbPrecoProposta.Location = new System.Drawing.Point(58, 108);
            this.tbPrecoProposta.Name = "tbPrecoProposta";
            this.tbPrecoProposta.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbPrecoProposta.Size = new System.Drawing.Size(100, 20);
            this.tbPrecoProposta.TabIndex = 4;
            this.toolTip1.SetToolTip(this.tbPrecoProposta, "Se necessário, este valor pode ser modificado antes de adicionar um item.");
            // 
            // tbPrecoCadastro
            // 
            this.tbPrecoCadastro.BackColor = System.Drawing.Color.Gainsboro;
            this.tbPrecoCadastro.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbPrecoCadastro.Location = new System.Drawing.Point(57, 82);
            this.tbPrecoCadastro.Name = "tbPrecoCadastro";
            this.tbPrecoCadastro.ReadOnly = true;
            this.tbPrecoCadastro.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbPrecoCadastro.Size = new System.Drawing.Size(100, 20);
            this.tbPrecoCadastro.TabIndex = 4;
            this.toolTip1.SetToolTip(this.tbPrecoCadastro, "Valor original do produto.");
            // 
            // lblPrecoProp
            // 
            this.lblPrecoProp.AutoSize = true;
            this.lblPrecoProp.Location = new System.Drawing.Point(6, 110);
            this.lblPrecoProp.Name = "lblPrecoProp";
            this.lblPrecoProp.Size = new System.Drawing.Size(48, 13);
            this.lblPrecoProp.TabIndex = 3;
            this.lblPrecoProp.Text = "proposta";
            // 
            // lblPrecoCad
            // 
            this.lblPrecoCad.AutoSize = true;
            this.lblPrecoCad.Location = new System.Drawing.Point(6, 84);
            this.lblPrecoCad.Name = "lblPrecoCad";
            this.lblPrecoCad.Size = new System.Drawing.Size(48, 13);
            this.lblPrecoCad.TabIndex = 2;
            this.lblPrecoCad.Text = "cadastro";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(12, 20);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(47, 13);
            this.lblProduto.TabIndex = 1;
            this.lblProduto.Text = "Produto ";
            // 
            // cboxProduto
            // 
            this.cboxProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxProduto.DisplayMember = "nome";
            this.cboxProduto.FormattingEnabled = true;
            this.cboxProduto.Location = new System.Drawing.Point(14, 36);
            this.cboxProduto.Name = "cboxProduto";
            this.cboxProduto.Size = new System.Drawing.Size(288, 21);
            this.cboxProduto.TabIndex = 0;
            this.cboxProduto.ValueMember = "id";
            this.cboxProduto.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboxProduto_DrawItem);
            this.cboxProduto.SelectedIndexChanged += new System.EventHandler(this.cboxProduto_SelectedIndexChanged);
            this.cboxProduto.DropDownClosed += new System.EventHandler(this.cboxProduto_DropDownClosed);
            // 
            // btCancela
            // 
            this.btCancela.BackColor = System.Drawing.SystemColors.Control;
            this.btCancela.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btCancela.Location = new System.Drawing.Point(385, 581);
            this.btCancela.Name = "btCancela";
            this.btCancela.Size = new System.Drawing.Size(179, 23);
            this.btCancela.TabIndex = 12;
            this.btCancela.Text = "Deletar orçamento";
            this.toolTip1.SetToolTip(this.btCancela, "Apaga o orçamento.");
            this.btCancela.UseVisualStyleBackColor = false;
            this.btCancela.Click += new System.EventHandler(this.btCancela_Click);
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.BackColor = System.Drawing.Color.LightSalmon;
            this.lblItems.ForeColor = System.Drawing.Color.SeaShell;
            this.lblItems.Location = new System.Drawing.Point(878, 6);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(26, 13);
            this.lblItems.TabIndex = 13;
            this.lblItems.Text = "item";
            // 
            // CadOrc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 613);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.btCancela);
            this.Controls.Add(this.gboxProduto);
            this.Controls.Add(this.linkCalc);
            this.Controls.Add(this.btnImprime);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.gboxDatagrid);
            this.Controls.Add(this.gboxCliente);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadOrc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Orçamentos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.CadOrc_Load_1);
            this.gboxDatagrid.ResumeLayout(false);
            this.gboxDatagrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpProd)).EndInit();
            this.gboxCliente.ResumeLayout(false);
            this.gboxCliente.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gboxProduto.ResumeLayout(false);
            this.gboxProduto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxDatagrid;
        private System.Windows.Forms.GroupBox gboxCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Label labelOrcamento;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnImprime;
        private System.Windows.Forms.TextBox tbCustoFinal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox tbDesconto;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Button btnDesconto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.ComboBox cboxTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkCalc;
        private System.Windows.Forms.ComboBox cboxNome;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gboxProduto;
        private System.Windows.Forms.Button btIncluiProd;
        private System.Windows.Forms.TextBox tbPrecoProposta;
        private System.Windows.Forms.TextBox tbPrecoCadastro;
        private System.Windows.Forms.Label lblPrecoProp;
        private System.Windows.Forms.Label lblPrecoCad;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.ComboBox cboxProduto;
        private System.Windows.Forms.Button btConfirma;
        private System.Windows.Forms.Button btRemoveProd;
        private System.Windows.Forms.Label lblQuant;
        private System.Windows.Forms.ComboBox cboxQuant;
        private System.Windows.Forms.Label tipoDinamico;
        private System.Windows.Forms.Label nomeDinamico;
        private System.Windows.Forms.Button btCancela;
        public System.Windows.Forms.DataGridView dgvpProd;
        private System.Windows.Forms.ToolStripMenuItem visualizarToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripStatus;
        private System.Windows.Forms.Label lblPorcento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdNovo;
        private System.Windows.Forms.RadioButton rdExistente;
        private System.Windows.Forms.Label lblItems;
    }
}