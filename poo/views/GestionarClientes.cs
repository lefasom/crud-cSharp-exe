using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using poo.dao;
using poo.models;

namespace poo
{
    public partial class GestionarClientes : Form
    {
        public GestionarClientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GestionarClientes_Load(object sender, EventArgs e)
        {
            actualizarLista();
        }
        private void actualizarLista()
        {
            EmpleadoDao baseDeDatos = new EmpleadoDao();
            List<Empleado> listaDb = baseDeDatos.ObtenerListaDeEmpleados();

            listClientes.Items.Clear();

            for (int i = 0; i < listaDb.Count; i++)
            {

                Empleado empleado = listaDb[i];
                listClientes.Items.Add(empleado);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.Name = textBoxNombre.Text;
            empleado.LastName = inpApellido.Text;
            empleado.Dni = inpTelefono.Text;

            if (lblID.Text != "")
            {
                empleado.Id = lblID.Text;
            }



            EmpleadoDao baseDeDatos = new EmpleadoDao();
            baseDeDatos.Guardar(empleado);
            actualizarLista();

            // listClientes.Items.Add(empleado);

        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            //  int indice = listClientes.SelectedIndex;
            //  listClientes.Items.RemoveAt(indice);

            Empleado empleado = (Empleado)listClientes.SelectedItem;
            EmpleadoDao baseDeDatos = new EmpleadoDao();
            baseDeDatos.Eliminar(empleado);
            actualizarLista();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Empleado empleado = (Empleado)listClientes.SelectedItem;
            textBoxNombre.Text = empleado.Name;
            inpTelefono.Text = empleado.Dni;
            inpApellido.Text = empleado.LastName;
            lblID.Text = empleado.Id;
        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            textBoxNombre.Text = "";
            inpTelefono.Text = "";
            inpApellido.Text = "";
            lblID.Text = "";
        }
    }
}
