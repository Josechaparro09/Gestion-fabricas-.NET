using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class UsuarioRepository 
    {
        UsuarioRepositorio usuarioRep;
        public UsuarioRepository(string conexion)
        {
            usuarioRep = new UsuarioRepositorio(conexion);
        }

        public void Actualizar(Usuario usuario , int id)
        {
            usuarioRep.Actualizar(usuario , id);
        }

        public void Eliminar(int id)
        {
            usuarioRep.Eliminar(id);
        }

        public int Insertar(Usuario usuario)
        {
            return usuarioRep.Insert(usuario);
            
        }

        public Usuario ObtenerPorId(int id)
        {
            return usuarioRep.ObtenerPorId(id);
        }

        public List<Usuario> ObtenerTodos()
        {
            return usuarioRep.GetAll();
        }
        public bool Existe(string usuario)
        {
            return usuarioRep.Existe(usuario);
        }
        public string ValidarUsuario(string usuario , string contrasenia)
        {
            return usuarioRep.ValidarUsuario(usuario,contrasenia);
        }
    }
}
