using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pa_estudiar2
{
    class Cuenta : Cliente
    {
        private string numeroCuenta;
        private string tipoCuenta;
        public Cuenta()
        {
        }
        public Cuenta(string numeroCuenta, string tipoCuenta)
        {
            this.numeroCuenta = numeroCuenta;
            this.tipoCuenta = tipoCuenta;
        }
        public string NumeroCuenta { get => numeroCuenta; set => numeroCuenta = value; }
        public string TipoCuenta { get => tipoCuenta; set => tipoCuenta = value; }


        public void deposito(int cantidad)
        {
            SaldoCliente += cantidad;
        }
        public bool retiro(int cantidad)
        {
            if (SaldoCliente >= cantidad)
            {
                SaldoCliente -= cantidad;
                return true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Saldo insuficiente" + "\n" +
                "Operacón Invalida");
                return false;
            }
        }
    }

    
}





     
