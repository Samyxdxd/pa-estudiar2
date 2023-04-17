using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pa_estudiar2
{
    public partial class Form1 : Form
    {
        Cuenta objCuenta = new Cuenta();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            gbTransacciones.Visible = true;
            string tipoCuenta = "";
            if (rbVista.Checked == true)
            {
                tipoCuenta = "Cuenta Vista";
            }
            else if (rbCorriente.Checked == true)
            {
                tipoCuenta = "Cuenta Corriente";
            }
            objCuenta.NumeroCuenta = txtCtaBancaria.Text;
            objCuenta.NombreCliente = txtCliente.Text;
            objCuenta.TipoCuenta = tipoCuenta;
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse(txtMontoRetiro.Text);
            if (objCuenta.retiro(cantidad))
            {
                listTransacciones.Items.Add("El número de cuenta bancaria es: " + objCuenta.NumeroCuenta +
                ", MONTO RETIRADO: $" + cantidad + " CLP.");
            }
            else
            {
                listTransacciones.Items.Add("El número de cuenta bancaria es: " + objCuenta.NumeroCuenta +
                "--/ OPERACIÓN NO VÁLIDA (SALDO INSUFICIENTE) /--");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCtaBancaria.Clear();
            txtCliente.Clear();
            rbVista.Checked = false;
            rbCorriente.Checked = false;
            gbTransacciones.Visible = false;
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("E S T A D O D E C U E N T A" + "\n" +
            "Número de cuenta: " + objCuenta.NumeroCuenta + "\n" + "Nombre del Cliente: " +
            objCuenta.NombreCliente + "\n" + "Tipo de Cuenta: " + objCuenta.TipoCuenta + "\n" +
            "\n" + "SALDO DE LA CUENTA: $" + objCuenta.SaldoCliente.ToString() + " CLP.\n" +
            "\n" + DateTime.Now.ToString());
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse(txtMontoDeposito.Text);
            objCuenta.deposito(cantidad);
            listTransacciones.Items.Add("El número de cuenta bancaria es: " +
            objCuenta.NumeroCuenta + ", MONTO DEPOSITADO: $" + cantidad + " CLP.");
        }

        private void rbVista_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbCorriente_CheckedChanged(object sender, EventArgs e)
        {

        }
        
    }
}
