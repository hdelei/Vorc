using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace Orcamento
{
    public partial class CadProd : Form
    {
        Vorc v;
        Sql sql = new Sql();
        private static string selectedID = "-1";

        public CadProd(Vorc v)
        {
            InitializeComponent();
            FormClosing += new FormClosingEventHandler(formClosing);
            this.v = v;
        }        

        private void formataProduto(bool isCustom)//Formata tabela produto no datagrid
        {
            string customQuery = "SELECT * FROM Produto " +
                "WHERE nome LIKE '%" + toolStripTextBox1.Text + "%';";

            if (isCustom)
            {
                sql.CustomSelect(customQuery);
                DataTable dt = Util.dtColumnIntToDecimal(sql.Datatable, 2);
                prodDGV.DataSource = dt;                
            }
            else
            {
                //sql.Select("Produto", toolStripTextBox1.Text);
                dgvUpdate(toolStripTextBox1.Text);                
            }
            FormatDataGridView.FormatDGV(prodDGV, "produto");

        }

        private void CadProd_Load(object sender, EventArgs e)
        {
            formataProduto(false);
            //sql.Select("Produto", "");
            //prodDGV.DataSource = sql.Datatable;
            //FormatDataGridView.FormatDGV(prodDGV, "produto");
        }
        private void btIncluir_Click(object sender, EventArgs e)
        {
            if (tbProduto.Text != "")
            {
                string validValue = Util.entryValidate(tbPreco.Text);
                
                string[] values = { tbProduto.Text, validValue};

                int insertSuccess = sql.Insert("Produto", values);

                if (insertSuccess == 0)
                {
                    MessageBox.Show("Este produto já existe. Atribua um nome diferente.", "Erro!",
                           MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tbProduto.Focus();
                }
                else if (insertSuccess == 1)
                {
                    //Atualiza o datagridview após o insert
                    formataProduto(false);
                    
                    MessageBox.Show("Produto cadastrado com sucesso.", "Informação",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btIncluir.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Atribua um nome para o produto.", "Informação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbProduto.Focus();
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            int deleteSucess = sql.Delete("Produto", selectedID);

            if (deleteSucess == 1)
            {
                dgvUpdate("");
                //sql.Select("Produto", "");
                //DataTable dt = Util.dtColumnIntToDecimal(sql.Datatable, 2);
                //prodDGV.DataSource = dt;

                MessageBox.Show("O produto foi excluído com sucesso", "Informação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (deleteSucess == 0)
            {
                MessageBox.Show("Impossível excluir o produto enquanto existir \n" +
                    "em outros orçamentos!", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //try
            //{
            //    produtoTableAdapter.Update(vorc2DataSet.Produto);
            //    vorc2DataSet.AcceptChanges();
            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("Um produto só pode ser excluído \n" +
            //        "se não estiver cadastrado em um orçamento. \n\n" +
            //        "É possível editar o preço e a descrição do produto.","Erro",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //produtoTableAdapter.Fill(vorc2DataSet.Produto);

        }

        private void dgvUpdate(string query)
        {
            sql.Select("Produto", query);
            DataTable dt = Util.dtColumnIntToDecimal(sql.Datatable, 2);
            prodDGV.DataSource = dt;
        }

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            v.AtualizaDGProduto();// Atualiza o DatagridView de Vorc quando fechar esta janela
            v.Visible = true;
        }
        private void txt_enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.PaleGreen;
        }

        private void txt_leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }
       
        //private void salvaEdicao() //Lógica de edição do produto //Inútil
        //{
        //    try
        //    {
        //        Validate();
        //        produtoBindingSource.EndEdit();
        //        produtoTableAdapter.Update(vorc2DataSet.Produto);
        //        MessageBox.Show("Alterações efetuadas com sucesso.","Sucesso",
        //            MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        btSalvaEdicao.Enabled = false;

        //    }
        //    catch (Exception)
        //    {

        //        MessageBox.Show("Você digitou alguma informação inválida! Tente novamente.",
        //            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        private void btSalvaStatus() //Atualiza status do do botão de salvar edição
        {
            btSalvaEdicao.Enabled = true;
        }

        private void DataGridView1_CellValueChanged(object sender, //Obtém status da célula
            DataGridViewCellEventArgs e)
        {
            btSalvaStatus(); //modifica status do botão de salvar edição                        
        }

        private void btSalvaEdicao_Click(object sender, EventArgs e)
        {
            //salvaEdicao(); // salva a edição feita diretamente na célula

            if (tbProduto.Text != "")
            {
                string validValue = Util.entryValidate(tbPreco.Text);

                string[] valuesForUpdate = { "Produto", selectedID,
                    tbProduto.Text, validValue };

                int updateSuccess = sql.Update(valuesForUpdate);

                if (updateSuccess == 0)
                {
                    MessageBox.Show("Já existe um produto com este nome. Atribua um nome diferente.", "Erro!",
                           MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tbProduto.Focus();
                }
                else if (updateSuccess == 1)
                {
                    //Atualiza o datagridview após o insert
                    dgvUpdate("");
                    //sql.Select("Produto", "");
                    //DataTable dt = Util.dtColumnIntToDecimal(sql.Datatable, 2);
                    //prodDGV.DataSource = dt;

                    MessageBox.Show("Cadastro atualizado com sucesso.", "Informação",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //btSalvaEdicao.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Atribua um nome para o produto.", "Informação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbProduto.Focus();
            }
        }
        
        private void toolStrip1TextBox1_TextChanged(object sender, EventArgs e)
        {
            localizar();
        }

        private void toolStrip1TextBox1_Enter(object sender, EventArgs e)
        {
            tbProduto.Clear();
            tbPreco.Clear();
        }
        
        private void localizar()//Localizar o produto
        {                    

            if (tssNome.Text == "início do nome")
            {                
                formataProduto(false);                
            }
            else
            {             
                formataProduto(true);             
            }
        }

        private void qualquerParteTSMItem_Click(object sender, EventArgs e)        
        {
            Busca busca = new Busca();
            busca.setaLogica(tssNome.Text);
            tssNome.Text = busca.retornaTxt1();
            tsmQualquerParte.Text = busca.retornaTxt2();
            localizar();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            tbProduto.Text = "";
            tbPreco.Text = "";            

            tbProduto.Focus();
            btIncluir.Enabled = true;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int rowSize = prodDGV.RowCount - 1;
            if (e.RowIndex < rowSize)
            {
                DataGridViewRow row = prodDGV.Rows[e.RowIndex];
                tbProduto.Text = row.Cells[1].Value.ToString();
                                
                decimal aux = (decimal)row.Cells[2].Value;
                tbPreco.Text = aux.ToString("N2");         
                                
                selectedID = row.Cells[0].Value.ToString();
                label5.Text = selectedID;
            }
        }
    }
}
