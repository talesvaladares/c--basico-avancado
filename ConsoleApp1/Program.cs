using System;
using System.Collections.Generic;

using CursoCSharp.fundamentos;
using CursoCSharp.estruturasDeControle;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", PrimeiroPrograma.Executar},
                {"variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo dados - Fundamentos", LendoDados.Executar},
                {"Formatando número - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unarios - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternario - Fundamentos", OperadorTernario.Executar},

                //estrutura de controle
                 {"Estrura If - Estruturas de Controle", EstruturaIf.Executar},
                 {"Estrura If/Else - Estruturas de Controle", EstruturaIfElse.Executar},
                 {"Estrura If/Else If - Estruturas de Controle", EstrutraIfElseIf.Executar},
                 {"Estrura Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                 {"Estrura While - Estruturas de Controle", EstruturaWhile.Executar},
                 {"Estrura Do While - Estruturas de Controle", EstruturaDoWhile.Executar},
                 {"Estrura Do For - Estruturas de Controle", EstruturaFor.Executar},
                 {"Estrura Foreach - Estruturas de Controle", EstruturaForeach.Executar},
                 {"Estrura Break - Estruturas de Controle", EstruturaBreak.Executar},
                  {"Estrura Continue - Estruturas de Controle", EstrutaraContinue.Executar},


                  //classes e metodos
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Construtores - Classes e Métodos", Construtores.Executar},
                {"Metodos com retorno - Classes e Métodos", MetodosComRetorno.Executar},
                {"Metodos Estaticos - Classes e Métodos", MetodosEstaticos.Executar},
                {"Atributos Estaticos - Classes e Métodos", AtributosEstaticos.Executar},
                {"Desafio Atributos - Classes e Métodos", DesafioAtributo.Executar},
                {"Params - Classes e Métodos", Params.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}