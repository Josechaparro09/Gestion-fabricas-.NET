using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MateriaPrimaUtilizada
    {
        public int Id { get; set; }
        public MateriaPrima MPrimaUtilizada { get; set; }
        public double CantUtilizada { get; set; }
        public Produccion Produccion { get; set; }
        public MateriaPrimaUtilizada()
        {
            
        }

        public MateriaPrimaUtilizada(int id, MateriaPrima mPrimaUtilizada, double cantUtilizada, Produccion produccion)
        {
            Id = id;
            MPrimaUtilizada = mPrimaUtilizada;
            CantUtilizada = cantUtilizada;
            Produccion = produccion;
        }
    }
}
