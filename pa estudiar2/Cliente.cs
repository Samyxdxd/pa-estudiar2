using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pa_estudiar2
{
    class Cliente
    {
        private string nombreCliente;
        private int saldoCliente;
        public Cliente()
        {
        }
        public Cliente(string nombreCliente, int saldoCliente)
        {
            this.nombreCliente = nombreCliente;
            this.saldoCliente = saldoCliente;
        }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public int SaldoCliente { get => saldoCliente; set => saldoCliente = value; }
    }
}
