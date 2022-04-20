using ExemploApi1.Model;
using ExemploApi1.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExemploApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimaisController : ControllerBase
    {
        public AnimaisController()
        {
        }

        [HttpGet("/gatos", Name = "Gatos")]
        public List<Gatos> Gatos()
        {
            BuscaAnimais xpto = new BuscaAnimais();
            return xpto.buscaGatos().ToList();
        }

        [HttpGet("/cachorros", Name = "Cachorros")]
        public List<Cachorro> Cachorros()
        {
            BuscaAnimais xpto1 = new BuscaAnimais();
            return xpto1.buscaCachorro().ToList();
        }
        [HttpGet("/todos", Name = "Todos")]

        public Todos Todos()
        {
            BuscaAnimais xpto2 = new BuscaAnimais();
            return xpto2.buscaTodosAnimais();
        }
        [HttpPost("/gatos", Name = "Gatos")]
        public Gatos post (Gatos gatos)
        {
            BuscaAnimais adicionag = new BuscaAnimais();
            gatos.Idade = gatos.Idade + 10;
            adicionag.adicionaGato(gatos);
            return gatos;
        }
        [HttpGet("/SQL", Name = "Insere SQL")]

        public List<UniãoTodostxt> UneSql()
        {
            BuscaAnimais xpto3 = new BuscaAnimais();
            return xpto3.animaisParaSql();
        }


    }

}
