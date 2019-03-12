namespace Heranca.Entities
{
    //sealed -> evita que a classe seja herdada
    class SavingAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingAccount() { }

        public SavingAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        //também evita que o método seja sobrescrita novamente
        public sealed override void Withdraw(double amount)
        {
            //chama a implementação da superclasse
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
