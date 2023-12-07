namespace Program
{
    internal class BankAccount
    {
        private string accountNumber;
        private decimal balance = 0;

        public BankAccount(string accountNumber)
        {
            this.accountNumber = accountNumber;

        }

        public string deposite(int balance = 500)
        {
            string value;
            {

                this.balance += balance;
                value = $"You deposit Rs. {balance} from your acount. Now, your total amount is {this.balance}";

                return value;
            }
        }

        public string Withdraw(int balance = 500)
        {
            string value;
            {

                this.balance -= balance;
                value = $"You withdraw Rs. {balance} from your acount. Now, your total amount is {this.balance}";

                return value;
            }



        }
    }
}

