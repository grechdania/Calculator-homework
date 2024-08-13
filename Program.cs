Console.WriteLine("Enter the first number");
string? number_1_input = Console.ReadLine();
double number_1 = Double.Parse(number_1_input);

Console.WriteLine("Enter the operation");
string? operation = Console.ReadLine();

Console.WriteLine("Enter the second number");
string? number_2_input = Console.ReadLine();
double number_2 = Double.Parse(number_2_input);

double result = 0;

try
{
    double check_number_1 = Double.Parse(number_1_input);
}
catch (FormatException)
{
    Console.WriteLine($"Use numerical value for the first input '{number_1_input}'");
}

try
{
    double check_number_2 = Double.Parse(number_2_input);
}
catch (FormatException)
{
    Console.WriteLine($"Use numerical value for the second input '{number_2_input}'");
}

if (operation != "/" && operation != "*" && operation != "-" && operation != "+")
{
    Console.WriteLine($"Use /, *, +, or - for operation '{operation}'");
}

if (operation == "/" && number_2 == 0)
{
    Console.WriteLine("Can not devide by zero");
}
else
{
    switch (operation)
    {
        case "/":
            result = (number_1 / number_2);
            break;
        case "*":
            result = (number_1 * number_2);
            break;
        case "-":
            result = (number_1 - number_2);
            break;
        case "+":
            result = (number_1 + number_2);
            break;
    }

    Console.WriteLine($"Your result: {result}");
}




