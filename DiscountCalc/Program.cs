// < 10 - 1%
//10 && 20 - 5%
//>= 20 - 10 %

Console.WriteLine("Total");
int UserInput = Int32.Parse(Console.ReadLine());
double discount = CalculateDiscount(UserInput);

Console.WriteLine($"Discount {discount}%");

double newTotal = CalculateNewTotal(UserInput,discount);


Console.WriteLine($"new discount with {discount}% {newTotal}");
static double CalculateDiscount(int total)
{
    if(total < 10)
    {
        return 1;
    }    
    else if(total >= 20 && total < 20 ) 
    { 
        return 5;
    }
    else 
    {
        return 10;
    }
}

static double CalculateNewTotal(double total, double discount)
{
    double result = total - (total * discount) / 100;
    return result;
}