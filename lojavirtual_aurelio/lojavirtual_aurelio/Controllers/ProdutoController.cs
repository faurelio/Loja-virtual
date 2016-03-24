using lojavirtual_aurelio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace lojavirtual_aurelio.Controllers
{
    public class ProdutoController : Controller
    {
     public ActionResult Lista()
        {
            var lista = new List<ProdutoVienModel>
            {
                new ProdutoVienModel
                {
                    Nome = "Chuteira Nike",
                    Categoria = "Calcados"
                    },
                    new ProdutoVienModel
                    {
                        Nome = "Camisa Adidas",
                        Categoria = "Roupas"                             
                    }
            };
            return View(lista);
        }   

    }
}