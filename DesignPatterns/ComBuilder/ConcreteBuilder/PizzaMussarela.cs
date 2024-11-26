using ComBuilder.Builder;
using ComBuilder.Product;
using System.Collections.Generic;

namespace ComBuilder.ConcreteBuilder
{
    public sealed class PizzaMussarela : PizzaBuildedr
    {
        public override void PreparaMassa()
        {
            pizza.TipoMassa = TipoMassa.Grossa;
            pizza.TipoBorda = TipoBorda.Recheada;
            pizza.Tamanho = Tamanho.Grande;
        }

        public override void IncluiIngredientes()
        {
            pizza.Ingredientes = new List<string> { "Mussarela", "Molho de tomate", "Orégano" };
        }
    }
}
