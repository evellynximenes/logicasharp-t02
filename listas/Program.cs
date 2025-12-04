using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Progam
{

static void Main()
    {
        List<string> nomes = new List<string>();

        //Adicionando elementos
        nomes.Add("Ana");
        nomes.Add("Bruno");
        nomes.Add("Carlos");

        Console.WriteLine("Lista após adicionar elementos:");
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }

        //Adicionar novo nome
        nomes.Add("Daniel");

        Console.WriteLine("\nLista após adicionar 'Daniel':");
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }

        //Removendo elementos
        nomes.Remove("Bruno"); //Remove elo valor

        Console.WriteLine("\nLista após remover 'Bruno':");
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }

        //Removendo pelo indice
        nomes.RemoveAt(0);

        Console.WriteLine("\nLista após remover o indice 0 (ana):");
        foreach(string nome in nomes)
        {
            Console.WriteLine(nome);
        }

        //Limpando toda a lista 
        nomes.Clear();

        Console.WriteLine("\nLista após Clear():");
        Console.WriteLine("Quantidade de elementos:" + nomes.Count);
    }
}