//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

start:
double firstvalue, secoundvalue;
string operatorV;

Console.WriteLine("Введите первое значение: ");
firstvalue = Double.Parse(Console.ReadLine());

Console.WriteLine("Введите второе значение: ");
secoundvalue = Double.Parse(Console.ReadLine());

Console.WriteLine("Выберите медод операции: + | - | * | / |");
operatorV = Console.ReadLine();

switch (operatorV)
{
    case "+":
        Console.WriteLine(firstvalue + secoundvalue);
        goto start;

    case "-":
        Console.WriteLine(firstvalue - secoundvalue);
        goto start;

    case "*":
        Console.WriteLine(firstvalue * secoundvalue);
        goto start;

    case "/":
        if (firstvalue == 0)
            Console.WriteLine(0);
        else if (secoundvalue == 0)
            Console.WriteLine(0);
        else
            Console.WriteLine(firstvalue / secoundvalue);
        goto start;

    default:
        Console.WriteLine("Неизвестная команда, повторите попытку!");
        goto start;
}
