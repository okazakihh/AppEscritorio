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
    public partial class frmrol : Form
    {
        public frmrol()
        {
            InitializeComponent();
        }

        private void listar()
        {
            try
            {
                dgblistado.DataSource = NRol.Listar();
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
            dgblistado.Columns[0].Width = 100;
            dgblistado.Columns[0].HeaderText = "ID";
            dgblistado.Columns[1].Width = 200;
            dgblistado.Columns[1].HeaderText = "Nombre";
        }

        private void frmrol_Load(object sender, EventArgs e)
        {
            this.listar();
        }
    }
}
