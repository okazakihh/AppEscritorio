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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tabla = new DataTable();
                tabla = NUsuario.Login(TxtUsuario.Text.Trim(), TxtClave.Text.Trim());
                if(tabla.Rows.Count<=0)
                {
                    MessageBox.Show("El correo o la clave es incorrect@ ", "Acceso al sistema ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(Convert.ToBoolean(tabla.Rows[0][4])==false)
                    {
                        MessageBox.Show("Este usuario no esta activo ", "Acceso al sistema ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        frmprincipal frm = new frmprincipal();
                        frm.IdUsuario = Convert.ToInt32(tabla.Rows[0][0]);
                        frm.IdRol = Convert.ToInt32(tabla.Rows[0][1]);
                        frm.Rol = Convert.ToString(tabla.Rows[0][2]);
                        frm.Nombre = Convert.ToString(tabla.Rows[0][3]);
                        frm.Estado = Convert.ToBoolean(tabla.Rows[0][4]);
                        frm.Show();
                        this.Hide();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             lblhora.Text = DateTime.Now.ToString();
        }
    }
}
