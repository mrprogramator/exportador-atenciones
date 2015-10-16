using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Reflection;
using System.Data.Entity.ModelConfiguration;

namespace ExportadorAtenciones.Data
{
    public class DBContext : DbContext
    {
        public DBContext(String connectionString)
            : base(connectionString)
        {
        }

        public DbSet<Entities.Parametro> Parametros { get; set; }

        public DbSet<Entities.Usuario> Usuarios { get; set; }

        public DbSet<Entities.Punto> Puntos { get; set; }

        public DbSet<Entities.Mesa> Mesas { get; set; }

        public DbSet<Entities.Atencion> Atenciones { get; set; }

        public DbSet<Entities.DetalleAtencion> DetalleAtenciones { get; set; }
    }
}