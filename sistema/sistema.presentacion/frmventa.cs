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
    public partial class frmventa : Form
    {
        private DataTable DtDetalle = new DataTable();
        public frmventa()
        {
            InitializeComponent();
        }
        private void listar()
        {
            try
            {
                dgblistado.DataSource = NVenta.Listar();
                this.formato();
                this.limpiar();
                lbltotal.Text = "Total de registros:  " + Convert.ToString(dgblistado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }
        private void Buscar()
        {
            try
            {
                dgblistado.DataSource = NVenta.Buscar(txtbuscar.Text);
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
            txtbuscar.Clear();
            txtid.Clear();
            TxtCodigo.Clear();
            TxtIdCliente.Clear();
            TxtNombreCliente.Clear();
            TxtSerieComprobante.Clear();
            TxtNumComprobante.Clear();
            DtDetalle.Clear();
            TxtSubtotal.Text = "0.00";
            TxtIva.Text = "0.00";
            TxtTotal.Text = "0.00";
            btninsertar.Visible = true;
            btnanular.Visible = false;
            errorIcono.Clear();
            dgblistado.Columns[0].Visible = false;
            chkseleccionar.Checked = false;

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

        private void frmventa_Load(object sender, EventArgs e)
        {
            this.listar();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void BtnBuscarr_Click(object sender, EventArgs e)
        {
            frmvista_clienteventa vista = new frmvista_clienteventa();
            vista.ShowDialog();
            TxtIdCliente.Text = Convert.ToString(Variables.IdCliente);
            TxtNombreCliente.Text = Variables.NombreCliente;
        }
    }
}
