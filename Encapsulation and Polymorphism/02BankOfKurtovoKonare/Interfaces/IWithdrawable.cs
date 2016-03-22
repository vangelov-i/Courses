
namespace _02BankOfKurtovoKonare.Interfaces
{
    interface IWithdrawable
    {
        void Withdraw(decimal amount);

        decimal Balance { get; set; }
    }
}
