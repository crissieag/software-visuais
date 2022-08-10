using System;

namespace aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean sair = false;
            String escolha = "";

            while (!sair)
            {
                menu();
                escolha = Console.ReadLine();
                switch (escolha)
                {
                    case "1":
                        exercicio1();
                        break;
                    case "2":
                        exercicio2();
                        break;
                    case "3":
                        exercicio3();
                        break;
                    case "4":
                        exercicio4();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }

        }
        static void menu()
        {
            String exibeMenu = "\n Qual exercício deseja realizar? \n 1 - Exercício 1 \n 2 - Exercício 2 \n 3 - Exercício 3 \n 4 - Exercício 4 \n 5 - Voltar";

            Console.WriteLine(exibeMenu);
        }

        static void exercicio1()
        {
            String enunciado = "Escreva um algoritmo que receba uma altura (1) e uma largura (2) de um retangulo calcule a sua área";
            Console.WriteLine(enunciado);

            Console.Write("Qual a altura do retangulo?");
            int altura = Convert.ToInt32(Console.ReadLine());
            Console.Write("Qual a largura do retangulo?");
            int largura = Convert.ToInt32(Console.ReadLine());

            int area = altura * largura;

            Console.WriteLine("O retangulo de altura " + altura + " e largura " + largura + " possui área de: " + area);
        }

        static void exercicio2()
        {
            String enunciado = "Crie um algoritmo que permita fazer três conversões monetárias. O algoritmo devereceber o valor em real (R$) e apresentar os valores convertidos em Dolar (1 dólar = 5,18 reais), Euro ( 1 euro = 5,31 reais) e em Peso Argentino (1 peso argentino = 0,04 reais).";
            Console.WriteLine(enunciado);

            Console.Write("Inserir valor em real: ");
            int valorEmReal = Convert.ToInt32(Console.ReadLine());
            Double dolar = 5.18 / valorEmReal;
            Double euro = 5.31 / valorEmReal;
            Double pesoArgentino = 0.04 / valorEmReal;

            Console.WriteLine("Valor em real: R$" + valorEmReal + "\n Valor em dolar: USD " + dolar + "\n Valor em euro:  EUR " + euro + " \n Valor em peso argentino: ARS " + pesoArgentino);
        }

        static void exercicio3()
        {
            String enunciado = "Receber dois números inteiros e informar qual valor lido é o menor e qual é omaior.";
            Console.WriteLine(enunciado);

            Console.Write("Inserir número A:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Inserir número B:");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("O número A: " + a + " é maior que o número B: " + b);
            }
            else if (a < b)
            {
                Console.WriteLine("O número B: " + b + " é maior que o número A: " + a);
            }
            else
            {
                Console.WriteLine("Os números inseridos são iguais.");
            }
        }

        static void exercicio4()
        {
            String enunciado = "Desenvolver um algoritmo para ler o valor inteiro da idade de uma pessoa eimprimir uma das mensagens: se idade <= 13: Criança, se idade > 13 e <= 18:Adolescente, se idade > 18 e <= 60: Adulto e se idade > 60: Idoso";
            Console.WriteLine(enunciado);

            Console.Write("Favor informar idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            if (idade > 60)
            {
                Console.Write("A idade (" + idade + ") é classificada como idoso");
            }
            else if (idade < 18 && idade >= 60)
            {
                Console.Write("A idade (" + idade + ") é classificada como adulto");
            }
            else if (idade < 13 && idade >= 18)
            {
                Console.Write("A idade (" + idade + ") é classificada como adolescente");
            }
            else
            {
                Console.Write("A idade (" + idade + ") é classificada como criança");

            }
        }
    }
}
