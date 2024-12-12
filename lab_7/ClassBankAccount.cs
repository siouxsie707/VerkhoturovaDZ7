using System;

public enum AccountType
{
    Savings,
    Checking,
    Business
}

namespace BankAccountAndBuilding
{
    public class BankAccount
    {
        private static int nextAccountNumber = 0;
        private string accountNumber;
        private decimal balance;
        private AccountType accountType;

        public BankAccount(AccountType accountType, string accountNumber)
        {
            this.accountType = accountType;
            this.accountNumber = accountNumber;
            this.balance = 0; // Начальный баланс
        }

        public static string GenerateUniqueAccountNumber()
        {
            nextAccountNumber++;
            return nextAccountNumber.ToString().PadLeft(20, '0');
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Номер счета: {accountNumber}, Тип счета: {accountType}, Баланс: {balance:C}");
        }

        public void SetBalance(decimal initialBalance)
        {
            balance = initialBalance;
        }

        public decimal GetBalance()
        {
            return balance;
        }
        
        // Упражнение 8.1
        public void Transfer(BankAccount targetAccount, decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Сумма должна быть положительной.");
            }

            if (balance < amount)
            {
                throw new InvalidOperationException("Недостаточно средств.");
            }

            balance -= amount;       
            targetAccount.balance += amount;

            Console.WriteLine($"Переведено {amount:C} со счета {accountNumber} на счет {targetAccount.accountNumber}.");
        }
    }
}