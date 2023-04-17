namespace pa_estudiar2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbTransacciones = new System.Windows.Forms.GroupBox();
            this.btnEstado = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRetiro = new System.Windows.Forms.Button();
            this.txtMontoRetiro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.txtMontoDeposito = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.rbCorriente = new System.Windows.Forms.RadioButton();
            this.rbVista = new System.Windows.Forms.RadioButton();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtCtaBancaria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listTransacciones = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.gbTransacciones.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbTransacciones);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 451);
            this.panel1.TabIndex = 0;
            // 
            // gbTransacciones
            // 
            this.gbTransacciones.Controls.Add(this.listTransacciones);
            this.gbTransacciones.Controls.Add(this.btnEstado);
            this.gbTransacciones.Controls.Add(this.groupBox4);
            this.gbTransacciones.Controls.Add(this.groupBox3);
            this.gbTransacciones.Location = new System.Drawing.Point(13, 202);
            this.gbTransacciones.Name = "gbTransacciones";
            this.gbTransacciones.Size = new System.Drawing.Size(886, 246);
            this.gbTransacciones.TabIndex = 1;
            this.gbTransacciones.TabStop = false;
            this.gbTransacciones.Text = "Transacciones";
            this.gbTransacciones.Visible = false;
            // 
            // btnEstado
            // 
            this.btnEstado.Location = new System.Drawing.Point(554, 188);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(193, 38);
            this.btnEstado.TabIndex = 10;
            this.btnEstado.Text = "Consultar estado de cuenta";
            this.btnEstado.UseVisualStyleBackColor = true;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnRetiro);
            this.groupBox4.Controls.Add(this.txtMontoRetiro);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(6, 129);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(392, 107);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Retirar";
            // 
            // btnRetiro
            // 
            this.btnRetiro.Location = new System.Drawing.Point(242, 67);
            this.btnRetiro.Name = "btnRetiro";
            this.btnRetiro.Size = new System.Drawing.Size(126, 23);
            this.btnRetiro.TabIndex = 14;
            this.btnRetiro.Text = "Retirar";
            this.btnRetiro.UseVisualStyleBackColor = true;
            this.btnRetiro.Click += new System.EventHandler(this.btnRetiro_Click);
            // 
            // txtMontoRetiro
            // 
            this.txtMontoRetiro.Location = new System.Drawing.Point(143, 26);
            this.txtMontoRetiro.Name = "txtMontoRetiro";
            this.txtMontoRetiro.Size = new System.Drawing.Size(155, 20);
            this.txtMontoRetiro.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Monto $";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDeposito);
            this.groupBox3.Controls.Add(this.txtMontoDeposito);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(392, 107);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Depositar";
            // 
            // btnDeposito
            // 
            this.btnDeposito.Location = new System.Drawing.Point(242, 68);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(126, 23);
            this.btnDeposito.TabIndex = 11;
            this.btnDeposito.Text = "Depositar";
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // txtMontoDeposito
            // 
            this.txtMontoDeposito.Location = new System.Drawing.Point(143, 31);
            this.txtMontoDeposito.Name = "txtMontoDeposito";
            this.txtMontoDeposito.Size = new System.Drawing.Size(155, 20);
            this.txtMontoDeposito.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Monto $";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.btnCrear);
            this.groupBox1.Controls.Add(this.rbCorriente);
            this.groupBox1.Controls.Add(this.rbVista);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.txtCtaBancaria);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(528, 88);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(159, 53);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(528, 19);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(159, 54);
            this.btnCrear.TabIndex = 8;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // rbCorriente
            // 
            this.rbCorriente.AutoSize = true;
            this.rbCorriente.Location = new System.Drawing.Point(210, 124);
            this.rbCorriente.Name = "rbCorriente";
            this.rbCorriente.Size = new System.Drawing.Size(67, 17);
            this.rbCorriente.TabIndex = 7;
            this.rbCorriente.TabStop = true;
            this.rbCorriente.Text = "Corriente";
            this.rbCorriente.UseVisualStyleBackColor = true;
            this.rbCorriente.CheckedChanged += new System.EventHandler(this.rbCorriente_CheckedChanged);
            // 
            // rbVista
            // 
            this.rbVista.AutoSize = true;
            this.rbVista.Location = new System.Drawing.Point(122, 124);
            this.rbVista.Name = "rbVista";
            this.rbVista.Size = new System.Drawing.Size(48, 17);
            this.rbVista.TabIndex = 6;
            this.rbVista.TabStop = true;
            this.rbVista.Text = "Vista";
            this.rbVista.UseVisualStyleBackColor = true;
            this.rbVista.CheckedChanged += new System.EventHandler(this.rbVista_CheckedChanged);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(122, 74);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(155, 20);
            this.txtCliente.TabIndex = 4;
            // 
            // txtCtaBancaria
            // 
            this.txtCtaBancaria.Location = new System.Drawing.Point(122, 28);
            this.txtCtaBancaria.Name = "txtCtaBancaria";
            this.txtCtaBancaria.Size = new System.Drawing.Size(155, 20);
            this.txtCtaBancaria.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de cuenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de cuenta";
            // 
            // listTransacciones
            // 
            this.listTransacciones.FormattingEnabled = true;
            this.listTransacciones.Location = new System.Drawing.Point(404, 19);
            this.listTransacciones.Name = "listTransacciones";
            this.listTransacciones.Size = new System.Drawing.Size(476, 160);
            this.listTransacciones.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Estudio :p";
            this.panel1.ResumeLayout(false);
            this.gbTransacciones.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbTransacciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.RadioButton rbCorriente;
        private System.Windows.Forms.RadioButton rbVista;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtCtaBancaria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRetiro;
        private System.Windows.Forms.TextBox txtMontoRetiro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.TextBox txtMontoDeposito;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.ListBox listTransacciones;
    }
}

