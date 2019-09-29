using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            int resp;
            double calculo;
            int inteiro;

            Console.WriteLine(@"
            --------------------------------------------------
            | SEJA BEM VINDO AO SISTEMA DE CALCULOS DO SENAI |
            --------------------------------------------------
            ");

            do{

            Console.Write("Informe um valor: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Informa o segundo valor: ");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine(@"
            -----------------------
            { - MENU DE CALCULO - }
            -----------------------

            (1) - Soma de dois números;
            (2) - Subtração do primeiro pelo segundo;
            (3) - Subtração do segundo pelo primeiro;
            (4) - Multiplicação dos dois números; 
            (5) - Divisão do primeiro pelo segundo; 
            (6) - Divisão do segundo pelo primeiro;
            (7) - Quociente inteiro da divisão do primeiro pelo segundo; 
            (8) - Quociente inteiro da divisão do segundo pelo primeiro;
            (9) - Resto da divisão do primeiro pelo segundo;
            (10) - Resto da divisão do segundo pelo primeiro;
            ");

            Console.Write("\nSelecione uma opcão: ");
            resp = int.Parse(Console.ReadLine());

            switch(resp){
                case 1:
                calculo = num1 + num2;
                Console.WriteLine($"Resultado do calculo é igual a {calculo}");
                break;

                case 2:
                calculo = num1 - num2;
                Console.WriteLine($"Resultado do calculo é igual a {calculo}");
                break;

                case 3:
                calculo = num2 - num1;
                Console.WriteLine($"Resultado do calculo é igual a {calculo}");
                break;

                case 4:
                calculo = num1 * num2;
                Console.WriteLine($"Resultado do calculo é igual a {calculo}");
                break;

                case 5:
                calculo = num1/num2;
                Console.WriteLine($"Resultado do calculo é igual a {calculo}");
                break;

                case 6:
                calculo = num2/num1;
                Console.WriteLine($"Resultado do calculo é igual a {calculo}"); 
                break;

                case 7:
                calculo = num1/num2;
                Console.WriteLine(Math.Round( calculo, 0));
                break;
            }

            }while(1 < 5);
        }
    }
}
