using System;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            Menu();
        }
        //Função menu
        static void Menu()
        {
            Console.WriteLine("Digite a operação desejada:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");     
            var resposta = int.Parse(Console.ReadLine());
            Console.Clear();
     

            switch (resposta)
            {
                case 1:
                    Soma();
                    break;
                case 2:
                    Subtracao();
                    break;
                case 3:
                    Divisao();
                    break;
                case 4:
                    Multiplicacao();
                    break;
                case 5:
                    System.Environment.Exit(0);
                    break;
                default: Menu();
                    break;
            }
            Console.ReadKey();
        }
        //Função de soma
        static void Soma()
        {
            
            Console.WriteLine("Primeiro valor: ");
            var v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            var v2 = float.Parse(Console.ReadLine());
            var soma = v1 + v2;
            Console.WriteLine($"Resultado: {soma}");
            
        }
        //Função de subtração
        static void Subtracao()
        {
            Console.WriteLine("Primeiro valor: ");
            var v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            var v2 = float.Parse(Console.ReadLine());
            float subtracao = v1 - v2;
            Console.WriteLine($"Subtração: {subtracao}");
        }
        //Função de divisão
        static void Divisao()
        {
            Console.WriteLine("Primeiro valor: ");
            var v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            var v2 = float.Parse(Console.ReadLine());
            float divisao = v1 / v2;
            Console.WriteLine($"Divisão: { divisao }");
        }
        //Função de multiplicação
        static void Multiplicacao()
        {
            Console.WriteLine("Primeiro valor: ");
            var v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            var v2 = float.Parse(Console.ReadLine());
            float multiplicacao = v1 * v2;
            Console.WriteLine($"Multiplicação: { multiplicacao }");
        }
    }

}
