using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeitorDeNumerosRomanos
{
    public class NumerosRomanos
    {
        private const string numerosRomanosP = "IVXLCDM";

        public int Ler(string numeroRomano)
        {
            //Remove os espaços em branco
            var numeros = numeroRomano.Replace(" ", "");

            var listaNumeros = numeros.ToUpper().ToCharArray();

            int total = 0;

            for (int i = 0; i < listaNumeros.Length; i++)
            {
                total = total + RetornaValor(listaNumeros[i], listaNumeros, i);
            }

            return total;
        }


        private int RetornaValor(char numeroRomano, char[] arrayValores, int index)
        {
            int valorAtual = RetornaValor(arrayValores[index]);

            if ((arrayValores.Length - 1) <= index)
                return valorAtual;

            if (RetornaValor(arrayValores[index + 1]) > valorAtual)
                return valorAtual * -1;

            return valorAtual;
        }


        private int RetornaValor(char numeroRomano)
        {
            switch (numeroRomano)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
                default:
                    return 0;
            }
        }
    }
}
