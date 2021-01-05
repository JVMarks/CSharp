using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace INICIAL_MVC.Controllers
{
    //controllers são classes da aplicação
    public class HomeController : Controller
    {
        //DAOS SÃO CLASSES ESPECIALISTAS PARA CRIAÇÃO DO BANCO DE DADOS
        // GET: Home
        //Metodo publicos são chamados de Actions

        //Qual variável herdada da classe Controller podemos utilizar 
        //para enviar informações para a camada de visualização?
        //ViewBag

        //Qual a instrução utilizada para 
        //se fazer um "loop" dentro do .cshtml?
        //@foreach


        //Da mesma forma que podemos utilizar o HttpPostAttribute para aceitar apenas
        //requisições do tipo post, também temos o HttpGetAttribute para aceitar apenas requisições do tipo Get

        //ModelValidertor - [Required] 
        //ModelState.addModelerror faz a tratação de errors dentro de um IF  
        //Para funcionar no html voce precisa colocar @Html.ValidationMessage
        public ActionResult Index()
        {

            return View();
        }
    }
}