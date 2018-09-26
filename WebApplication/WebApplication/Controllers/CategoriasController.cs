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

        public ActionResult Index()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

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

            return RedirectToAction("Index");

        }

        public ActionResult Actualizar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Actualizar( CategoriasModel cat)
        {
            return View(cat);


        }


        public ActionResult EliminarCategorias()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EliminarCategorias(CategoriasModel cat)
        {
            categorias.EliminarCategorias(cat.Id);

            return View();
        }

        //public ActionResult GrillaCategorias()
        //{
        //    var listaCategorias = categorias.ListarCategorias();
        //    var resultado = (from c in listaCategorias
        //                     select new GrillaModel
        //                     {
        //                         Id = c.Id,
        //                         Descripcion = c.Descripcion,
        //                         Nombre = c.Nombre
        //                     }).ToList();

        //    return View(resultado);
        //}

    }
}