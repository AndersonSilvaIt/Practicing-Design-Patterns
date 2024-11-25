using System;

namespace PizzaSimpleFactory
{
    public class PizzaMussarela : PizzaCalabreza
    {
        public string Nome { get; set; }

        public PizzaMussarela()
        {
            Nome = "Pizza de mussarela";
        }

        public override void Preparar()
        {
            Console.WriteLine($"\nPreparando pizza de {Nome}");
        }

        public override void Embalar()
        {
            Console.WriteLine($"\nEmbalando pizza de {Nome}");
        }

        public override void Assar(int tempo)
        {
            Console.WriteLine($"Pizza de {Nome} assando por {tempo} min.");
        }
    }
}
