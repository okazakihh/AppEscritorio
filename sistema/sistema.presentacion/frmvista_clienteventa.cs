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
    public partial class frmvista_clienteventa : Form
    {
        public frmvista_clienteventa()
        {
            InitializeComponent();
        }
        private void Buscar()
        {
            try
            {
                dgblistado.DataSource = NPersona.BuscarClientes(txtbuscar.Text);
                this.formato();
                lbltotal.Text = "Total de registros:  " + Convert.ToString(dgblistado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
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

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void dgblistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Variables.IdCliente = Convert.ToInt32(dgblistado.CurrentRow.Cells["ID"].Value);
            Variables.NombreCliente = Convert.ToString(dgblistado.CurrentRow.Cells["Nombre"].Value);
            this.Close();
        }
    }
}
