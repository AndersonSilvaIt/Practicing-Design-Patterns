using System;

namespace Pizza_WithoutSimpleFactory
{
    public class PizzaMussarela
    {
        public string Nome { get; set; }

        public PizzaMussarela()
        {
            Nome = "Pizza de mussarela";
        }

        public void Preparar()
        {
            Console.WriteLine($"\nPreparando pizza de {Nome}");
        }

        public void Embalar()
        {
            Console.WriteLine($"\nEmbalando pizza de {Nome}");
        }

        public void Assar(int tempo)
        {
            Console.WriteLine($"Pizza de {Nome} assando por {tempo} min.");
        }

        public void Emvalar()
        {
            Console.WriteLine($"Embalando pizza de {Nome}\n");
        }
    }
}
