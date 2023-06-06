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
        public int IdReceta { get; set; }

        public MateriaPrimaUtilizada()
        {
            
        }

        public MateriaPrimaUtilizada(int id, MateriaPrima mPrimaUtilizada, double cantUtilizada, int idReceta)
        {
            Id = id;
            MPrimaUtilizada = mPrimaUtilizada;
            CantUtilizada = cantUtilizada;
            IdReceta = idReceta;
        }
    }
}
