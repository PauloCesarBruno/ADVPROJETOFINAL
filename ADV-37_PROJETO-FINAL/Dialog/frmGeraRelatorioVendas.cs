using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADV_37_PROJETO_FINAL.Dialog
{
    public partial class frmGeraRelatorioVendas : Form
    {


        private DateTime datainicial = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);

        public frmGeraRelatorioVendas()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            Reporting.frmVendas fVendas = new Reporting.frmVendas();
            fVendas.MdiParent = this.MdiParent;

            fVendas.dInicial = dtpDataInicial.Value;
            fVendas.dFinal = dtpDataFinal.Value;

            fVendas.Show();
            this.Close();

        }

        private void frmGeraRelatorioVendas_Load(object sender, EventArgs e)
        {
            dtpDataInicial.Text = datainicial.ToString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
