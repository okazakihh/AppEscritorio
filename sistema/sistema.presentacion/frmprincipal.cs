using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema.presentacion
{
    public partial class frmprincipal : Form
    {
        private int childFormNumber = 0;
        public int IdUsuario;
        public int IdRol;
        public string Nombre;
        public string Rol;
        public bool Estado;


        public frmprincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void frmprincipal_Load(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString();

            TsUsuario.Text = "GESTION Y CONTROL DE OPERCIONES MERCANTILES   Usuario:  " + this.Nombre;
            MessageBox.Show("Bienvenido" + this.Nombre, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if(this.Rol.Equals("Administrador"))
            {
                MnuAlmacen.Enabled = true;
                MnuIngresos.Enabled = true;
                MnuVentas.Enabled = true;
                MnuConsultas.Enabled = true;
                MnuAccesos.Enabled = true;
                TsCompras.Enabled = true;
                TsVentas.Enabled = true;
            }
            else
            {
                if (this.Rol.Equals("Vendedor"))
                {
                    MnuAlmacen.Enabled = false;
                    MnuIngresos.Enabled = false;
                    MnuVentas.Enabled = true;
                    MnuConsultas.Enabled = true;
                    MnuAccesos.Enabled = false;
                    TsCompras.Enabled = false;
                    TsVentas.Enabled = true;
                }
                else
                {
                    if (this.Rol.Equals("Almacenista"))
                    {
                        MnuAlmacen.Enabled = true;
                        MnuIngresos.Enabled = true;
                        MnuVentas.Enabled = false;
                        MnuConsultas.Enabled = true;
                        MnuAccesos.Enabled = false;
                        TsCompras.Enabled = true;
                        TsVentas.Enabled = false;
                    }
                    else
                    {
                        MnuAlmacen.Enabled = false;
                        MnuIngresos.Enabled = false;
                        MnuVentas.Enabled = false;
                        MnuConsultas.Enabled = false;
                        MnuAccesos.Enabled = false;
                        TsCompras.Enabled = false;
                        TsVentas.Enabled = false;
                    }
                }
            }
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcategoria frm = new frmcategoria();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmArticulo frm = new frmArticulo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmrol frm = new frmrol();
            frm.MdiParent = this;
            frm.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmususario frm = new frmususario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString();
        }

        private void frmprincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("Desea salir del sistema?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(Opcion==DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmproveedor frm = new frmproveedor();
            frm.MdiParent = this;
            frm.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcliente frm = new frmcliente();
            frm.MdiParent = this;
            frm.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmingreso frm = new frmingreso();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmventa frm = new frmventa();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
