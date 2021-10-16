
namespace CalculoLiquidacion
{
    partial class frmCalculoLiquidacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculoLiquidacion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nudCantidadAguinaldo = new System.Windows.Forms.NumericUpDown();
            this.nudCantidadPreaviso = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.chkAguinaldo = new System.Windows.Forms.CheckBox();
            this.chkPreaviso = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiasVacaciones = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAniosLaborados = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalarioPromedio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TsbAgregarEmpleado = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TsbActualizarEmpleado = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TsbCalcularLiquidacion = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAguinaldo = new System.Windows.Forms.Label();
            this.lblPreaviso = new System.Windows.Forms.Label();
            this.lblVacaciones = new System.Windows.Forms.Label();
            this.lblCesantia = new System.Windows.Forms.Label();
            this.lblResultadoLiquidacion = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadAguinaldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadPreaviso)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 85);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(80, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cálculo de Liquidación";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.nudCantidadAguinaldo);
            this.panel2.Controls.Add(this.nudCantidadPreaviso);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.chkAguinaldo);
            this.panel2.Controls.Add(this.chkPreaviso);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtDiasVacaciones);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtAniosLaborados);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtSalarioPromedio);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtNombreEmpleado);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Location = new System.Drawing.Point(12, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 279);
            this.panel2.TabIndex = 1;
            this.panel2.Tag = "Agregar Empleado";
            // 
            // nudCantidadAguinaldo
            // 
            this.nudCantidadAguinaldo.Enabled = false;
            this.nudCantidadAguinaldo.Location = new System.Drawing.Point(125, 241);
            this.nudCantidadAguinaldo.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudCantidadAguinaldo.Name = "nudCantidadAguinaldo";
            this.nudCantidadAguinaldo.ReadOnly = true;
            this.nudCantidadAguinaldo.Size = new System.Drawing.Size(51, 23);
            this.nudCantidadAguinaldo.TabIndex = 17;
            // 
            // nudCantidadPreaviso
            // 
            this.nudCantidadPreaviso.Enabled = false;
            this.nudCantidadPreaviso.Location = new System.Drawing.Point(126, 209);
            this.nudCantidadPreaviso.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudCantidadPreaviso.Name = "nudCantidadPreaviso";
            this.nudCantidadPreaviso.ReadOnly = true;
            this.nudCantidadPreaviso.Size = new System.Drawing.Size(50, 23);
            this.nudCantidadPreaviso.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(182, 246);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 15);
            this.label13.TabIndex = 15;
            this.label13.Text = "Meses";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(182, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 15);
            this.label12.TabIndex = 14;
            this.label12.Text = "Días";
            // 
            // chkAguinaldo
            // 
            this.chkAguinaldo.AutoSize = true;
            this.chkAguinaldo.Location = new System.Drawing.Point(3, 242);
            this.chkAguinaldo.Name = "chkAguinaldo";
            this.chkAguinaldo.Size = new System.Drawing.Size(114, 19);
            this.chkAguinaldo.TabIndex = 11;
            this.chkAguinaldo.Text = "Pagar Aguinaldo";
            this.chkAguinaldo.UseVisualStyleBackColor = true;
            this.chkAguinaldo.CheckedChanged += new System.EventHandler(this.chkAguinaldo_CheckedChanged);
            // 
            // chkPreaviso
            // 
            this.chkPreaviso.AutoSize = true;
            this.chkPreaviso.Location = new System.Drawing.Point(3, 207);
            this.chkPreaviso.Name = "chkPreaviso";
            this.chkPreaviso.Size = new System.Drawing.Size(103, 19);
            this.chkPreaviso.TabIndex = 10;
            this.chkPreaviso.Text = "Pagar Preaviso";
            this.chkPreaviso.UseVisualStyleBackColor = true;
            this.chkPreaviso.CheckedChanged += new System.EventHandler(this.chkPreaviso_CheckedChanged);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(3, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(410, 1);
            this.label6.TabIndex = 9;
            // 
            // txtDiasVacaciones
            // 
            this.txtDiasVacaciones.Location = new System.Drawing.Point(125, 157);
            this.txtDiasVacaciones.MaxLength = 2;
            this.txtDiasVacaciones.Name = "txtDiasVacaciones";
            this.txtDiasVacaciones.Size = new System.Drawing.Size(51, 23);
            this.txtDiasVacaciones.TabIndex = 8;
            this.txtDiasVacaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiasVacaciones_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Dias de Vacaciones:";
            // 
            // txtAniosLaborados
            // 
            this.txtAniosLaborados.Location = new System.Drawing.Point(125, 114);
            this.txtAniosLaborados.MaxLength = 2;
            this.txtAniosLaborados.Name = "txtAniosLaborados";
            this.txtAniosLaborados.Size = new System.Drawing.Size(51, 23);
            this.txtAniosLaborados.TabIndex = 6;
            this.txtAniosLaborados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAniosLaborados_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Años laborados:";
            // 
            // txtSalarioPromedio
            // 
            this.txtSalarioPromedio.Location = new System.Drawing.Point(225, 75);
            this.txtSalarioPromedio.MaxLength = 7;
            this.txtSalarioPromedio.Name = "txtSalarioPromedio";
            this.txtSalarioPromedio.Size = new System.Drawing.Size(188, 23);
            this.txtSalarioPromedio.TabIndex = 4;
            this.txtSalarioPromedio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalarioPromedio_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Salario Promedio de los ultimos 6 meses:";
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtNombreEmpleado.Location = new System.Drawing.Point(126, 35);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(287, 23);
            this.txtNombreEmpleado.TabIndex = 2;
            this.txtNombreEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreEmpleado_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Empleado:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbAgregarEmpleado,
            this.toolStripSeparator1,
            this.TsbActualizarEmpleado,
            this.toolStripSeparator2,
            this.TsbCalcularLiquidacion,
            this.toolStripSeparator3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(450, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TsbAgregarEmpleado
            // 
            this.TsbAgregarEmpleado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbAgregarEmpleado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TsbAgregarEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("TsbAgregarEmpleado.Image")));
            this.TsbAgregarEmpleado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbAgregarEmpleado.Name = "TsbAgregarEmpleado";
            this.TsbAgregarEmpleado.Size = new System.Drawing.Size(23, 22);
            this.TsbAgregarEmpleado.Text = "Agregar Datos";
            this.TsbAgregarEmpleado.Click += new System.EventHandler(this.TsbAgregarEmpleado_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // TsbActualizarEmpleado
            // 
            this.TsbActualizarEmpleado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbActualizarEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("TsbActualizarEmpleado.Image")));
            this.TsbActualizarEmpleado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbActualizarEmpleado.Name = "TsbActualizarEmpleado";
            this.TsbActualizarEmpleado.Size = new System.Drawing.Size(23, 22);
            this.TsbActualizarEmpleado.Tag = "";
            this.TsbActualizarEmpleado.Text = "Actualizar Información";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // TsbCalcularLiquidacion
            // 
            this.TsbCalcularLiquidacion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbCalcularLiquidacion.Image = ((System.Drawing.Image)(resources.GetObject("TsbCalcularLiquidacion.Image")));
            this.TsbCalcularLiquidacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbCalcularLiquidacion.Name = "TsbCalcularLiquidacion";
            this.TsbCalcularLiquidacion.Size = new System.Drawing.Size(23, 22);
            this.TsbCalcularLiquidacion.Tag = "";
            this.TsbCalcularLiquidacion.Text = "Calcular Liquidación";
            this.TsbCalcularLiquidacion.Click += new System.EventHandler(this.TsbCalcularLiquidacion_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Tag = "";
            this.toolStripButton4.Text = "Cerrar esta ventana";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAguinaldo);
            this.groupBox1.Controls.Add(this.lblPreaviso);
            this.groupBox1.Controls.Add(this.lblVacaciones);
            this.groupBox1.Controls.Add(this.lblCesantia);
            this.groupBox1.Controls.Add(this.lblResultadoLiquidacion);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 407);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 157);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumen del Cálculo";
            // 
            // lblAguinaldo
            // 
            this.lblAguinaldo.AutoSize = true;
            this.lblAguinaldo.Location = new System.Drawing.Point(90, 117);
            this.lblAguinaldo.Name = "lblAguinaldo";
            this.lblAguinaldo.Size = new System.Drawing.Size(0, 15);
            this.lblAguinaldo.TabIndex = 21;
            // 
            // lblPreaviso
            // 
            this.lblPreaviso.AutoSize = true;
            this.lblPreaviso.Location = new System.Drawing.Point(90, 90);
            this.lblPreaviso.Name = "lblPreaviso";
            this.lblPreaviso.Size = new System.Drawing.Size(0, 15);
            this.lblPreaviso.TabIndex = 20;
            // 
            // lblVacaciones
            // 
            this.lblVacaciones.AutoSize = true;
            this.lblVacaciones.Location = new System.Drawing.Point(90, 59);
            this.lblVacaciones.Name = "lblVacaciones";
            this.lblVacaciones.Size = new System.Drawing.Size(0, 15);
            this.lblVacaciones.TabIndex = 19;
            // 
            // lblCesantia
            // 
            this.lblCesantia.AutoSize = true;
            this.lblCesantia.Location = new System.Drawing.Point(90, 32);
            this.lblCesantia.Name = "lblCesantia";
            this.lblCesantia.Size = new System.Drawing.Size(0, 15);
            this.lblCesantia.TabIndex = 18;
            // 
            // lblResultadoLiquidacion
            // 
            this.lblResultadoLiquidacion.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblResultadoLiquidacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultadoLiquidacion.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultadoLiquidacion.Location = new System.Drawing.Point(202, 90);
            this.lblResultadoLiquidacion.Name = "lblResultadoLiquidacion";
            this.lblResultadoLiquidacion.Size = new System.Drawing.Size(212, 53);
            this.lblResultadoLiquidacion.TabIndex = 17;
            this.lblResultadoLiquidacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(202, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "Monto de la Liquidación";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 15);
            this.label10.TabIndex = 15;
            this.label10.Text = "Aguinaldo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Preaviso:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Vacaciones:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cesantía:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmCalculoLiquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 574);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmCalculoLiquidacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo Liquidación";
            this.Load += new System.EventHandler(this.frmCalculoLiquidacion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadAguinaldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadPreaviso)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSalarioPromedio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TsbAgregarEmpleado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TsbActualizarEmpleado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton TsbCalcularLiquidacion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.CheckBox chkAguinaldo;
        private System.Windows.Forms.CheckBox chkPreaviso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiasVacaciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAniosLaborados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAguinaldo;
        private System.Windows.Forms.Label lblPreaviso;
        private System.Windows.Forms.Label lblVacaciones;
        private System.Windows.Forms.Label lblCesantia;
        private System.Windows.Forms.Label lblResultadoLiquidacion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown nudCantidadAguinaldo;
        private System.Windows.Forms.NumericUpDown nudCantidadPreaviso;
    }
}