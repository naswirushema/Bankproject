

    
        using System;

        namespace BankApp
        {
        public class Account
        {
            private int account_number;
            private string account_type;
            private string currency;
            private double initialBalance;

            public Account(int account_number, string account_type, string currency)
            {
                this.account_number = account_number;
                this.account_type = account_type;
                this.currency = currency;

                if (currency.ToLower().Equals("frw"))
                {
                    this.initialBalance = 50000;
                }else if (currency.ToLower().Equals("usd") || currency.ToLower().Equals("euro"))
                {
                    this.initialBalance = 50;
                }
            
            }

            public void deposit(double amount)
            {
                if (amount != 0)
                {
                    initialBalance = initialBalance + amount;
                    Console.WriteLine($"your new balance is {initialBalance}");
                }
                else
                {
                    Console.WriteLine("Sorry you can not deposit 0 amount");
                }
            }

            public void withdraw(double amount)
            {
                if (amount <= initialBalance)
                {
                    if (amount!= 0)
                    {
                        initialBalance = initialBalance - amount;
                        Console.WriteLine($"your new balance is {initialBalance}");
                    }
                    else
                    {
                        Console.WriteLine("You can not withdraw with 0 amount");  
                    }
                }
                else
                {
                    Console.WriteLine("Insufficient balance on your account");
                }
            }

        }
    
    
}