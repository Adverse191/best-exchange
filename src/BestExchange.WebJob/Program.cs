using BestExchange.Common.IoC;

namespace BestExchange.WebJob
{
    // To learn more about Microsoft Azure WebJobs, please see http://go.microsoft.com/fwlink/?LinkID=401557
    internal class Program
    {
        private static void Main()
        {
            IContainer container = new Container();
            Bootstrapper bootstrapper = new Bootstrapper(container);
            bootstrapper.Run();
        }
    }
}
