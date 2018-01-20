using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;
using System.Data;
using System.Linq;

namespace Orcamento
{    

    public partial class CadOrc : Form
    {
        Sql sql = new Sql();

        //Variáveis para preencher orçamento em html
        public  static List<string> dadosCliente = new List<string>();
        public  static List<string> itensCliente = new List<string>();
        public  static List<string> quantItem = new List<string>();
        public  static List<string> precoItem = new List<string>();
        public  static List<string> subTotal = new List<string>();
        public  static string valorFinal = "";
        //==============================================================        

        private int numOrcamento; //numero de orçamento proveniente de Vorc
        private int naoPreenche = -1;//numero para anular o preenchimento de orçamento

        public CadOrc(int numOrc)
        {
            InitializeComponent();            
            numOrcamento = numOrc;//recebe numero de orçamento de vorc                   
        }
        private void CadOrc_Load_1(object sender, EventArgs e)
        {               
            loadClients();
            loadServices();
            loadProducts();

            orcExistente();//Preenche com orçamento existente quando necessário     

            // Mostra toolTip nos produtos acima de 50 carateres ---
            cboxProduto.DrawMode = DrawMode.OwnerDrawFixed;
            cboxProduto.DrawItem += cboxProduto_DrawItem;
            cboxProduto.DropDownClosed += cboxProduto_DropDownClosed;
            //------------------------------------------------------- 
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //Inicia calculadora
        {
            try
            {
                System.Diagnostics.Process.Start("calc");
            }
            catch (Exception)
            {
                MessageBox.Show("Ops! Algum problema ocorreu com a calculadora.","Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }        

        private void loadClients()
        {
            string customQuery = "SELECT id, nome FROM Cliente;";

            sql.CustomSelect(customQuery);
            cboxNome.DataSource = sql.Datatable;            
            loadAddress();
        }
        private void loadAddress() //Preenche as labels com local e endereço
        {
            if (cboxNome.Items.Count == 0)
            {
                MessageBox.Show("Não existe nenhum cliente cadastrado! \r\n" +
                    "Adicione pelo menos um cliente na tela de cadastro.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            string customQuery = "SELECT endereco, local FROM Cliente" +
                          " WHERE id = " + cboxNome.SelectedValue + " ;";

            sql.CustomSelect(customQuery);
            lblEndereco.Text = sql.Datatable.Rows[0][0].ToString();
            lblLocal.Text = sql.Datatable.Rows[0][1].ToString();
        }

        private void loadServices() //gerar serviços no menu
        {
            string customQuery = "SELECT id, nome FROM Tipo;";
            sql.CustomSelect(customQuery);
            cboxTipo.DataSource = sql.Datatable;
        }
        private void loadProducts()
        {
            string customQuery = "SELECT id, nome FROM Produto;";
            sql.CustomSelect(customQuery);
            cboxProduto.DataSource = sql.Datatable;
            loadPrice();
        }

        private void loadPrice()
        {
            string customQuery = "SELECT preco FROM Produto" +
                          " WHERE id = " + cboxProduto.SelectedValue + " ;";

            sql.CustomSelect(customQuery);
            DataTable dt = Util.dtColumnIntToDecimal(sql.Datatable, 0);
            
            //Converte para o formato decimal
            decimal priceAux = (decimal)dt.Rows[0][0];
            tbPrecoCadastro.Text = priceAux.ToString("N2");
            tbPrecoProposta.Text = tbPrecoCadastro.Text;                 
        }        

        private void btConfirma_Click(object sender, EventArgs e)//Confirma novo orçamento
        {
            if (cboxNome.Items.Count == 0 || cboxTipo.Items.Count == 0)
            {
                MessageBox.Show("Você deve possuir clientes e serviços cadastrados.", "Informação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {                   
                try
                {
                    idItens.Clear();

                    //=========================início do código novo
                    string date = DateTime.Now.ToShortDateString();
                    string idCliente = cboxNome.SelectedValue.ToString();
                    string idTipo = cboxTipo.SelectedValue.ToString();
                    string desconto = "0";
                    string status = "Pendente";
                    
                    string[] values = { idCliente, date, idTipo, desconto, status };

                    sql.Insert("Orcamento", values);
                    idOrcamento = sql.InsertId;
                    lblNumero.Text = idOrcamento.ToString();

                    //=========================fim do código novo                    

                    //orcTableAdapter.Insert(Convert.ToInt32(cboxNome.SelectedValue),
                    //DateTime.Now, Convert.ToInt32(cboxTipo.SelectedValue), 0);
                    //orcTableAdapter.Fill(vorc2DataSet.Orcamento);

                    //PegaIdOrc = orcTableAdapter.GetDataByMaxIDOrc().
                        //Rows[0]["Expr1"].ToString();//armazena o ID orçamento em string
                    //lblNumero.Text = PegaIdOrc;//troca o texto da label para o id do orçamento
                    //idOrcamento = Convert.ToInt32(PegaIdOrc);

                    formataCliente();

                    pegaDadosCliente();

                    //Status "Pendente"
                    toolStripStatus.Text = "Pendente";
                    toolStripStatus.ForeColor = Color.Blue;

                    //Encapsula os dados do orçamento para Vorc utilizar
                    UltimoOrcamento dadosOrc1 = new UltimoOrcamento();
                    dadosOrc1.Nome = nomeDinamico.Text;
                    dadosOrc1.Numero = idOrcamento;
                    dadosOrc1.Tipo = tipoDinamico.Text;

                    //habilita a inclusão de produtos
                    gboxProduto.Enabled = true;

                }
                catch (Exception)
                {
                    MessageBox.Show("Escolha o cliente ou serviço na lista.");
                    cboxNome.Focus();
                    cboxNome.SelectedIndex = 0;
                    cboxTipo.SelectedIndex = 0;
                }               
            }
        }        
        private void preencheOrc(int numOrc) // preeenche com orçamento existente
        {
            //ESTA FUNÇÃO PREENCHE O DATAGRID COM DADOS LANÇADOS DO ORÇAMENTO EM VORC
            //RECEBE O ID DO ORÇAMENTO E PREENCHE AUTOMATICAMENTE OS CAMPOS DO
            //ORÇAMENTO E ITENS E DEIXA O DGV DISPONÍVEL PARA EDIÇÃO

            //<versão nova já Ok neste método>
            
            idItens.Clear();
            gboxProduto.Enabled = true;
            formataCliente();

            string query = Queries.GetDataByOrcId(numOrc);
            sql.CustomSelect(query);

            DataTable clientData = new DataTable();
            clientData = sql.Datatable;

            lblNumero.Text = clientData.Rows[0]["orc_id"].ToString();
            nomeDinamico.Text = clientData.Rows[0]["nome"].ToString();
            lblEndereco.Text = clientData.Rows[0]["endereco"].ToString();
            lblLocal.Text = clientData.Rows[0]["local"].ToString();
            tipoDinamico.Text = clientData.Rows[0]["tipo"].ToString();

            //preenche datagrid
            preencheItens(numOrc);                       
                        
            organizaColunas();
            valorTotal();
            idOrcamento = numOrc;
            pegaDadosCliente();
            obtemIDItens();

            Cliente cli = new Cliente();
            toolStripStatus.Text = cli.OrcStatus;
            statusCor();
        }

        private void preencheItens(int orcId)//Preenche Datagrid toda vez que um item é adicionado
        {
            string query = Queries.GetItemsByOrcId(orcId);
            sql.CustomSelect(query);
            DataTable dt = Util.dtColumnIntToDecimal(sql.Datatable, 2);
            dt = Util.dtColumnIntToDecimal(dt, 3);
            dgvpProd.DataSource = dt;
            FormatDataGridView.FormatDGV(dgvpProd, "item");
        }

        private void statusCor()//
        {
            string status = toolStripStatus.Text;

            switch (status)
            {
                case "Aprovado":
                    toolStripStatus.ForeColor = Color.Green;
                break;
                case "Reprovado":
                    toolStripStatus.ForeColor = Color.Red;
                    break;
                case "Pendente":
                    toolStripStatus.ForeColor = Color.Blue;
                    break;
                default:
                    toolStripStatus.ForeColor = Color.DarkGoldenrod;
                    break;                                    
            }
        }

        private void obtemIDItens() //obtém valor de itens no Datagridview
        {
            foreach (DataGridViewRow linha in dgvpProd.Rows)
            {
                var valorDaCelula = linha.Cells[4].Value;
                if (valorDaCelula == null || valorDaCelula.ToString().Trim() == "")
                {
                }
                else
                {
                    idItens.Add(Convert.ToInt32(valorDaCelula));
                }
            }
        }            

        private void formataCliente()//Torna permanente os dados do cliente
        {
            nomeDinamico.Visible = true;
            nomeDinamico.Text = cboxNome.Text;
            tipoDinamico.Visible = true;
            tipoDinamico.Text = cboxTipo.Text;
            lblNumero.Visible = true;
            labelOrcamento.Visible = true;
            cboxNome.Visible = false;
            cboxTipo.Visible = false;
            btConfirma.Enabled = false;
        }
        //public string PegaIdOrc { get; set; } // Armazena o id do orçamento em string
        
        //private void btRemove_Enter(object sender, DataGridViewCellEventArgs e)
        //{   
        //    if (dgvpProd.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null) //checa se linha contém valores
        //    {
        //       btRemoveProd.Enabled = true; // habilita botão de remover                
        //    }
        //}

        private void btRemove_Leave(object sender, DataGridViewCellEventArgs e)
        {
            btRemoveProd.Enabled = false; // Desabilita Botão de remover quando está fora da linha do DGV
        }
                                
        private void btIncluiProd_Click(object sender, EventArgs e)//botão inclui produtos
        {
            if (rdExistente.Checked == true)
            {
                try
                {
                    int id_orcam, id_produto, quantidade;
                    string validValue = Util.entryValidate(tbPrecoProposta.Text);
                    long preco_item;
                    
                    id_orcam = int.Parse(lblNumero.Text);//Obtém o valor da chave primária de Orçamentos
                    id_produto = Convert.ToInt32(cboxProduto.SelectedValue); // Obtém o valor da chave primária de produtos
                    quantidade = Convert.ToInt32(cboxQuant.Text); // Informa a quantidade de itens de um produto                    
                    
                    //Aviso para evitar erro de digitação
                    if (!long.TryParse(validValue, out preco_item))
                    {
                        MessageBox.Show(string.Format("O valor \"{0}\" não é um preço válido!" +
                            "\r\n São aceitos apenas números e vírgula.", tbPrecoProposta.Text ), 
                            "Erro:");

                        tbPrecoProposta.Text = tbPrecoCadastro.Text;
                        tbPrecoProposta.Focus();
                        return;
                    }                    

                    //Valida entrada de produto e quantidade
                    var myItem = cboxProduto.SelectedValue;
                    var myQuantity = cboxQuant.Text;
                    if (myItem == null)
                    {
                        MessageBox.Show("Selecione um produto válido na lista.", "Aviso:");
                        cboxProduto.SelectedIndex = 0;
                        return;
                    }
                    else if (myQuantity == "" || myQuantity == "0")
                    {
                        MessageBox.Show("Selecione uma quantidade de itens válida na lista.", "Aviso:");
                        cboxQuant.SelectedIndex = 0;
                        return;
                    }
                    //Fim validação

                    if (cboxProduto.Text == "Desconto") //Converte desconto em valor negativo
                    {
                        preco_item = preco_item * -1;
                        validValue = preco_item.ToString();
                    }

                    string[] values = { lblNumero.Text, cboxProduto.SelectedValue.ToString(),
                                        validValue, cboxQuant.Text };                    

                    sql.Insert("Item", values);
                    idItens.Add(sql.InsertId);

                    preencheItens(int.Parse(lblNumero.Text));                                        
                    
                    organizaColunas();
                    valorTotal();

                    cboxQuant.Text = "1";//retorna a quantidade para 1

                    atualizadesconto();//atualiza label desconto
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu o seguinte erro: \r\n" + ex.ToString());
                }                
            }
            else // se Radio Button novo está clicado, adiciona produto no BD
            {                
                try
                {
                    if (cboxProduto.Text == "" || tbPrecoCadastro.Text == "")
                    {
                        if (tbPrecoCadastro.Text == "")
                        {
                            MessageBox.Show("Informe o preço do item.", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbPrecoCadastro.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Escolha um nome para o item.", "Informação",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cboxProduto.Focus();
                        }                        
                    }
                    else
                    {
                        string produto = cboxProduto.Text;
                        string preco = Util.entryValidate(tbPrecoCadastro.Text);
                        //string preco = tbPrecoCadastro.Text.Replace(",", ".");
                        string[] values = { produto, preco };
                        int insertSuccess = sql.Insert("Produto", values);

                        if (insertSuccess == 0)
                        {
                            MessageBox.Show("Este produto já existe. Atribua um nome diferente.", "Erro!",
                                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            cboxProduto.Focus();
                        }
                        else if (insertSuccess == 1)
                        {
                            loadProducts();
                            rdExistente.Checked = true;
                            cboxProduto.Text = produto;
                            MessageBox.Show("Produto adicionado ao banco de dados. " +
                                "Clique novamente no botão incluir para adicionar o produto" +
                                " no orçamento.", "Informação",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro inesperado: \r\n" + ex.Message);
                }
            }            
        }

        private void atualizadesconto()//Atualiza a label de desconto ao adicionar ou remover item
        {
            decimal desconto = 0;
            decimal total = Convert.ToDecimal(tbCustoFinal.Text);            

            foreach (DataGridViewRow col in dgvpProd.Rows)
            {
                if (col.Cells.Count >= 2 &&
                    col.Cells["Produto"].Value != null &&
                    col.Cells["Quantidade"].Value != null &&
                    col.Cells["Preço"].Value != null &&
                    col.Cells["Subtotal"].Value != null)
                {
                    if (col.Cells["Produto"].Value.Equals("Desconto"))
                    {
                        desconto += Convert.ToDecimal(col.Cells["Preço"].Value);
                    }
                }
            }

            int descontoInt = Convert.ToInt32(Math.Abs(desconto));
            try
            {
                int valorLabel = Convert.ToInt32(descontoInt / ((total + descontoInt) / 100));

                lblPorcento.Text = valorLabel + "% de desconto";
            }
            catch (Exception)
            {
                lblPorcento.Text = "0% de desconto";             
            }
            
        }

        private void organizaColunas()//organiza as colunas do DGV
        {
            FormatDataGridView.FormatDGV(dgvpProd, "item");
        }        
        
        private void valorTotal()//Adiciona o valor total na textbox
        {
            decimal valorTotal = 0;
            foreach (DataGridViewRow col in dgvpProd.Rows)
            {
                valorTotal = valorTotal + Convert.ToDecimal(col.Cells["Subtotal"].Value);
            }
            tbCustoFinal.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("id-ID"),
                "{0:#,##0.00}", valorTotal); //converte para R$

            //calculaDesconto();
        }
        
        private void btCancela_Click(object sender, EventArgs e)
        {            
            if (idOrcamento != 0)
            {
                string mensagem = "Você tem certeza que deseja excluir o orçamento?";
                string aviso = "Aviso:";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult resultado;
                resultado = MessageBox.Show(this, mensagem, aviso, buttons,
                    MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    deletaItens();

                    //orcamentoTableAdapter.DeleteOrcam(idOrcamento); // apaga orçamento

                    sql.Delete("Orcamento", idOrcamento.ToString());

                    UltimoOrcamento dadosOrc2 = new UltimoOrcamento();
                    dadosOrc2.Numero = 0;

                    Close();
                    MessageBox.Show("Orçamento excluído.", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (resultado == DialogResult.No)
                {
                }                
            }
            else
            {
                MessageBox.Show("Não foi criado nenhum orçamento. " + 
                    "É necessário criar um orçamento antes","Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            idOrcamento = 0;
        }

        private void deletaItens()
        {
            foreach (int item in idItens)
            {
                sql.Delete("item", item.ToString());
                //itemTableAdapter.DeleteItem(item); //apaga itens                    
            }

            idItens.Clear();
            dgvpProd.DataSource = null; //limpa o datasource
            dgvpProd.Rows.Clear(); //limpa o datagridview            
        }        

        private void pegaDadosCliente() // armazena os dados do cliente no array publico
        {
            dadosCliente.Clear();
            dadosCliente.Add(lblNumero.Text);//numero orçamento
            dadosCliente.Add(nomeDinamico.Text);//nome do cliente
            dadosCliente.Add(lblEndereco.Text);//Endereço
            dadosCliente.Add(lblLocal.Text);//Local
            dadosCliente.Add(tipoDinamico.Text);//Tipo de orçamento                        
        }

        private void btnImprime_Click(object sender, EventArgs e)
        {
            armazenaItens();
            orcEmHtml();            
        }

        //variáveis para exclusão dos itens e orçamento
        public static int idOrcamento = 0;
        public static List<int> idItens = new List<int>();        
                
        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            //limpaVariaveis();
        }

        private void reloadForm() //Recarrega o form com dados padrão
        {
            MessageBox.Show("Orçamento apagado","Sucesso!",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);            
            CadOrc objCadOrc = new CadOrc(naoPreenche);
            this.Dispose();
            objCadOrc.Show();
        }
                
        private void armazenaItens()// armazena itens de produtos e preço final na lista
        {
            //Limpa variáveis antes de preencher
            itensCliente.Clear();
            quantItem.Clear();
            precoItem.Clear();
            subTotal.Clear();

            foreach (DataGridViewRow col in dgvpProd.Rows)
            {
                if (col.Cells.Count >= 2 &&
                    col.Cells["Produto"].Value != null &&
                    col.Cells["Quantidade"].Value != null &&
                    col.Cells["Preço"].Value != null &&
                    col.Cells["Subtotal"].Value != null)
                {
                    itensCliente.Add(col.Cells["Produto"].Value.ToString());
                    quantItem.Add(col.Cells["Quantidade"].Value.ToString());
                    precoItem.Add(col.Cells["Preço"].Value.ToString());
                    subTotal.Add(col.Cells["Subtotal"].Value.ToString());
                    
                }                                
            }
            valorFinal = tbCustoFinal.Text;
                        
        }

        private void btnLimpa_Click(object sender, EventArgs e)// Limpa todos itens no Datagrid
        {
            if (idItens.Count > 0)
            {
                string mensagem = "Você tem certeza que deseja apagar todos os itens do orçamento?";
                string aviso = "Aviso:";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult resultado;
                resultado = MessageBox.Show(this, mensagem, aviso, buttons,
                    MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    deletaItens();
                    atualizadesconto();//atualiza label desconto          
                    tbCustoFinal.Text = "0";
                }
                else if (resultado == DialogResult.No)
                {
                }
            }
            else
            {
                MessageBox.Show("Lista de itens vazia! Nada será excluído.", "Informação:",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btRemoveProd_Click(object sender, EventArgs e)
        {
            removeLinhas();
            atualizadesconto();
            
        }

        private void removeLinhas() //Apaga linhas individuais da tabela
        {
            try
            {
                foreach (DataGridViewCell celula in dgvpProd.SelectedCells)
                {
                    if (celula.Selected)
                    {
                        string itemId = idItens[celula.RowIndex].ToString();

                        sql.Delete("Item", itemId);
                        //itemTableAdapter.DeleteItem(idItens[celula.RowIndex]);
                        
                        idItens.RemoveAt(celula.RowIndex);
                        dgvpProd.Rows.RemoveAt(celula.RowIndex);
                        valorTotal();//atualização do custo final                                     
                        
                    }
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Você tentou deletar uma linha vazia. \n" +
                    "Selecione uma linha que contenha informações.","Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void orcExistente() //Preenche orçamento se necessário
        {
            if (numOrcamento != naoPreenche)
            {                
                preencheOrc(numOrcamento);
                atualizadesconto();
            }
            
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            armazenaItens();
            orcEmHtml();            
        }

        private void orcEmHtml()//Mostra orçamento em html
        {
            if (itensCliente.Count >= 1)
            {
                DocFormatado doc = new DocFormatado();
                doc.Show();
            }
            else
            {
                MessageBox.Show("Adicione produtos para visualizar o orçamento.", "Aviso:",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDesconto_Click(object sender, EventArgs e)
        {
            int indice = cboxProduto.FindStringExact("Desconto");

            if (indice < 0)//ADICIONA DESCONTO NO BD PRODUTO CASO NÃO EXISTA
            {
                string[] values = { "Desconto", "1"};
                sql.Insert("Produto", values);

                loadProducts();
                preencheItens(numOrcamento);                
                
                indice = cboxProduto.FindStringExact("Desconto");
            }            

            if (indice >= 0)//ADICIONA DESCONTO NO ORÇAMENTO 
            {
                cboxProduto.SelectedIndex = indice;
                decimal desconto;
                bool ehDecimal = decimal.TryParse(tbDesconto.Text, out desconto);
                tbPrecoProposta.Text = desconto.ToString("N2");

                if (ehDecimal)//checa se é um número válido, clica em adicionar e atualiza label
                {
                    decimal total = decimal.Parse(tbCustoFinal.Text);
                    btIncluiProd.PerformClick();                    
                    atualizadesconto();//atualiza label desconto
                }                
            } 
                       
        }
                
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dpdItem = toolStripComboBox1.SelectedIndex;
            if (btConfirma.Enabled == false)
            {
                atualizaStatus(dpdItem);
            }            
        }

        private void atualizaStatus(int item)//atualiza o status do orçamento aberto
        {                        
            switch (item)
            {
                case 0:
                    statusAux("Aprovado");                    
                    toolStripStatus.ForeColor = Color.Green;
                    break;
                case 1:
                    statusAux("Reprovado");
                    toolStripStatus.ForeColor = Color.Red;
                    break;
                case 2:
                    statusAux("Pendente");
                    toolStripStatus.ForeColor = Color.Blue;
                    break;
            }
            fecharToolStripMenuItem.Select();
        }
        private void statusAux(string status)//método auxiliar de atualizaStatus()
        {
            string sucesso = "Status atualizado com sucesso.";
            string pendente = "Clicando em \"SIM\" o orçamento será "
                + "atualizado com a data corrente. Você tem certeza?";
            var botoes = MessageBoxButtons.YesNo;
            string date = DateTime.Now.ToShortDateString();
            string table1 = "Orcamento Status";
            string table2 = "Orcamento Date";
            string[] values1 = { table1, idOrcamento.ToString(), status };
            string[] values2 = { table2, idOrcamento.ToString(), date, status };

            try
            {                
                if (status == "Aprovado" || status == "Reprovado")
                {                    
                    sql.Update(values1);
                    //Validate();
                    //orcBindingSource.EndEdit();
                    //orcTableAdapter.UpdateStatus(status, idOrcamento);
                    toolStripStatus.Text = status;
                    MessageBox.Show(sucesso, "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {                    
                    DialogResult resultado = MessageBox.Show(pendente, "Atenção", botoes,
                        MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        sql.Update(values2);
                        
                        //Validate();
                        //orcBindingSource.EndEdit();
                        //orcTableAdapter.UpdateStatus(status, idOrcamento);
                        //orcamentoTableAdapter.UpdateDataPorID(DateTime.Now, idOrcamento);
                        toolStripStatus.Text = status;
                        MessageBox.Show(sucesso, "Informação",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma alteração foi feita.", "Informação",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }                
            }
            catch (Exception)
            {
            }
        }

        private void cboxProduto_DrawItem(object sender, DrawItemEventArgs e)
        {
            //Se o produto tem mais de 50 carateres, mostra tooltip
            if (e.Index < 0) { return; } 
            string text = cboxProduto.GetItemText(cboxProduto.Items[e.Index]);
            e.DrawBackground();
            using (SolidBrush br = new SolidBrush(e.ForeColor))
            { e.Graphics.DrawString(text, e.Font, br, e.Bounds); }
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected
                && text.Length > 50)
            {
                toolTip1.Show(text, cboxProduto, e.Bounds.Right, e.Bounds.Bottom);
            }
            else
            {
                toolTip1.Hide(cboxProduto);
            }
            e.DrawFocusRectangle();
        }

        private void cboxProduto_DropDownClosed(object sender, EventArgs e)
        {
            toolTip1.Hide(cboxProduto);
        }

        private void rdNovo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNovo.Checked == true)
            {
                tbPrecoCadastro.ReadOnly = false;
                tbPrecoProposta.ReadOnly = true;
                tbPrecoCadastro.BackColor = Color.LightGreen;
                
                cboxProduto.Select();
                cboxProduto.Focus();
            }
            else
            {
                tbPrecoCadastro.ReadOnly = true;
                tbPrecoProposta.ReadOnly = false;
                tbPrecoCadastro.BackColor = DefaultBackColor;                
            }            
        }

        private void rdExistente_CheckedChanged(object sender, EventArgs e)
        {
            //rdNovo.Checked = false;
        }

        private void cboxQuant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void cboxNome_SelectedIndexChanged(object sender, EventArgs e)
        {            
            loadAddress();
        }

        private void cboxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPrice();
        }

        private void dgvpProd_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            countItems();
        }

        private void countItems()
        {            
            int count = 0;
            foreach (DataGridViewRow col in dgvpProd.Rows)
            {
                if (col.Cells.Count >= 2 &&                    
                    col.Cells["Quantidade"].Value != null)                    
                {   
                    count += Convert.ToInt32(col.Cells["Quantidade"].Value);
                }
            }

            if (count <= 1)
            {
                lblItems.Text = count + " item";
            }
            else
            {
                lblItems.Text = count + " itens";
            }
        }

        private void dgvpProd_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            countItems();            
        }
    }
}
