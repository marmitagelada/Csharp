using System;

namespace Senai.Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            #region imcPessoa1
            Console.WriteLine("Informe o peso da primeira pessoa: ");
            float pesoPessoa1 = float.Parse( Console.ReadLine() );

            Console.WriteLine("Informe a altura da primeira pessoa: ");
            float alturaPessoa1 = float.Parse( Console.ReadLine() );

            float imcPessoa1 = pesoPessoa1 / (alturaPessoa1 * alturaPessoa1);

            Console.WriteLine( "Pessoa 1 pesa " + pesoPessoa1 + " e tem a altura de " + alturaPessoa1 + ". Então seu IMC é: " + imcPessoa1);
            #endregion

            #region imcPessoa2
            Console.WriteLine("Informe o peso da segunda pessoa: ");
            float pesoPessoa2 = float.Parse( Console.ReadLine() );

            Console.WriteLine("Informe a altura da segunda pessoa: ");
            float alturaPessoa2 = float.Parse( Console.ReadLine() );

            // casting
            float imcPessoa2 = (float) ((pesoPessoa2 / Math.Pow (alturaPessoa2,2)));

            Console.WriteLine( $"Pessoa 2 pesa { pesoPessoa2 } e tem a altura de { alturaPessoa2 }. Então seu IMC é: { imcPessoa2 }");
            #endregion
        }
    }
}
