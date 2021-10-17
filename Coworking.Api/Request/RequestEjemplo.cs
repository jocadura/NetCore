using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coworking.Api.Request
{
    public class RequestEjemplo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Edad { get; set; }
        public RequestEjemplo2 DatosContacto { get; set; }

    }
}
