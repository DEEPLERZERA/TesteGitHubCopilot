using System;    //Bibliotecas do C#
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {



//Criar uma calculadora com as operações básicas de soma, subtração, multiplicação e divisão.
int soma(int a, int b) //função soma
{
    return a + b; //retorna a soma
}

int subtracao(int a, int b) //função subtração
{
    return a - b; //retorna a subtração
}

int multiplicacao(int a, int b)  //função multiplicação
{
    return a * b; //retorna a multiplicação
}

double divisao(double a, double b)   //função divisão
{
    return a / b; //retorna a divisão
}

//Criar um programa que receba dois números e um caractere, e realize a operação solicitada pelo caractere.
//Exemplo:
//Digite o primeiro número: 10
//Digite o segundo número: 5
//Digite a operação: +
//Resultado: 15

soma(10, 5);
subtracao(10, 5);
multiplicacao(10, 5);
divisao(10, 5);

Console.WriteLine(soma);
Console.WriteLine(subtracao);
Console.WriteLine(multiplicacao);
Console.WriteLine(divisao);

        }
    }
}






