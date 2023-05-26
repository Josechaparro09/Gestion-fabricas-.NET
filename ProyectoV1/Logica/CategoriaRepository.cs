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
        public void Actualizar(Categoria categoria, int id)
        {
            categoriaRep.Actualizar(categoria, id);
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
    }
}
