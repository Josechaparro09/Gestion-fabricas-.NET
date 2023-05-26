using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ProveedorRepository
    {
        ProveedorRepositorio provRep;
        public ProveedorRepository(string conexion)
        {
            provRep = new ProveedorRepositorio(conexion);
        }
        public void Actualizar(Proveedores proveedor, int id)
        {
            provRep.Actualizar(proveedor, id);
        }

        public void Eliminar(int id)
        {
            provRep.Eliminar(id);
        }

        public int Insertar(Proveedores proveedor)
        {
            return provRep.Insert(proveedor);

        }

        public Proveedores ObtenerPorId(int id)
        {
            return provRep.ObtenerPorId(id);
        }

        public List<Proveedores> ObtenerTodos()
        {
            return provRep.GetAll();
        }
        public bool Existe(string proveedor)
        {
            return provRep.Existe(proveedor);
        }
    }
}
