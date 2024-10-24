using DAL;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Productos
    {
        public static Productos Insert(Productos Entidad)
        {
            return DAL_Productos.Insert(Entidad);

        }
        public static bool Update(Productos Entidad)
        {
            return DAL_Productos.Update(Entidad);

        }
        public static bool Anular(Productos Entidad)
        {
            return DAL_Productos.Anular(Entidad);

        }
        public static bool Existe(Productos Entidad)
        {
            return DAL_Productos.Existe(Entidad);

        }
        public static Productos Registro(Productos Entidad)
        {
            return DAL_Productos.Registro(Entidad);

        }
        public static List<Productos> Lista(bool Activo = true)
        {
            return DAL_Productos.Lista(Activo);

        }


        public static bool ValidarCorreo(string productName, int IdRegistro)
        {
            return DAL_Productos.ValidarCorreo(productName, IdRegistro);

        }

    }
}
