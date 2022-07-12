using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu();


        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Qual operação deseja realizar ?");
            string[] methods = { "Soma", "Subtração", "Divisão", "Multiplicação", "Sair" };
            int i = 1;

            foreach (string item in methods)
            {
                Console.WriteLine($"{i} - {item}");
                i++;
            }
            short selecao = short.Parse(Console.ReadLine());

            switch (selecao)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: sair(); break;
                default: Menu(); break;
            }
        }

        static void sair(){
            Console.Clear();
            Console.WriteLine("Obrigado por usar a calculadora");
            System.Environment.Exit(0);
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Soma");
            Console.WriteLine("");
            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine($"Primeiro valor {v1} Segundo valor {v2}");

            Console.WriteLine($"A soma dos valores é: {v1 + v2}");
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Subtração");
            Console.WriteLine("");
            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine($"Primeiro valor {v1} Segundo valor {v2}");

            Console.WriteLine($"O resultado da subtração é: {v1 - v2}");
            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Divisão");
            Console.WriteLine("");
            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine($"Primeiro valor {v1} Segundo valor {v2}");

            Console.WriteLine($"A divisão dos valores é: {v1 / v2}");
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Multiplicação");
            Console.WriteLine("");
            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine($"Primeiro valor {v1} Segundo valor {v2}");

            Console.WriteLine($"A soma dos valores é: {v1 * v2}");
            Console.ReadKey();
            Menu();
        }
    }

}

