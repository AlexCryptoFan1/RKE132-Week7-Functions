Console.WriteLine("enter operation (+/-)");
char userOperator = Char.Parse(Console.ReadLine());
Console.WriteLine("a");
int firstNum = Int32.Parse(Console.ReadLine());
Console.WriteLine("b");
int secondNum = Int32.Parse(Console.ReadLine());

switch (userOperator)
{
    case '+':
        Addition(firstNum, secondNum);
        break;
    case '-':
        Substraction(firstNum, secondNum);
        break;
    default:
        Console.WriteLine("invalid");
        break;
}    

static void Addition(int a, int b)
{
    Console.WriteLine($"{a} + {b} = {a + b}");
}

static void Substraction (int a, int b)
{
    Console.WriteLine($"{a} - {b} = {a - b}");
}


