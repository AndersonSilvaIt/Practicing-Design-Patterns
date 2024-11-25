using System;

namespace PizzaSimpleFactory
{
    public class Pizzaria
    {
        public static void SolicitaPizza()
        {
            Console.WriteLine(" ===== Pizzaria =====");
            Console.WriteLine("Informe a Pizza (C)alabreza ou (M)ussarela \n");

            var pizzaEscolha = Console.ReadLine().ToUpper();
            try
            {
                Pizza pizza = PizzaSimpleFactory.CriaPizza(pizzaEscolha);
                pizza.Preparar();
                pizza.Assar(10);
                pizza.Embalar();
                Console.WriteLine("pizza concluida");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }
    }
}
