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
        public static List<Categoria> ListaCategorias = new List<Categoria>();

        public List<Categoria> ListarCategorias()
        {
            //return ListaCategorias.Where(x => x.Activa == true).ToList();
            ListaCategorias.Add(new Categoria { Nombre = "aaaaaaaaaaaaaa", Activa = true, Descripcion = "1111111111111", Id = 1 });
            ListaCategorias.Add(new Categoria { Nombre = "bbbbbbbbbbbbbb", Activa = true, Descripcion = "2222222222222", Id = 2 });
            return ListaCategorias.Where(x=> x.Activa==true).ToList();
        }

        public void EditarCategorias(Categoria cat)
        {
            var categoriaEncontrada = ListaCategorias.Where(x => x.Id == cat.Id).First();
            
            if(categoriaEncontrada!= null)
                categoriaEncontrada.Activa = cat.Activa; categoriaEncontrada.Descripcion = cat.Descripcion; categoriaEncontrada.Nombre = cat.Nombre;       
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
