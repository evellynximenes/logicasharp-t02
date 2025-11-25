using System;
using System.IO;

namespace AulaRegistrosArquivos
{
    public struct Cliente
    {
        public string Nome;
        public int Idade;
        public string Email;
    }

class progam
    {
        static void Main(string[] args)
        {
            //declaração de uso básico de registros
            Cliente cliente1;
            cliente1.Nome = "João";
            cliente1.Idade = 30;
            cliente1.Email = "joao@exemple.com";

            Console.WriteLine("=== Cliente1 ===");
            Console.WriteLine("Nome: " + cliente1.Nome);
            Console.WriteLine("idade: " + cliente1.Idade);
            Console.WriteLine("email: " + cliente1.Email);
            Console.WriteLine();

            //SEGUNDA GRAAÇÃO E EXIBIÇÃO DE INFORMAÇÕES
            Cliente cliente2;
            cliente2.Nome = "maria";
            cliente2.Idade = 25;
            cliente2.Email = "maria@exemple.com";

            Console.WriteLine("=== Cliente1 ===");
            Console.WriteLine("Nome: " + cliente2.Nome);
            Console.WriteLine("idade: " + cliente2.Idade);
            Console.WriteLine("email: " + cliente2.Email);
            Console.WriteLine();

            // organização dos dados em tabela (vetor de registros)
            Cliente[] clientes = new Cliente [2];
            clientes[0].Nome = "joão";
            clientes[0].Idade = 30;
            clientes[0].Email = "joao@exemple.com";
            clientes[1].Nome = "maria";
            clientes[1].Idade = 25;
            clientes[1].Email = "maria@exemple.com";

            Console.Write("=== Tabela de Clientes ===");
            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine("nome: " + cliente.Nome);
                Console.WriteLine("idade: " + cliente.Idade);
                Console.WriteLine("Email: " + cliente.Email);
                Console.WriteLine();
            }


            // gravação de dados em arquivo
            Cliente cliente3;
            cliente3.Nome = "carlos";
            cliente3.Idade = 40;
            cliente3.Email = "carlos@exemple.com";

            string caminhoArquivo = "clientes.txt";

            using (StreamWriter sw = new StreamWriter(caminhoArquivo))
            {
                sw.WriteLine("=== Cliente 3 ===");
                sw.WriteLine("nome: "+ cliente3.Nome);
                sw.WriteLine("idade: " + cliente3.Idade);
                sw.WriteLine("email: " + cliente3.Email);
            }
            Console.WriteLine("=== Gravação em Arquivo ===");
            Console.WriteLine($"informações de {cliente3.Nome} gravadas em {caminhoArquivo}.");
            Console.WriteLine();

            //leitura do arquivo gravado
            Console.WriteLine("=== Conteudo do arquivo ===");
            string conteudo = File.ReadAllText(caminhoArquivo);
            Console.WriteLine(conteudo);

            Console.WriteLine("\n=== Fim da Execução ===");
        }

    }
}
