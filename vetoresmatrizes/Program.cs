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
foreach (var nome in nome)
{
    Console.WriteLine(nome);
}

//ordenação vetor numeros
Array.Sort(numeros);
Console.WriteLine("\nvetor de numeros ordenados:");
foreach  (var n in numeros)
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

static int PesquisaSequencial(int[] vetor int valor)
{
    for  (int i = 0; i< vetor.Length; i++)
    { if (vetor[i] == valor)
            return i; //retorna o indice do valor encontrado
    }
    return -1; //retorna -1 se não encontrar
}

// pesquisa binaria 
int posicaoBinaria = Array.BinarySearch(numeros, valorProcurado);
if (posicaoBinaria >= 0)
{
    Console.WriteLine($"pesquisa binaria: valor {valorProcurado} encontrado na posição {posicaoBinaria}.");
}
else
{
    Console.WriteLine($"pesquisa binaria: valor {valorProcurado} não encontrado.");
}

// declaração e manipulação de matrizes 3x2
int[,] matriz = new int[3, 2]
{
    { 1, 2 },
    { 3, 4 },
    { 5, 6 }
};
Console.Write("\n Exibindo Matriz 3x2:");
for (int i = 0; i < 3; i++)
{
    for(int j = 0; j < 2; j++)
    {
        Console.Write(matriz[i, j] + "\t");
    }
    Console.WriteLine();
}