using Calculator.Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        Security check = new Security();
        Calculatr amal = new Calculatr();

        check.checking();
        amal.amal1();

        string message =
            amal.mantiq()
                ? "1-son ikkinchisidan katta"
                : "2-son birinchisidan katta";
        Console.WriteLine(message);
        amal.taqqoslash();
        System.Console.WriteLine();
        amal.switchoperation();
        System.Console.WriteLine();
        amal.switchresult();
        System.Console.WriteLine();
        amal.myfriends();
        amal.karra();
    }
}