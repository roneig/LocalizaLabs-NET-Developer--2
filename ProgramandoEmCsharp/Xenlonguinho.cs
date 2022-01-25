/*
Entrada
A primeira linha consiste de um inteiro C que representa a quantidade de casos de teste. 
As linhas subsequentes contém um inteiro N (2 ≤ N ≤ 1000) que representa a quantidade de esferas necessárias 
para invocar Xenlonguinho.

Saída
Seu programa deve exibir a quantidade mínima de esferas que Kogu tem que procurar

O programa deve selecionar as esferas cujo o número de divisores da quantidade de estrelas dentro da esfera 
seja um número par.

Números quadrados perfeitos tem quantidade de divisores igual a um número impar

Calcular a Raiz quadrada da quantidade de esferas informada, 
o inteiro resultante  será a quantidade de quadrados perfeitos entre 
1 e o número de esferas informadas.

Subtraindo a parte inteira do número de quadrados perfeitos da quantidade de esferas informada
encontraremos a soma da quantidade de divisores pares que é = ao números de esferas que o kogu deve encontrar.
*/
//usei dotnet 6.0.101
using System;
int N = Convert.ToInt32(Console.ReadLine());

while(N-- > 0){
    int val = Convert.ToInt32(Console.ReadLine());
    int newval = (int)Math.Sqrt(val); 
    int resposta = val - newval;
    Console.WriteLine(resposta);
}
            