using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCuadradoMedio.Algoritmos
{
    public class AlgoritmoGenerador
    {
        public List<Tuple<int, int, int, double, double>> MetodoCuadradosMedios(int semilla)
        {
            List<Tuple<int, int, int, double, double>> resultados = new List<Tuple<int, int, int, double, double>>();
            int semillaActual = semilla;
            int iteracion = 0;

            while (semillaActual >= 0)
            {
                int cuadrado = semillaActual * semillaActual;
                string cuadradoStr = cuadrado.ToString();
                string valor1Str = "";
                string valor2Str = "";

                if (cuadradoStr.Length == 5)
                {
                    valor1Str = cuadradoStr.Substring(1, 3);
                    valor2Str = "0";
                }
                else if (cuadradoStr.Length == 6)
                {
                    valor1Str = cuadradoStr.Substring(1, 3);
                    valor2Str = cuadradoStr.Substring(2, 3);
                }

                double valor1 = 0;
                if (!string.IsNullOrEmpty(valor1Str) && double.TryParse(valor1Str, out double tempVal1))
                {
                    valor1 = tempVal1;
                }

                double valor2 = 0;
                if (!string.IsNullOrEmpty(valor2Str) && double.TryParse(valor2Str, out double tempVal2))
                {
                    valor2 = tempVal2;
                }

                resultados.Add(new Tuple<int, int, int, double, double>(iteracion++, semillaActual, cuadrado, valor1, valor2));

                if (semillaActual == 0)
                {
                    break;
                }

                semillaActual = (int)valor1;
            }

            return resultados;
        }
    }
}
