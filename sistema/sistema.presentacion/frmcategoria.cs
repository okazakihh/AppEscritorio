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
    public partial class frmcategoria : Form
    {
        private string NombreAnt;
        public frmcategoria()
        {
            InitializeComponent();
        }
        private void listar()
        {
            try
            {
                dgblistado.DataSource = NCategoria.Listar();
                this.formato();
                this.limpiar();
                lbltotal.Text = "Total de registros:  "  + Convert.ToString(dgblistado.Rows.Count);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }
        private void Buscar()
        {
            try
            {
                dgblistado.DataSource = NCategoria.Buscar(txtbuscar.Text);
                this.formato();
                lbltotal.Text = "Total de registros:  " + Convert.ToString(dgblistado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void limpiar ()
        {
            txtbuscar.Clear();
            txtnombre.Clear();
            txtid.Clear();
            txtdescripcion.Clear();
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

        private void formato()
        {
            dgblistado.Columns[0].Visible = false;
            dgblistado.Columns[1].Visible = false;
            dgblistado.Columns[2].Width = 150 ;
            dgblistado.Columns[3].Width = 350;
            dgblistado.Columns[3].HeaderText = "Descripción";
            dgblistado.Columns[4].Width = 100;
        } 
        private void frmcategoria_Load(object sender, EventArgs e)
        {
            this.listar();
            
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
                if (txtnombre.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seran remarcados");
                    errorIcono.SetError(txtnombre,"Ingrese un nombre");
                }
                else
                {
                    Rpta = NCategoria.Insertar(txtnombre.Text.Trim(), txtdescripcion.Text.Trim());
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.limpiar();
            tabgeneral.SelectedIndex = 0;
        }

        private void dgblistado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.limpiar();
                btnactualizar.Visible = true;
                btninsertar.Visible = false;

                txtid.Text = Convert.ToString(dgblistado.CurrentRow.Cells["Id"].Value);
                this.NombreAnt = Convert.ToString(dgblistado.CurrentRow.Cells["Nombre"].Value);
                txtnombre.Text = Convert.ToString(dgblistado.CurrentRow.Cells["Nombre"].Value);
                txtdescripcion.Text = Convert.ToString(dgblistado.CurrentRow.Cells["Descripcion"].Value);
                tabgeneral.SelectedIndex = 1;
            }
            catch(Exception )
            {
                MessageBox.Show("Seleccione desde la celda nombre");
            }

        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (txtnombre.Text == string.Empty || txtid.Text ==string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seran remarcados");
                    errorIcono.SetError(txtnombre, "Ingrese un nombre");
                }
                else
                {
                    Rpta = NCategoria.Actualizar(Convert.ToInt32(txtid.Text),this.NombreAnt, txtnombre.Text.Trim(), txtdescripcion.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se actualizó de forma correcta el registro");
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

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void chkseleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if(chkseleccionar.Checked)
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

        private void dgblistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==dgblistado.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell chkeliminar = (DataGridViewCheckBoxCell)dgblistado.Rows[e.RowIndex].Cells["Seleccionar"];
                chkeliminar.Value = !Convert.ToBoolean(chkeliminar.Value);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente desea eliminar el (los) registro(s) ?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
               
                if(Opcion==DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";
                   
                    foreach(DataGridViewRow row in dgblistado.Rows)
                    {
                        if(Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            
                            Rpta = NCategoria.Eliminar(Codigo);
                            if(Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se eliminó el registro "+ Convert.ToString(row.Cells[2].Value));
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnactivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente desea activar el (los) registro(s) ?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dgblistado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = NCategoria.Activar(Codigo);
                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se activó el registro " + Convert.ToString(row.Cells[2].Value));
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
                            Rpta = NCategoria.Desactivar(Codigo);
                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se desactivó el registro " + Convert.ToString(row.Cells[2].Value));
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
