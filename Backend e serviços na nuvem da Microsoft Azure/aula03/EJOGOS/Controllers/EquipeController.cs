using EJOGOS.Models;
using Microsoft.AspNetCore.Mvc;

namespace EJOGOS.Controllers
{
    public class EquipeController : Controller
    {

        //ActionResult representam os varios codigos HTTP,

        //Codigos HTTP - https://developer.mozilla.org/pt-BR/docs/Web/HTTP/Status


        Equipe equipeModel = new Equipe();

        public IActionResult Index()
        {
            //ViewBag = Reserva de espaco para armazenar informacoes para recuparar na VIEW.

            //ViewBag = tem a função de "carregar" as informaçoes do Controller para a 
             // VIEW.

            ViewBag.Equipes = equipeModel.LerEquipes();

            return View();
        }
    }
}
