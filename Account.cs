namespace csharp_bank;

public class Account
{
    private string _ownerAccount;

    public double BankBalance { get; private set; } 
    public int AccountNumber { get; private set; }
    

    public Account (int accountNumber, string ownerAccount, double initialValue) {
        AccountNumber = accountNumber;
        _ownerAccount = ownerAccount;
        BankBalance = initialValue;
    }

    public Account (int accountNumber, string ownerAccount) {
        AccountNumber = accountNumber;
        _ownerAccount = ownerAccount; 
        BankBalance = 0; 
    }

    public string OwnerAccount{
        get { return _ownerAccount; }
        
        set {
            if(value != null && value.Length > 2 ){
                _ownerAccount = value; 
            }
        }
    }

    public void BankDeposit(int value){
        if (value > 0 ) { BankBalance += value; } 
    }
}

