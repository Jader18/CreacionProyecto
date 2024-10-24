﻿using DAL;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Proveedores
    {
        public static Proveedores Insert(Proveedores Entidad)
        {
            return DAL_Proveedores.Insert(Entidad);
        }
        public static bool Update(Proveedores Entidad)
        {
            return DAL_Proveedores.Update(Entidad);
        }
        public static bool Anular(Proveedores Entidad)
        {
            return DAL_Proveedores.Anular(Entidad);
        }
        public static bool Existe(Proveedores Entidad)
        {
            return DAL_Proveedores.Existe(Entidad);
        }
        public static Proveedores Registro(Proveedores Entidad)
        {
            return DAL_Proveedores.Registro(Entidad);
        }
        public static List<Proveedores> Lista(bool Activo = true)
        {
            return DAL_Proveedores.Lista(Activo);
        }
        public static bool ValidarNumero(string Numero, int IdRegistro)
        {
            return DAL_Proveedores.ValidarNumero(Numero, IdRegistro);
        }
        public static bool ValidarCorreo(string Email, int IdRegistro)
        {
            return DAL_Proveedores.ValidarCorreo(Email, IdRegistro);
        }




    }
}
