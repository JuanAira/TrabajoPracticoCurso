using Aplicacion.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Servicios
{
    public class Categorias : ICategorias
    {
        private List<Categoria> ListaCategorias { get; set; }

        public Categorias()
        {
            this.ListaCategorias = new List<Categoria>();
        }

        public List<Categoria> ListarCategorias()
        {
            return ListaCategorias.Where(x => x.Activa == true).ToList();
        }

        public void ActualizarCategorias(Categoria cat)
        {
            var categoriaEncontrada = ListaCategorias.Where(x => x.Id == cat.Id).First();

            categoriaEncontrada = cat;
        }

        public void CrearCategoria(Categoria cat)
        {
            cat.Id = ListaCategorias.Count + 1;
            ListaCategorias.Add(cat);
        }

        public void EliminarCategorias(int id)
        {
            var categoriaEncontrada = ListaCategorias.Where(x => x.Id == id).First();

            categoriaEncontrada.Activa = false;
        }
    }
}
