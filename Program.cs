using System;

namespace module2;

class Program
{
    static void Main(string[] args)
    {
        Console.ReadKey();
    }
}
interface ITransaction
{
    void ExecuteTransaction();
    void CheckTransactionState();
}
class FinancialTransaction : ITransaction
{
    public int Amount { get; set; }
    public DateTime Date { get; set; }

    public FinancialTransaction(int amount, DateTime date)
    {
        Amount = amount;
        Date = date;
    }
    public virtual void ExecuteTransaction()
    { 
        Console.WriteLine("Виконуємо транзакцію...");   
    }
    public virtual void CheckTransactionState()
    {
        Console.WriteLine("Перевіряємо транзакцію");
    }
}
public class Transction
{
    public int TransactionID { get; set; }
    public string Description { get; set; }

    public Transction(int transactionid, string description)
    {
        TransactionID = transactionid;
        Description = description;
    }
    ~Transction()
    {
        Console.WriteLine($"Транзакція {TransactionID} відбулася");
    }
}

public class DepositTransaction : Transction
{
    public int DepositAmount { get; set; }
    public DateTime DepositDate { get; set; }

    public DepositTransaction(int transactionID, string description, int amount, DateTime date)
        : base(transactionID, description)
    {
        DepositAmount = amount;
        DepositDate = date;
    }
}

public class WithdrawalTransaction : Transction
{
    public int WithdrawlAmount { get; set; }
    public DateTime WithdrawlDate { get; set; }

    public WithdrawalTransaction(int transactionID, string description, int amount ,DateTime date)
        :base (transactionID, description)
    {
        WithdrawlAmount = amount;
        WithdrawlDate = date;
    }
}

class TransactionException : Exception
{
    public TransactionException(string message) : base(message)
    {
    }
}
class TransactionCompletedEventArgs : EventArgs
{
    public bool IsSuccessful { get; set; }

    public TransactionCompletedEventArgs(bool isSuccessful)
    {
        IsSuccessful = isSuccessful;
    }
}
