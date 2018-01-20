using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Orcamento
{
    using prop = Properties.Settings;
    class HTML
    {
        
        string htmlCode = "<html><head></head><body>Hello, world!</body></html>";
        string openHtml, pageNumberHtml, headerHtml, clienteDataHtml, 
            tableHtml, closeHtml;

        string footerstr = prop.Default.textoRodape;
        string corpLogo = prop.Default.logotipo;
        string corpName = prop.Default.nomeEmp;
        string corpAddress = prop.Default.enderecoEmp;
        string corpPhone = prop.Default.foneEmp;

        string[] client = CadOrc.dadosCliente.ToArray();
        string[] item = CadOrc.itensCliente.ToArray();
        string[] ItemCount = CadOrc.quantItem.ToArray();
        string[] ItemPrice = CadOrc.precoItem.ToArray();
        string[] subTotal = CadOrc.subTotal.ToArray();
        string total = CadOrc.valorFinal;

        public string HtmlCode
        {
            get
            { return htmlCode; }
        }
        public string HeaderCode
        {
            get
            { return headerHtml; }
        }
        public string PageNumber
        {
            get
            {
                return pageNumberHtml;
            }
        }

        /// <summary>
        /// Constrói o código html
        /// </summary>
        public void buildHtml()
        {
            openHtml = "<!DOCTYPE html><meta charset='UTF-8'>" +
                        "<html lang='pt-BR'><head><style>" +
                        "table {border-collapse: collapse;}" +
                        "table td, th {border: 1px solid #E8F1D3;}" +
                        "td {text-align: left; padding: 8px;}" +
                        "td.dir {text-align: right; padding: 8px;}" +
                        "th {text-align: center; padding: 8px;}" +

                        //esta linha não funciona. Deveria formatar linha par de uma cor e ímpar de outra, 
                        //fiz via código em buildTable()
                        //"tr:nth-child(even) {background-color: #F2F2F2;}" +
                        "th {background-color: #EF5A4B; color: white;}" +
                        "</style></head><body>";                        
                        //"<div style='page-break-before:always;'>";

            pageNumberHtml = "<div style='text-align:right'>Pág.: <span class='page'></span></div>";

            headerHtml = buildHeader();

            //[0]numero do orçamento, [1]nome do cliente, [2]Endereço, [3]Local, [4]Tipo orçamento
            clienteDataHtml = "<br><h2>Para " + client[1] + "</h2><b>" + client[3] + "</b><p><br>" +
                              "Ref.: orçamento de " + client[4] + " nº " + client[0] + "<p>";

            tableHtml = buildTable();

            closeHtml = "<br>" + prop.Default.textoRodape + "</body></html>";

            htmlCode = openHtml + pageNumberHtml + headerHtml + clienteDataHtml +
                tableHtml + closeHtml;
        }

        /// <summary>
        /// Formata a tabela de produtos e quebra linha quando necessário.
        /// Evita que a tabela possa quebrar entre uma linha e outra
        /// </summary>
        /// <returns>String contendo o código das tabelas</returns>
        private string buildTable()
        {
            string pageBreak = "<div style='page-break-before:always;'></div>";
            //string divClose = "";  
  
            string code = "";
            decimal count = item.Count();
            const decimal MAX_ROWS_FIRST_LOOP = 16;
            const decimal MAX_ROWS_LOOPS = 16;
            decimal rowsAux = MAX_ROWS_FIRST_LOOP;
            decimal result = count / MAX_ROWS_LOOPS;
            int loopStart = 0;
            int loopStartAux = 0;
            int truncValue = (int)Math.Truncate((count / MAX_ROWS_LOOPS) - 1);
            decimal fraction = result - Math.Truncate(count / MAX_ROWS_LOOPS);

            //decimal result = 1;

            string tableHeader = "<table style='width:100%'><tr>" +
                                 "<th>Produtos/Serviços</th>" +
                                 "<th style='width:1%'>Quantidade</th>" +
                                 "<th style='width:20%'>Preço</th>" +
                                 "<th style='width:25%'>Subtotal</th></tr>";
            
                        
            //Loop 1: fixo = de 0 a 16
            string bgcolor = "";
            if (count >= MAX_ROWS_FIRST_LOOP)
            {
                code += tableHeader;
                for (int i = loopStart; i < MAX_ROWS_FIRST_LOOP; i++)
                {
                    loopStartAux++;
                    if (i % 2 == 0)
                    {
                        bgcolor = "<tr bgcolor='#F2F2F2'>";
                    }
                    else
                    {
                        bgcolor = "<tr>";
                    }
                    code += bgcolor + "<td>" + item[i] + "</td>" +
                            "<td><center>" + ItemCount[i] + "</center></td>" +
                            "<td class='dir'>" +
                            decimal.Parse(ItemPrice[i]).ToString("N2") + "</td>" +
                            "<td class='dir'>" +
                            decimal.Parse(subTotal[i]).ToString("N2") + "</td></tr>";
                }
                code += "</table>";             
            }            
            //fim loop 1

            //Loop 2: Inteiro = de 17 adiante                        
            for (int i = 0; i < truncValue; i++)
            {
                rowsAux += MAX_ROWS_LOOPS;
                loopStart += (int)MAX_ROWS_LOOPS;                

                code += pageBreak + "<br>" + tableHeader;

                for (int j = loopStart; j < rowsAux; j++)
                {
                    loopStartAux++;
                    if (j % 2 == 0)
                    {
                        bgcolor = "<tr bgcolor='#F2F2F2'>";
                    }
                    else
                    {
                        bgcolor = "<tr>";
                    }
                    code += bgcolor + "<td>" + item[j] + "</td>" +
                           "<td><center>" + ItemCount[j] + "</center></td>" +
                            "<td class='dir'>" +
                            decimal.Parse(ItemPrice[j]).ToString("N2") + "</td>" +
                            "<td class='dir'>" +
                            decimal.Parse(subTotal[j]).ToString("N2") + "</td></tr>";
                }
                code += "</table>";                
            }
            //Fim loop 2

            //Loop 3: fração após loop 3    
            if (loopStartAux == 0)//verifica se o numero de itens é menor que o loop
            {
                loopStart = loopStartAux;
                rowsAux = count;

            }
            else
            {
                loopStart += (int)MAX_ROWS_LOOPS;
                rowsAux += (int)(fraction * MAX_ROWS_LOOPS);
                code += pageBreak + "<br>";
            }

            code += tableHeader;
            for (int j = loopStart; j < rowsAux; j++)
            {

                if (j % 2 == 0)
                {
                    bgcolor = "<tr bgcolor='#F2F2F2'>";
                }
                else
                {
                    bgcolor = "<tr>";
                }
                code += bgcolor + "<td>" + item[j] + "</td>" +
                    "<td><center>" + ItemCount[j] + "</center></td>" +
                    "<td class='dir'>" +
                    decimal.Parse(ItemPrice[j]).ToString("N2") + "</td>" +
                    "<td class='dir'>" +
                    decimal.Parse(subTotal[j]).ToString("N2") + "</td></tr>";
            }
            //Fim do Loop 3

            //============
            code += "<tr bgcolor='#ADF7B6' style='color:#1C4D1C'>" +
                "<td>Total</td><td></td><td></td><td class='dir'><b>R$ " +
                total + "</b></td></tr></table><p>";            

            return code;
        }

        /// <summary>
        /// Gera o cabeçalho em html com a imagem e os dados da empresa
        /// </summary>
        /// <returns>String com o código html</returns>
        private string buildHeader()
        {
            string header;
            if (corpLogo == "vazio" || !System.IO.File.Exists(corpLogo)) // Obtém logotipo padrão ou custom
            {
                header = "<img src='" + System.IO.Directory.GetCurrentDirectory() + @"\Imagens\logo.png" +
                         "' alt='Logotipo da sua empresa' style='float:left;width:150px;height:150px;'><br>" +
                         "<b>&nbsp;" + corpName + "</b><br>&nbsp;" + corpAddress + "<br>" +
                         "&nbsp;Telefones: " + corpPhone + "<p><br><br><br><br><br>";
            }
            else
            {
                header = "<img src='" + corpLogo +
                         "' alt='Logotipo da sua empresa' style='float:left;width:150px;height:150px;'><br>" +
                         "<b>&nbsp;" + corpName + "</b><br>&nbsp;" + corpAddress + "<br>" +
                         "&nbsp;Telefones: " + corpPhone + "<p><br><br><br><br><br>";
            }
            return header;
        }
    }
}
