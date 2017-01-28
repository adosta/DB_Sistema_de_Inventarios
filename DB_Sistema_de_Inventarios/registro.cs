using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Sistema_de_Inventarios
{
    public partial class registro : Form
    {
        dsInventarioTableAdapters.Tabla_UsuariosTableAdapter taUsuarios = new dsInventarioTableAdapters.Tabla_UsuariosTableAdapter();
        public registro()
        {
            InitializeComponent();
        }

        private void registro_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            taUsuarios.Insert(tbUsuario.Text, tbContrasena.Text);
        }
    }
}
