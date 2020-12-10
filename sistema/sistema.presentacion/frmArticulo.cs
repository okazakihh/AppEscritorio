using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using Sistema.Negocio;
using System.IO;


namespace sistema.presentacion
{
    public partial class frmArticulo : Form
    {
        private string RutaOrigen;
        private string RutaDestino;
        private string Directorio = "D:\\sistema\\";
        private string NombreAnt;
        public frmArticulo()
        {
            InitializeComponent();
        }
        private void listar()
        {
            try
            {
                dgblistado.DataSource = NArticulo.Listar();
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
                dgblistado.DataSource = NArticulo.Buscar(txtbuscar.Text);
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
            TxtId.Clear();
            TxtCodigo.Clear();
            PanelCodigo.BackgroundImage = null;
            TxtPrecioVenta.Clear();
            TxtStock.Clear();
            TxtImagen.Clear();
            PicImagen.Image = null;
            TxtDescripcion.Clear();
            btninsertar.Visible = true;
            btnactualizar.Visible = false;
            errorIcono.Clear();
            dgblistado.Columns[0].Visible = false;
            btnactivar.Visible = false;
            btndesactivar.Visible = false;
            btneliminar.Visible = false;
            chkseleccionar.Checked = false;
            this.RutaDestino = "";
            this.RutaDestino = "";

        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CargarCategoria()
        {
            try
            {
                CboCategoria.DataSource = NCategoria.Seleccionar();
                CboCategoria.ValueMember = "idcategoria";
                CboCategoria.DisplayMember = "nombre";
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
            dgblistado.Columns[0].Width = 100;
            dgblistado.Columns[1].Width = 50;
            dgblistado.Columns[3].Width = 100;
            dgblistado.Columns[3].HeaderText = "Categoría";
            dgblistado.Columns[4].Width = 100;
            dgblistado.Columns[4].HeaderText = "Código";
            dgblistado.Columns[5].Width = 150;
            dgblistado.Columns[6].Width = 150;
            dgblistado.Columns[6].HeaderText = "Precio de venta";
            dgblistado.Columns[7].Width = 70;
            dgblistado.Columns[8].Width = 200;
            dgblistado.Columns[8].HeaderText = "Descripción";
            dgblistado.Columns[9].Width = 100;
            dgblistado.Columns[10].Width = 100;
        }

        private void frmArticulo_Load(object sender, EventArgs e)
        {
            this.listar();
            this.CargarCategoria();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void BtnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if(file.ShowDialog() == DialogResult.OK)
            {
                PicImagen.Image = Image.FromFile(file.FileName);
                TxtImagen.Text = file.FileName.Substring(file.FileName.LastIndexOf("\\") + 1);
                this.RutaOrigen = file.FileName;
            }


           
        }

        private void BtnGenerarCodigo_Click(object sender, EventArgs e)
        {
            BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
            Codigo.IncludeLabel = true;
            PanelCodigo.BackgroundImage = Codigo.Encode(BarcodeLib.TYPE.CODE128, TxtCodigo.Text, Color.Black,Color.LightSteelBlue);
            BtnGuardarCodigo.Enabled = true;
        }

        private void BtnGuardarCodigo_Click(object sender, EventArgs e)
        {
            Image imgFinal = (Image)PanelCodigo.BackgroundImage.Clone();

            SaveFileDialog DialogoGuardar = new SaveFileDialog();
            DialogoGuardar.AddExtension = true;
            DialogoGuardar.Filter = "image PNG(*.png)|*.png";
            DialogoGuardar.ShowDialog();
           
            if(!string.IsNullOrEmpty(DialogoGuardar.FileName))
            {
                imgFinal.Save(DialogoGuardar.FileName, ImageFormat.Png);

            }
            imgFinal.Dispose();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (CboCategoria.Text==string.Empty||  TxtNombre.Text == string.Empty|| TxtCodigo.Text == string.Empty|| TxtPrecioVenta.Text == string.Empty||TxtStock.Text==string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seran remarcados");
                    errorIcono.SetError(CboCategoria, " Seleccione una categoria ");
                    errorIcono.SetError(TxtNombre, "Ingrese un nombre");
                    errorIcono.SetError(TxtCodigo, "Ingrese un codigo ");
                    errorIcono.SetError(TxtPrecioVenta, "Ingrese un precio de venta ");
                    errorIcono.SetError(TxtStock, "Ingrese el stock del producto");
                }
                else
                {
                    Rpta = NArticulo.Insertar(Convert.ToInt32(CboCategoria.SelectedValue), TxtCodigo.Text, TxtNombre.Text.Trim(),Convert.ToDecimal(TxtPrecioVenta.Text),Convert.ToInt32(TxtStock.Text), TxtDescripcion.Text.Trim(),TxtImagen.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se insertó de forma correcta el registro");
                        if(TxtImagen.Text !=string.Empty)
                        {
                            this.RutaDestino = this.Directorio + TxtImagen.Text;
                            File.Copy(this.RutaOrigen, this.RutaDestino);
                        }

                       
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
                TxtId.Text = Convert.ToString(dgblistado.CurrentRow.Cells["ID"].Value);
                CboCategoria.SelectedValue = Convert.ToString(dgblistado.CurrentRow.Cells["idcategoria"].Value);
                TxtCodigo.Text = Convert.ToString(dgblistado.CurrentRow.Cells["Codigo"].Value);
                this.NombreAnt = Convert.ToString(dgblistado.CurrentRow.Cells["Nombre"].Value);
                TxtNombre.Text = Convert.ToString(dgblistado.CurrentRow.Cells["Nombre"].Value);
                TxtPrecioVenta.Text = Convert.ToString(dgblistado.CurrentRow.Cells["Precio_Venta"].Value);
                TxtStock.Text = Convert.ToString(dgblistado.CurrentRow.Cells["Stock"].Value);
                TxtDescripcion.Text = Convert.ToString(dgblistado.CurrentRow.Cells["Descripcion"].Value);
                string imagen;
                imagen = Convert.ToString(dgblistado.CurrentRow.Cells["Imagen"].Value);
                if(imagen != string.Empty)
                {
                    PicImagen.Image = Image.FromFile(this.Directorio + imagen);
                    TxtImagen.Text = imagen;
                }
                else
                {
                    PicImagen.Image = null;
                    TxtImagen.Text = "";
                }
                tabgeneral.SelectedIndex = 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Seleccione desde la celda nombre " + "Error:" + ex.Message);
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (TxtId.Text == string.Empty || CboCategoria.Text == string.Empty || TxtNombre.Text == string.Empty || TxtPrecioVenta.Text == string.Empty || TxtStock.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    errorIcono.SetError(CboCategoria, "Seleccione una categoría.");
                    errorIcono.SetError(TxtNombre, "Ingrese un nombre.");
                    errorIcono.SetError(TxtPrecioVenta, "Ingrese un precio.");
                    errorIcono.SetError(TxtStock, "Ingrese un stock inicial.");
                }
                else
                {
                    Rpta = NArticulo.Actualizar(Convert.ToInt32(TxtId.Text), Convert.ToInt32(CboCategoria.SelectedValue), TxtCodigo.Text.Trim(), this.NombreAnt, TxtNombre.Text.Trim(), Convert.ToDecimal(TxtPrecioVenta.Text), Convert.ToInt32(TxtStock.Text), TxtDescripcion.Text.Trim(), TxtImagen.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se actualizó de forma correcta el registro");
                        if (TxtImagen.Text != string.Empty && this.RutaOrigen!=string.Empty)
                        {
                            this.RutaDestino = this.Directorio + TxtImagen.Text;

                           // File.Copy(this.RutaOrigen, this.RutaDestino);
                        }

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
                    string imagen = "";


                    foreach (DataGridViewRow row in dgblistado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            imagen = Convert.ToString(row.Cells[9].Value);
                            Rpta = NArticulo.Eliminar(Codigo);
                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se eliminó el registro " + Convert.ToString(row.Cells[5].Value));
                                File.Delete(this.Directorio + imagen);
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
                            Rpta = NArticulo.Desactivar(Codigo);
                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se desactivó el registro " + Convert.ToString(row.Cells[5].Value));
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
                            Rpta = NArticulo.Activar(Codigo);
                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se activó el registro " + Convert.ToString(row.Cells[5].Value));
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

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            Reportes.frmreportearticulos Reporte = new Reportes.frmreportearticulos();
            Reporte.ShowDialog();
        }
    }
}
