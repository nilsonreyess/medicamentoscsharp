using System.Reflection.PortableExecutable;

namespace Medicamentos
{
    public partial class FrmIntro : Form
    {
        public FrmIntro()
        {
            InitializeComponent();
            OcultarErrores();
        }

        private void OcultarErrores()
        {
            LblErrMedicamento.Visible = false;
            LblErrTipoMedicamento.Visible = false;
            LblErrCantidad.Visible = false;
            LblErrDistribuidor.Visible = false;
            LblErrSucursal.Visible = false;
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            OcultarErrores();
            Limpiar();
        }

        private void Limpiar()
        {
            TxtMedicamento.Text = string.Empty;
            CmbMedicamento.Text = "Seleccione";
            NumCantidad.Value = 1;
            RdbCofarma.Checked = true;
            ChkPrincipal.Checked = true;
            ChkSucursal.Checked = false;
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (Verifica())
            {
                Pedido pedido = new();
                pedido.SetMedicamento(TxtMedicamento.Text);
                pedido.SetTipoMedicamento(CmbMedicamento.Text);
                pedido.SetCantidad((int)NumCantidad.Value);
                pedido.SetDistribuidor(Distribuidor());
                if (ChkPrincipal.Checked)
                {
                    pedido.SetDespachar(ChkPrincipal.Text);
                }
                if (ChkSucursal.Checked)
                {
                    pedido.SetDespachar(ChkSucursal.Text);
                }

                using FrmPedido pedir = new FrmPedido(pedido);
                pedir.ShowDialog();
               
            }
        }

        private string Distribuidor()
        {
            if (RdbCofarma.Checked)
            {
                return "Cofarma";
            }
            if (RdbCemefar.Checked)
            {
                return "Cemefar";
            }
            return "Empsephar";
        }

        private bool Verifica()
        {
            if (TxtMedicamento.Text.Trim().Equals(""))
            {
                OcultarErrores();
                LblErrMedicamento.Visible = true;
                TxtMedicamento.Focus();
                return false;
            }

            if (CmbMedicamento.SelectedIndex < 0)
            {
                OcultarErrores();
                LblErrTipoMedicamento.Visible = true;
                CmbMedicamento.Focus();
                return false;
            }

            if (NumCantidad.Value <= 0)
            {
                OcultarErrores();
                LblErrCantidad.Visible = true;
                NumCantidad.Focus();
                return false;
            }

            if (!RdbCofarma.Checked && !RdbCemefar.Checked && !RdbEmpsephar.Checked)
            {
                OcultarErrores();
                LblErrDistribuidor.Visible = true;
                RdbCofarma.Focus();
                return false;
            }

            if (!ChkPrincipal.Checked && !ChkSucursal.Checked)
            {
                OcultarErrores();
                LblErrSucursal.Visible = true;
                ChkPrincipal.Focus();
                return false;
            }
            
            return true;
        }
    }
}
