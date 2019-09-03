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
    public partial class Vtotal : Form
    {
        public Vtotal()
        {
            InitializeComponent();
        }

        private void Vtotal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dsADV_vendaVarejo.V_Total'. Você pode movê-la ou removê-la conforme necessário.
            this.v_TotalTableAdapter.Fill(this.dsADV_vendaVarejo.V_Total);

            this.reportViewer1.RefreshReport();
        }
    }
}
