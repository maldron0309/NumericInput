# NumericInput

[Korean](./README.md) | [English](./README_EN.md)

NumericInput is a library that simplifies the task of receiving numeric input and input validation in C#. When using `Console.ReadLine()` to receive numeric input, you need to convert the string to a number. This library streamlines that process.

## Installation
After installation with the command `dotnet add package NumericInput --version 1.0.1`, 
To use the library, include `using NumericInput;` in your code.

### Features
- `ReadInteger()`: Prompts the user for an integer input and repeatedly requests input until a valid integer is entered.
- `ReadDouble()`: Prompts the user for a double input and repeatedly requests input until a valid double is entered.
- `IsVaildNum(string value)`: Checks if the given string is a valid number.

## Usage Examples

### Traditional Input Method
```cs
class Program
{
    static void Main(string[] args)
    {
        // Read an integer
        Console.Write("Enter an integer: ");
        string intInput = Console.ReadLine();
        int intValue;
        while (!int.TryParse(intInput, out intValue))
        {
            Console.WriteLine("Invalid input. Please enter an integer.");
            Console.Write("Enter an integer: ");
            intInput = Console.ReadLine();
        }
        Console.WriteLine($"You entered: {intValue}");

        // Read a double
        Console.Write("Enter a decimal number: ");
        string doubleInput = Console.ReadLine();
        double doubleValue;
        while (!double.TryParse(doubleInput, out doubleValue))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            Console.Write("Enter a decimal number: ");
            doubleInput = Console.ReadLine();
        }
        Console.WriteLine($"You entered: {doubleValue}");

        // Use IsValidNum
        Console.Write("Enter a number or text: ");
        string input = Console.ReadLine();
        double value;
        if (double.TryParse(input, out value))
        {
            Console.WriteLine($"You entered a valid number: {value}");
        }
        else
        {
            Console.WriteLine($"'{input}' is not a valid number.");
        }
    }
}
```

### Using NumericInput Library
```cs
using NumericInput;

class Program
{
    static void Main(string[] args)
    {
        // Read an integer
        Console.Write("Enter an integer: ");
        int intValue = Numeric.ReadInteger();
        Console.WriteLine($"You entered: {intValue}");

        // Read a double
        Console.Write("Enter a decimal number: ");
        double doubleValue = Numeric.ReadDouble();
        Console.WriteLine($"You entered: {doubleValue}");

        // Use IsValidNum
        Console.Write("Enter a number or text: ");
        string input = Numeric.ReadInput();

        if (Numeric.IsValidNum(input))
        {
            double value = double.Parse(input);
            Console.WriteLine($"You entered a valid number: {value}");
        }
        else
        {
            Console.WriteLine($"'{input}' is not a valid number.");
        }
    }
}
```

## Contributing
If you'd like to contribute to this project, please open an Issue or a Pull Request. All contributions are welcome!


