using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fabrica
    {
        public string Nombre { get; set; }
        public string Nit { get; set; }
        public string DatosExtra { get; set; }
        public List<Planta> Plantas { get; set; }
        public List<Produccion> Producciones { get; set; }
        public List<Empleado> Empleados { get; set; }
        public List<Venta> Ventas { get; set; }
        public List<Categoria> Categorias { get; set; }
        public List<Producto> Productos { get; set; }

        public Fabrica()
        {
        }

        public Fabrica(string nombre, string nit, string datosExtra, List<Planta> plantas, List<Produccion> producciones, List<Empleado> empleados, List<Venta> ventas, List<Categoria> categorias, List<Producto> productos)
        {
            Nombre = nombre;
            Nit = nit;
            DatosExtra = datosExtra;
            Plantas = plantas;
            Producciones = producciones;
            Empleados = empleados;
            Ventas = ventas;
            Categorias = categorias;
            Productos = productos;
        }
    }
}
