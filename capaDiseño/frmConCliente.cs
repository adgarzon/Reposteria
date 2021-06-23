using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaEntidades;
using capaLogica;

namespace capaDiseño
{
    public partial class frmConCliente : Form
    {
        clsCliente res;
        public frmConCliente()
        {
            InitializeComponent();
        }

        private void btnConCliente_Click(object sender, EventArgs e)
        {
            res = logProgram.consultaCliente(txtIdBuscar.Text);
            txtDocumento.Text = res.Documento;
            txtPrimerNombre.Text = res.PrimerNombre;
            txtSegundoNombre.Text = res.SegundoNombre;
            txtPrimerApellido.Text = res.PrimerApellido;
            txtSegundoApellido.Text = res.SegundoApellido;
            txtTelefono.Text = res.Telefono;
            txtSexo.Text = res.Sexo;
            txtCiudad.Text = res.Ciudad;
            txtBarrio.Text = res.Barrio;
            txtCalle.Text = res.Calle;
            txtCarrera.Text = res.Carrera;
            txtCasa.Text = res.Casa;
        }
    }
}
