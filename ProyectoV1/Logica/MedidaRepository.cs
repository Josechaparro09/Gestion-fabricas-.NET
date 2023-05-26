using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class MedidaRepository
    {
        MedidasRepositorio medidasRepositorio;
        public MedidaRepository(string conexion)
        {
            medidasRepositorio = new MedidasRepositorio(conexion);
        }
        public void Actualizar(Medida medida, int id)
        {
            medidasRepositorio.Actualizar(medida, id);
        }

        public void Eliminar(int id)
        {
            medidasRepositorio.Eliminar(id);
        }

        public int Insertar(Medida medida)
        {
            return medidasRepositorio.Insert(medida);

        }

        public Medida ObtenerPorId(int id)
        {
            return medidasRepositorio.ObtenerPorId(id);
        }

        public List<Medida> ObtenerTodos()
        {
            return medidasRepositorio.GetAll();
        }
        public bool Existe(string usuario)
        {
            return medidasRepositorio.Existe(usuario);
        }



    }
}
