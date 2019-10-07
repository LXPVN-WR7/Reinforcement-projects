using System;
using Reforço_Final_de_Semana.Models;

namespace Reforço_Final_de_Semana.Controllers
{
    public class CapController : BaseController
    {

        CapModel capModel = new CapModel();


        public string LancarEscudo()
        {
            return "Capitão América lançou o escudo";
        }

        public string DefenderComEscudo()
        {
            return "Capitão América defendeu-se";
        }

        public ConsoleColor MudaCor()
        {
            return ConsoleColor.Blue;
        }
    }
}