using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class CategoriaRepository
    {
        CategoriaRepositorio categoriaRep;
        public CategoriaRepository(string conexion)
        {
            categoriaRep = new CategoriaRepositorio(conexion);
        }
        public int Actualizar(Categoria categoria, int id)
        {
            return categoriaRep.Actualizar(categoria, id);
        }

        public void Eliminar(int id)
        {
            categoriaRep.Eliminar(id);
        }

        public int Insertar(Categoria categoria)
        {
            return categoriaRep.Insert(categoria);

        }

        public Categoria ObtenerPorId(int id)
        {
            return categoriaRep.ObtenerPorId(id);
        }

        public List<Categoria> ObtenerTodos()
        {
            return categoriaRep.GetAll();
        }
        public bool Existe(string categoria)
        {
            return categoriaRep.Existe(categoria);
        }
        public Categoria ObtenerPorIndex(int index)
        {
            return categoriaRep.ObtenerPorIndex(index);
        }
        public int ObtenerIndexPorId(int id)
        {
            return categoriaRep.ObtenerIndexPorId(id);
        }
    }
}
