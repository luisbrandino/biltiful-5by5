using biltiful.Modules;

namespace biltiful
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IModule> modules = new() { new RegistrationModule() };
            ConsoleMenu menu = new("Módulo de cadastro", "Módulo de vendas", "Módulo de MP", "Módulo de cosméticos");

            menu.SetActionForOption(1, () => { modules[0].Start(); });

            menu.Execute(menu.Ask());
        }
    }


}