using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema.presentacion.Reportes
{
    public partial class frmreportecomprobanteventa : Form
    {
        public frmreportecomprobanteventa()
        {
            InitializeComponent();
        }

        private void frmreportecomprobanteventa_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DsSistema.venta_comprobante' Puede moverla o quitarla según sea necesario.
            this.venta_comprobanteTableAdapter.Fill(this.DsSistema.venta_comprobante, Variables.IdVenta);

            this.reportViewer1.RefreshReport();
        }
    }
}
