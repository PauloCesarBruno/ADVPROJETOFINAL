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
    public partial class frmProdutos : Form
    {
        private Controllers.Produto produto = new Controllers.Produto();


        public frmProdutos()
        {
            InitializeComponent();
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            try
            {
                produto.ListaProdutos (dsADV_vendaVarejo ,"");

                if (!Directory .Exists (Models.Shared .stPathDHTML ))
                {
                    Directory .CreateDirectory (Models .Shared .stPathDHTML );
                }
                Models .Shared .GeraFolhaDeEstilo ();

                using (XmlTextWriter xml = new XmlTextWriter (Models .Shared .stPathDHTML + "produtos.html", Encoding .GetEncoding ("UTF-8")))
                {
                    xml.Formatting =Formatting.Indented ;

                    xml.WriteStartElement ("html");

                    xml.WriteStartElement ("head");

                    xml.WriteElementString ("title", "Relatório de Produtos");

                    xml.WriteStartElement ("link rel='stylesheet' type='text/css' href='estilo.css'");
                    xml.WriteEndElement (); // Fecha Link
                    xml.WriteEndElement (); // Fecha href

                    xml.WriteStartElement ("body");
                    xml.WriteStartElement ("div id='box'");
                    xml.WriteStartElement ("table");
                    xml.WriteStartElement ("tr id='cabecalho'");

                    xml.WriteElementString ("th class='small'", "Código");
                     xml.WriteElementString ("th", "Descrição");
                     xml.WriteElementString ("th","Fornecedor");
                     xml.WriteElementString ("th", "Q.Mínima");
                     xml.WriteElementString ("th", "Imagem");

                    xml.WriteEndElement();

                    for (int idx = 0; idx < dsADV_vendaVarejo .view_spListaProdutos.Rows .Count ; idx++)
                    {
                        if (idx % 2 != 0)
                        {
                            xml.WriteStartElement ("tr class='impar'");
                        }
                        else
                        {
                            xml.WriteStartElement ("tr");
                        }
                        object [] row = dsADV_vendaVarejo .view_spListaProdutos .Rows [idx].ItemArray ;

                        for (int col = 0; col < row.Length ; col ++)
                        {
                            xml.WriteElementString ("td",row[col].ToString ());
                        }
                        xml.WriteEndElement ();
                    }

                    xml.WriteEndElement (); // Fecha "table"
                    xml.WriteEndElement (); // Fecha "div"
                    xml.WriteEndElement (); // Fecha "body"
                    xml.WriteEndElement (); // Fecha "html"

                }
                webBrowser .Navigate (Models.Shared.stPathDHTML + "produtos.html");                
            }
            catch (Exception)
            {
                MessageBox.Show("ERRO !!!");
            }
        }
    }
}
