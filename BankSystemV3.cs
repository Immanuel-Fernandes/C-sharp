using System;

enum AccountType
{
    Current,
    Saving
}

class BankAccount
{
    private string name;
    private int accountNumber;
    private AccountType accountType;
    private double balance;
    private string password;

    public BankAccount(string name, AccountType accountType, string password, int accountNumber)
    {
        this.name = name;
        this.accountNumber = accountNumber;
        this.accountType = accountType;
        this.password = password;
        this.balance = 1500; // Minimum balance
    }

    public bool VerifyPassword(string password)
    {
        return this.password == password;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine("Deposited {0}. New Balance: {1}", amount, balance);
        }
        else
        {
            Console.WriteLine("Deposit amount should be positive.");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && balance >= amount)
        {
            balance -= amount;
            Console.WriteLine("Withdrew {0}. New Balance: {1}", amount, balance);
        }
        else
        {
            Console.WriteLine("Insufficient balance or invalid amount.");
        }
    }

    public void Display()
    {
        Console.WriteLine("Account Holder: {0}, Account Number: {1}, Account Type: {2}, Balance: {3}", name, accountNumber, accountType, balance);
    }

    public int GetAccountNumber()
    {
        return accountNumber;
    }
}

class Bank
{
    private const int MAX_CUSTOMERS = 10;
    private BankAccount[] accounts = new BankAccount[MAX_CUSTOMERS];
    private int numCustomers = 0;
    private string empID = "18023";
    private string empPassword = "2024";

    public Bank()
    {
        CreateNewAccount("James", AccountType.Current, "1234");
        CreateNewAccount("Peter", AccountType.Saving, "1234");
        CreateNewAccount("Paul", AccountType.Current, "1234");
        CreateNewAccount("Jude", AccountType.Current, "1234");
        CreateNewAccount("Mark", AccountType.Saving, "1234");
        CreateNewAccount("John", AccountType.Current, "1234");
        // CreateNewAccount("Adolf", AccountType.Current, "1234");
        // CreateNewAccount("Thomas", AccountType.Saving, "1234");
        // CreateNewAccount("Joshua", AccountType.Current, "1234");
    }

    public void BankerLogin()
    {
        Console.WriteLine("Enter Employee ID:");
        string enteredEmpID = Console.ReadLine();
        Console.WriteLine("Enter Password:");
        string enteredPassword = Console.ReadLine();

        if (enteredEmpID == empID && enteredPassword == empPassword)
        {
            Console.WriteLine("Banker logged in successfully.");
            BankerMenu();
        }
        else
        {
            Console.WriteLine("Invalid Employee ID or Password. Exiting...");
        }
    }

    private void BankerMenu()
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\nBanker Options:");
            Console.WriteLine("1. Add Customer");
            Console.WriteLine("2. Remove Customer");
            Console.WriteLine("3. Display All Customers");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Select account type:");
                    Console.WriteLine("1. Current");
                    Console.WriteLine("2. Saving");
                    AccountType accountType;
                    if (Console.ReadLine() == "1")
                        accountType = AccountType.Current;
                    else
                        accountType = AccountType.Saving;
                    Console.Write("Enter password: ");
                    string password = Console.ReadLine();
                    CreateNewAccount(name, accountType, password);
                    break;

                case 2:
                    Console.Write("Enter account number to remove: ");
                    int accountNumberToRemove;
                    if (!int.TryParse(Console.ReadLine(), out accountNumberToRemove))
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                        continue;
                    }
                    RemoveCustomer(accountNumberToRemove);
                    break;

                case 3:
                    DisplayAllCustomers();
                    break;

                case 0:
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

     public void CreateNewAccount(string name, AccountType accountType, string password)
    {
        if (numCustomers < accounts.Length)
        {
            int accountNumber = GenerateAccountNumber();
            BankAccount account = new BankAccount(name, accountType, password, accountNumber);
            accounts[numCustomers] = account;
            numCustomers++;
            Console.WriteLine("Added customer: {0}", account.GetAccountNumber());
        }
        else
        {
            Console.WriteLine("Bank is full. Cannot add more customers.");
        }
    }

    private void RemoveCustomer(int accountNumber)
    {
        int index = -1;
        for (int i = 0; i < accounts.Length; i++)
        {
            if (accounts[i] != null && accounts[i].GetAccountNumber() == accountNumber)
            {
                index = i;
                break;
            }
        }

        if (index != -1)
        {
            accounts[index] = null; // Clear the cell
            Console.WriteLine("Removed customer with Account Number: {0}", accountNumber);
        }
        else
        {
            Console.WriteLine("Account not found.");
        }
    }

    private void DisplayAllCustomers()
    {
        for (int i = 0; i < numCustomers; i++)
        {
            accounts[i].Display();
        }
    }

    public void CustomerMenu()
    {
        Console.WriteLine("\nWelcome, Customer!");

        // Verify account details
        Console.Write("Enter your account number: ");
        int accountNumber;
        if (!int.TryParse(Console.ReadLine(), out accountNumber))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            return;
        }
        Console.Write("Enter your password: ");
        string password = Console.ReadLine();

        BankAccount customerAccount = VerifyAccount(accountNumber, password);

        if (customerAccount != null)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nCustomer Options:");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Account Balance");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");
                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter amount to deposit: ");
                        double depositAmount;
                        if (!double.TryParse(Console.ReadLine(), out depositAmount))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid amount.");
                            continue;
                        }
                        customerAccount.Deposit(depositAmount);
                        break;

                    case 2:
                        Console.Write("Enter amount to withdraw: ");
                        double withdrawAmount;
                        if (!double.TryParse(Console.ReadLine(), out withdrawAmount))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid amount.");
                            continue;
                        }
                        customerAccount.Withdraw(withdrawAmount);
                        break;

                    case 3:
                        customerAccount.Display();
                        break;

                    case 0:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid account number or password. Exiting...");
        }
    }

    private BankAccount VerifyAccount(int accountNumber, string password)
    {
        for (int i = 0; i < numCustomers; i++)
        {
            if (accounts[i].GetAccountNumber() == accountNumber && accounts[i].VerifyPassword(password))
            {
                return accounts[i];
            }
        }
        return null;
    }

    private int GenerateAccountNumber()
    {
        int startingNumber = 19000;
        int increment = 10;
        int accountNumber;

        do
        {
            accountNumber = startingNumber + increment * numCustomers; // Calculate next account number
            bool found = false;

            // Check if the account number already exists
            foreach (var account in accounts)
            {
                if (account != null && account.GetAccountNumber() == accountNumber)
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                break; // Exit the loop if unique account number found
            }

        } while (true); // Loop until unique account number is found

        return accountNumber;
    }



    static void Main(string[] args)
    {
        Bank bank = new Bank();

        bool exitProgram = false;
        while (!exitProgram)
        {
            Console.WriteLine("Are you a Banker or Customer? Enter 'Banker' or 'Customer':");
            string userType = Console.ReadLine();

            if (userType.ToLower() == "banker")
            {
                bank.BankerLogin();
            }
            else if (userType.ToLower() == "customer")
            {
                bank.CustomerMenu();
            }
            else
            {
                Console.WriteLine("Invalid user type.");
            }

            // Ask whether to continue or exit
            Console.WriteLine("\nDo you want to perform another transaction? (yes/no)");
            string continueOption = Console.ReadLine();
            if (continueOption.ToLower() != "yes")
            {
                exitProgram = true;
            }
        }

        Console.WriteLine("Bank Closed");
    }
}
