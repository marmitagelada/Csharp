using System;

namespace Simulador.Classes {
    public class Carro {

        #region Atributos

        public float KilometragemPorLitro;

        public int CapacidadeTanque;

        public float NivelTanque {get; private set;}

        public bool Ligado;

        public float Odometro {get; private set;}
        #endregion

        #region Métodos

        /// <sumary>
        /// Ligar o carro
        /// <sumary>
        public void Ligar () {
            System.Console.WriteLine ("Carro ligado");
            Ligado = true;
        }


        public void Abastecer (float quantidade) {
            NivelTanque+=quantidade;
            if (NivelTanque+quantidade <= CapacidadeTanque) {
                System.Console.WriteLine("Tanque Cheio");
            }
        }
        public void Andar(float kilometragem) {
            if (Ligado) {
                float consumo = kilometragem / KilometragemPorLitro;
                System.Console.WriteLine ($"Carro vai consumir {consumo} litros");

                //Verificando se o tanque possui combustível suf. p/ consumo
                if (NivelTanque >= consumo) {
                    Odometro+=kilometragem;
                    NivelTanque -= consumo;
                }
                else {
                    System.Console.WriteLine("Carro não possui combustível");
                }
            } else {
                System.Console.WriteLine("Ligue o Carro");
            }
        }

        public float PorcentagemNivelTanque() {
            float porcentagem = NivelTanque / CapacidadeTanque;
            return porcentagem; 
        }
        #endregion
    }

}