using System;
using Vingadores.Models;

namespace Vingadores.Controllers
{
    public class ControllerAll
    {
        public void Jogador(){
            Console.WriteLine(@"
            -----------------------------------------
            | Seja Bem Vindo ao Game dos Vingadores |
            -----------------------------------------

            (1) - Homem de Ferro 
            (2) - Capitão América

            Selecione seu Jogador 
            ");

            int resp = int.Parse(Console.ReadLine());

            switch(resp){
                case 1:
                HomemDeFerroModel avatar = new HomemDeFerroModel();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Agora você é o Homem de Ferro!");
                Console.WriteLine(@"

                Você está de armadura ?
              
                (1) - Sim 
                (2) - Não");

                int resp2 = int.Parse(Console.ReadLine());

                switch(resp2){
                    case 1:
                    avatar.Vida = 100;
                    break;

                    case 2:
                    avatar.Vida = 30;
                    break;
                }

                break;

                case 2:
                CapitaoAmericaModel avatar2 = new CapitaoAmericaModel();
                Console.WriteLine("Agora você é o Capitão América!");
                Console.WriteLine(@"
                Você está com o seu escudo ?
                
                (1) - Sim
                (2) - Não");
                break;
            }

        }
    }
}