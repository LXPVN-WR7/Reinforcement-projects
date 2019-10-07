using System;
using Reforço_Final_de_Semana.Controllers;

namespace Reforço_Final_de_Semana
{
    class Program
    {
        static void Main(string[] args)
        {

            string personagem;

            Console.WriteLine("(1) - Homem de Ferro\n(2) - Capitão América");
            personagem = Console.ReadLine();

            HFController hFController = new HFController();

            CapController capController = new CapController();

            if (personagem == "1")
            {

                Console.ForegroundColor = hFController.MudarCor();

                Console.WriteLine(hFController.Mostrar());

                Console.WriteLine("Você está jogando com o homeme de Ferro");

                hFController.Atrirar();

                hFController.Pular();

                hFController.Voar();

            }
            else if (personagem == "2")
            {

                Console.WriteLine(capController.MudaCor());
                Console.WriteLine(capController.Mostrar());
                Console.WriteLine("Você está jogando com o Capitão América");
                Console.WriteLine(capController.LancarEscudo());
                Console.WriteLine(capController.Pular());
                Console.WriteLine(capController.DefenderComEscudo());

            }else{
                System.Console.WriteLine("");
            }
        }
    }
}