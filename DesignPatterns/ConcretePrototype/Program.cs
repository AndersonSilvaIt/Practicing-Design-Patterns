namespace ConcretePrototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Soldado soldado = new Soldado();
            soldado.Nome = "Soldado 1";
            soldado.Arma = "Fuzil HK G36";
            soldado.Acessorio = new Acessorio { Nome = "Visor Noturno" };

            // clone1 do objeto original

            Soldado soldado_clone1 = (Soldado)soldado.Clone();
        }
    }
}
