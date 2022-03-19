using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Datos.Accesos;
using Datos.Entidades;

namespace ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button3_Click_1(object sender, EventArgs e)
        {
            UsuarioDA usuarioDA = new UsuarioDA();
            Usuario usuario = new Usuario();

            usuario = usuarioDA.Login(textBox3.Text, textBox4.Text);

            if (usuario == null)
            {
                MessageBox.Show("Datos Erroneos");
                return;

            }
            else if (usuario.EstaActivo)
            {
                MessageBox.Show("Datos Erroneos");
            }


            frmUsuarios frmUsuarios = new frmUsuarios();
            frmUsuarios.Show();
        
        }
    }
}
