using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica14
{
    //Classe base (super classe)
    internal class animal
    {
        //Propriedade da classe animal
        public string Nome {  get; set; }

        //Método que será sobrecarregado nas classes derivadas
        public virtual void EmitirSom()
        {
            Console.WriteLine($"O {Nome} emite um som.");

        }
    }
    //Classe derivada (subclasse)
    internal class Cachorro : animal
    {
        //Escrevendo o método EmitirSom
        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} late: Au Au! ");
        }
    }

    //outra classe derivada
    internal class Gato : animal
    {
        //sobrescrevendo o método EnitirSom
        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} mia: Miau!");
        }
    }
internal class progam
    {
        static void Main (string[] args)
        {
            // Criando instâncias das classes derivadas
            animal meuCachorro = new Cachorro { Nome = "Rex" };
            animal meuGato = new Gato { Nome = "Felix" };
            animal meuCoelho = new animal { Nome = "lulu" };

            //Chamando o método EmitirSom para cada animal
            meuCachorro.EmitirSom(); //Saída: Rex late: Au Au 
            meuGato.EmitirSom(); //Saída: Felix mia: Miau
            meuCoelho.EmitirSom();

            //Utilizando Polimorfismo: Array dos animais 
            animal[] animais = { meuCachorro, meuGato, meuCoelho };
            foreach (var anima in animais)
            {
                animal.EmitirSom(); // Cada objeto chama o método adequado de sua classe
            }
        }

    }
}



