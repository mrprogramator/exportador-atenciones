using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportadorAtenciones
{
    public class Exportador : IDisposable
    {
        Repositories.AtencionRepository atencionRepository;
        Data.DBContext sqlServerDBContext;
        Data.DBContext postgreSQLDBContext;

        Boolean disposed = false;

        public Exportador()
        {
            sqlServerDBContext = new Data
                .DBContextFactory()
                .SQLServerDBContext;

            postgreSQLDBContext = new Data
                .DBContextFactory()
                .PostgreSQLDBContext;
        }

        public Response ExportarAtenciones()
        {
            try
            {
                var atencionRepositorySQLServer = new Repositories
                    .AtencionRepository(sqlServerDBContext);

                var atencionRepositoryPostgreSQL = new Repositories
                    .AtencionRepository(postgreSQLDBContext);

                var atenciones = atencionRepositorySQLServer
                    .Atenciones
                    .ToArray();

                foreach (var atencion in atenciones)
                {
                    atencionRepositoryPostgreSQL.Insert(atencion);
                    atencionRepositorySQLServer.Delete(atencion);
                }

                return new Response(true);
            }
            catch (Exception e)
            {
                return new Response(false, e.Message);
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            } 

            if (disposing)
            {
                sqlServerDBContext.Dispose();
                postgreSQLDBContext.Dispose();
            }

            disposed = true;
        }
    }
}
