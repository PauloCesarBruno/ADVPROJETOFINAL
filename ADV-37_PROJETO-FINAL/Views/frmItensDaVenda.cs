using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADV_37_PROJETO_FINAL.Views
{
    public partial class frmItensDaVenda : Form
    {
        public int idVenda;

        private Controllers.ItensDaVenda itensDaVenda = new Controllers.ItensDaVenda();
        public frmItensDaVenda()
        {
            InitializeComponent();
        }

        private void frmItensDaVenda_Load(object sender, EventArgs e)
        {
            try
            {
                itensDaVenda .ListaItensDaVenda (dsADV_vendaVarejo ,idVenda );
            }
            catch (Exception)
            {
                MessageBox.Show("ERRO !!!");
            }
        }
    }
}
