namespace FactoryMethod
{
    public class PizzaCalabrezaRJ : Pizza
    {
        public PizzaCalabrezaRJ()
        {
            Nome = "Pizza de calabreza carioca com muita calabresa";
            Massa = "Massa fina crocante carioca";
            Molho = "Molho de tomate italiano carioca";
            ingredientes.Add("Fatias de calabreza defumada especial");
            ingredientes.Add("Queijo parmesão italiano tradicional");
        }
    }
}
