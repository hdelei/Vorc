using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Orcamento
{
    public partial class Config : Form
    {
        private Vorc vorc;
        Sql sql = new Sql();        

        public Config(Vorc vorc)
        {
            InitializeComponent();
            this.vorc = vorc;
        }      

        private void button1_Click(object sender, EventArgs e)
        {            
            dlg1.FileName = "";
            dlg1.Title = "Selecione o logotipo";
            dlg1.Filter = "Arquivos de imagem(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            dlg1.ShowDialog();
               
        }

        private void dlg1_FileOk(object sender, CancelEventArgs e)
        {
            Properties.Settings.Default.logotipo = dlg1.FileName;
            //Properties.Settings.Default.Save();
            pictureBox1.Image = Image.FromFile(
                Properties.Settings.Default.logotipo);           

        }     

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Config_Load(object sender, EventArgs e)
        {            
            loadData();            
        }

        private void loadData()
        {
            sql.Select("Tipo", "");
            dataGridView1.DataSource = sql.Datatable;
            FormatDataGridView.FormatDGV(dataGridView1, "tipo");
        }

        private void configPadrao() //Volta ao padrão de fábrica
        {
            //EMPRESA
            pictureBox1.Image = Properties.Resources.vorc_maior;
            Properties.Settings.Default.logotipo = "vazio";
            Properties.Settings.Default.nomeEmp = "Nome da sua empresa";
            Properties.Settings.Default.enderecoEmp = "Endereço da sua empresa";
            Properties.Settings.Default.foneEmp = "Telefone(s) da sua empresa";
            textBox1.Text = Properties.Settings.Default.nomeEmp;
            textBox2.Text = Properties.Settings.Default.enderecoEmp;
            textBox3.Text = Properties.Settings.Default.foneEmp;

            //RODAPÉ
            rodapeTrue.Checked = true;
            tbRodape.Text = rodapePadrao;
            Properties.Settings.Default.textoRodape = rodapePadrao;
            Properties.Settings.Default.comRodape = true;

            //SALVA TUDO
            Properties.Settings.Default.Save();
            
            MessageBox.Show("Você restaurou as configurações padrão do aplicativo com sucesso",
                "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void padrãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configPadrao();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.nomeEmp = textBox1.Text;
            Properties.Settings.Default.enderecoEmp = textBox2.Text;
            Properties.Settings.Default.foneEmp = textBox3.Text;
            Properties.Settings.Default.textoRodape = tbRodape.Text;            
            Properties.Settings.Default.Save();            
            Close();         
        }

        private void configInicial() 
        {            
            textBox1.Text = Properties.Settings.Default.nomeEmp;
            textBox2.Text = Properties.Settings.Default.enderecoEmp;
            textBox3.Text = Properties.Settings.Default.foneEmp;
            tbRodape.Text = Properties.Settings.Default.textoRodape;
            var psdRodape = Properties.Settings.Default.comRodape;

            if (psdRodape)
            {
                rodapeTrue.Checked = true;
            }
            else
            {
                rodapeFalse.Checked = true;
            }
            
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

        private void Config_Shown(object sender, EventArgs e)
        {
            configInicial();
        }

        private void Config_FormClosed(object sender, FormClosedEventArgs e)
        {
            vorc.atualizaLogotipo();
        }

        private void btSalvaTipo_Click(object sender, EventArgs e)
        {
            salvaEdicao();
            loadData();
        }

        private void salvaEdicao() //Lógica de adição e atualização dos serviços
        {
            try
            {
                DataTable updatedItemsDT = sql.Datatable.GetChanges();

                if (updatedItemsDT != null)
                {
                    foreach (DataRow row in updatedItemsDT.Rows)
                    {
                        if (row[1].ToString() != "")
                        {
                            string id = row[0].ToString();
                            string nome = row[1].ToString();
                            string[] values = { "Tipo", id, nome };
                            if (sql.Update(values) < 1)
                            {
                                string[] insertValues = { nome, nome };
                                sql.Insert("Tipo", insertValues);
                                //MessageBox.Show("O item \"" + nome.ToUpper() +
                                //    "\" Foi adiicionado aos serviços.", "Erro");
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu um erro: \r\n" +
                    e.Message, "Erro");
            }            
        }        

        private void btdeletaTipo_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedCells[0].Value != null)
                {
                    int row = dataGridView1.CurrentCell.RowIndex;                    
                    string id = sql.Datatable.Rows[row]["id"].ToString();
                    int deleteSuccess = sql.Delete("Tipo", id);                    
                    loadData();

                    if (deleteSuccess < 1)
                    {
                        MessageBox.Show("Impossível deletar este registro. " +
                        " Ele já está sendo utilizado em orçamento.", "Erro:",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                    MessageBox.Show("Ocorreu um erro: \n\r" + ex.Message, 
                        "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }            
        }

        //RODAPÉ
        private string rodapePadrao = "A validade desta proposta é de 10 dias." +
            " Após este prazo você ainda poderá adquirir estes produtos ou" + 
            " serviços, mas nem todas as condições previamente combinadas" +
            " poderão ser mantidas, tais como descontos e prazos.";

        private void rodapeTrue_CheckedChanged(object sender, EventArgs e)
        {
            tbRodape.Enabled = true;
            Properties.Settings.Default.comRodape = true;
            Properties.Settings.Default.textoRodape = tbRodape.Text;            
        }

        private void rodapeFalse_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.comRodape = false;
            Properties.Settings.Default.textoRodape = "";
            tbRodape.Text = "";
            tbRodape.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbRodape.Clear();
            tbRodape.Focus();
        }

        private void btFooterDefault_Click(object sender, EventArgs e)
        {
            if (tbRodape.Enabled == true)
            {
                Properties.Settings.Default.textoRodape = rodapePadrao;
                tbRodape.Text = rodapePadrao;
            }
        }
    }
}
