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
    public partial class frmproveedor : Form
    {
        private string NombreAnt;
        public frmproveedor()
        {
            InitializeComponent();
        }
        private void listar()
        {
            try
            {
                dgblistado.DataSource = NPersona.ListarProveedores();
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
                dgblistado.DataSource = NPersona.BuscarProveedores(txtbuscar.Text);
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
            TxtNombre.Clear();
            txtid.Clear();
            TxtNumDocumento.Clear();
            TxtDireccion.Clear();
            TxtTelefono.Clear();
            TxtEmail.Clear();
            btninsertar.Visible = true;
            btnactualizar.Visible = false;
            errorIcono.Clear();
            dgblistado.Columns[0].Visible = false;
            btneliminar.Visible = false;
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
            dgblistado.Columns[1].Width = 50;
            dgblistado.Columns[2].Width = 150;
            dgblistado.Columns[2].HeaderText = "Tipo persona";
            dgblistado.Columns[3].Width = 170;
            dgblistado.Columns[4].Width = 100;
            dgblistado.Columns[4].HeaderText = "Documento";
            dgblistado.Columns[5].Width = 150;
            dgblistado.Columns[5].HeaderText = "Numero Doc";
            dgblistado.Columns[6].Width = 120;
            dgblistado.Columns[6].HeaderText = "Dirección";
            dgblistado.Columns[7].Width = 100;
            dgblistado.Columns[7].HeaderText = "Teléfono";
            dgblistado.Columns[8].Width = 120;

        }

        private void frmproveedor_Load(object sender, EventArgs e)
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

        private void btninsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if ( TxtNombre.Text == string.Empty || TxtEmail.Text == string.Empty )
                {
                    this.MensajeError("Falta ingresar algunos datos, seran remarcados");
                    errorIcono.SetError(TxtNombre, "Ingrese un nombre");
                    errorIcono.SetError(TxtEmail, "Ingrese un email");
                }
                else
                {
                    Rpta = NPersona.Insertar("Proveedor", TxtNombre.Text.Trim(), CboTipoDocumento.Text, TxtNumDocumento.Text.Trim(), TxtDireccion.Text.Trim(), TxtTelefono.Text.Trim(), TxtEmail.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se insertó de forma correcta el registro");
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

        private void dgblistado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.limpiar();
                btnactualizar.Visible = true;
                btninsertar.Visible = false;
                txtid.Text = Convert.ToString(dgblistado.CurrentRow.Cells["ID"].Value);
                this.NombreAnt = Convert.ToString(dgblistado.CurrentRow.Cells["Nombre"].Value);
                TxtNombre.Text = Convert.ToString(dgblistado.CurrentRow.Cells["Nombre"].Value);
                CboTipoDocumento.Text = Convert.ToString(dgblistado.CurrentRow.Cells["Tipo_Documento"].Value);
                TxtNumDocumento.Text = Convert.ToString(dgblistado.CurrentRow.Cells["Num_Documento"].Value);
                TxtDireccion.Text = Convert.ToString(dgblistado.CurrentRow.Cells["Direccion"].Value);
                TxtTelefono.Text = Convert.ToString(dgblistado.CurrentRow.Cells["Telefono"].Value);
                TxtEmail.Text = Convert.ToString(dgblistado.CurrentRow.Cells["Email"].Value);
                tabgeneral.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione desde la celda nombre." + "| Error: " + ex.Message);
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (txtid.Text == string.Empty || TxtNombre.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    errorIcono.SetError(TxtNombre, "Ingrese un nombre.");
                }
                else
                {
                    Rpta = NPersona.Actualizar(Convert.ToInt32(txtid.Text), "Proveedor", this.NombreAnt, TxtNombre.Text.Trim(), CboTipoDocumento.Text, TxtNumDocumento.Text.Trim(), TxtDireccion.Text.Trim(), TxtTelefono.Text.Trim(), TxtEmail.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se actualizó de forma correcta el registro");
                        this.limpiar();
                        this.listar();
                        tabgeneral.SelectedIndex = 0;
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

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.limpiar();
            tabgeneral.SelectedIndex = 0;
        }

        private void chkseleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkseleccionar.Checked)
            {
                dgblistado.Columns[0].Visible = true;
                btneliminar.Visible = true;
            }
            else
            {
                dgblistado.Columns[0].Visible = false;
                btneliminar.Visible = false;
            }
        }

        private void dgblistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgblistado.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dgblistado.Rows[e.RowIndex].Cells["Seleccionar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente deseas eliminar el(los) registro(s)?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dgblistado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = NPersona.Eliminar(Codigo);

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se eliminó el registro: " + Convert.ToString(row.Cells[3].Value));
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
