using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//
using System.Xml;
using System.IO;

namespace ADV_37_PROJETO_FINAL.Reporting
{
    public partial class frmVendas : Form
    {
        // Atributos:
        private Controllers .Venda venda = new Controllers .Venda ();

        public DateTime dInicial, dFinal;

        public frmVendas()
        {
            InitializeComponent();
        }

        private void frmVendas_Load(object sender, EventArgs e)
        {
            try
            {
                this.venda.ListaVendasEntreDatas (dsADV_vendaVarejo,dInicial ,dFinal);

                if(!Directory .Exists (Models .Shared .stPathDHTML ))
                {
                    Directory.CreateDirectory(Models .Shared .stPathDHTML );
                }
                Models.Shared .GeraFolhaDeEstilo ();

                using (XmlTextWriter xml = new XmlTextWriter (Models .Shared .stPathDHTML  + "vendas.html", Encoding .GetEncoding ("UTF-8")))
                {
                    xml.Formatting = Formatting .Indented;
                    xml.WriteStartElement ("html");
                    xml.WriteStartElement ("head");

                    xml.WriteElementString ("title", "Relatório de Produtos");

                    xml.WriteStartElement ("link rel='stylesheet' type='text/css' href='estilo.css'");
                    xml.WriteEndElement (); // Fecha "link"

                    xml.WriteEndElement (); // Fecha "head"

                    xml.WriteStartElement ("body");
                    xml.WriteStartElement ("div id='box'");
                    xml.WriteStartElement ("table");

                    xml.WriteStartElement ("tr id='cabecalho'");

                    xml.WriteElementString ("th class='small'", "Código");
                    xml.WriteElementString ("th", "Vendedor");
                    xml.WriteElementString ("th", "Cliente");
                    xml.WriteElementString ("th", "F. Pagamento");
                    xml.WriteElementString ("th", "D.Venda");
                    xml.WriteElementString ("th", "Total");

                    xml.WriteEndElement ();

                    for (int idx = 0;idx < dsADV_vendaVarejo.view_spListaVendasEntreDatas.Rows.Count;idx++)
                    {
                        if(idx % 2!=0)
                        {
                            xml.WriteStartElement ("tr class='impar'");
                        }
                        else
                        {
                            xml.WriteStartElement ("tr");
                        }

                        object [] row = dsADV_vendaVarejo .view_spListaVendasEntreDatas .Rows [idx].ItemArray ;

                        for (int col = 0; col < row .Length ; col ++)
                        {
                            if(col == row .Length -1)
                            {
                                xml.WriteElementString ("td", string .Format ("R$ {0:0.00}",row [col]));
                            }
                            else
                            {
                                xml.WriteElementString ("td", row [col].ToString ());
                            }
                        }
                        xml.WriteEndElement ();
                    }

                     xml.WriteEndElement (); // Fecha "Table"

                     xml.WriteEndElement (); // Fecha "div"

                     xml.WriteEndElement (); // Fecha "body"

                     xml.WriteEndElement (); // Fecha "html"
                   }
                this.webBrowser .Navigate (Models.Shared.stPathDHTML + "vendas.html");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO !!!");
            }

        }
    }
}
