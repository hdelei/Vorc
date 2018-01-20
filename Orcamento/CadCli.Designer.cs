namespace Orcamento
{
    partial class CadCli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadCli));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbFone2 = new System.Windows.Forms.MaskedTextBox();
            this.tbFone1 = new System.Windows.Forms.MaskedTextBox();
            this.lblFone2 = new System.Windows.Forms.Label();
            this.lblFone1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.clienteDGV = new System.Windows.Forms.DataGridView();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLocal = new System.Windows.Forms.TextBox();
            this.btSalvaEdicao = new System.Windows.Forms.Button();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.tssNome = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmQualquerParte = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbFone2);
            this.groupBox1.Controls.Add(this.tbFone1);
            this.groupBox1.Controls.Add(this.lblFone2);
            this.groupBox1.Controls.Add(this.lblFone1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.clienteDGV);
            this.groupBox1.Controls.Add(this.tbNome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbEndereco);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbLocal);
            this.groupBox1.Location = new System.Drawing.Point(0, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(961, 452);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do cliente";
            // 
            // tbFone2
            // 
            this.tbFone2.Location = new System.Drawing.Point(327, 71);
            this.tbFone2.Mask = "(99) 000000000";
            this.tbFone2.Name = "tbFone2";
            this.tbFone2.Size = new System.Drawing.Size(111, 20);
            this.tbFone2.TabIndex = 4;
            this.tbFone2.Enter += new System.EventHandler(this.maskedTxt_Enter);
            this.tbFone2.Leave += new System.EventHandler(this.maskedTxt_Leave);
            // 
            // tbFone1
            // 
            this.tbFone1.Location = new System.Drawing.Point(80, 71);
            this.tbFone1.Mask = "(99) 000000000";
            this.tbFone1.Name = "tbFone1";
            this.tbFone1.Size = new System.Drawing.Size(107, 20);
            this.tbFone1.TabIndex = 3;
            this.tbFone1.Enter += new System.EventHandler(this.maskedTxt_Enter);
            this.tbFone1.Leave += new System.EventHandler(this.maskedTxt_Leave);
            // 
            // lblFone2
            // 
            this.lblFone2.AutoSize = true;
            this.lblFone2.Location = new System.Drawing.Point(262, 74);
            this.lblFone2.Name = "lblFone2";
            this.lblFone2.Size = new System.Drawing.Size(43, 13);
            this.lblFone2.TabIndex = 8;
            this.lblFone2.Text = "Fone 2:";
            // 
            // lblFone1
            // 
            this.lblFone1.AutoSize = true;
            this.lblFone1.Location = new System.Drawing.Point(15, 74);
            this.lblFone1.Name = "lblFone1";
            this.lblFone1.Size = new System.Drawing.Size(43, 13);
            this.lblFone1.TabIndex = 8;
            this.lblFone1.Text = "Fone 1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Clientes";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(720, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clienteDGV
            // 
            this.clienteDGV.AllowUserToOrderColumns = true;
            this.clienteDGV.BackgroundColor = System.Drawing.Color.LightBlue;
            this.clienteDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteDGV.Location = new System.Drawing.Point(18, 137);
            this.clienteDGV.Name = "clienteDGV";
            this.clienteDGV.ReadOnly = true;
            this.clienteDGV.Size = new System.Drawing.Size(931, 309);
            this.clienteDGV.TabIndex = 4;
            this.clienteDGV.TabStop = false;
            this.clienteDGV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellValueChanged);
            this.clienteDGV.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(80, 19);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(255, 20);
            this.tbNome.TabIndex = 0;
            this.tbNome.Enter += new System.EventHandler(this.txt_enter);
            this.tbNome.Leave += new System.EventHandler(this.txt_leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endereço: ";
            // 
            // tbEndereco
            // 
            this.tbEndereco.Location = new System.Drawing.Point(80, 45);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(633, 20);
            this.tbEndereco.TabIndex = 1;
            this.tbEndereco.Enter += new System.EventHandler(this.txt_enter);
            this.tbEndereco.Leave += new System.EventHandler(this.txt_leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Local:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nome:";
            // 
            // tbLocal
            // 
            this.tbLocal.Location = new System.Drawing.Point(397, 19);
            this.tbLocal.Name = "tbLocal";
            this.tbLocal.Size = new System.Drawing.Size(316, 20);
            this.tbLocal.TabIndex = 2;
            this.tbLocal.Enter += new System.EventHandler(this.txt_enter);
            this.tbLocal.Leave += new System.EventHandler(this.txt_leave);
            // 
            // btSalvaEdicao
            // 
            this.btSalvaEdicao.Location = new System.Drawing.Point(18, 481);
            this.btSalvaEdicao.Name = "btSalvaEdicao";
            this.btSalvaEdicao.Size = new System.Drawing.Size(107, 23);
            this.btSalvaEdicao.TabIndex = 6;
            this.btSalvaEdicao.Text = "Salvar alterações";
            this.btSalvaEdicao.UseVisualStyleBackColor = true;
            this.btSalvaEdicao.Click += new System.EventHandler(this.button2_Click_3);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(146, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo cliente";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(99, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir cliente";
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
            this.toolStripLabel1.Size = new System.Drawing.Size(94, 22);
            this.toolStripLabel1.Text = "Localizar cliente:";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(150, 25);
            this.toolStripTextBox1.ToolTipText = "Deixe este campo em branco para mostrar todos os clientes.";
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
            this.tsmQualquerParte.Click += new System.EventHandler(this.tsmQualquerParte_Click);
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
            this.bindingNavigatorSeparator,
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
            this.bindingNavigator1.Size = new System.Drawing.Size(961, 25);
            this.bindingNavigator1.TabIndex = 6;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // CadCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 516);
            this.Controls.Add(this.btSalvaEdicao);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadCli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.Consultar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLocal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView clienteDGV;
        private System.Windows.Forms.Button btSalvaEdicao;
        private System.Windows.Forms.MaskedTextBox tbFone2;
        private System.Windows.Forms.MaskedTextBox tbFone1;
        private System.Windows.Forms.Label lblFone2;
        private System.Windows.Forms.Label lblFone1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSplitButton tssNome;
        private System.Windows.Forms.ToolStripMenuItem tsmQualquerParte;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
    }
}