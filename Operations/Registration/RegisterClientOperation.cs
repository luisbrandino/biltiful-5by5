namespace biltiful.Operations.Registration
{
    internal class RegisterClientOperation : IOperation
    {

        public void Execute()
        {
            // aqui pede pelos dados necessarios para criar o novo cliente, com tratamentos
            Console.WriteLine("pega dados cliente");

            // aqui a logica para adicionar a recente entidade criada ao arquivo
            Console.WriteLine("adiciona cliente");

            // independente de como os grupos vão implementar essa parte, seguindo essa arquitetura podemos "trocar" os modulos por outros 
            // já que garantimos que seguirá o mesmo formato
        }

    }
}
