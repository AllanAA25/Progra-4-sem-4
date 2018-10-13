using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class logicaCalculadora
    {
        /// <summary>
        /// Esta función es la cara de la interfaz para hacer el calculo de las operaciones.
        /// </summary>
        /// <param name="Operando1">Hilera de caractares que representa el primer operando</param>
        /// <param name="Operando2">Hilera de caractares que representa el segundo operando</param>
        /// <param name="elOperador">Hilera de caractares que representa el operando del resultado</param>
        /// <returns></returns>
        public string RealizarOperacion(string Operando1, string Operando2, string elOperador)
        {
            double primerOperando = Double.Parse(Operando1);
            double segundoOperando = Double.Parse(Operando2);
            double elResultado = RealizarOperacion(primerOperando, segundoOperando, elOperador);
            string elResultadoConvertido = elResultado.ToString();
            return elResultadoConvertido;
        }
        public double RealizarOperacion (double Operando1, double Operando2, EnumeradoOperadores elOperador)
        {
            double result= 0.0;
            switch (elOperador)
            {
                case EnumeradoOperadores.Suma:
                result = Operando1 + Operando2;
                    break;
                case EnumeradoOperadores.Resta:
                    result = Operando1 - Operando2;
                    break;
                case EnumeradoOperadores.Multiplicacion:
                    result = Operando1 * Operando2;
                    break;
                case EnumeradoOperadores.Division:
                    result = Operando1 / Operando2;
                    break;          
            }
            return result;
}
    }
}
