using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class Program
    {
        static void Main(string[] args)
        {
            var empleado = new Empleado("10656642" , "Jose", "Alberto" , "Chaparro" , "Castro" , "3000000000" , new DateTime());
            var planta = new Planta("123" , "Esencias" , empleado);
            var medida = new Medida("000", "ml", "Mililitro");
            var medida1 = new Medida("001", "gr", "Gramo");
            var materiaPrima = new MateriaPrima("0001" , "Monoglutamato de sodio" , 50, 58.2 ,medida1, new DateTime(),new DateTime());
            var categoria = new Categoria("0001" , "Esencia");
            var producto = new Producto("0001" , "Esencia de coco", categoria, medida, 500, 900, 1600);
            var produccion = new Produccion("0001" , "Esencia de coco 500ml" , 50 , medida , planta, producto, materiaPrima,new DateTime());

            Console.WriteLine(produccion.ToString());
            Console.ReadKey();
        }
    }
}
