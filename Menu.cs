public class Menu : Bank
{
    public Menu()
    {
        bankRepository = new Bank();
        users = [];
    }
    private IBank bankRepository;
    private List<UserLoginSystem> users;

    public void MyMenu()
    {

        bool running = true;
        while (running)
        {
            Console.WriteLine("Enter your option:");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("0. Exit");

            Console.WriteLine("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine()!);

            switch (choice)
            {
                case 1:
                    bankRepository.CreateAccount();
                    break;
                case 0:
                    running = false;
                    break;
            }
        }
    }

}