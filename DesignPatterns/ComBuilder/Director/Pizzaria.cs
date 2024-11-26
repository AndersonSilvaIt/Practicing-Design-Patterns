using ComBuilder.Builder;
using ComBuilder.Product;

namespace ComBuilder.Director
{
    public class Pizzaria
    {
        private readonly PizzaBuildedr builder;

        public Pizzaria(PizzaBuildedr builder)
        {
            this.builder = builder;
        }

        public void MontaPizza()
        {
            builder.CriaPizza();
            builder.PreparaMassa();
            builder.IncluiIngredientes();
        }

        public Pizza GetPizza()
        {
            return builder.GetPizza();
        }
    }
}
