using System;
namespace csharp_bank{
    class Program{
        static void Main(string[] args){

            Account account; 

            Console.Write("Informe o número da conta: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Informe o titular da conta: ");
            string name = Console.ReadLine();
            
            Console.Write("Haverá depósito inicial [s/n]? ");
            char resp = char.Parse(Console.ReadLine()); 
            

            if (resp == 'S' || resp == 's'){
                Console.Write("Informe o valor inicial: ");
                double value = double.Parse(Console.ReadLine());
                account = new Account(number, name, value);
            }else{
                account = new Account(number, name);
            } 


            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(account); 

            Console.Write("Informe um valor para depósito: ");
            double balance = double.Parse(Console.ReadLine());
            account.BankDeposit(balance); 

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(account); 

            Console.Write("Informe um valor para saque: ");
            balance = double.Parse(Console.ReadLine());
            account.BankDraft(balance);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(account); 

            
        }
    }
}