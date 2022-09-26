//Andrew Moore Exam section 1

int sum = 0;
int num1 = 0;
int num2 = 0;

//Opening menu
Console.WriteLine("Hello.\nThis is a program that performs multiple actions.\n");
Console.WriteLine("\nEnter 1 for: A program that computes the sum of the two given integer values.\n" +
    "If the two values are the same it will return triple the sum.\n");
Console.WriteLine("\nEnter 2 for: A program that will return true if a given integer is 30 or the sum\n" +
    "of the two is 30.\n");
Console.WriteLine("\nEnter 3 for: A program that exchanges the first and last characters in a given string\n");
Console.WriteLine("\nEnter 4 for: A program to check if a given positive integer is a multiple of 3 or 7.\n");
Console.WriteLine("\nEnter 5 for: A program that concatenates two given strings. If there are any double\n" +
    "characters in the new string, it will omit one character.\n");
Console.WriteLine("Make your selection.");
int selection = Convert.ToInt32(Console.ReadLine());

//Functions being called based on selection
if (selection == 1)
{
    Question1(sum);
}
if (selection == 2)
{
    Console.WriteLine("Please enter the first number.");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\nPlease enter the second number.");
    num2 = Convert.ToInt32(Console.ReadLine());
    Question2(num1, num2);
}
if (selection == 3)
{
    Question3();
}
if (selection == 4)
{
    Question4();
}
if (selection == 5)
{
    Question5();
}
else
{
    Console.WriteLine("Invalid command. Please restart and enter 1 - 5");
}

//  1.	Write a C# Sharp program to compute the sum of the two given integer values.
//      If the two values are the same, then return triple their sum
static void Question1(int sum)
{
    Console.WriteLine("Please enter the first number.");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\nPlease enter the second number.");
    int num2 = Convert.ToInt32(Console.ReadLine());
    if (num1 == num2)
    {
        sum = (num1 + num2) * 3;
        Console.WriteLine("The value is " + sum);
    }
    else
    {
        sum = num1 + num2;
        Console.WriteLine("The value is " + sum);
    }
}

//  2.	Write a C# Sharp program to check two given integers, and return true if one of
//      them is 30 or if their sum is 30.
static bool Question2(int num1, int num2)
{
    if (num1 == 30 || num2 == 30 || num1 + num2 == 30)
    {
        Console.WriteLine("True");
        return true;
    }
    else
    {
        Console.WriteLine("False");
        return false;
    }
}

//  3.	Write a C# Sharp program to exchange the first and last characters in a given
//      string and return the new string.
static void Question3()
{
    Console.WriteLine("Please enter a string.");
    string beginString = Console.ReadLine();
    char[] charArray = new char[beginString.Length];
    for (int i = 0; i < beginString.Length ; i++)
    {
        charArray[i] = beginString[i];
    }
    char x = charArray[0];
    char y = charArray[charArray.Length - 1];
    charArray[charArray.Length - 1] = x;
    charArray[0] = y;
    string endString = new string(charArray);
    Console.WriteLine(endString);
}

//  4.	Write a C# Sharp program to check if a given positive number is a multiple of 3 or
//      a multiple of 7. 
static void Question4()
{
    Console.WriteLine("Please enter a positive number.");
    int num1 = Convert.ToInt32(Console.ReadLine());
    if(num1 % 7 == 0 || num1 % 3 == 0)
    {
        Console.WriteLine("This number is a multiple of 3 or 7.");
    }
    else
    {
        Console.WriteLine("This number is not a multiple of 3 or 7.");
    }
}

//  5.	Write a C# Sharp program to concat two given strings. If there are any double
//      character in new string then omit one character.
static void Question5()
{
    Console.WriteLine("Please enter your first string.");
    string s1 = Console.ReadLine();
    Console.WriteLine("Please enter your first string.");
    string s2 = Console.ReadLine();
    string s3 = !s1.EndsWith(s2.Substring(0, 1)) ? s1 + s2 : s1 + s2.Substring(1);
    Console.WriteLine(s3);
}

