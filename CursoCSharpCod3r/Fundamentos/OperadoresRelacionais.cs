using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCod3r.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar()
        {
            //double nota = 6.0;
            Console.Write("Digite a nota: ");
            double.TryParse(Console.ReadLine(), out double nota);
            double notaDeCorte = 7.0;

            Console.WriteLine("Nota inválida? {0}",nota>10.0);
            Console.WriteLine("Nota inválida? {0}",nota<0.0);
            Console.WriteLine("Nota máxima? {0}",nota==10.0);
            Console.WriteLine("Nota passível de melhora? {0}",nota!=10.0);
            Console.WriteLine("Nota suficiente por média? {0}", nota >= notaDeCorte);
            Console.WriteLine("Nota passível de recuperação? {0}", nota < notaDeCorte);
            Console.WriteLine("Nota insuficiente? {0}",nota<=3.0);
        }
    }
}
