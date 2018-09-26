using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Contratos
{
    public interface ICategorias
    {
        //(creación, listado, actualización y eliminación)

        List<Categoria> ListarCategorias();
        void CrearCategoria(Categoria cat);
        void ActualizarCategorias(Categoria cat);
        void EliminarCategorias(int id);

    }
}
