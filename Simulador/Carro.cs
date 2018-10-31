using System;

namespace Simulador.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro();
            carro1.CapacidadeTanque = 45;
            carro1.KilometragemPorLitro = 14;
            carro1.Ligar();
            System.Console.WriteLine(carro1.Ligado);
            carro1.Abastecer(30);
            carro1.Abastecer(10);
            carro1.Abastecer(5);
            carro1.Andar(120);
            carro1.Andar(260);
            carro1.Andar(80);
            carro1.Andar(1);
            carro1.Andar(400);
            System.Console.WriteLine(carro1.NivelTanque);
            System.Console.WriteLine($"Odômetro: {carro1.Odometro} km");
            float resultado = carro1.PorcentagemNivelTanque();
            System.Console.WriteLine($"Nivel do tanque: {resultado.ToString("p")}");
        }
    }
}
