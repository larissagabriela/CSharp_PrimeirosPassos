using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeirasVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o segundo projeto");

            /*
             Tipo inteiro
             */

            int idade;
            idade = 21;

            Console.WriteLine("Minha idade é " + idade);

            int soma = (idade + 5) * 2;

            /* A diferença entre o Console.WriteLine e Console.Write é:
                Enquando o Console.Write apenas escreve na tela, o Console.WriteLine, além de escrever, também pula uma linha.
            */
            Console.WriteLine(soma);


            /*
             Tipo ponto flutuante
             */

            double salario;
            double quinzenal;

            salario = 1800.75;
            quinzenal = 605.0 / 30;

            Console.WriteLine(salario);
            Console.WriteLine(quinzenal);

            Console.WriteLine("Execução finalizada. Pressione qualquer tecla para continuar . . .");
            Console.ReadLine();
        }
    }
}
