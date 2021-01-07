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
        //@foreach (var NOMEVARIAVEL in Model){<HTML>}

        //Da mesma forma que podemos utilizar o HttpPostAttribute para aceitar apenas
        //requisições do tipo post, também temos o HttpGetAttribute para aceitar apenas requisições do tipo Get

        //ModelValidertor - [Required] 
        //ModelState.addModelerror faz a tratação de errors dentro de um IF  
        //Para funcionar no html voce precisa colocar @Html.ValidationMessage

        //DAO inforações do banco de dados

        //@html.ActionLink()

        //@model (é dinamico/Foritmente tipada) serve para indicar o tipo de referencia da Model 

        //Vimos que uma segunda forma de enviarmos valores para a camada de visualização é colocando-o como 
        //argumento do método View do Controller. Como podemos acessar a variável que é passada para a view dessa forma?
        //podemos utilizar a variável Model

        //[Route("url/{id}")] Controller
        //routes.MapMVCAttributeRoutes(); Router
        // @html.RouteLink("", "") view 

        //Podemos criar no projeto um novo arquivo especial do razor chamado _ViewStart.cshtml 
        //dentro da pasta Views da aplicação.O arquivo _ViewStart.cshtml
        public ActionResult Index()
        {

            return View();
        }
    }
}