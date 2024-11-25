using System;

namespace PizzaSimpleFactory
{
    public class PizzaCalabreza : Pizza
    {
        public string Nome { get; set; }

        public PizzaCalabreza()
        {
            Nome = "Pizza de calabresa";
        }

        public override void Preparar()
        {
            Console.WriteLine($"\nPreparando pizza de {Nome}");
        }

        public override void Embalar()
        {
            Console.WriteLine($"\nPreparando pizza de {Nome}");
        }

        public override void Assar(int tempo)
        {
            Console.WriteLine($"Pizza de {Nome} assando por {tempo} min.");
        }
    }
}
