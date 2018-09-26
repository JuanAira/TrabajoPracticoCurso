using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Contratos
{
    public interface INotas
    {
        void CrearNota();
        void ListarNotas();
        void ActualizarNota();
        void EliminarNota();
    }
}
