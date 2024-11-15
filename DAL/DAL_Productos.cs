using EL;
using System.IO.Pipes;

namespace DAL
{
    public static class DAL_Productos
    {
        public static Productos Insert(Productos Entidad)
        {
            using (BDInventario bd = new BDInventario())
            {
                Entidad.Activo = true;
                Entidad.FechaRegistro = DateTime.Now;
                bd.Productos.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }
        public static bool Update(Productos Entidad)
        {
            using (BDInventario bd = new BDInventario())
            {
                var Registro = bd.Productos.Find(Entidad.IdProducto);

                Registro.Descripcion = Entidad.Descripcion;
                Registro.Cantidad = Entidad.Cantidad;
                Registro.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Registro.FechaActualizacion = Entidad.FechaActualizacion;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool Anular(Productos Entidad)
        {
            using (BDInventario bd = new BDInventario())
            {
                var Registro = bd.Productos.Find(Entidad.IdProducto);
                Registro.Activo = false;
                Registro.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Registro.FechaActualizacion = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool Existe(Productos Entidad)
        {
            using (BDInventario bd = new BDInventario())
            {
                return bd.Productos.Where(a => a.IdProducto == Entidad.IdProducto).Count() > 0;
            }
        }
        public static Productos Registro(Productos Entidad)
        {
            using (BDInventario bd = new BDInventario())
            {
                return bd.Productos.Where(a => a.IdProducto == Entidad.IdProducto).SingleOrDefault();
            }
        }
        public static List<Productos> Lista(bool Activo = true)
        {
            using (BDInventario bd = new BDInventario())
            {
                return bd.Productos.Where(a => a.Activo == Activo).ToList();
            }
        }

        public static bool ValidarDescripcionProduct(string Descripcion, int IdRegistro)
        {
            using (BDInventario bd = new())
            {
                return bd.Productos.Where(a => a.Descripcion == Descripcion && a.IdProducto != IdRegistro && a.Activo == true).Count() > 0;
            }
        }

        public static bool ValidarCantidadProduct(string Cantidad, int IdRegistro)
        {
            using (BDInventario bd = new())
            {
                return bd.Productos.Where(a => a.Cantidad == Cantidad && a.IdProducto != IdRegistro && a.Activo == true).Count() > 0;
            }
        }
    }
}
