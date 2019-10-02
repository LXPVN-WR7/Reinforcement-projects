using System;

namespace Vingadores.Models
{
    public class CapitaoAmericaModel : BaseModel
    {
        public bool Escudo {get; set;}

        public void LancarEscudo(){
            Console.WriteLine("Toma essa seu riquinho de bosta!");
        }
        public void Defender(){
            Console.WriteLine("Opaaaa o Pai aqui é foda lkkk"); 
        }
    }
}