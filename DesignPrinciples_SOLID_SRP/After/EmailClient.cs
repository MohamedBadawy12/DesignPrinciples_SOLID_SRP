namespace DesignPrinciples_SOLID_SRP.After
{
    internal class EmailClient
    {
        public void send(Account account, string transactionMessage, DateTime transactionDate)
        {
            Console.WriteLine(
         $"\n\n\t\t To: {account.Email}" +
         $"\n\t\t Subject: Bank Account Activity" +
         $"\n\n\t\t Dear {account.Name}," +
         $"\n\n\t\t\t A recent activity on your account occures at {transactionDate.ToString("yyyy-MM-dd hh:mm")}" +
         "\n\t\t\t\t ===> {0}" +
         $"\n\n\t\t Thank You,\n\t\t Bank." +
         $"\n\n\t\t--------------------------- ", transactionMessage);
        }
    }
}
