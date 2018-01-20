using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orcamento
{
    static class FormatDataGridView
    {
        public static void FormatDGV(DataGridView myDGV, string tabela)
        {
            switch (tabela)
            {
                case "produto":
                    myDGV.Columns[0].Visible = false;
                    myDGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    myDGV.Columns[2].DefaultCellStyle.Format = "C2";
                    myDGV.Columns[1].HeaderText = "Descrição";
                    myDGV.Columns[2].HeaderText = "Preço";
                    break;
                case "cliente":
                    myDGV.Columns[0].Visible = false;
                    myDGV.Columns[1].Visible = true;
                    myDGV.Columns[2].Visible = true;
                    myDGV.Columns[3].Visible = true;
                    myDGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    myDGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    myDGV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    myDGV.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    myDGV.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    myDGV.Columns[1].HeaderText = "Nome";
                    myDGV.Columns[2].HeaderText = "Endereço";
                    myDGV.Columns[3].HeaderText = "Local";
                    myDGV.Columns[4].HeaderText = "Telefone 1";
                    myDGV.Columns[5].HeaderText = "Telefone 2";
                    break;
                case "orcamento":
                    myDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    myDGV.Columns[0].Visible = true;
                    myDGV.Columns[0].HeaderText = "Número do orçamento";
                    myDGV.Columns[1].HeaderText = "Data de inclusão";
                    myDGV.Columns[2].HeaderText = "Tipo de orçamento";
                    myDGV.Columns[3].HeaderText = "Status";
                    myDGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    break;
                case "tipo":
                    myDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    myDGV.Columns[0].Visible = false;                    
                    myDGV.Columns[1].HeaderText = "Tipos de Serviços";
                    myDGV.Columns[2].Visible = false;                    
                    myDGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    break;
                case "item":
                    myDGV.Columns[4].Visible = false;
                    myDGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    myDGV.Columns[2].DefaultCellStyle.Format = "N2";//formatação monetária
                    myDGV.Columns[3].DefaultCellStyle.Format = "N2";
                    myDGV.AllowUserToAddRows = false;
                    //myDGV.Columns["preco_item"].DefaultCellStyle.Format = "c";
                    //myDGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    break;
            }
        }        
    }
}
