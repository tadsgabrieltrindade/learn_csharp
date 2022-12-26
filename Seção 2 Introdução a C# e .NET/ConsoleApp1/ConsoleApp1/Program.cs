using System;
using System.Globalization; //deixa o ponto como padrão USA

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            double x = 10.35784;
            int y = 32;
            string z = "Maria";
            char w = 'F';

            Console.Write("Olá mundo!"); //não realiza a quebra de linha
            Console.WriteLine("Bom dia!");
            Console.WriteLine("Até mais.");

            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2")); //delimita o número de casa pós a vírgula
            Console.WriteLine(x.ToString("F4")); //delimita o número de casa pós a vírgula
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture)); //além de delimitar, deixa o ponto como padrão USA

            Console.WriteLine();
            Console.WriteLine("RESULTADO = " + x);
            Console.WriteLine("O valor do troco é " + x + " reais");
            Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais");

            Console.WriteLine();
            Console.WriteLine("A paciente " + z + " tem " + y + " anos e seu sexo é: " + w);

            Console.WriteLine("A paciente {0}, com saldo de {1:F2}, tem {2} anos e seu sexo é: {3}", z, x, y, w); //placeholder
            //{1:F2} - indica quantas casas decimais pós a vírgula

            Console.WriteLine($"A paciente {z}, com saldo de {x:F2}, tem {y} anos e seu sexo é: {w}");

            Console.WriteLine($"A paciente {z}, com saldo de {x.ToString("F2", CultureInfo.InvariantCulture)}, tem {y} anos e seu sexo é: {w}");

            Console.ReadLine();


            Console.WriteLine("-----ENTRADA DE DADOS COM C# ---------");

            



        }
    }
}
