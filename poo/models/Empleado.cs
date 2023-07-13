using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo.models
{
    class Empleado
    {
        /*   private string nombre;
           private string apellido;
           private string telefono;
           private string tarjetaDeCredito;
        */
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Dni { get; set; }

        public string NombreCompleto
        {
            get { return Name + " " + LastName; }
        }
        public override string ToString()
        {
            return "Nombre : " + Name + " Apellido : " + LastName;
        }

    }
}
