using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variaveis_de_texto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto Variáveis de Texto");

            //character
            char primeira_letra = 'a';
            Console.WriteLine(primeira_letra);

            // Com o cast nós conseguimos converter diferentes tipos de variáveis
            // Isso é o que a linha abaixo está fazendo

            primeira_letra = (char)65; //tabela de conversão hexadecimal; 65 representa o A.
            Console.WriteLine(primeira_letra);

            primeira_letra = (char)(primeira_letra + 1);

            //textos

            string titulo = "Alura melhor curso " + 2021; //concatenação
            string cursosProgramação = 
 @"- .NET
- Java
- Javascript";

            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramação);

            Console.ReadLine();
        }
    }
}