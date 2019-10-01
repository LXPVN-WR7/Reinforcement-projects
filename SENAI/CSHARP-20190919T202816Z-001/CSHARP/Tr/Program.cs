using System;

namespace Tr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("| Seja bem vindo ao seitema de compras do SENAI |");
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("-----------     ------------");
            Console.WriteLine("| Começar |     | Cancelar |");
            Console.WriteLine("-----------     ------------");


            Console.WriteLine(@"
            
            -------------------------------------------------
            | Seja bem vindo ao seitema de compras do SENAI |
            -------------------------------------------------

                    -----------     ------------
                    | Começar |     | Cancelar |
                    -----------     ------------

            ");

            String resposta = Console.ReadLine();

            if(resposta == "Começar" || resposta == "começar" || resposta == "comecar"){
                
                Console.WriteLine("Informe o seu nome:");
                String nome = Console.ReadLine();
                
                Console.WriteLine($"Ok {nome} vamos começar");

                String [] produtos = new String [];

                while(produtos )

            }
        }
    }
}
