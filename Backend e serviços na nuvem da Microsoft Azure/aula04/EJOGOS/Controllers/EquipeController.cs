using EJOGOS.Models;
using Microsoft.AspNetCore.Http;
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

        public IActionResult Cadastrar(IFormCollection form)
        {
            //criar uma objeto equipe a partir do frontend. 
            // IFormCollection

            Equipe novaEquipe = new Equipe();

            novaEquipe.idEquipe = int.Parse(form["IdEquipe"]);
            novaEquipe.Nome = form["Nome"];
            novaEquipe.Imagem = form["Imagem"];

            //chamar a funcao CRIAR passando um objeto do tipo EQUIPE.
            equipeModel.Criar(novaEquipe);

            ViewBag.Equipes = equipeModel.LerEquipes();

            return LocalRedirect("~/Equipe");

        }



    }
}
