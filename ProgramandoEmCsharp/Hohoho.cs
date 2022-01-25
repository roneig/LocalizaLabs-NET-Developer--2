/*
Seu trabalho é ajudar o Papai Noel montando um problema que 
mostre todos os "Ho" que ele deve falar dado o número sorteado.

Entrada
A entrada é composta por um único inteiro N (0 < N ≤ 106) representando quantos "Ho" serão falados por Noel.

Saída
A saída é composta por todos "Ho" que Papai Noel deve falar separados por um espaço. 
Após o último "Ho" deve ser apresentado um "!" encerrando o programa.
 
Exemplo de Entrada
5	
Exemplo de Saída
Ho Ho Ho Ho Ho!
*/
//usei dotnet 6.0.101

using System;
int N = int.Parse(Console.ReadLine());

for( int i = 0; i < N; i++ ){
    if ( i < N-1 ) {
        Console.Write("Ho ");                  
    }
    else {
        Console.WriteLine("Ho!");
    }    
}     
           
