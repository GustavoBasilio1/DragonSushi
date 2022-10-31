using DragonSushi.DAO;
using DragonSushi.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace DragonSushi.Controllers
{
    public class EstoqueController : Controller
    {
        public  ActionResult MostrarEstoque()
        {
            var produto = "Atum";
            ProdutoDAO produtoDAO = new ProdutoDAO();

            //ProdutoViewModel ConsultarEstoque = produtoDAO.ConsultarEstoque(produto).Result;



            //return View(ConsultarEstoque);
            return View();
        }
        
    } 
}