using System;

namespace Exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recebendo o número x
            Console.WriteLine("Insira um número:");
            int x = int.Parse(Console.ReadLine());
            
            //Recebendo o limite
            System.Console.WriteLine("Insira o limite:");
            int limite = int.Parse(Console.ReadLine());

            int cont = 0;
            Console.Clear();
            // //Laço da tabuada: Exibir tabuada do número n do 0 até o limite.
            // while(cont<limite){
            //     cont++;
            //     System.Console.WriteLine($"{x} x {cont} = {x*cont}");
            // }
            for(cont=0;cont<=limite;cont++){
                System.Console.WriteLine($"{x} x {cont} = {x*cont}");
            }
        }
    }
}
