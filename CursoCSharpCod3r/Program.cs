using System;
using System.Collections.Generic;

using CursoCSharpCod3r.Fundamentos;

namespace CursoCSharpCod3r
{
    class Program
    {
        static void Main(string[] args)
        {
            string fundamentos = " - Fundamentos";
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {$"Primeiro programa{fundamentos}", PrimeiroPrograma.Executar},
                {$"Comentário{fundamentos}", Comentarios.Executar},
                {$"Variáveis e constantes{fundamentos}", VariaveisEConstantes.Executar},
                {$"Inferencia{fundamentos}", Inferencia.Executar},
                {$"Interpolação{fundamentos}", Interpolacao.Executar},
                {$"Notação ponto{fundamentos}", NotacaoPonto.Executar},
                {$"Lendo dados{fundamentos}", LendoDados.Executar},
                {$"Formatando numeros{fundamentos}", FormantandoNumero.Executar},
                {$"Conversões{fundamentos}", Conversoes.Executar},
                {$"Operadores aritiméticos{fundamentos}", OperadoresAritimeticos.Executar},
                {$"Operadores relacionais{fundamentos}", OperadoresRelacionais.Executar},
            });

            central.SelecionarEExecutar();
            Console.ReadKey();
        }
    }
}