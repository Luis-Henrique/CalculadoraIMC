using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá!! qual o seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a sua altura? (Ex: '1,7m')");
            float altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Qual o seu peso? (Ex: '60,5kg')");
            float peso = Convert.ToSingle(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine("================\n-Status:\n\nNome --> {0}\nAltura --> {1}\nPeso --> {2}\nIMC --> {3}\n================", nome, altura, peso, imc);
        }
    }
}
