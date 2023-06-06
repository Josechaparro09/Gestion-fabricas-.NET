using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class CompraMPrimaRepository
    {
        CompraMPrimaRepositorio cmpRep;
        public CompraMPrimaRepository(string conexion)
        {
            cmpRep = new CompraMPrimaRepositorio(conexion);
        }
        public int Actualizar(CompraMprima cmp, int id)
        {
            return cmpRep.Actualizar(cmp, id);        
        }

        public void Eliminar(int id)
        {
            cmpRep.Eliminar(id);
        }

        public bool Existe(string nombre)
        {
            return cmpRep.Existe(nombre);
        }

        public List<CompraMprima> GetAll()
        {
            return cmpRep.GetAll();
        }

        public int Insert(CompraMprima cmp)
        {
            return cmpRep.Insert(cmp);
        }



        public CompraMprima ObtenerPorId(int id)
        {
            return cmpRep.ObtenerPorId(id);
        }
        public CompraMprima ObtenerPorIndex(int index)
        {
            return cmpRep.ObtenerPorIndex(index);
        }
        public int ObtenerIndexPorId(int id)
        {
            return cmpRep.ObtenerIndexPorId(id);
        }
    }
}
