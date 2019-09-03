using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Xml;
using System.IO;

namespace ADV_37_PROJETO_FINAL.Reporting
{
    public partial class frmTabelaDePrecos : Form
    {
        private Controllers.TabelaDePreco tPreco = new Controllers.TabelaDePreco();

        public frmTabelaDePrecos()
        {
            InitializeComponent();
        }

        private void frmTabelaDePrecos_Load(object sender, EventArgs e)
        {
            try
            {

                tPreco.ListaPrecos(dsADV_vendaVarejo);
                if (!Directory.Exists(Models.Shared.stPathDHTML))
                {
                    Directory.CreateDirectory(Models.Shared.stPathDHTML);
                }
                Models.Shared.GeraFolhaDeEstilo();
                using (XmlTextWriter xml = new XmlTextWriter(Models.Shared.stPathDHTML + "tabelaDePrecos.html", Encoding.GetEncoding("UTF-8")))
                {
                    xml.Formatting = Formatting.Indented;
                    xml.WriteStartElement("html");
                    xml.WriteStartElement("head");
                    xml.WriteElementString("title", "Relatorio de Tabela de Preços");
                    xml.WriteStartElement("link rel='stylesheet' type='text/css' href='estilo.css'");
                    xml.WriteEndElement(); // Fecha Link
                    xml.WriteEndElement(); // Fecha head
                    xml.WriteStartElement("body");
                    xml.WriteStartElement("div id='box'");
                    xml.WriteStartElement("table");
                    xml.WriteStartElement("tr id='cabecalho'");
                    xml.WriteElementString("th class='small'", "Código");
                    xml.WriteElementString("th", "Descrição");
                    xml.WriteElementString("th", "Preço");
                    xml.WriteEndElement();

                    for (int idx = 0; idx < dsADV_vendaVarejo.view_spListaTabelaDePrecos.Rows.Count; idx++)
                    {
                        if (idx % 2 != 0)
                        {
                            xml.WriteStartElement("tr class='impar'");
                        }
                        else
                        {
                            xml.WriteStartElement("tr");
                        }

                        object[] row = dsADV_vendaVarejo.view_spListaTabelaDePrecos.Rows[idx].ItemArray;

                        for (int col = 0; col < row.Length; col++)
                        {
                            if (col == row.Length - 1)
                            {
                                xml.WriteElementString("td", string.Format("R$ {0:0.00}", row[col]));
                            }
                            else
                            {
                                xml.WriteElementString("td", row[col].ToString());
                            }
                        }
                        xml.WriteEndElement(); // fecha "tr"
                    }
                    xml.WriteEndElement(); // fecha "table"
                    xml.WriteEndElement(); // fecha "div"
                    xml.WriteEndElement(); // fecha "body"
                    xml.WriteEndElement(); // fecha "html"
                }
                webBrowser.Navigate(Models.Shared.stPathDHTML + "tabelaDePrecos.html");
            }
            catch (Exception)
            {
                MessageBox.Show("ERRO!!!");
            }
        }
    }
}

