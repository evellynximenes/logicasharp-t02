// declaração de dois vetores
int[] numeros = { 7, 2, 3, 34, 5 }; //vetor de inteiros
string[] nome = { "ana", "joão", "maria", "carlos" }; //vetor de strings 

//exibindo os elementos do vetor de numeros com loop for
Console.WriteLine("vetor de numeros (usando for):");
for (int i = 0; i< numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}

// exibindo elementos de vetor com lista foreach 
Console.WriteLine("\nvetor de numeros ordenados:");
foreach (var nome in nomes)
{
    Console.WriteLine(nome);
}

//ordenação vetor numeros
Array.Sort(numeros);
Console.WriteLine("\nvetor de numeros ordenados:");
foreach  (var n in numeros
{
    Console.WriteLine(n);
}

int valorProcurado = 5;
int posicaoSequencial = PesquisaSequencial(numeros, valorProcurado);

if (posicaoSequencial != -1)
{
    Console.WriteLine($"\nPesquisa Sequencial: valor {valorProcurado} encontrado na posição {posicaoSequencial}.");
}
else 
{
    Console.WriteLine($"\nPesquisa Sequencial: valor {valorProcurado} não encontrado.");
}

static int PesquisaSequencial(int[] vetor. int valor)
{
    for  (int i = 0; i< vetor.Length; i++)
    { if (vetor[i] == valor)
            return i; //retorna o indice do valor encontrado
    }
    return -1; //retorna -1 se não encontrar
}