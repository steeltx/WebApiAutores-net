using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIAutores.Servicios
{
    public interface IServicio
    {

        void RealizarTarea();

        public class ServicioA : IServicio
        {
            private readonly ILogger<ServicioA> logger;
            public ServicioA(ILogger<ServicioA> logger)
            {
                this.logger = logger;
            }
            public void RealizarTarea()
            {

            }
        }

        public class ServicioB : IServicio
        {
            public void RealizarTarea()
            {

            }
        }
    }
}
