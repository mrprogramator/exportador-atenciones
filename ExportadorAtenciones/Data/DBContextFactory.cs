using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportadorAtenciones.Data
{
    public class DBContextFactory
    {
        public DBContext SQLServerDBContext
        {
            get
            {
                return new DBContext("name=SQLDBConnection");
            }
        }

        public DBContext PostgreSQLDBContext
        {
            get
            {
                return new DBContext("name=PSQLDBConnection");
            }
        }
    }
}
