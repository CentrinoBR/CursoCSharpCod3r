using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCod3r.Fundamentos
{
    public class VariaveisEConstantes
    {
        public static void Executar()
        {
            //area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;
            double area = PI * raio * raio;
            Console.WriteLine(area);

            //Tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo "+ estaChovendo);

            byte idade = 45; //somente números positivos
            Console.WriteLine("Idade "+idade);

            Console.ReadKey();
        }
    }
}
