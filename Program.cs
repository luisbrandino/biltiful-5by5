namespace biltiful
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IModule> modules = new() { new RegistrationModule() };

            modules[0].Start();
        }
    }
}