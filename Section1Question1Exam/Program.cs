// See https://aka.ms/new-console-template for more information
int sum = 0;
Console.WriteLine("Please enter the first number.");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\nPlease enter the second number.");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1 == num2)
{
    sum = (num1 + num2) * 3;
    Console.WriteLine("The value is " + sum);
}
else
{
    sum = num1 + num2;
    Console.WriteLine("The value is " + sum);
}


