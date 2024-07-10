namespace DesignPrinciples_SOLID_SRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestWithoutSRP();
            TestWithSRP();
            Console.ReadKey();
        }
        private static void TestWithoutSRP()
        {
            var account = new Before.Account("Mohamed", "Mohamed@gmail.com", 10000m);
            account.MakeTransaction(500);
            account.MakeTransaction(-11000);
        }
        private static void TestWithSRP()
        {
            var account = new After.Account("Mohamed", "Mohamed@gmail.com", 10000m);
            var accountService = new After.AccountService();
            accountService.Deposite(account, 500);
            accountService.WithDraw(account, 11000);
        }
    }
}