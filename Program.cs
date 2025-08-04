using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.ExerciciosFundamentos;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Variaveis e Constantes - Fundamentos",VariaveisEConstantes.Executar},
                {"Notação Ponto - Fundamentos",NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos",LendoDados.Executar},
                {"Formatando Números - Fundamentos",FormatandoNumeros.Executar},
                {"Opereradores Aritméticos - Fundamentos",OperadoresAritmeticos.Executar},
                {"Exercicio Calculo Média - Fundamentos",CalculoMedia.Executar},
                {"Operadores Relacionais e Lógicos - Fundamentos",Operadores.Executar},
                {"Operadores de Atribuição - Fundamentos",OperadoresAtribuicao.Executar},
                {"Estrutura de Condição - Fundamentos",EstruturaIf.Executar},
                {"Estrutura Switch - Fundamentos",EstruturaSwitch.Executar},
                {"Estruturas de Repetição - Fundamentos",EstruturaRep.Executar},
                {"Try Parse - Fundamentos",TryParse.Executar},
                {"Estrutura ForEach - Fundamentos",EstruturaForEach.Executar},

                /*Classes e Métodos - POO */
                {"Membros - Classes e Métodos",Membros.Executar},
                {"Construtores - Classes e Métodos",Construtores.Executar},
                 {"Construtores - Exercicios",Construtores2.Executar},
                {"Construtores - Classes e Métodos 3",Construtores3.Executar }


            });

            central.SelecionarEExecutar();
        }
    }
}