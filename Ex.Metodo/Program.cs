using System;

namespace Ex.Metodo.Classes.Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Criando novo retângulo
            Retangulo retangulo = new Retangulo();

            //Recebendo Lado A
            Console.WriteLine("Digite o valor do LadoA: ");
            retangulo.LadoA = float.Parse(Console.ReadLine());
            
            //Recebendo Lado B
            Console.WriteLine("Digite o valor do LadoB: ");
            retangulo.LadoB = float.Parse(Console.ReadLine());

            System.Console.WriteLine($"A área do retângulo é: {retangulo.CalculaArea()}");
            System.Console.WriteLine($"O perímetro do retângulo é: {retangulo.CalculaPerimetro()}");
        }
    }
}
