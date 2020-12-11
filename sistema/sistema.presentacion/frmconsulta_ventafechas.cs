using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Negocio;

namespace sistema.presentacion
{
    public partial class frmconsulta_ventafechas : Form
    {
        public frmconsulta_ventafechas()
        {
            InitializeComponent();
        }
        private void Buscar()
        {
            try
            {
                dgblistado.DataSource = NVenta.ConsultarFechas(Convert.ToDateTime(dateinicio.Value), Convert.ToDateTime(datefinal.Value));
                this.formato();
                lbltotal.Text = "Total de registros:  " + Convert.ToString(dgblistado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void limpiar()
        {
         
            dgblistado.Columns[0].Visible = false;
          

        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void formato()
        {
            dgblistado.Columns[0].Visible = false;
            dgblistado.Columns[1].Visible = false;
            dgblistado.Columns[2].Visible = false;
            dgblistado.Columns[0].Width = 100;
            dgblistado.Columns[3].Width = 150;
            dgblistado.Columns[4].Width = 150;
            dgblistado.Columns[5].Width = 100;
            dgblistado.Columns[5].HeaderText = "Documento";
            dgblistado.Columns[6].Width = 80;
            dgblistado.Columns[6].HeaderText = "Serie";
            dgblistado.Columns[7].Width = 80;
            dgblistado.Columns[7].HeaderText = "Numero";
            dgblistado.Columns[8].Width = 70;
            dgblistado.Columns[9].Width = 100;
            dgblistado.Columns[10].Width = 100;
            dgblistado.Columns[11].Width = 100;
        }

        private void frmconsulta_ventafechas_Load(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void BtnCerrarDetalle_Click(object sender, EventArgs e)
        {
            panelmostrar.Visible = false;
        }

        private void dgblistado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DGVMostrarDetalle.DataSource = NVenta.ListarDetalle(Convert.ToInt32(dgblistado.CurrentRow.Cells["ID"].Value));
                decimal Total, Subtotal;
                decimal Impuesto = Convert.ToDecimal(dgblistado.CurrentRow.Cells["Impuesto"].Value);
                Total = Convert.ToDecimal(dgblistado.CurrentRow.Cells["Total"].Value);
                Subtotal = Total / (1 + Impuesto);
                DGVMostrarDetalle.Columns[0].Width = 70;
                DGVMostrarDetalle.Columns[5].HeaderText = "PRECIO TOTAL";
                DGVMostrarDetalle.Columns[5].Width = 150;
                txtttotal.Text = Total.ToString("#0,00#");
                txtssubtotal.Text = Subtotal.ToString("#0,00#");
                txtiiva.Text = (Total - Subtotal).ToString("#0,00#");
                panelmostrar.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            try
            {
                Variables.IdVenta = Convert.ToInt32(dgblistado.CurrentRow.Cells["ID"].Value);
                Reportes.frmreportecomprobanteventa Reporte = new Reportes.frmreportecomprobanteventa();
                Reporte.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
