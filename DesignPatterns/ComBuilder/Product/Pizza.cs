using System;
using System.Collections.Generic;

namespace ComBuilder.Product
{
    public class Pizza
    {
        public TipoMassa TipoMassa { get; set; }
        public TipoBorda TipoBorda { get; set; }
        public Tamanho Tamanho { get; set; }
        public List<string> Ingredientes { get; set; }

        public void PizzaConteudo()
        {
            Console.WriteLine("Pizza com massa: {0}", TipoMassa);
            Console.WriteLine($"Tamanho: {Tamanho}");
            Console.WriteLine($"Tipo Borda: {TipoBorda}");
            Console.WriteLine("Ingredientes");
            foreach (var item in Ingredientes)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
