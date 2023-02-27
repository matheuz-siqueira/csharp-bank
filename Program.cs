using System;
namespace csharp_bank{
    class Program{
        static void Main(string[] args){

            Console.Write("Informe o número da conta: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Informe o titular da conta: ");
            string name = Console.ReadLine();
            
            Console.Write("Haverá depósito inicial [s/n]? ");
            char resp = char.Parse(Console.ReadLine()); 
            double value = 0;

            if (resp == 'S' || resp == 's'){
                Console.Write("Informe o valor inicial: ");
                value = double.Parse(Console.ReadLine());
            } 

            Account account = new Account(number, name, value);

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(account.ToString()); 

            Console.Write("Informe um valor para depósito: ");
            double balance = double.Parse(Console.ReadLine());
            account.BankDeposit(balance); 

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(account.ToString()); 

            Console.Write("Informe um valor para saque: ");
            double draft = double.Parse(Console.ReadLine());
            account.BankDraft(draft);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(account.ToString()); 

            
        }
    }
}