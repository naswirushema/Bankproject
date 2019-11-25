using System;
using bank.BankApp;
using BankApp;

namespace bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer();
            string firstname;
            string lastname;
            string gender;
            Console.WriteLine("what is your first name?");
            firstname = Console.ReadLine();
            cust.setFirstName(firstname);
            Console.WriteLine("what is your last name?");
            lastname = Console.ReadLine();
            cust.setLastName(lastname);
            Console.WriteLine("what is your gender?");
            gender = Console.ReadLine();
            cust.setGender(gender);

            int account_number;
            string account_type;
            string currency;
            Console.WriteLine("what is your account number?");
            account_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("what type account do you have");
            account_type = Console.ReadLine();
            Console.WriteLine("in which currency?");
            currency = Console.ReadLine();
            
            Account acc = new Account(account_number, account_type, currency);
                
            Console.WriteLine("Enter amount to deposit");
            double depositAmount;
            depositAmount = Convert.ToDouble(Console.ReadLine());
            acc.deposit(depositAmount);
               
            Console.WriteLine("Enter amount to withdraw");
            double withdrawAmount;
            withdrawAmount = Convert.ToDouble(Console.ReadLine());
            acc.withdraw(withdrawAmount);
              
        }
    }
}
        
    
