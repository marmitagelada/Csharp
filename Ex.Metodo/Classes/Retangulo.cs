using System;

namespace Ex.Metodo.Classes.Retangulo {
    public class Retangulo {

        #region Atributos
        public float LadoA;

        public float LadoB;
        #endregion

        #region Métodos

        /// <summary>
        /// Calcula a área do retângulo
        /// </summary>
        /// <returns>A área do retângulo</returns>
        public float CalculaArea(){
            float area = LadoA*LadoB;
            return area;
        }

        /// <summary>
        /// Calcula o perímetro do retângulo
        /// </summary>
        /// <returns>O perímetro do retângulo</returns>
        public float CalculaPerimetro(){
            float per = LadoA+LadoB+LadoA+LadoB;
            return per;
        }
        #endregion
    }

}