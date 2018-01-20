namespace Orcamento
{
    partial class Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dlg1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.padrãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btSalvaTipo = new System.Windows.Forms.Button();
            this.btdeletaTipo = new System.Windows.Forms.Button();
            this.tabConfig = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.rodapeFalse = new System.Windows.Forms.RadioButton();
            this.rodapeTrue = new System.Windows.Forms.RadioButton();
            this.tbRodape = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btFooterDefault = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabConfig.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            this.textBox4.AutoCompleteCustomSource.AddRange(new string[] {
            "A imagem deve obedecer os seguintes formatos: ",
            "PNG, BMP, GIF ou JPEG.",
            "O tamanho da imagem deve ser de "});
            this.textBox4.BackColor = System.Drawing.Color.SkyBlue;
            this.textBox4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox4.Location = new System.Drawing.Point(9, 148);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(151, 205);
            this.textBox4.TabIndex = 0;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "Requisitos de imagem:\r\nTamanho: 262x262.\r\nFormatos: BMP, PNG, JPEG e GIF.\r\nA imag" +
    "em poderá ficar deformada se o tamanho for diferente do tamanho sugerido.";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(75, 57);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(353, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(75, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(353, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(353, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Telefone(s):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Endereço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Orcamento.Properties.Resources.vorc_maior;
            this.pictureBox1.Location = new System.Drawing.Point(166, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Selecionar logotipo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dlg1
            // 
            this.dlg1.FileName = "dlg";
            this.dlg1.Title = "Selecionar logotipo";
            this.dlg1.FileOk += new System.ComponentModel.CancelEventHandler(this.dlg1_FileOk);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSalmon;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripMenuItem,
            this.fecharToolStripMenuItem,
            this.padrãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.salvarToolStripMenuItem.Text = "- Salvar -";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.fecharToolStripMenuItem.Text = "- Fechar -";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // padrãoToolStripMenuItem
            // 
            this.padrãoToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.padrãoToolStripMenuItem.Name = "padrãoToolStripMenuItem";
            this.padrãoToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.padrãoToolStripMenuItem.Text = "- Padrão -";
            this.padrãoToolStripMenuItem.ToolTipText = "Restaura o aplicativo para os valores padrão, exceto o banco de dados.";
            this.padrãoToolStripMenuItem.Click += new System.EventHandler(this.padrãoToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(438, 259);
            this.dataGridView1.TabIndex = 0;
            // 
            // btSalvaTipo
            // 
            this.btSalvaTipo.Location = new System.Drawing.Point(6, 271);
            this.btSalvaTipo.Name = "btSalvaTipo";
            this.btSalvaTipo.Size = new System.Drawing.Size(89, 23);
            this.btSalvaTipo.TabIndex = 1;
            this.btSalvaTipo.Text = "Salvar itens";
            this.btSalvaTipo.UseVisualStyleBackColor = true;
            this.btSalvaTipo.Click += new System.EventHandler(this.btSalvaTipo_Click);
            // 
            // btdeletaTipo
            // 
            this.btdeletaTipo.Location = new System.Drawing.Point(354, 271);
            this.btdeletaTipo.Name = "btdeletaTipo";
            this.btdeletaTipo.Size = new System.Drawing.Size(90, 23);
            this.btdeletaTipo.TabIndex = 1;
            this.btdeletaTipo.Text = "Deletar item";
            this.btdeletaTipo.UseVisualStyleBackColor = true;
            this.btdeletaTipo.Click += new System.EventHandler(this.btdeletaTipo_Click);
            // 
            // tabConfig
            // 
            this.tabConfig.Controls.Add(this.tabPage1);
            this.tabConfig.Controls.Add(this.tabPage2);
            this.tabConfig.Controls.Add(this.tabPage3);
            this.tabConfig.Location = new System.Drawing.Point(12, 27);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.SelectedIndex = 0;
            this.tabConfig.Size = new System.Drawing.Size(458, 391);
            this.tabConfig.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(450, 365);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Empresa";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btdeletaTipo);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.btSalvaTipo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(450, 365);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Serviços";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btFooterDefault);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.rodapeFalse);
            this.tabPage3.Controls.Add(this.rodapeTrue);
            this.tabPage3.Controls.Add(this.tbRodape);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(450, 365);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rodapé";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(351, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rodapeFalse
            // 
            this.rodapeFalse.AutoSize = true;
            this.rodapeFalse.Location = new System.Drawing.Point(10, 165);
            this.rodapeFalse.Name = "rodapeFalse";
            this.rodapeFalse.Size = new System.Drawing.Size(82, 17);
            this.rodapeFalse.TabIndex = 3;
            this.rodapeFalse.TabStop = true;
            this.rodapeFalse.Text = "Sem rodapé";
            this.rodapeFalse.UseVisualStyleBackColor = true;
            this.rodapeFalse.CheckedChanged += new System.EventHandler(this.rodapeFalse_CheckedChanged);
            // 
            // rodapeTrue
            // 
            this.rodapeTrue.AutoSize = true;
            this.rodapeTrue.Location = new System.Drawing.Point(10, 142);
            this.rodapeTrue.Name = "rodapeTrue";
            this.rodapeTrue.Size = new System.Drawing.Size(82, 17);
            this.rodapeTrue.TabIndex = 3;
            this.rodapeTrue.TabStop = true;
            this.rodapeTrue.Text = "Com rodapé";
            this.rodapeTrue.UseVisualStyleBackColor = true;
            this.rodapeTrue.CheckedChanged += new System.EventHandler(this.rodapeTrue_CheckedChanged);
            // 
            // tbRodape
            // 
            this.tbRodape.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRodape.Location = new System.Drawing.Point(6, 37);
            this.tbRodape.MaxLength = 224;
            this.tbRodape.Multiline = true;
            this.tbRodape.Name = "tbRodape";
            this.tbRodape.Size = new System.Drawing.Size(438, 95);
            this.tbRodape.TabIndex = 2;
            this.tbRodape.Text = resources.GetString("tbRodape.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Este rodapé será aplicado à folha de orçamento:";
            // 
            // btFooterDefault
            // 
            this.btFooterDefault.Location = new System.Drawing.Point(351, 172);
            this.btFooterDefault.Name = "btFooterDefault";
            this.btFooterDefault.Size = new System.Drawing.Size(93, 23);
            this.btFooterDefault.TabIndex = 5;
            this.btFooterDefault.Text = "Rodapé padrão";
            this.btFooterDefault.UseVisualStyleBackColor = true;
            this.btFooterDefault.Click += new System.EventHandler(this.btFooterDefault_Click);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 430);
            this.Controls.Add(this.tabConfig);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Config";
            this.Text = "Config";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Config_FormClosed);
            this.Load += new System.EventHandler(this.Config_Load);
            this.Shown += new System.EventHandler(this.Config_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabConfig.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog dlg1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem padrãoToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btSalvaTipo;
        private System.Windows.Forms.Button btdeletaTipo;
        private System.Windows.Forms.TabControl tabConfig;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tbRodape;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rodapeFalse;
        private System.Windows.Forms.RadioButton rodapeTrue;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btFooterDefault;
    }
}