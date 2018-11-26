using System;
using System.IO;
using System.IO.Compression;

namespace Compactação {
    class Program {
        static string opcao;
        static void Main (string[] args) {
            do {
                System.Console.WriteLine ("==================================");
                System.Console.WriteLine ("       Compactar arquivos");
                System.Console.WriteLine ("==================================");
                System.Console.WriteLine ("1 - Compactar");
                System.Console.WriteLine ("2 - Descompactar");

                System.Console.WriteLine ("Insita uma opção: ");
                string opcao = Console.ReadLine ();

                switch (opcao) {
                    case "1":
                        System.Console.WriteLine ("Insira o diretório que será compactado: ");
                        string diretorioParaCompactar = Console.ReadLine ();

                        System.Console.WriteLine ("Insira o nome do arquivo . zip: ");
                        string arquivoZipDestino = System.Console.ReadLine ();

                        if (!File.Exists (diretorioParaCompactar)) {
                            System.Console.WriteLine ("Diretório alvo não existe");
                        } else if (File.Exists (arquivoZipDestino)) {
                            System.Console.WriteLine ("O arquivo já foi compactado");
                        } else {
                            ZipFile.CreateFromDirectory (diretorioParaCompactar, arquivoZipDestino);
                        }
                        break;
                    case "2":
                        System.Console.WriteLine ("Insira o nome do arquivo.zip a ser descompactado: ");
                        string arquivoZip = Console.ReadLine ();

                        System.Console.WriteLine ("Insira o nome do diretório após a compactação: ");
                        string diretorioDestino = Console.ReadLine ();

                        if (File.Exists(arquivoZip))
                        {
                            System.Console.WriteLine("Diretório alvo não encontrado");
                        }
                        else if (File.Exists(diretorioDestino))
                        {
                            System.Console.WriteLine("O arquivo já foi descompactado");
                        }
                        else
                        {    
                        ZipFile.ExtractToDirectory (arquivoZip, diretorioDestino);
                        }
                        break;
                    default:
                        break;
                }
            } while (opcao != "0");
        }
    }
}