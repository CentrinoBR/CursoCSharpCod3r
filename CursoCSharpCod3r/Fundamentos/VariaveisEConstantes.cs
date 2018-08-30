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
            Console.WriteLine(byte.MinValue); //0
            Console.WriteLine(byte.MaxValue); //255

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de gols "+ saldoDeGols); // -128
            Console.WriteLine(sbyte.MaxValue); // 127

            short salario = short.MaxValue;
            Console.WriteLine("Salário "+salario); // 32.767
            Console.WriteLine(short.MinValue); // -32.768

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População brasileira "+ populacaoBrasileira);
            Console.WriteLine(uint.MinValue); // 0
            Console.WriteLine(uint.MaxValue);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long "+ menorValorLong);
            Console.WriteLine(long.MaxValue);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População mundial "+populacaoMundial);
            Console.WriteLine(ulong.MinValue);
            Console.WriteLine(ulong.MaxValue);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço computador "+precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00;
            Console.WriteLine("Valor Apple "+ valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre estrelas "+distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra "+letra);

            string texto = "Seja bem vindo ao curso de C#!";
            Console.WriteLine(texto);

            Console.ReadKey();
        }
    }
}
