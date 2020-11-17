using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a operação desejada? Digite:");
            Console.WriteLine("1. Adição");
            Console.WriteLine("2. Subtração");
            Console.WriteLine("3. Multiplicação");
            Console.WriteLine("4. Divisão");
            int op = int.Parse( Console.ReadLine() );

            Console.WriteLine("Digite o 1o numero");
                    double num1 = double.Parse( Console.ReadLine() );
                    Console.WriteLine("Digite o 2o numero");
                    double num2 = double.Parse( Console.ReadLine() );

                    double resultado = 0;
            
            switch (op) 
            {
                case 1 :
                    resultado = num1 + num2; 
                    break;

                case 2 :
                    resultado = num1 - num2;
                    break;

                case 3 :
                    resultado = num1 * num2;
                    break;

                case 4 :
                    resultado = num1 / num2;
                    break;

                default:
                    Console.WriteLine("Por favor, insira um valor válido");
                    break;
            
            
            }
            Console.WriteLine($"Resultado: {num1} com {num2} = {resultado} ");

        }
    }
}
