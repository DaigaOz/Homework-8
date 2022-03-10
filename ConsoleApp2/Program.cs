// See https://aka.ms/new-console-template for more information
// TASK 3
// HOMEWORK 
// ADVANCED CALCULATOR

Console.WriteLine("Let's do some math!");

float result = 0;
Console.WriteLine("Please enter first number!");
float num1 = float.Parse(Console.ReadLine());

Console.WriteLine("Enter second number!");
float num2 = float.Parse(Console.ReadLine());

Console.WriteLine("Enter operator!");
string op = Console.ReadLine();

    switch (op)
{
    case "+": result = num1 + num2;
        break;
    case "-": result = num1 - num2;
        break;
    case "/": result = num1 / num2;
        break;
    case "*": result = num1 * num2;
        break;
    case "%": result = num1 % num2;
        break;
    case "p":
        Convert.ToString(result) = string(Convert.ToString(num1) + Convert.ToString(num2));
        break;
   
}
Console.WriteLine("Result = " + result);
