using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace turmaA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int _5minutos;//<- nao pode começar com numero
            int salario; //<- Não é recomendado usar acentuação
            int salariodofuncionario; //<- Não separar por palavra. salario do funcionario

            /* -----Convenções-----
            string primeiroNome;  <- Camel Case (Parametros e metodos, variaveis dentro de metodos)
            string PrimeiroNome;  <- Pascal Case (namespaces, classe, properties e metodos)
            string _primeiroNome; <- Padrão ( atributos "internos" da classe)
            */
            /*
            string nome = "Aldenor Neto";
            Console.Write(nome);
            Console.WriteLine(nome);

            int idade = 15;
            double saldo = 10.35784;
            string nome1 = "Maria";
            //placeholders 
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2} reais", nome1, idade, saldo);

            //Interpolação 
            Console.WriteLine($"{nome1} tem {idade} anos e tem saldo igual a {saldo} reais");

            //Concatenação
            Console.WriteLine(nome1 + " tem " +idade + " anos e tem saldo igual a " + saldo+ " reais");
            */
            int num1 = 10;
            num1 += 1;
            num1 -= 1;
            num1 *= 3;
            num1 /= 3;
            num1 %= 2;

            num1 ++;

            Console.WriteLine(num1);


        }
    }
}
