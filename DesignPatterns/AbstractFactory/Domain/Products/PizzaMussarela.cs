using AbstractFactory.Domain.Enums;

namespace AbstractFactory.Domain.Products
{
    public sealed class PizzaMussarela : Pizza
    {
        public PizzaMussarela() : base("Pizza calabresa", TipoMassa.Pizza)
        {
            Ingredientes.Add("Queijo mussarela gratinado e molho de tomate");
        }
    }
}