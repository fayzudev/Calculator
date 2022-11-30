System.Console.WriteLine("Here I Started a calculator program");
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
        ? "saadsad"
        : "dsada";
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

