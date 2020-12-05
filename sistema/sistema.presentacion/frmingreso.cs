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
    public partial class frmingreso : Form
    {
        private DataTable DtDetalle = new DataTable();
        public frmingreso()
        {
            InitializeComponent();
        }
        private void listar()
        {
            try
            {
                dgblistado.DataSource = NIngreso.Listar();
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
                dgblistado.DataSource = NIngreso.Buscar(txtbuscar.Text);
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
           // txtnombre.Clear();
            txtid.Clear();
            //txtdescripcion.Clear();
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
            dgblistado.Columns[1].Visible = false;
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
        private void CrearTabla()
        {
            this.DtDetalle.Columns.Add("idarticulo", System.Type.GetType("System.Int32"));
            this.DtDetalle.Columns.Add("codigo", System.Type.GetType("System.String"));
            this.DtDetalle.Columns.Add("articulo", System.Type.GetType("System.String"));
            this.DtDetalle.Columns.Add("cantidad", System.Type.GetType("System.Int32"));
            this.DtDetalle.Columns.Add("precio", System.Type.GetType("System.Decimal"));
            this.DtDetalle.Columns.Add("importe", System.Type.GetType("System.Decimal"));

            dgvdetalle.DataSource = this.DtDetalle;

            dgvdetalle.Columns[0].Visible = false;
            dgvdetalle.Columns[1].HeaderText = "Codigo";
            dgvdetalle.Columns[1].Width = 100;
            dgvdetalle.Columns[2].HeaderText = "Articulo";
            dgvdetalle.Columns[2].Width = 200;
            dgvdetalle.Columns[3].HeaderText = "Cantidad";
            dgvdetalle.Columns[3].Width = 80;
            dgvdetalle.Columns[4].HeaderText = "Precio";
            dgvdetalle.Columns[4].Width = 80;
            dgvdetalle.Columns[5].HeaderText = "Importe";
            dgvdetalle.Columns[5].Width = 90;

            dgvdetalle.Columns[1].ReadOnly = true;
            dgvdetalle.Columns[2].ReadOnly = true;
            dgvdetalle.Columns[5].ReadOnly = true;
        }
        private void frmingreso_Load(object sender, EventArgs e)
        {
            this.listar();
            this.CrearTabla();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            this.Buscar();
          
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }
    }
}
