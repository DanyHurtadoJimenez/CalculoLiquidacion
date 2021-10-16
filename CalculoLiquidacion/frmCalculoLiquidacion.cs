using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OperacionesLogica;

namespace CalculoLiquidacion
{
    public partial class frmCalculoLiquidacion : Form
    {
        public frmCalculoLiquidacion()
        {
            InitializeComponent();
        }

        #region variables Globales
        public double cesantia, vacaciones, preaviso, aguinaldo,liquidacionTotal;
        #endregion

        #region Metodos
        public void LimpiarControles() {

            txtNombreEmpleado.Text = string.Empty;
            txtSalarioPromedio.Text = string.Empty;
            txtAniosLaborados.Text = string.Empty;
            txtDiasVacaciones.Text = string.Empty;
            chkPreaviso.Checked = false;
            chkAguinaldo.Checked = false;
            nudCantidadAguinaldo.Value = 0;
            nudCantidadAguinaldo.Enabled = false;
            nudCantidadPreaviso.Enabled = false;
            nudCantidadPreaviso.Value = 0;
            lblCesantia.Text = string.Empty;
            lblVacaciones.Text = string.Empty;
            lblPreaviso.Text = string.Empty;
            lblAguinaldo.Text = string.Empty;
            lblResultadoLiquidacion.Text = string.Empty;
        }

        private bool ValidarCampos() { //valida que todos los campos esten llenos
            bool todoCorrecto = true;

            if (txtNombreEmpleado.Text == string.Empty) {
                todoCorrecto = false;
                errorProvider1.SetError(txtNombreEmpleado, "Debe ingresar un nombre de empleado");
            }

            if (txtSalarioPromedio.Text == string.Empty)
            {
                todoCorrecto = false;
                errorProvider1.SetError(txtSalarioPromedio, "Debe ingresar un salario promedio");
            }

            if (txtAniosLaborados.Text == string.Empty)
            {
                todoCorrecto = false;
                errorProvider1.SetError(txtAniosLaborados, "Debe ingresar los años laborados");
            }

            if (txtDiasVacaciones.Text == string.Empty)
            {
                todoCorrecto = false;
                errorProvider1.SetError(txtDiasVacaciones, "Debe ingresar los dias de vacaciones");
            }

            return todoCorrecto;
        
        }


        private void BorrarMensajesError() { //elimina los mensajes de error que se producen en la recoleccion de datos
            errorProvider1.SetError(txtNombreEmpleado, string.Empty);
            errorProvider1.SetError(txtSalarioPromedio, string.Empty);
            errorProvider1.SetError(txtAniosLaborados, string.Empty);
            errorProvider1.SetError(txtDiasVacaciones, string.Empty);
        }


        #endregion

        private void frmCalculoLiquidacion_Load(object sender, EventArgs e)
        {
            LimpiarControles();

        }

        private void TsbCalcularLiquidacion_Click(object sender, EventArgs e)
        {
            
            BorrarMensajesError();

            if (ValidarCampos()) {
                ClsLiquidacion pagoEmpleado = new ClsLiquidacion();
                pagoEmpleado.SalarioPromedio = double.Parse(txtSalarioPromedio.Text);///////////////////////////////////////////////////////////////////////////////////////////////////////////////
                cesantia = pagoEmpleado.CalculoCesantia(int.Parse(txtAniosLaborados.Text));
                vacaciones = pagoEmpleado.CalculoVacaciones(int.Parse(txtDiasVacaciones.Text));

                if (chkPreaviso.Checked) {
                    nudCantidadPreaviso.Enabled = true;
                    preaviso = pagoEmpleado.CalculoPreaviso(Decimal.ToInt32(nudCantidadPreaviso.Value));
                }
                else {
                    preaviso = 0;
                }

                if (chkAguinaldo.Checked) {
                    aguinaldo = pagoEmpleado.CalculoAguinaldo(Decimal.ToInt32(nudCantidadAguinaldo.Value));
                }
                else {
                    aguinaldo = 0;
                }

                liquidacionTotal = (cesantia + vacaciones + preaviso + aguinaldo); //se calcula el total de liquidacion

                lblCesantia.Text = cesantia.ToString("C");
                lblVacaciones.Text = vacaciones.ToString("C");
                lblPreaviso.Text = preaviso.ToString("C");
                lblAguinaldo.Text = aguinaldo.ToString("C");
                lblResultadoLiquidacion.Text = liquidacionTotal.ToString("C");

            }

        }

        private void TsbAgregarEmpleado_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            txtNombreEmpleado.Focus();
        }

        private void txtSalarioPromedio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)  && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                errorProvider1.SetError(txtSalarioPromedio, "Debe ingresar un valor numerico");
            }
            else {
                errorProvider1.SetError(txtSalarioPromedio, string.Empty);
            }
        }

        private void chkPreaviso_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPreaviso.Checked)
            {
                nudCantidadPreaviso.Enabled = true;
            }
            else {
                nudCantidadPreaviso.Enabled = false;
            }
            
        }

        private void chkAguinaldo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAguinaldo.Checked)
            {
                nudCantidadAguinaldo.Enabled = true;
            }
            else
            {
                nudCantidadAguinaldo.Enabled = false;
            }
        }

        private void txtNombreEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                errorProvider1.SetError(txtNombreEmpleado, "Debe ingresar solamente letras");
            }
            else
            {
                errorProvider1.SetError(txtNombreEmpleado, string.Empty);
            }
        }

        private void txtAniosLaborados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                errorProvider1.SetError(txtAniosLaborados, "Debe ingresar un valor numerico");
            }
            else
            {
                errorProvider1.SetError(txtAniosLaborados, string.Empty);
            }
        }

        private void txtDiasVacaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                errorProvider1.SetError(txtDiasVacaciones, "Debe ingresar un valor numerico");
            }
            else
            {
                errorProvider1.SetError(txtDiasVacaciones, string.Empty);
            }
        }
    }
}
