namespace csharp_bank;

public class Account
{
    private string _ownerAccount;

    public double BankBalance { get; private set; } 
    public int AccountNumber { get; private set; }
    
     public Account (int accountNumber, string ownerAccount) {
        AccountNumber = accountNumber;
        _ownerAccount = ownerAccount; 
    }
    public Account (int accountNumber, string ownerAccount, double initialValue) : this (accountNumber, ownerAccount) {
        BankDeposit(initialValue);
    }

   

    public string OwnerAccount{
        get { return _ownerAccount; }
        
        set {
            if(value != null && value.Length > 2 ){
                _ownerAccount = value; 
            }
        }
    }

    public void BankDeposit(double value){
        if (value > 0 ) { BankBalance += value; } 
    }

    public void BankDraft(double     value){
        BankBalance -= (value + 5); 
    }

    public override string ToString()
    {
        return $"Conta {AccountNumber}, Titular: {OwnerAccount}, Saldo: {BankBalance.ToString("C")}";

    }
}

