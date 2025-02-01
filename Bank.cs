
using System.Text.RegularExpressions;

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
        bool isValidated = false;
        string userName;
        do
        {
            Console.WriteLine("Enter your User Name");
            userName = Console.ReadLine()!;
            isValidated = ValidateUserName(userName);
        }
        while (isValidated != true);
        string phoneNumber;
        do
        {
            Console.WriteLine("Enter your Phone Number");
            phoneNumber = Console.ReadLine()!;
            isValidated = ValidatePhoneNumber(phoneNumber);
        }
        while (isValidated != true);
        string password;
        do
        {
            Console.WriteLine("Create a Password");
            password = Console.ReadLine()!;
            isValidated = ValidatePassword(password);
        }
        while (isValidated != true);

        UserLoginSystem userLoginSystem = new UserLoginSystem(userName, phoneNumber, password);
        users.Add(userLoginSystem);
        Console.WriteLine("Account created successfully");
    }

    public void Deposit()
    {

    }

    public void Transfer()
    {
        
    }

    public void Withdraw()
    {

    }
    public void ViewAllAccount()
    {   
        foreach(var ban in users)
        {
            Console.WriteLine(ban);
        }
    }
    public bool ValidateUserName(string userName)
    {
        if (userName.Length < 3)
        {
            Console.WriteLine("Username must not be less than three charactrers");
            return false;
        }
        string namePattern = @"^[a-zA-Z@]+(?: [a-zA-Z@]+)*$";
        if (!Regex.IsMatch(userName, namePattern))
        {
            return false;
        }
        return true;
    }
    public bool ValidatePhoneNumber(string phoneNumber)
    {
        string phoneNumberPattern = @"^\d+ $";
        if (Regex.IsMatch(phoneNumber, phoneNumberPattern))
        {
            throw new Exception("Phone number can not contain a special character(s).");
        }
        if (phoneNumber.Length < 11 || phoneNumber.Length > 11)
        {
            Console.WriteLine("Phone number must be at least 11 digit.");
            return false;
        }
        return true;
    }
    public bool ValidatePassword(string password)
    {
        string passwordPattern = @"^\d+ $";
        if (Regex.IsMatch(password, passwordPattern))
        {
            Console.WriteLine("password can not contain a special characters");
            return false;
        }
        if (password.Length < 6 || password.Length > 6)
        {
            Console.WriteLine("password must not be less than or greater than six numbers");
            return false;
        }
        return true;
    }


}
