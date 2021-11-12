using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtribuiçãoDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto Atribuição de Variáveis");

            int idade = 21;
            int idadeVinicio = idade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadeVinicio);

            Console.ReadLine();
        }
    }
}
