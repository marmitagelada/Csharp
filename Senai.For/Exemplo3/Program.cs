using System;

namespace Exemplo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número inteiro par:");
            int num = int.Parse(Console.ReadLine());
            
             for (int n = 100; n>0; n--){
                 num+=2;
                 System.Console.WriteLine(num);
             }
        }
    }
}
