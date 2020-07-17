using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserRegistrationMvc.Models;

namespace UserRegistrationMvc.Controllers
{
    public class ProdutosController : Controller
    {
        public IActionResult Index()
        {
            List<Produto> list = new List<Produto>();
            list.Add(new Produto { TpoprdCodigo = 3, NomeProduto = "Adiantamento Salarial" });
            list.Add(new Produto { TpoprdCodigo = 62, NomeProduto = "Alimentação UP Brasil" });

            return View(list);
        }
    }
}
