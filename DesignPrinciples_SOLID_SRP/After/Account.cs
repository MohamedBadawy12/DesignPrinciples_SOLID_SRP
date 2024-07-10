namespace DesignPrinciples_SOLID_SRP.After
{
    internal class Account
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Balance { get; set; }
        public Account(string name, string email, decimal balnace)
        {
            Name = name;
            Email = email;
            Balance = balnace;
        }
    }
}
