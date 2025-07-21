namespace Practice;

public class Calculator
{
    private List<int> _pastResults = new List<int>();
    public void Calculate()
    {
        int number1;
        int number2;
        int result = 0;
        char operation;
        
        while (true)
        {
            Console.WriteLine("Enter a number:");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number:");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter operation: + - * / %");
            operation = char.Parse(Console.ReadLine());
            result = operation switch
            {
                '+' => number1 + number2,
                '-' => number1 - number2,
                '*' => number1 * number2,
                '/' => number1 / number2,
                '%' => number1 % number2,
                _ => result

            };
            Console.WriteLine(result);

            _pastResults.Add(result);
            Console.WriteLine("Want to continue? y/n");
            string answer = Console.ReadLine();
            if (answer == "n")
            {
                Console.WriteLine("Previous results:");
                PrintResults();
                break;
            }
            Console.Clear();
        }
    }

    public void PrintResults()
    {
        foreach (var result in _pastResults)
        {
            Console.WriteLine(result);
        }
    }
    
}