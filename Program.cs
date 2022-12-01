string password;
do
{
    System.Console.Write("Enter the password for continuing the program: ");
    password=System.Console.ReadLine();
    if(password!="pa$$w0rd")
    {
        System.Console.WriteLine("You typed wrong password, please type again!");
    }
}
while(password!="pa$$w0rd");

System.Console.WriteLine("Here I Started a calculator program");
System.Console.Write("Isminggizni kiiriting: ");
string name= System.Console.ReadLine();
System.Console.Write("Yoshingizni kiriting: ");
int age = int.Parse(System.Console.ReadLine());
System.Console.Write("1-sonni kiriting: ");
int a = int.Parse(System.Console.ReadLine());
System.Console.Write("2-sonni kiriting: ");
int b = int.Parse(System.Console.ReadLine());
System.Console.Write("Amallardan birini tanlang(+,-,*,/,%): ");
string operation = Console.ReadLine();

if(a>b)
{
    System.Console.WriteLine($"{a} + {b} = {a+b}");
}
else if(a<b)
{
    System.Console.WriteLine($"{a} - {b} = {a-b}");
}
else
{System.Console.WriteLine("Opertion not found");}

string message=
    a>=b
        ? "1-son ikkinchisidan katta"
        : "2-son birinchisidan katta";
System.Console.WriteLine(message);

// switch(operation)
// {
//     case "+":
//         Console.WriteLine($"{a} + {b} = {a+b}");
//         break;

//     case "-":
//         Console.WriteLine($"{a} - {b} = {a-b}");
//         break;

//     case "*":
//         Console.WriteLine($"{a} * {b} = {a*b}");
//         break;

//     case "/":
//         Console.WriteLine($"{a} / {b} = {a/b}");
//         break;

//     case "%":
//         Console.WriteLine($"{a} % {b} = {a%b}");
//         break;

//     default:
//         System.Console.WriteLine("Opertion not found");
//         break;
// }

string result = operation switch
{
    "+" => $"{a} + {b} = {a+b}",
    "-" => $"{a} - {b} = {a-b}",
    "*" => $"{a} * {b} = {a*b}",
    "/" => $"{a} / {b} = {a/b}",
    "%" => $"{a} % {b} = {a%b}",
    _   => "Operation not found"

};
System.Console.WriteLine(result);

System.Console.WriteLine();
string[] array1=new string[4];
array1[0]="Ali";
array1[1]="Vali";
array1[2]="Uli";
array1[3]=name;
int[] age_a={15,2,25,age};

for(int i=0; i<array1.Length;i++)
{
    System.Console.WriteLine($"{array1[i]}ning yoshi {age_a[i]}da");
}
