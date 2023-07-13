using Google.Type;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using poo.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace poo.dao
{
     class EmpleadoDao
    {
        public MySqlConnection Conexion()
        {
            string servidor = "localhost";
            string usuario = "root";
            string password = "";
            string db = "empleados";

            string Conexion = "Database=" + db +
                               "; Data Source=" + servidor +
                               "; User Id=" + usuario +
                               "; Password=" + password;

            MySqlConnection conexionDb = new MySqlConnection(Conexion);
            conexionDb.Open();

            return conexionDb;
           
          
        }

        public List<Empleado> ObtenerListaDeEmpleados()
        {
            List<Empleado> lista = new List<Empleado>();

            string consulta = "SELECT * FROM datos";
            MySqlCommand comando = new MySqlCommand(consulta, Conexion());
            MySqlDataReader lectura = comando.ExecuteReader();

            while (lectura.Read())
            {
                Empleado empleado = new Empleado();
                empleado.Id = lectura.GetString("id");
                empleado.Name = lectura.GetString(1);
                empleado.LastName = lectura.GetString(2);
                empleado.Dni = lectura.GetString(3);
                lista.Add(empleado);

            }
            comando.Connection.Close();

            return lista;
        }
        public void Guardar(Empleado empleado)
        {

            if (empleado.Id==null)
            {
                insert(empleado);
            }
            else
            {
                update(empleado);

            }
        }
        private void insert(Empleado empleado)
        {

            string consulta = "INSERT INTO `datos`" +
                "(`id`, `name`, `lastName`, `dni`)" +
                " VALUES ('NULL" +
                "','" + empleado.Name +
                "','" + empleado.LastName +
                "','" + empleado.Dni +
                "')";
            MySqlCommand comando = new MySqlCommand(consulta, Conexion());
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }
        private void update(Empleado empleado)
        {

            string consulta = "UPDATE `datos` SET `name` = @name, `lastName` = @lastName, `dni` = @dni WHERE `datos`.`id` = @id";
            MySqlCommand comando = new MySqlCommand(consulta, Conexion());
            comando.Parameters.AddWithValue("@name", empleado.Name);
            comando.Parameters.AddWithValue("@lastName", empleado.LastName);
            comando.Parameters.AddWithValue("@dni", empleado.Dni);
            comando.Parameters.AddWithValue("@id", empleado.Id);

            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }

        public void Eliminar(Empleado empleado)
        {
            try
            {
                string consulta = "DELETE FROM `datos` WHERE id=" + empleado.Id + ";";
                MySqlCommand comando = new MySqlCommand(consulta, Conexion());
                comando.ExecuteNonQuery();
                comando.Connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
          
        }
    }

}
