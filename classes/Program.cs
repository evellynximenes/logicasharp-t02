using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace logica13
{
    //Definição da classe Carro
    internal class carro
    {
        //Propriedade pública: Pode ser acessada e modificada fora da classe
        public string Marca { get; set; } //publica a propriedade da marca 

        //Propriedade privada: Não pode ser acessada ou modificada fora da classe 
        private string modelo { get; set; } //privada, acessivel apenas dentro da classe

        // Propriedade com um campo privado e um método getter e setter personalizados
        private int _ano; //Campo privado

        public int ano
        {
            get { return _ano; } //getter, para acessar o valor do campo privado 
            set
            {
                if (value > 1900 && value <= DateTime.Now.Year) //verificação para garantir um valor válido
                {
                    _ano = value;
                }
                else
                {
                    Console.WriteLine("ano inválido.");
                }
            }
        }
       //método público para exibir informação de carro
       public void ExibirInformacoes()
        {
            Console.WriteLine($"Marca:{Marca}");
            Console.WriteLine($"Modelo:{modelo}");
            Console.WriteLine($"Ano: {ano}");

            //Método para calcular a idade do carro 
            public int CalcularIdade()
        {
            int anoAtual = DateTime.Now.Year;
            return anoAtual - ano;
        }
        //Método para definir o modelo 
        public void DefinirModelo (string modelo)
        {
            modelo = modelo;
        }

    }
    internal class program
    {
        static void Main(string[] args)
        {
            //criando um objeto de classe carro
            carro meuCarro = new carro();

            //atribuindo valores a popriedades públicas e privadas
            meuCarro.Marca = "toyota";
            meuCarro.DefinirModelo("corolla");// Usando método para definir o modelo, poís é privado
            meuCarro.ano = 2020;//propriedade Ano é pública, mas com uma validação interna
                                
            //exibindo informações do carro
            meuCarro.ExibirInformacoes();

            //Calculandoe exibindo idade do carro 
            int idadeCarro = meuCarro.CalcularIdade();
            Console.WriteLine($"Idade do Carro: {idadeCarro} anos.");

            //Matntendo o console aberto
            Console.ReadLine();


        }
    }
}
