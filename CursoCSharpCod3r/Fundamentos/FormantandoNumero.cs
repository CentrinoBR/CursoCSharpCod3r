using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoCSharpCod3r.Fundamentos
{
    class FormantandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            double porcentagem = 0.5;
            Console.WriteLine(valor.ToString("F1"));
            Console.WriteLine(valor.ToString("C"));
            Console.WriteLine(porcentagem.ToString("P"));
            Console.WriteLine(valor.ToString("#.##"));
            Console.WriteLine(valor.ToString("#.#"));

            CultureInfo cultura = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C0",cultura));
            Console.WriteLine(valor.ToString("C2",cultura));

            CultureInfo culturaUs = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C2", culturaUs));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // zeros a esquerda
        }
    }
}
