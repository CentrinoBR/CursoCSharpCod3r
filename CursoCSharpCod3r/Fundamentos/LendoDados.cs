using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoCSharpCod3r.Fundamentos
{
    public class LendoDados
    {
        public static void Executar()
        {
            Console.WriteLine("Qual é o seu nome? ");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual a sua idade? ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("{0} - {1} anos R$ {2}",nome,idade,salario);
        }
    }
}
