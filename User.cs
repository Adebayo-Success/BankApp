
public class UserLoginSystem
{
    public string UserName {get; set;}
    public string PhoneNumber {get; set;}
    public string Password {get; set;}
    public decimal Balace {get; set;} 
    public UserLoginSystem(string userName, string phoneNumber, string password, decimal balance)
    {
        UserName = userName;
        PhoneNumber = phoneNumber;
        Password = password;
        Balace = 0; // default
    }
}