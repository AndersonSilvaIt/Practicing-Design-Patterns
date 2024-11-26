using AbstractFactory.Domain.Enums;

namespace AbstractFactory.Domain.Products
{
    public sealed class BoloLaranja : Bolo
    {
        public BoloLaranja() : base("Bolo de Laranja", TipoMassa.Bolo)
        {
            Ingredientes.Add("Com cobertura de calda de laranja");
        }
    }
}
