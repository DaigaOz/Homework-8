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
    case "%": result = num1 / num2 * 100;
        break;
    case "p": result =
        break;
    case "b": result =
        break;
    case "s": result =
        break;

}
Console.WriteLine("Result = " + result);
