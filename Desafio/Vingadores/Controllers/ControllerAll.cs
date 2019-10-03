using System;
using Vingadores.Models;

namespace Vingadores.Controllers
{
    public class ControllerAll
    {
        public void Jogador()
        {
            // Iniciando o Game 
            Console.WriteLine(@"
            -----------------------------------------
            | Seja Bem Vindo ao Game dos Vingadores |
            -----------------------------------------

            (1) - Homem de Ferro 
            (2) - Capitão América

            Selecione seu Jogador 
            ");
            // Armazenando a opção de jogador do usuário
            int resp = int.Parse(Console.ReadLine());
            // Avaliando a resposta do usuário
            switch (resp)
            {
                case 1:
                    // Criando o objeto Homem de Ferro
                    HomemDeFerroModel avatar = new HomemDeFerroModel();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Agora você é o Homem de Ferro!");
                    Console.WriteLine(@"

                Você está de armadura ?
              
                (1) - Sim 
                (2) - Não");

                    int resp2 = int.Parse(Console.ReadLine());

                    switch (resp2)
                    {
                        case 1:
                            avatar.Vida = 100;
                            avatar.Armadura = true;
                            break;

                        case 2:
                            avatar.Vida = 30;
                            avatar.Armadura = false;
                            break;

                        default:
                            Console.WriteLine("Informe uma opção válida:");
                            break;

                    }

                    CapitaoAmericaModel inimigo = new CapitaoAmericaModel();
                    inimigo.Vida = 100;
                    inimigo.ColorText = "Blue";
                    inimigo.Equipe = "Inimiga";
                    inimigo.Escudo = true;

                    break;

                case 2:
                    CapitaoAmericaModel avatar2 = new CapitaoAmericaModel();
                    Console.WriteLine("Agora você é o Capitão América!");
                    Console.WriteLine(@"
                Você está com o seu escudo ?
                
                (1) - Sim
                (2) - Não");

                    int resp3 = int.Parse(Console.ReadLine());
                    switch (resp3)
                    {
                        case 1:
                            avatar2.Vida = 100;
                            break;

                        case 2:
                            avatar2.Vida = 60;
                            break;

                        default:
                            Console.WriteLine("Informe uma opção válida:");
                            break;
                    }

                    HomemDeFerroModel inimigo2 = new HomemDeFerroModel();
                    inimigo2.Vida = 100;
                    inimigo2.ColorText = "Red";
                    inimigo2.Equipe = "Inimiga";
                    inimigo2.Armadura = true;

                    break;
            }

        }

        public void AcaoCapitaoAmerica()
        {

            HomemDeFerroModel inimigo2 = new HomemDeFerroModel();
            inimigo2.Vida = 100;
            inimigo2.ColorText = "Red";
            inimigo2.Equipe = "Inimiga";
            inimigo2.Armadura = true;

            Console.WriteLine("O Capitão América está logo ali, vamos atacar!");

            Console.WriteLine("Acões do Capitão América:");
            Console.WriteLine("(1) - Lançar escudo");
            Console.WriteLine("(2) - Defender-se");

            int resp = int.Parse(Console.ReadLine());

            switch (resp)
            {

                case 1:
                    Console.WriteLine("Uow toma essa!");
                    inimigo2.Vida -= 20;
                    break;

                case 2:
                    Console.WriteLine("Opaaa por essa você não esperava né");
                    break;

                default:
                    break;
            }
        }
    }
}