using AbstractFactory.Domain.Enums;

namespace AbstractFactory.Domain.Products
{
    public abstract class Pizza : MassaBase
    {
        public Pizza(string nome, TipoMassa tipoMassa) : base(nome, tipoMassa)
        {
        }
    }
}
