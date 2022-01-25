/*
Você terá o desafio de escrever um algoritmo que leia 2 números e imprima o 
resultado da divisão do primeiro pelo segundo. Caso não for possível, 
mostre a mensagem “divisao impossivel” para os valores em questão.

Entrada
A entrada contém um número inteiro N. 
Este N será a quantidade de pares de valores inteiros (X e Y) que serão lidos em seguida.

Saída
Para cada caso mostre o resultado da divisão com um dígito após o ponto decimal, 
ou “divisao impossivel” caso não seja possível efetuar o cálculo. 

Exemplo de Entrada	Exemplo de Saída
3
3 -2                -1.5
-8 0                divisao impossivel 
0 8	                0.0 

*/
//usei dotnet 6.0.101

using System;
using System.Globalization;

int limit = Int32.Parse(Console.ReadLine());

CultureInfo culture = new CultureInfo("en-US");

for (int i = 0; i < limit; i++) 
{
    string[] line = Console.ReadLine().Split(" ");

    double X = double.Parse(line[0]);
    double Y = double.Parse(line[1]);

    if ( Y == 0 ) {
          Console.WriteLine("divisao impossivel");  
    } else {
          //Console.WriteLine((X/Y).ToString("N1", culture));    
          Console.WriteLine((X/Y).ToString("0.0", culture));  
    }
}    

