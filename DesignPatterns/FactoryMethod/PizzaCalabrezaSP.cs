namespace FactoryMethod
{
    public class PizzaCalabrezaSP : Pizza
    {
        public PizzaCalabrezaSP()
        {
            Nome = "Pizza de calabreza Paulistana com muita calabresa";
            Massa = "Massa fina crocante paulistana";
            Molho = "Molho de tomate italiano paulista";
            ingredientes.Add("Fatias de calabreza defumada especial");
            ingredientes.Add("Queijo parmesão italiano tradicional");
        }
    }
}
