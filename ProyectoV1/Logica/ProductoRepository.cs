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
    public class ProductoRepository : ICRUD<Producto>
    {
        ProductoRepositorio prodRep;
        public ProductoRepository(string conexion)
        {
            prodRep = new ProductoRepositorio(conexion);
        }
        public int Actualizar(Producto producto, int id)
        {
            return prodRep.Actualizar(producto, id);
        }

        public void Eliminar(int id)
        {
            prodRep.Eliminar(id);
        }

        public bool Existe(string nombre)
        {
            return prodRep.Existe(nombre);
        }

        public List<Producto> GetAll()
        {
            return prodRep.GetAll();
        }

        public int Insert(Producto producto)
        {
            return prodRep.Insert(producto);
        }

        public Producto Mapper(SqlDataReader dataReader)
        {
            return prodRep.Mapper(dataReader);
        }

        public Producto ObtenerPorId(int id)
        {
            return prodRep.ObtenerPorId(id);
        }
        public Producto ObtenerPorIndex(int index)
        {
            return prodRep.ObtenerPorIndex(index);
        }
        public int ObtenerIndexPorId(int id)
        {
            return prodRep.ObtenerIndexPorId(id);
        }
    }
}
