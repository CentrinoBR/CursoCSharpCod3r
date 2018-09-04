using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCod3r.Fundamentos
{
    public class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "Olá".ToUpper().Insert(3, " world!").Replace("world!", "mundo!");
            Console.WriteLine(saudacao);
            Console.WriteLine(1.CompareTo(9)); // -1 falso
            Console.WriteLine(1.CompareTo(1)); // 0 verdadeiro
            string valorImportante = null;
            //valorImportante = "string";
            Console.WriteLine(valorImportante?.Length);
        }
    }
}
