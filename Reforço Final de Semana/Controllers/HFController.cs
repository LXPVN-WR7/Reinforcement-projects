using System;

namespace Reforço_Final_de_Semana.Controllers
{
    public class HFController : BaseController
    {





        public string Voar()
        {
            return "Homem de Ferro voando";
        }

        public string Atrirar()
        {
            return "Homem de Ferro atirando";
        }

        public ConsoleColor MudarCor()
        {
            return  ConsoleColor.Red;
        }
    }
}