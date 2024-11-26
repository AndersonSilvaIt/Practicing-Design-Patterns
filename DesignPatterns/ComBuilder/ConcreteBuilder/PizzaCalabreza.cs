using ComBuilder.Builder;
using ComBuilder.Product;
using System.Collections.Generic;

namespace ComBuilder.ConcreteBuilder
{
    public sealed class PizzaCalabreza : PizzaBuildedr
    {
        public override void PreparaMassa()
        {
            pizza.TipoMassa = TipoMassa.Grossa;
            pizza.TipoBorda = TipoBorda.Normal;
            pizza.Tamanho = Tamanho.Grande;
        }

        public override void IncluiIngredientes()
        {
            pizza.Ingredientes = new List<string> { "Calabreza em fatias", "Molho de tomate" };
        }
    }
}
