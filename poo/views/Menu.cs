using poo.dao;
using poo.models;

namespace poo
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            GestionarClientes gestionarClientes = new GestionarClientes();
            gestionarClientes.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}