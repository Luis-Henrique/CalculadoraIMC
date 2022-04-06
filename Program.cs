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

            Console.WriteLine("================\n-Status:\n\nNome --> {0}\nAltura --> {1}\nPeso --> {2}\nIMC --> {3}\nFaixa --> {4}\n================", nome, altura, peso, imc, StatusPeso(imc));

        }

        public static String StatusPeso(double imc)
        {
            if (imc < 17)
            {
            return "Muito abaixo do peso";
            }

            if (imc >= 17 && imc <= 18.49)
            {
            return "Abaixo do peso";
            }

            if(imc >= 18.50 && imc <= 24.99)
            {
            return "Peso normal";
            }

            if(imc >= 25 && imc <= 29.99)
            {
            return "Acima do peso";
            }

            if(imc >= 30 && imc <= 34.99)
            {
            return "Obesidade I";
            }

            if(imc >= 35 && imc <= 39.99)
            {
            return "Obesidade II (severa)";
            }

            if(imc > 40)
            {
            return "Obesidade III (mórbida)";
            }
            return "Valor inválido";
        }
    }
}