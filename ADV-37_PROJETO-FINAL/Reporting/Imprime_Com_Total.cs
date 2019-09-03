using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADV_37_PROJETO_FINAL.Reporting
{
    public partial class Imprime_Com_Total : Form
    {
        public Imprime_Com_Total()
        {
            InitializeComponent();
        }

        private void Imprime_Com_Total_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dsADV_vendaVarejo.Venda'. Você pode movê-la ou removê-la conforme necessário.
            this.vendaTableAdapter.Fill(this.dsADV_vendaVarejo.Venda);

            this.reportViewer1.RefreshReport();
        }
    }
}
