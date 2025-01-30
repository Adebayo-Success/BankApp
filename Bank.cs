
public class Bank : IBank
{
    private readonly List<UserLoginSystem> users;
    public Bank()
    {
        users = [];
    }
    public void CheckBalance()
    {

    }

    public void CreateAccount()
    {
        Console.WriteLine("Enter your User Name");
        string userName = Console.ReadLine()!;

        Console.WriteLine("Enter your Phone Number");
        string phoneNumber = Console.ReadLine()!;

        Console.WriteLine("Create a Password");
        string password = Console.ReadLine()!;

        decimal balance = 0.00M;
        UserLoginSystem userLoginSystem = new UserLoginSystem(userName, phoneNumber, password, balance);
        users.Add(userLoginSystem);
        Console.WriteLine("Account created successfully");
    }
    
    // public void Deposit()
    // {
        
    // }

    // public void Transfer()
    // {
         
    // }

    // public void Withdraw()
    // {
        
    // }
}