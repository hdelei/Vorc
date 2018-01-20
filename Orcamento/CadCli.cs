using System;
using System.Drawing;
using System.Windows.Forms;

namespace Orcamento
{
    public partial class CadCli : Form
    {
        private Vorc v; /// Variavel para mudar o texto da janela
        Sql sql = new Sql();
        private static string selectedID = "-1";
        
        public CadCli(Vorc v)//parametros da janela Vorc
        {
            InitializeComponent();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(formClosing);
            this.v = v; //atribuição do parametro para janela Vorc
        }

        private void Consultar_Load(object sender, EventArgs e)
        {                   
            sql.Select("Cliente", "");
            clienteDGV.DataSource = sql.Datatable;                        
            FormatDataGridView.FormatDGV(clienteDGV, "cliente");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbNome.Text != "")
            {
                string fone1 = tbFone1.Text.Replace("(", "").Replace(")", "").Replace("_","");
                string fone2 = tbFone2.Text.Replace("(", "").Replace(")", "").Replace("_", ""); 
                string[] values = { tbNome.Text, tbEndereco.Text, tbLocal.Text, fone1, fone2 };

                int insertSuccess = sql.Insert("Cliente", values);

                if (insertSuccess == 0)
                {
                    MessageBox.Show("Este cliente já existe. Atribua um nome diferente.", "Erro!",
                           MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tbNome.Focus();
                }
                else if (insertSuccess == 1)
                {
                    //Atualiza o datagridview após o insert
                    sql.Select("Cliente", "");
                    clienteDGV.DataSource = sql.Datatable;

                    MessageBox.Show("Cliente cadastrado com sucesso.", "Informação",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button1.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Atribua um nome para o cliente.", "Informação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNome.Focus();
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            int deleteSucess = sql.Delete("Cliente", selectedID);

            if (deleteSucess == 1)
            {
                sql.Select("Cliente", "");//atualiza após ter deletado
                clienteDGV.DataSource = sql.Datatable;

                MessageBox.Show("O cliente foi excluído com sucesso", "Informação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
            else if (deleteSucess == 0)
            {
                MessageBox.Show("Impossível excluir o cliente enquanto houver \n" +
                    "orçamentos cadastrados em seu nome!", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        
        private void formClosing(object sender, FormClosingEventArgs e)
        {
            v.AtualizaDGCliente();// Atualiza o DatagridView do Vorc quando fechar esta janela
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

        private void button2_Click_3(object sender, EventArgs e)
        {
            if (tbNome.Text != "")
            {
                string fone1 = tbFone1.Text.Replace("(", "").Replace(")", "").Replace("_", "");
                string fone2 = tbFone2.Text.Replace("(", "").Replace(")", "").Replace("_", "");
                string[] valuesForUpdate = { "Cliente", selectedID,
                    tbNome.Text, tbEndereco.Text, tbLocal.Text, fone1, fone2 };

                int updateSuccess = sql.Update(valuesForUpdate);

                if (updateSuccess == 0)
                {
                    MessageBox.Show("Já existe um cliente com este nome. Atribua um nome diferente.", "Erro!",
                           MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tbNome.Focus();
                }
                else if (updateSuccess == 1)
                {
                    //Atualiza o datagridview após o insert
                    sql.Select("Cliente", "");
                    clienteDGV.DataSource = sql.Datatable;

                    MessageBox.Show("Cadastro atualizado com sucesso.", "Informação",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //btSalvaEdicao.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Atribua um nome para o cliente.", "Informação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNome.Focus();
            }
        }

        private void DataGridView1_CellValueChanged(object sender, //Obtém status da célula
            DataGridViewCellEventArgs e)
        {
            //if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            //{
            //    MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            //}
        

        //btSalvaStatus(); //modifica status do botão de salvar edição    

    }

        //private void salvaEdicao() //Lógica de edição do cliente
        //{
        //    try
        //    {
        //        Validate();
        //        clienteBindingSource.EndEdit();
        //        clienteTableAdapter.Update(vorc2DataSet.Cliente);
        //        MessageBox.Show("Alterações efetuadas com sucesso.", "Sucesso!",
        //            MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        //btSalvaEdicao.Enabled = false;
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Você digitou alguma informação inválida! Tente novamente.","Erro!",
        //            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //    }
        //}

        private void btSalvaStatus() //Atualiza status do do botão de salvar edição
        {
            //btSalvaEdicao.Enabled = true;
        }

        private void localizar()//Localizar o cliente
        {
            string customQuery = "SELECT * FROM Cliente " +
                "WHERE nome LIKE '%" + toolStripTextBox1.Text + "%';";

            if (tssNome.Text == "início do nome")
            {
                //clienteBindingSource.Filter = string.Format("nome LIKE '" + toolStripTextBox1.Text + "*'");
                sql.Select("Cliente", toolStripTextBox1.Text);
                clienteDGV.DataSource = sql.Datatable;
            }
            else
            {
                //clienteBindingSource.Filter = string.Format("nome LIKE '%" + toolStripTextBox1.Text + "%'");
                sql.CustomSelect(customQuery);
                clienteDGV.DataSource = sql.Datatable;
            }
            
        }
        private void toolStrip1TextBox1_TextChanged(object sender, EventArgs e)
        {
            localizar();
        }

        //private void fillToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.clienteTableAdapter.Fill(this.vorc2DataSet.Cliente);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //}

        private void maskedTxt_Enter(object sender, EventArgs e)
        {
            ((MaskedTextBox)sender).BackColor = Color.PaleGreen;
        }

        private void maskedTxt_Leave(object sender, EventArgs e)
        {
            ((MaskedTextBox)sender).BackColor = Color.White;
        }

        private void tsmQualquerParte_Click(object sender, EventArgs e)
        {
            //Atualiza dinamicamente a descrição de busca por parte ou pelo nome
            Busca busca = new Busca();
            busca.setaLogica(tssNome.Text);
            tssNome.Text = busca.retornaTxt1();
            tsmQualquerParte.Text = busca.retornaTxt2();
            localizar();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int rowSize = clienteDGV.RowCount -1;
            if (e.RowIndex < rowSize)
            {
                DataGridViewRow row = clienteDGV.Rows[e.RowIndex];
                tbNome.Text = row.Cells[1].Value.ToString();
                tbEndereco.Text = row.Cells[2].Value.ToString();                
                tbLocal.Text = row.Cells[3].Value.ToString();
                tbFone1.Text = row.Cells[4].Value.ToString();
                tbFone2.Text = row.Cells[5].Value.ToString();
                selectedID = row.Cells[0].Value.ToString();

            }

            
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            tbNome.Text = "";
            tbEndereco.Text = "";
            tbLocal.Text = "";
            tbFone1.Text = "";
            tbFone2.Text = "";

            tbNome.Focus();
            button1.Enabled = true;
        }
    }
}
