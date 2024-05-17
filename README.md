# NumericInput

[Korean](./README.md) | [English](./README_EN.md)

C#에서 숫자 입력을 받는 작업을 간소화하고 입력 검증을 쉽게 해주는 라이브러리입니다.
기존 `Console.ReadLine()` 을 사용하여 숫자를 입력받으려면 문자열에서 숫자로 형변환을 해야하는데 
이 라이브러리는 해당 작업을 조금 간소화 시킬 수 있습니다.

## 설치
`dotnet add package NumericInput --version 1.0.1` 명령어로 설치 후
`using NumericInput;` 을 통해 라이브러리 사용이 가능합니다.

### 기능
- `ReadInteger()`: 사용자로부터 정수 입력을 받고, 유효한 정수가 입력 될 때까지 반복적으로 입력을 요청합니다.
- `ReadDouble()`: 사용자로부터 실수 입력을 받고, 유효한 실수가 입력 될 때까지 반복적으로 입력을 요청합니다.
- `IsVaildNum(string value)`: 주어진 문자열이 유효한 숫자인지 확인합니다.

## 사용 예시

### 기존 입력 방식
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

### NumericInput 라이브러리 적용 후
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

## 기여하기
이 프로젝트에 기여하고 싶으시다면 Issues 또는 Pull Request를 열어주세요! 모든 기여는 환영합니다!


