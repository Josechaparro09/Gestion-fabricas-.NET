using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class UsuarioRepositorio : ConnectionManager
    {
        public UsuarioRepositorio(string connectionString) : base(connectionString)
        {
        }
        
        public List<Usuario> GetAll()
        {
            List<Usuario> usuarios = new List<Usuario>();
            var comando = _conexion.CreateCommand();
            comando.CommandText = "select * from Usuarios";
            Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                usuarios.Add(Mapper(lector));
            }
            Close();
            return usuarios;
        }
        public int Insert(Usuario usuario)
        {
            int rows;
            using (var Comando = _conexion.CreateCommand())
            {
                Comando.CommandText = "Insert Into usuarios (Nombre,NUsuario,Contrasenia,FRegistro)" +
                " values (@Nombre,@NUsuario,@Contrasenia,@FRegistro)";
                Comando.Parameters.Add("Nombre", SqlDbType.VarChar).Value = usuario.Nombre;
                Comando.Parameters.Add("NUsuario", SqlDbType.VarChar).Value = usuario.NUsuario;
                Comando.Parameters.Add("Contrasenia", SqlDbType.VarChar).Value = usuario.Contrasenia;
                Comando.Parameters.Add("FRegistro", SqlDbType.DateTime).Value = DateTime.Now;

                Open();
                rows = Comando.ExecuteNonQuery();
                Close();
            }
            return rows;
        }

        private Usuario Mapper(SqlDataReader dataReader)
        {

            if (!dataReader.HasRows) return null;
            Usuario usuario = new Usuario();
            usuario.Id = dataReader.GetInt32(0);
            usuario.Nombre = dataReader.GetString(1);
            usuario.NUsuario = dataReader.GetString(2);
            usuario.FRegistro = dataReader.GetDateTime(3);
            return usuario;

        }
        public void Actualizar(Usuario usuario , int id)
        {
            using (var Comando = _conexion.CreateCommand())
            {
                Comando.CommandText = $"Update usuarios set Nombre = @Nombre , NUsuario = @NUsuario , Contrasenia = @Contrasenia , FRegistro = @FRegistro WHERE Id= @id";
                Comando.Parameters.Add("Nombre", SqlDbType.VarChar).Value = usuario.Nombre;
                Comando.Parameters.Add("NUsuario", SqlDbType.VarChar).Value = usuario.NUsuario;
                Comando.Parameters.Add("Contrasenia", SqlDbType.VarChar).Value = usuario.Contrasenia;
                Comando.Parameters.Add("FRegistro", SqlDbType.DateTime).Value = usuario.FRegistro;
                Comando.Parameters.Add("id", SqlDbType.Int).Value = id;

                Open();
                Comando.ExecuteNonQuery();
                Close();
            }
        }
        public void Eliminar(int id)
        {
            using (var Comando = _conexion.CreateCommand())
            {
                Comando.CommandText = $"DELETE FROM usuarios WHERE Id = @id";
                Comando.Parameters.Add("id", SqlDbType.Int).Value = id;

                Open();
                Comando.ExecuteNonQuery();
                Close();
            }
        }
        
        public Usuario ObtenerPorId(int id)
        {

            var usuario = new Usuario();
         
            var comando = _conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM Usuarios WHERE id = @id ";
            comando.Parameters.Add("id", SqlDbType.Int).Value = id;
            Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                usuario = Mapper(lector);
            }
            Close();
            return usuario;
        }
        public bool Existe(string NUsuario)
        {
            var comando = _conexion.CreateCommand();
            comando.CommandText = "SELECT COUNT(*) FROM Usuarios WHERE NUsuario = @NUsuario ";
            comando.Parameters.Add("NUsuario", SqlDbType.VarChar).Value = NUsuario;
            Open();
            var contador = (int)comando.ExecuteScalar();
            Close();
            if (contador!=0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public bool ValidarUsuario(string usuario , string contrasenia)
        {
            var comando = _conexion.CreateCommand();
            comando.CommandText = "SELECT COUNT(*) FROM Usuarios WHERE NUsuario = @usuario AND Contrasenia = @contrasenia ";
            comando.Parameters.Add("usuario", SqlDbType.VarChar).Value = usuario;
            comando.Parameters.Add("Contrasenia", SqlDbType.VarChar).Value = contrasenia;
            Open();
            var contador = (int)comando.ExecuteScalar();
            Close();
            if (contador != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
 

    }
}
