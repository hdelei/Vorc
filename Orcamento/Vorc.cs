using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Orcamento
{
    public partial class Vorc : Form
    {
        Cliente cliAtual = new Cliente();//Objeto para armazenar dados do cliente
        Sql sql = new Sql();

        public Vorc()
        {
            InitializeComponent();
            SQLiteDB.Create(Properties.Settings.Default.connectionString);            
        }
        private void Vorc_Load(object sender, EventArgs e)
        {            
            atualizaLogotipo();
            orcsExpirados();
        }        
        private void PreencherGrid(string tipo) //Popula oDatagridView de acordo com a escolha
        {
            apagaColunaAbrir();                       
            
            dataGridView1.RowHeadersVisible = false;

            if (tipo == "cliente")
            {
                HabilitaDClick();
                formataCliente();                
            }
            else if (tipo == "produto")
            {
                DesabilitaDClick();
                formataProduto();                
            }            
        }
        private void apagaColunaAbrir() //cancela coluna "Abrir", se necessário
        {
            if (dataGridView1.Columns.Contains("Abrir"))
            {
                dataGridView1.Columns.Remove("Abrir");
                dataGridView1.CellClick -=
                new DataGridViewCellEventHandler(dataGridView1_CellClick);
            }
        }
        private void formataProduto()//Formata tabela produto no datagrid
        {            
            sql.Select("Produto", tbConsulta.Text);                        
            DataTable dt = Util.dtColumnIntToDecimal(sql.Datatable, 2);
            dataGridView1.DataSource = dt;            
        }
        private void formataCliente()//Formata tabela cliente no datagrid
        {            
            sql.Select("Cliente", tbConsulta.Text);            
            dataGridView1.DataSource = sql.Datatable;            
        }
        private void btCliente_Click(object sender, EventArgs e) 
        {            
            PreencherGrid("cliente");//Preenche DGV e dá dica na celula
            FormatDataGridView.FormatDGV(dataGridView1, "cliente");
            gboxCliente.Text = "Clientes";            
        }
        private void btProduto_Click(object sender, EventArgs e) 
        {               
            AtualizaDGProduto();
        }
        private void btLimpar_Click(object sender, EventArgs e)
        {
            apagaColunaAbrir();
            tbConsulta.Clear();
            dataGridView1.DataSource = "";
            gboxCliente.Text = "";
        }                
        private void orcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkEmptyTables();
            int naoPreenche = -1;//evita o preenchimento de orçamento em Cadorc
            CadOrc cadorc2 = new CadOrc(naoPreenche);
            cadorc2.ShowDialog();

            //Atualiza label último orçamento
            ultimoOrcLabel();
        }
        /// <summary>
        /// Evita que erros sejam gerados por falta de Cliente, Produto ou Item
        /// </summary>
        private void checkEmptyTables()
        {
            sql.CustomSelect(Queries.ItemsExists("Cliente"));
            if (sql.Datatable.Select().Length == 0)
            {
                string[] values = { "Fulano", "Rua 1", "Transilvânia", "163333333", "" };
                sql.Insert("Cliente", values);
            }

            sql.CustomSelect(Queries.ItemsExists("Produto"));
            if (sql.Datatable.Select().Length == 0)
            {
                string[] values = { "Unicórnio de Pelúcia", "10250" };
                sql.Insert("Produto", values);
            }

            sql.CustomSelect(Queries.ItemsExists("Tipo"));
            if (sql.Datatable.Select().Length == 0)
            {
                string[] values = { "Brinquedos", "Brinquedos em geral" };
                sql.Insert("Tipo", values);
            }
        }

        private void ultimoOrcLabel() //Atualiza a label Ultimo Orc
        {
            UltimoOrcamento dadosOrc2 = new UltimoOrcamento();
            if (dadosOrc2.Numero > 0)
            {
                lblUltimoOrc.Text = dadosOrc2.Tipo + " nº "
                + dadosOrc2.Numero + " - " + dadosOrc2.Nome;
            }
            else
            {
                lblUltimoOrc.Text = "Nenhum";
            }
        }
        private void cliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Chama o cadastro de clientes e envia instancia deste
            CadCli cadCliente = new CadCli(this);
            cadCliente.Show();           
            this.Visible = false;            
        }
        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Chama o cadastro de produtos e envia instancia deste
            CadProd cadProduto = new CadProd(this);
            cadProduto.Show();
            this.Visible = false;
        }
        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tbConsulta_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void AtualizaDGCliente()// Método para atualizar o datagridview
        {
            sql.Select("cliente", "");
            dataGridView1.DataSource = sql.Datatable;
            FormatDataGridView.FormatDGV(dataGridView1, "cliente");
            gboxCliente.Text = "Clientes";
        }
        public void AtualizaDGProduto()// Método para atualizar o datagridview 
        {
            PreencherGrid("produto");//Preenche DGV e esconde dica de célula
            FormatDataGridView.FormatDGV(dataGridView1, "produto");
            gboxCliente.Text = "Produtos";            
        }       
        private void DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {            
            try
            {
                if (gboxCliente.Text.Contains("Orçamentos"))
                {                    
                    //NÃO FAÇA NADA                    
                }
                else if (e.ColumnIndex == dataGridView1.Columns["Nome"].Index)            
                {
                   string nomePessoa = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
                   PreencheOrcam(nomePessoa);
                   StatusCor();
                }                
            }
            catch (Exception)
            {
                
            }                        
        }
        private void StatusCor()
        {
            foreach (DataGridViewRow linha in dataGridView1.Rows)
            {
                string status = linha.Cells["Status"].Value.ToString();

                switch (status)
                {
                    case "Aprovado":
                        linha.DefaultCellStyle.BackColor = Color.LightGreen;
                        break;
                    //case "Pendente":
                    //    linha.DefaultCellStyle.BackColor = Color.LightBlue;
                    //    break;
                    case "Expirado":
                        linha.DefaultCellStyle.BackColor = Color.Wheat;
                        break;
                    case "Reprovado":
                        linha.DefaultCellStyle.BackColor = Color.LightCoral;
                        break;

                    default:
                        break;
                }                
            }
        }
        private void PreencheOrcam(string nome)//Preenche DGV com orçamentos do cliente
        {
            string customQuery = "SELECT Orcamento.id, Orcamento.data, Tipo.nome, Orcamento.status" +
                                 " FROM((Orcamento INNER JOIN" +
                                 " TIPO ON Orcamento.id_tipo = Tipo.id)INNER JOIN" +
                                 " Cliente ON Orcamento.id_cliente = Cliente.id)" +
                                 " WHERE(Cliente.nome = '" + nome + "');";

            gboxCliente.Text = "Orçamentos de " + nome;                     

            sql.CustomSelect(customQuery);
            dataGridView1.DataSource = sql.Datatable;
            FormatDataGridView.FormatDGV(dataGridView1, "orcamento");            

            AddColunaBotao();
                        
            cliAtual.Nome = nome; //ARMAZENA O NOME NA CLASSE PESSOA            

        }
        private void AddColunaBotao()//Adiciona botões na coluna de orçamentos
        {
            DataGridViewButtonColumn botaoOrc = new DataGridViewButtonColumn();
            {
                botaoOrc.HeaderText = "Abrir";
                botaoOrc.Text = "Abrir";
                botaoOrc.Name = "Abrir";
                botaoOrc.UseColumnTextForButtonValue = true;
                botaoOrc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //buttons.FlatStyle = FlatStyle.Standard;
                //buttons.CellTemplate.Style.BackColor = Color.Honeydew;
                botaoOrc.DisplayIndex = 4;
            }

            dataGridView1.Columns.Add(botaoOrc);
            dataGridView1.CellClick +=
                new DataGridViewCellEventHandler(dataGridView1_CellClick);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //IGNORA O CLIQUE DO BOTÃO SE NÃO EXISTIR LINHAS
            if (e.RowIndex < 0 || e.ColumnIndex !=
                dataGridView1.Columns["Abrir"].Index)
            {                
                return;                
            }

            //Salva o status na classe Cliente para acesso em Cadorc
            cliAtual.OrcStatus = dataGridView1["Status", e.RowIndex].Value.ToString();
            
            //ABRE O ORÇAMENTO PELO BOTÃO DA CÉLULA
            int numOrcamento = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
            
            CadOrc cadorc = new CadOrc(numOrcamento);
            
            cadorc.ShowDialog();

            //QUANDO RETORNAR PARA VORC O CAMPO STATUS DO ORÇAMENTO É ATUALIZADO
            apagaColunaAbrir();
            PreencheOrcam(cliAtual.Nome);
            StatusCor();

            //encapsula os dados
            dadosLabelStatus(numOrcamento, e);
            
            //Atualiza a label do Ultimo orçamento
            ultimoOrcLabel();
        }
        /*ENCAPSULA DADOS PARA EXIBIR NA LABEL DO úLTIMO ORÇAMENTO,
        EM CASO DE EXCLUSÃO, ZERA A VARIAVEL PARA EVITAR NOVA ABERTURA*/        
        private void dadosLabelStatus(int num, DataGridViewCellEventArgs e)
        {
            try
            {
                UltimoOrcamento dadosOrc4 = new UltimoOrcamento();
                dadosOrc4.Nome = cliAtual.Nome;
                dadosOrc4.Numero = num;
                dadosOrc4.Tipo = dataGridView1["nome", e.RowIndex].Value.ToString();
            }
            catch (Exception)
            {
                UltimoOrcamento dadosOrc5 = new UltimoOrcamento();
                dadosOrc5.Numero = 0;

                //throw;
            }
            
        }
        private void HabilitaDClick() // Habilita Doubleclick em clientes
        {            
            dataGridView1.CellContentDoubleClick -= //remove evento antes de habilitar
                    DataGridView1_CellContentDoubleClick;
            dataGridView1.CellContentDoubleClick += 
                DataGridView1_CellContentDoubleClick;
        }
        private void DesabilitaDClick() // desabilita doubleclick em clientes
        {
            dataGridView1.CellContentDoubleClick -= //cancela doubleClick
                DataGridView1_CellContentDoubleClick;
        }
        private void label1_MouseEnter(object sender, EventArgs e)
        {
            lblDica1.Visible = true;
        }
        private void label1_MouseLeave(object sender, EventArgs e)
        {
            lblDica1.Visible = false;        }
        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Config janelaConfig = new Config(this);
            janelaConfig.ShowDialog();
        }        
        public void atualizaLogotipo()//atualiza o logotipo
        {
            if (Properties.Settings.Default.logotipo != null
                || Properties.Settings.Default.logotipo != "")
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(
                        Properties.Settings.Default.logotipo);
                }
                catch (Exception)
                {
                    pictureBox1.Image = Properties.Resources.vorc_maior;                    
                }
            }
            else
            {
                pictureBox1.Image = Properties.Resources.vorc_maior;
            }
        }
        private void orcsExpirados()
        {
            DateTime hoje = DateTime.Now.Date;
            DateTime ultimaAtualizacao = Properties.Settings.Default.dataUltAtualizacao.Date;
            int orcsExpirados = 0;

            if (hoje > ultimaAtualizacao)
            {
                hoje = hoje.AddDays(-10);
                try
                {                    
                    string[] valuesForUpdate = { "Expirados", hoje.ToString()};
                    orcsExpirados = sql.Update(valuesForUpdate);

                    Properties.Settings.Default.dataUltAtualizacao = DateTime.Now.Date;
                    Properties.Settings.Default.Save();
                }
                catch (Exception)
                {
                    throw;
                }
            }

            lblExpirados.Text = mensagemExpirados(orcsExpirados);            
        }
        private string mensagemExpirados(int quantidade)
        {
            string mensagem;

            switch (quantidade)
            {
                case 0:
                    mensagem = "Nenhum orçamento expirou desde a última execução do programa.";
                    break;
                case 1:
                    mensagem = quantidade + " orçamento expirou desde a última execução do programa.";
                    break;                    
                default:
                    mensagem = quantidade + " orçamentos expiraram desde a última execução do programa.";
                    break;
            }
            return mensagem;
        }
        private void lblUltimoOrc_Click(object sender, EventArgs e)
        {
            abreUltimoOrc();            
        }
        private void abreUltimoOrc()
        {
            if (lblUltimoOrc.Text != "Nenhum")
            {
                UltimoOrcamento dadosOrc3 = new UltimoOrcamento();
                CadOrc cadorc3 = new CadOrc(dadosOrc3.Numero);
                cadorc3.ShowDialog();
            }
            
        }
        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                StatusCor();
            }
            catch (Exception)
            {
                
            }            
        }        
    }
}
