using System;
using System.Collections.Generic;
using System.Linq;
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
                          
    }
}