namespace Calculator.Classes
{
    class Security
    {
        public void checking()
        {
            string password;
            do
            {
                Console.Write("Enter the password for continuing the program: ");
                password = Console.ReadLine();
                if (password != "pa$$w0rd")
                {
                    Console.WriteLine("You typed wrong password, please type again!");
                }
            }
            while (password != "pa$$w0rd");
        }
    }
}