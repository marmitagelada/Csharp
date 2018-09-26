using System;

namespace Senai.Operadores.Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em °C a ser convertida");
            float tmp = float.Parse(Console.ReadLine());

            float tmpConvert = (float) ((tmp*1.8)+32);

            Console.WriteLine($"{tmpConvert}°F");
        }
    }
}
