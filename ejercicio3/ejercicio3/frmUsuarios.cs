using Datos.Accesos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio3
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        UsuarioDA usuarioDA = new UsuarioDA();

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            ListarUsuarios();

        }

        private void ListarUsuarios()
        {
            dataGridView1.DataSource = usuarioDA.ListarUsuarios();
        }
    }
}
