using System;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ===== Pizzaria =====");
            Console.WriteLine("Informe o local (S) São Paulo   (R)Rio de Janeiro");

            var localEscolhido = Console.ReadLine().ToUpper();

            Console.WriteLine("Escolha a pizza (M)Mussarela   (C)Calabresa");
            var pizzaEscolhida = Console.ReadLine().ToUpper();

            try
            {
                PizzaFactoryMethod pizzaria = PizzaSimpleFactory.CriarPizzaria(localEscolhido);

                var pizza = pizzaria.MontaPizzaa(pizzaEscolhida);

                Console.WriteLine(pizza.Preparar());
                Console.WriteLine("\n Pizza concluída com sucesso")
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
            Console.ReadLine();

        }
    }
}
