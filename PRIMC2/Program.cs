using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace PRIMC2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Declarando variáveis - Arrey Unidimencional (Vetor). 

            string[] nome = new string[5];
            int[] idades = new int[5];
            double[] peso = new double[5];
            double[] altura = new double[5];
            double[] imc = new double[5];
            int i = 0;
            string repetir = "s";

            // Saudações ao usuário!

            Console.WriteLine("Olá! Este é um programa que vai calcular o seu IMC (Índice de Massa Corporal)");

            Console.WriteLine();

            // Laço de repetição WHILE 

            while (repetir.ToLower() == "s")
            {

                Console.Write("Olá! Informe o seu nome: ");
                nome[i] = Console.ReadLine();

                Console.Write("Agora informe a sua idade: ");
                idades[i] = int.Parse(Console.ReadLine());

                Console.Write("Me informe o seu peso: ");
                peso[i] = double.Parse(Console.ReadLine());

                Console.Write("Me informe a sua altura: ");
                altura[i] = double.Parse(Console.ReadLine());

                imc[i] = peso[i] / (altura[i] * altura[i]);

                Console.Write("Quer calcular mais alguém? (s/n): \n");
                repetir = Console.ReadLine();

                i++;
            }

            Console.Clear();

            // Calculando o IMC. 

            for (i = 0; i < 5; i++)
            {
                Console.Write($"Nome: {nome[i]} \n");
                Console.Write($"idade: {idades[i]} \n");
                Console.WriteLine($"Peso: {peso[i]} \n");
                Console.WriteLine($"Altura: {altura[i]} \n");

               // Condicional de decisão ao nível do IMC. 

                if (imc[i] < 18.5) Console.WriteLine("Você está abaixo do peso: " + imc[i]);
                else if (imc[i] >= 18.5 && imc[i] <= 24.9) Console.WriteLine("Peso normal!: " + imc[i]);
                else if (imc[i] >= 25 && imc[i] <= 29.9) Console.WriteLine("Esta com sobrepeso: " + imc[i]);
                else if (imc[i] >= 30 && imc[i] <= 34.9) Console.WriteLine("Obesidade Grau 1!: " + imc[i]);
                else if (imc[i] >= 35 && imc[i] <= 39.9) Console.WriteLine("Obesidade Grau 2!!:" + imc[i]);
                else if (imc[i] >= 40) Console.WriteLine("Obesidade Grau 3!!! Obersidade mórbita!!!!:" + imc[i]);
            }

            Console.ReadKey();
        }
    }
}
