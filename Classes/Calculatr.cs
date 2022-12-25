namespace Calculator.Classes
{
    class Calculatr
    {
        public string UserName { get; set; }
        public int UserAge { get; set; }
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public string Operation { get; set; }

        public void amal1()
        {
            Console.WriteLine("Here I Started FirstNumbercalculator program");
            Console.Write("Isminggizni kiiriting: ");
            UserName = Console.ReadLine();
            Console.Write("Yoshingizni kiriting: ");
            UserAge = int.Parse(Console.ReadLine());
            Console.Write("1-sonni kiriting: ");
            FirstNumber = int.Parse(Console.ReadLine());
            Console.Write("2-sonni kiriting: ");
            SecondNumber = int.Parse(Console.ReadLine());
            Console.Write("Amallardan birini tanlang(+,-,*,/,%): ");
            Operation = Console.ReadLine();
        }

        public void taqqoslash()
        {
            if (FirstNumber> SecondNumber)
        {
            Console.WriteLine($"{FirstNumber} + {SecondNumber} = {FirstNumber+ SecondNumber}");
        }
        else if (FirstNumber< SecondNumber)
        {
            Console.WriteLine($"{FirstNumber} - {SecondNumber} = {FirstNumber- SecondNumber}");
        }
        else
        { 
            Console.WriteLine("Operation not found"); 
        }
        }

        public bool mantiq()
        {
            return FirstNumber>= SecondNumber;
        } 

        public void switchoperation()
        {
            switch(Operation)
                {
                    case "+":
                        Console.WriteLine($"{FirstNumber} + {SecondNumber} = {FirstNumber+SecondNumber}");
                        break;

                    case "-":
                        Console.WriteLine($"{FirstNumber} - {SecondNumber} = {FirstNumber-SecondNumber}");
                        break;

                    case "*":
                        Console.WriteLine($"{FirstNumber} * {SecondNumber} = {FirstNumber*SecondNumber}");
                        break;

                    case "/":
                        Console.WriteLine($"{FirstNumber} / {SecondNumber} = {FirstNumber/SecondNumber}");
                        break;

                    case "%":
                        Console.WriteLine($"{FirstNumber} % {SecondNumber} = {FirstNumber%SecondNumber}");
                        break;

                    default:
                        System.Console.WriteLine("Opertion not found");
                        break;
                }
        }

        public void switchresult()
        {
            string result = Operation switch
            {
                "-" => $"{FirstNumber} - {SecondNumber} = {FirstNumber- SecondNumber}",
                "+" => $"{FirstNumber} + {SecondNumber} = {FirstNumber+ SecondNumber}",
                "*" => $"{FirstNumber} * {SecondNumber} = {FirstNumber* SecondNumber}",
                "/" => $"{FirstNumber} / {SecondNumber} = {FirstNumber/ SecondNumber}",
                "%" => $"{FirstNumber} % {SecondNumber} = {FirstNumber% SecondNumber}",
                _ => "Operation not found"
            };
            Console.WriteLine(result);
        }

        public void myfriends()
        {
            string[] array1 = new string[4];
            array1[0] = "Ali";
            array1[1] = "Vali";
            array1[2] = "Uli";
            array1[3] = UserName;
            int[] ages= { 15, 2, 25, UserAge };
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine($"{array1[i]}ning yoshi {ages[i]}da");
            }
            System.Console.WriteLine();
        }

        public void karra()
        {
            for(int i=0;i<11;i++)
            {
                for(int j=0;j<11;j++)
                {
                    System.Console.WriteLine($"{i} * {j} = {i*j}");
                    
                }
                System.Console.WriteLine("\n");
            }
        }

    }
}