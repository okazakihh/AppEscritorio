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
    public partial class frmreportearticulos : Form
    {
        public frmreportearticulos()
        {
            InitializeComponent();
        }

        private void frmreportearticulos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DsSistema.articulo_listar' Puede moverla o quitarla según sea necesario.
            this.articulo_listarTableAdapter.Fill(this.DsSistema.articulo_listar);

            this.reportViewer1.RefreshReport();
        }
    }
}
