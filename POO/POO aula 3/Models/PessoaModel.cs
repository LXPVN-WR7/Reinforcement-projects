namespace POO_aula_3.Models
{
    public class PessoaModel
    {
        public string name {get; set;}
        public int age {get; set;}

        public void Comer(){
            System.Console.WriteLine("Bora comer");
        }
        public void andar(){
            System.Console.WriteLine("Bora andar");
        }
        public void Dormir(){
            System.Console.WriteLine("Bora dormir");
        }
    }
}