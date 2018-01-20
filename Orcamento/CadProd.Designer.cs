namespace Orcamento
{
    partial class CadProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadProd));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btSalvaEdicao = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.btIncluir = new System.Windows.Forms.Button();
            this.prodDGV = new System.Windows.Forms.DataGridView();
            this.lblNumero = new System.Windows.Forms.Label();
            this.tbProduto = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.tbPreco = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.tssNome = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmQualquerParte = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btSalvaEdicao);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblCod);
            this.groupBox1.Controls.Add(this.btIncluir);
            this.groupBox1.Controls.Add(this.prodDGV);
            this.groupBox1.Controls.Add(this.lblNumero);
            this.groupBox1.Controls.Add(this.tbProduto);
            this.groupBox1.Controls.Add(this.lblPreco);
            this.groupBox1.Controls.Add(this.lblDescricao);
            this.groupBox1.Controls.Add(this.tbPreco);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(844, 463);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações dos Produtos";
            // 
            // btSalvaEdicao
            // 
            this.btSalvaEdicao.Location = new System.Drawing.Point(633, 21);
            this.btSalvaEdicao.Name = "btSalvaEdicao";
            this.btSalvaEdicao.Size = new System.Drawing.Size(99, 44);
            this.btSalvaEdicao.TabIndex = 10;
            this.btSalvaEdicao.Text = "Salvar alterações";
            this.btSalvaEdicao.UseVisualStyleBackColor = true;
            this.btSalvaEdicao.Click += new System.EventHandler(this.btSalvaEdicao_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.ForestGreen;
            this.label5.Location = new System.Drawing.Point(76, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "0";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(15, 20);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(43, 13);
            this.lblCod.TabIndex = 8;
            this.lblCod.Text = "Código:";
            // 
            // btIncluir
            // 
            this.btIncluir.Location = new System.Drawing.Point(484, 20);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(75, 44);
            this.btIncluir.TabIndex = 3;
            this.btIncluir.Text = "Incluir";
            this.btIncluir.UseVisualStyleBackColor = true;
            this.btIncluir.Click += new System.EventHandler(this.btIncluir_Click);
            // 
            // prodDGV
            // 
            this.prodDGV.AllowUserToOrderColumns = true;
            this.prodDGV.BackgroundColor = System.Drawing.Color.LightBlue;
            this.prodDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodDGV.Location = new System.Drawing.Point(18, 89);
            this.prodDGV.Name = "prodDGV";
            this.prodDGV.ReadOnly = true;
            this.prodDGV.Size = new System.Drawing.Size(806, 359);
            this.prodDGV.TabIndex = 4;
            this.prodDGV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellValueChanged);
            this.prodDGV.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.ForeColor = System.Drawing.Color.Maroon;
            this.lblNumero.Location = new System.Drawing.Point(910, 87);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(31, 13);
            this.lblNumero.TabIndex = 2;
            this.lblNumero.Text = "0001";
            // 
            // tbProduto
            // 
            this.tbProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbProduto.Location = new System.Drawing.Point(79, 43);
            this.tbProduto.MaxLength = 82;
            this.tbProduto.Name = "tbProduto";
            this.tbProduto.Size = new System.Drawing.Size(255, 20);
            this.tbProduto.TabIndex = 0;
            this.tbProduto.Enter += new System.EventHandler(this.txt_enter);
            this.tbProduto.Leave += new System.EventHandler(this.txt_leave);
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(354, 47);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(38, 13);
            this.lblPreco.TabIndex = 1;
            this.lblPreco.Text = "Preço:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(14, 46);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "Descrição:";
            // 
            // tbPreco
            // 
            this.tbPreco.Location = new System.Drawing.Point(396, 44);
            this.tbPreco.Name = "tbPreco";
            this.tbPreco.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbPreco.Size = new System.Drawing.Size(67, 20);
            this.tbPreco.TabIndex = 1;
            this.tbPreco.Enter += new System.EventHandler(this.txt_enter);
            this.tbPreco.Leave += new System.EventHandler(this.txt_leave);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BackColor = System.Drawing.Color.LightSalmon;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.CountItemFormat = "de {0}";
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripTextBox1,
            this.tssNome});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(868, 25);
            this.bindingNavigator1.TabIndex = 7;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(154, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo produto";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(107, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir produto";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(102, 22);
            this.toolStripLabel1.Text = "Localizar produto:";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(150, 25);
            this.toolStripTextBox1.ToolTipText = "Para exibir todos os clientes, deixe este campo em branco.";
            this.toolStripTextBox1.Enter += new System.EventHandler(this.toolStrip1TextBox1_Enter);
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStrip1TextBox1_TextChanged);
            // 
            // tssNome
            // 
            this.tssNome.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmQualquerParte});
            this.tssNome.Name = "tssNome";
            this.tssNome.Size = new System.Drawing.Size(103, 22);
            this.tssNome.Text = "início do nome";
            // 
            // tsmQualquerParte
            // 
            this.tsmQualquerParte.Name = "tsmQualquerParte";
            this.tsmQualquerParte.Size = new System.Drawing.Size(202, 22);
            this.tsmQualquerParte.Text = "qualquer parte do nome";
            this.tsmQualquerParte.Click += new System.EventHandler(this.qualquerParteTSMItem_Click);
            // 
            // CadProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 515);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.CadProd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btIncluir;
        private System.Windows.Forms.DataGridView prodDGV;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox tbProduto;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox tbPreco;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Button btSalvaEdicao;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSplitButton tssNome;
        private System.Windows.Forms.ToolStripMenuItem tsmQualquerParte;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
    }
}