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
    public partial class frmususario : Form
    {
        private string EmailAnt;
        public frmususario()
        {
            InitializeComponent();
        }
        private void listar()
        {
            try
            {
                dgblistado.DataSource = NUsuario.Listar();
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
                dgblistado.DataSource = NUsuario.Buscar(txtbuscar.Text);
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
            TxtClave.Clear();
            btninsertar.Visible = true;
            btnactualizar.Visible = false;
            errorIcono.Clear();
            dgblistado.Columns[0].Visible = false;
            btnactivar.Visible = false;
            btndesactivar.Visible = false;
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
        private void CargarRol()
        {
            try
            {
                CboRol.DataSource = NRol.Listar();
                CboRol.ValueMember = "idrol";
                CboRol.DisplayMember = "nombre";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        


        private void formato()
        {
            dgblistado.Columns[0].Visible = false;
            dgblistado.Columns[2].Visible = false;
            dgblistado.Columns[1].Width = 50;
            dgblistado.Columns[3].Width = 100;
            dgblistado.Columns[4].Width = 170;
            dgblistado.Columns[5].Width = 100;
            dgblistado.Columns[5].HeaderText = "Documento";
            dgblistado.Columns[6].Width = 150;
            dgblistado.Columns[6].HeaderText = "Numero Doc";
            dgblistado.Columns[7].Width = 120;
            dgblistado.Columns[7].HeaderText = "Dirección";
            dgblistado.Columns[8].Width = 100;
            dgblistado.Columns[8].HeaderText = "Teléfono";
            dgblistado.Columns[9].Width = 120;

        }

        private void frmususario_Load(object sender, EventArgs e)
        {
            this.listar();
            this.CargarRol();
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
                if (CboRol.Text == string.Empty ||  TxtNombre.Text == string.Empty || TxtEmail.Text == string.Empty ||TxtClave.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seran remarcados");
                    errorIcono.SetError(CboRol, "Seleccione  un rol");
                    errorIcono.SetError(TxtNombre, "Ingrese un nombre");
                    errorIcono.SetError(TxtEmail, "Ingrese un email");
                    errorIcono.SetError(TxtClave, "Ingrese una clave");
                }
                else
                {
                    Rpta = NUsuario.Insertar(Convert.ToInt32(CboRol.SelectedValue), TxtNombre.Text.Trim(), CboTipoDocumento.Text, TxtNumDocumento.Text.Trim(), TxtDireccion.Text.Trim(), TxtTelefono.Text.Trim(), TxtEmail.Text.Trim(),TxtClave.Text.Trim());
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
                CboRol.SelectedValue = Convert.ToString(dgblistado.CurrentRow.Cells["idrol"].Value);
                TxtNombre.Text = Convert.ToString(dgblistado.CurrentRow.Cells["Nombre"].Value);
                CboTipoDocumento.Text = Convert.ToString(dgblistado.CurrentRow.Cells["Tipo_Documento"].Value);
                TxtNumDocumento.Text = Convert.ToString(dgblistado.CurrentRow.Cells["Num_Documento"].Value);
                TxtDireccion.Text = Convert.ToString(dgblistado.CurrentRow.Cells["Direccion"].Value);
                TxtTelefono.Text = Convert.ToString(dgblistado.CurrentRow.Cells["Telefono"].Value);
                this.EmailAnt = Convert.ToString(dgblistado.CurrentRow.Cells["Email"].Value);
                TxtEmail.Text = Convert.ToString(dgblistado.CurrentRow.Cells["Email"].Value);

                tabgeneral.SelectedIndex = 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Seleccione desde la celda nombre" + "| error" + ex.Message);
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (txtid.Text == string.Empty ||  CboRol.Text == string.Empty || TxtNombre.Text == string.Empty || TxtEmail.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seran remarcados");
                    errorIcono.SetError(CboRol, "Seleccione  un rol");
                    errorIcono.SetError(TxtNombre, "Ingrese un nombre");
                    errorIcono.SetError(TxtEmail, "Ingrese un email");
                   
                }
                else
                {
                    Rpta = NUsuario.Actualizar(Convert.ToInt32(txtid.Text),  Convert.ToInt32(CboRol.SelectedValue), TxtNombre.Text.Trim(), CboTipoDocumento.Text, TxtNumDocumento.Text.Trim(), TxtDireccion.Text.Trim(), TxtTelefono.Text.Trim(),this.EmailAnt,  TxtEmail.Text.Trim(), TxtClave.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se actualizó de forma correcta el registro");
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
                btnactivar.Visible = true;
                btndesactivar.Visible = true;
                btneliminar.Visible = true;
            }
            else
            {
                dgblistado.Columns[0].Visible = false;
                btnactivar.Visible = false;
                btndesactivar.Visible = false;
                btneliminar.Visible = false;
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente desea eliminar el (los) registro(s) ?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dgblistado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);

                            Rpta = NUsuario.Eliminar(Codigo);
                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se eliminó el registro " + Convert.ToString(row.Cells[4].Value));
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

        private void btndesactivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente desea desactivar el (los) registro(s)? ", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dgblistado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = NUsuario.Desactivar(Codigo);
                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se desactivó el registro " + Convert.ToString(row.Cells[4].Value));
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

        private void btnactivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente desea activar el (los) registro(s)? ", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dgblistado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = NUsuario.Activar(Codigo);
                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se Activó el registro " + Convert.ToString(row.Cells[4].Value));
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
