using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportadorAtenciones
{
    public class Response
    {
        Boolean result;
        String value;

        public Response(Boolean result, String value = null)
        {
            this.result = result;
            this.value = value;
        }
    }
}
