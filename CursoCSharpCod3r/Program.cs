using System;
using System.Collections.Generic;

using CursoCSharpCod3r.Fundamentos;

namespace CursoCSharpCod3r {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}