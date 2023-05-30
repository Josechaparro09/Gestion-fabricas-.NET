using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class EmpleadoRepository : ICRUD<Empleado>
    {
        EmpleadoRepositorio empRep;
        public EmpleadoRepository(string conexion)
        {
            empRep = new EmpleadoRepositorio(conexion);
        }
        public int Actualizar(Empleado empleado, int id)
        {
            return empRep.Actualizar(empleado, id);
        }

        public void Eliminar(int id)
        {
            empRep.Eliminar(id);
        }

        public bool Existe(string empleado)
        {
            return empRep.Existe(empleado);
        }

        public List<Empleado> GetAll()
        {
            return empRep.GetAll();
        }

        public int Insert(Empleado empleado)
        {
            return empRep.Insert(empleado);
        }

        public Empleado Mapper(SqlDataReader dataReader)
        {
            return empRep.Mapper(dataReader);
        }

        public Empleado ObtenerPorId(int id)
        {
            return empRep.ObtenerPorId(id);
        }
        public Empleado ObtenerPorIndex(int index)
        {
            return empRep.ObtenerPorIndex(index);
        }
        public int ObtenerIndexPorId(int id)
        {
            return empRep.ObtenerIndexPorId(id);
        }
    }
}
