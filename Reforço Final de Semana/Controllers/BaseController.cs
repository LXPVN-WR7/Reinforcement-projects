using Reforço_Final_de_Semana.Models;

namespace Reforço_Final_de_Semana.Controllers
{
    public class BaseController
    {

        BaseModel baseModel = new BaseModel();

        public string Mostrar()
        {
            return $"Info do Personagem: \n Vida: {baseModel.Vida"};
        }

        public string Pular()
        {
            return "Personagem pulando";
        }
    }
}