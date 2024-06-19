using Microsoft.AspNetCore.Mvc;

namespace PrimeiroProjeto.Controllers
{
    [ApiController]
    [Route("api/Home")]
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("HandShake")]
        public string HandShake()
        {
            return "OK";
        }

        [HttpGet]
        [Route("CalculateMedia")]
        public float CalculateMedia(float n1, float n2, float n3)
        {
            float resultado;

            resultado = (n1 + n2 + n3) / 3;

            return resultado;
        }

        [HttpGet]
        [Route("GetValue")]
        public int GetValue(int initial, int final)
        {
            return GenerateValue(initial, final);
        }

        //Método que não será exposto na API
        [NonAction]
        private int GenerateValue(int initial, int final)
        { 
            Random rnd = new Random();
            return rnd.Next(initial, final + 1);
        }
    }
}
