using System;
namespace csharp_bank{
    class Program{
        static void Main(string[] args){
            Account account = new Account(1234, "Alex Green"); 

            account.OwnerAccount = "Alex Black";

            Console.WriteLine(account.AccountNumber);
            Console.WriteLine(account.OwnerAccount);
            Console.WriteLine(account.BankBalance);

            account.BankDeposit(200); 
            Console.WriteLine(account.BankBalance);
            account.BankDraft(198); 
            Console.WriteLine(account.BankBalance);

           
            
        }
    }
}