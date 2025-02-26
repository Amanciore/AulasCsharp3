namespace Aula_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int idade = 39;
            string nomecompleto = "Diego Aquila Almeida Sampaio";

            var VariavelSemTipo = "Diego";


            Console.WriteLine(VariavelSemTipo.GetType());

            Console.WriteLine("digite o seu nome: ");

            string nomeUsuario = Console.ReadLine();

            Console.WriteLine("digite sua idade; ");

            string idadeUsuario = Console.ReadLine();
            Console.WriteLine($"meu nome é{nomeUsuario} e a minha idade é {idadeUsuario} ");


        }
           
    }
        
