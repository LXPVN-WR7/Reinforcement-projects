using System;

namespace Vingadores.Models
{
    public class HomemDeFerroModel : BaseModel 
    {
        public bool Armadura {get; set;}

        public void Voar()
        {
            Console.WriteLine("Vamos voar!");
        }       
        public void Atirar()
        {
            Console.WriteLine("Boom! Toma essa seu bosta");
        }
    }
}