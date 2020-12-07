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
            txtid.Clear();
            TxtCodigo.Clear();
            TxtIdProveedor.Clear();
            TxtNombreProveedor.Clear();
            TxtSerieComprobante.Clear();
            TxtNumComprobante.Clear();
            DtDetalle.Clear();
            TxtSubtotal.Text ="0.00";
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
            dgvdetalle.Columns[5].HeaderText = "Precio total";
            dgvdetalle.Columns[5].Width = 110;

            dgvdetalle.Columns[1].ReadOnly = true;
            dgvdetalle.Columns[2].ReadOnly = true;
            dgvdetalle.Columns[5].ReadOnly = true;
        }
        private void FormatoArticulos()
        {
            DgvArticulos.Columns[1].Visible = false;
            DgvArticulos.Columns[2].Width = 100;
            DgvArticulos.Columns[2].HeaderText = "Categoria";
            DgvArticulos.Columns[3].Width = 100;
            DgvArticulos.Columns[3].HeaderText = "Codigo";
            DgvArticulos.Columns[4].Width = 150;
            DgvArticulos.Columns[5].Width = 140;
            DgvArticulos.Columns[5].HeaderText = "Precio venta";
            DgvArticulos.Columns[6].Width = 70;
            DgvArticulos.Columns[7].Width = 200;
            DgvArticulos.Columns[7].HeaderText = "Descipción";
            DgvArticulos.Columns[8].Width = 100;

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

        private void BtnBuscarr_Click(object sender, EventArgs e)
        {
            frmvistaproveedor vista = new frmvistaproveedor();
            vista.ShowDialog();
            TxtIdProveedor.Text = Convert.ToString(Variables.IdProveedor);
            TxtNombreProveedor.Text = Variables.NombreProveedor;
        }

        private void TxtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if(e.KeyCode==Keys.Enter)
                {
                    DataTable tabla = new DataTable();
                    tabla = NArticulo.BuscarCodigo(TxtCodigo.Text.Trim());
                    if(tabla.Rows.Count<=0)
                    {
                        this.MensajeError("No existe un articulo con ese codigo de barras");
                    }
                    else
                    {
                        this.AgregarDetalle(Convert.ToInt32(tabla.Rows[0][0]), Convert.ToString(tabla.Rows[0][1]), Convert.ToString(tabla.Rows[0][2]), Convert.ToDecimal(tabla.Rows[0][3]));
                        TxtCodigo.Clear();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AgregarDetalle(int IdArticulo, string Codigo, string Nombre, decimal Precio)
        {
            bool Agregar = true;
            foreach(DataRow FilaTemp in DtDetalle.Rows)
            {
                if(Convert.ToInt32(FilaTemp["idarticulo"])==IdArticulo)
                {
                    Agregar = false;
                    this.MensajeError("El articulo ya ha sido agregado");
                }
            }
            if(Agregar)
            {
                DataRow fila = DtDetalle.NewRow();

                fila["idarticulo"] = IdArticulo;
                fila["codigo"] = Codigo;
                fila["articulo"] = Nombre;
                fila["cantidad"] = 1;
                fila["precio"] = Precio;
                fila["importe"] = Precio;

                this.DtDetalle.Rows.Add(fila);
                this.CalcularTotales();
            }
        }
        private void CalcularTotales()
        {
            decimal Total = 0;
            decimal Subtotal = 0;
            if(dgvdetalle.Rows.Count==0)
            {
                Total = 0;
            }
            else
            {
                foreach (DataRow FilaTemp in DtDetalle.Rows)
                {
                    Total = Total + Convert.ToDecimal(FilaTemp["importe"]);

                }
            }

            Subtotal = Total / (1 + Convert.ToDecimal(TxtImpuesto.Text));
            TxtTotal.Text = Total.ToString("#0,00#");
            TxtSubtotal.Text = Subtotal.ToString("#0,00#");
            TxtIva.Text = (Total - Subtotal).ToString("#0,00#");

        }

        private void BtnVerArticulo_Click(object sender, EventArgs e)
        {
            panelArticulos.Show();
        }


        private void BtnCerrarArticulos_Click_1(object sender, EventArgs e)
        {
            panelArticulos.Visible = false;
        }

        private void BtnFiltrarArticulos_Click_1(object sender, EventArgs e)
        {
            try
            {
                DgvArticulos.DataSource = NArticulo.Buscar(TxtBuscarArticulo.Text.Trim());
                this.FormatoArticulos();
                LblTotalArticulos.Text = "Total registros: " + Convert.ToString(DgvArticulos.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DgvArticulos_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int IdArticulo;
            string Codigo, Nombre;
            decimal Precio;

            IdArticulo = Convert.ToInt32(DgvArticulos.CurrentRow.Cells["ID"].Value);
            Codigo = Convert.ToString(DgvArticulos.CurrentRow.Cells["Codigo"].Value);
            Nombre = Convert.ToString(DgvArticulos.CurrentRow.Cells["Nombre"].Value);
            Precio = Convert.ToDecimal(DgvArticulos.CurrentRow.Cells["Precio_Venta"].Value);

            this.AgregarDetalle(IdArticulo, Codigo, Nombre, Precio);
        }

        private void dgvdetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataRow Fila = (DataRow)DtDetalle.Rows[e.RowIndex];
            decimal Precio = Convert.ToDecimal(Fila["precio"]);
            int Cantidad = Convert.ToInt32(Fila["cantidad"]);
            Fila["importe"] = Precio * Cantidad;
            this.CalcularTotales();
        }

        private void dgvdetalle_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            //this.CalcularTotales();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (TxtIdProveedor.Text == string.Empty || TxtImpuesto.Text == string.Empty || TxtNumComprobante.Text == string.Empty || DtDetalle.Rows.Count == 0)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    errorIcono.SetError(TxtIdProveedor, "Seleccione un proveedor.");
                    errorIcono.SetError(TxtImpuesto, "Ingrese el iva.");
                    errorIcono.SetError(TxtNumComprobante, "Ingrese el número del comprobante.");
                    errorIcono.SetError(dgvdetalle, "Debe tener al menos un detalle.");
                }
                else
                {
                    Rpta = NIngreso.Insertar(Convert.ToInt32(TxtIdProveedor.Text),Variables.IdUsuario, CboComprobante.Text, TxtSerieComprobante.Text.Trim(), TxtNumComprobante.Text.Trim(),Convert.ToDecimal(TxtImpuesto.Text), Convert.ToDecimal(TxtTotal.Text), DtDetalle);
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se insertó de forma correcta el registro");
                        this.limpiar();
                        this.listar();
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.CalcularTotales();
        }

        private void dgblistado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               
                DGVMostrarDetalle.DataSource = NIngreso.ListarDetalle(Convert.ToInt32(dgblistado.CurrentRow.Cells["ID"].Value));
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCerrarDetalle_Click(object sender, EventArgs e)
        {
            panelmostrar.Visible = false;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.limpiar();
            tabgeneral.SelectedIndex = 0;
        }

        private void dgblistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgblistado.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell chkeliminar = (DataGridViewCheckBoxCell)dgblistado.Rows[e.RowIndex].Cells["Seleccionar"];
                chkeliminar.Value = !Convert.ToBoolean(chkeliminar.Value);
            }
        }

        private void chkseleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkseleccionar.Checked)
            {
                dgblistado.Columns[0].Visible = true;
                btnanular.Visible = true;

            }
            else
            {
                dgblistado.Columns[0].Visible = false;
                btnanular.Visible = true;
            }
        }

        private void btnanular_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente desea anular el (los) registro(s) ?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dgblistado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = NIngreso.Anular(Codigo);
                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se anuló el registro " + Convert.ToString(row.Cells[6].Value) + "_" + Convert.ToString(row.Cells[7].Value));
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }
                        }
                    }

                    this.listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
