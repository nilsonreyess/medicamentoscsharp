using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicamentos
{
    internal class Pedido
    {
        private string Medicamento;
        private string TipoMedicamento;
        private int Cantidad;
        private string Distribuidor;
        private List<String> Despachar = [];

        public Pedido()
        {
        }

        public void SetMedicamento(string medicamento)
        { this.Medicamento = medicamento; }

        public string GetMedicamento()
        { return this.Medicamento; }

        public void SetTipoMedicamento(string tipoMedicamento)
        { this.TipoMedicamento= tipoMedicamento; }

        public string GetTipoMedicamento()
        { return this.TipoMedicamento; }

        public void SetCantidad(int cantidad)
        { this.Cantidad = cantidad; }

        public int GetCantidad()
        { return this.Cantidad; }

        public void SetDistribuidor(string distribuidor)
        { this.Distribuidor = distribuidor; }

        public string GetDistribuidor()
        { return this.Distribuidor; }

        public void SetDespachar(String despachar)
        {
            this.Despachar.Add(despachar);
        }

        public string GetDespachar()
        {
            string despacho = String.Empty;
            foreach (var item in Despachar)
            {
                despacho += CreaDespacho(item);
            }
            return despacho;
        }

        public static string CreaDespacho(string sucursal)
        {
            string despacho = string.Empty;
            if (sucursal == "Principal")
            {
                despacho = "PRINCIPAL: \nCalle de la Rosa n. 28\n\n";
            }
            if (sucursal == "Sucursal")
            {
                despacho = "SUCURSAL: \nCalle Alcazabilla n. 3\n";
            }
            return despacho;
        }

    }
}
