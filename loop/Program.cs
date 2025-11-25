// loop for
using System.Net;

for (int i = 1; i <=10; i++)
{
    Console.WriteLine(i);
}


int soma = 0;
for (int i = 1; i <=100; i++)
{
    soma += i; //soma o valor de i a variavel soma, exemplo 1+2+3+4.....
}
Console.WriteLine("A soma dos números de 1 a 100 é:" + soma);

/*loop infinito
for (; ;)
{
    Console.WriteLine("Este é um loop infinito!");
}

*/

//loop while (enquanto)

int contador = 1;
while(contador <=5)
{
    Console.WriteLine(contador);
    contador++; //Incrementa o contador 
}

// do while (faça enquanto)
int novocontador = 2;

do
{
    Console.WriteLine(novocontador);
    novocontador++;
} while (contador <= 5);

/*loop infinito while

while (true)
{
    Console.WriteLine("este é um loop infinito");
}*/

//loop foreach

// uma lista de strings 
List<string> nomes = new List<string> { "ana", "carlos", "joão", "maria" };

//usando o for reach para percorrer a lista 
foreach (string nome in nomes)
{
    Console.WriteLine(nome);// imprime cada nome exibindo na tela 
}

//um vetor de numeros inteiros 
int[] numeros = { 1, 2, 3, 4, 5 };

//usando o foreach para percorrer o vetor 
foreach ( int numero in numeros)
{
    Console.WriteLine(numero); // imprimi cada numero exibindo na tela
}

// solicitando ao usuário a digitação 
double preco, total = 0;
do
{
    Console.Write("digite o preço do produto (0 para finalizar):");
    preco = Convert.ToDouble(Console.ReadLine());
    total += preco;
} while (preco != 0);

Console.WriteLine($"\nTotal da Compra: R$ {total:F2}");
