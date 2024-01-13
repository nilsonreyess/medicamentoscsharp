using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medicamentos
{
    public partial class FrmPedido : Form
    {
        public FrmPedido(Pedido pedido)
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pedido enviado.");
            this.Close();
        }
    }
}
