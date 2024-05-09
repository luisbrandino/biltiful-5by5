using biltiful.Operations;
using biltiful.Operations.Registration;

namespace biltiful.Modules
{
    internal class RegistrationModule : IModule
    {
        List<IOperation> operations = new List<IOperation>();

        public RegistrationModule()
        {
            operations.Add(new RegisterClientOperation());
        }

        private void _ClientRegistration()
        {
            Console.WriteLine("Cadastro de cliente");
        }

        private void _ProviderRegistration()
        {
            Console.WriteLine("Cadastro de fornecedor");
        }

        private void _FeedstockRegistration()
        {
            Console.WriteLine("Cadastro de MP");
        }

        private void _ProductRegistration()
        {
            Console.WriteLine("Cadastro de produto");
        }

        private void _DefaulterClientRegistration()
        {

        }

        private void _BlockedProviderRegistration()
        {

        }

        public void Start()
        {
            ConsoleMenu menu = new("Cadastrar cliente", "Cadastrar fornecedor", "Cadastrar matéria-prima", "Cadastrar produto", "Clientes inadimplentes", "Fornecedores bloqueados");

            menu.SetActionForOption(1, () => { operations[0].Execute(); });
            menu.SetActionForOption(2, () => { _ProviderRegistration(); });
            menu.SetActionForOption(3, () => { _FeedstockRegistration(); });
            menu.SetActionForOption(4, () => { _ProductRegistration(); });

            menu.ClearConsoleBeforeDisplaying(true);

            while (true)
            {
                menu.Execute(menu.Ask());
            }
        }

    }
}
