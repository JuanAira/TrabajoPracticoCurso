using Aplicacion.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly ICategorias categorias;

        public CategoriasController(ICategorias categori)
        {
            this.categorias = categori;
        }


        //Grilla
        public ActionResult Grilla()
        {
            IList<CategoriasModel> listaCategoriasModelos = new List<CategoriasModel>();

            var lista = categorias.ListarCategorias();

            foreach (var item in lista)
            {
                listaCategoriasModelos.Add(new CategoriasModel { Descripcion = item.Descripcion, Id = item.Id, Nombre = item.Nombre });
            }

            if (listaCategoriasModelos.Count == 0)
            {
                return View();
            }
            else
            {
                return View(listaCategoriasModelos);
            }
        }


        //Crear
        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Crear(CategoriasModel cat)
        {
            var categoriaGuardar = new Categoria { Descripcion = cat.Descripcion, Nombre = cat.Nombre };

            if (!ModelState.IsValid)
            {
                return View(cat);
            }

            categorias.CrearCategoria(categoriaGuardar);

            return RedirectToAction("Grilla");

        }


        //Editar
        public ActionResult Editar(int id)
        {
            var categoria = categorias.ListarCategorias().Where(x => x.Id == id).First();

            return View(new CategoriasModel { Id = categoria.Id, Nombre = categoria.Nombre, Activa = categoria.Activa, Descripcion = categoria.Descripcion });
        }

        [HttpPost]
        public ActionResult Editar(CategoriasModel cat)
        {
            if (!ModelState.IsValid)
            {
                return View(cat);
            }

            var categoria = new Categoria { Id = cat.Id, Activa = cat.Activa, Descripcion = cat.Descripcion, Nombre = cat.Nombre };

            categorias.EditarCategorias(categoria);

            return RedirectToAction("Grilla");
        }


        //Eliminar
        public ActionResult Eliminar(int id)
        {
            categorias.EliminarCategorias(id);
            return RedirectToAction("Grilla");
        }
    }
}