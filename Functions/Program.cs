
Console.WriteLine("Are u coming or leavin'? (in/out)");
string userChoice = Console.ReadLine();
if(userChoice == "in")
{
    PrintHello();
}    
else
{
    PrintGoodBye();
}    

PrintHello();
PrintGoodBye();


static void PrintHello()
{
    Console.WriteLine("Hello, world!");
}

static void PrintGoodBye()
{
    Console.WriteLine("See ya later");
}
