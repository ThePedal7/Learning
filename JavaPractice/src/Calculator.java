import java.util.Scanner;

public class Calculator
{
    public void Calculate()
    {
        Scanner scanner = new Scanner(System.in);
        int num1;
        int num2;
        String op;
        int result;
        String answer;

        while(true)
        {
           System.out.println("Enter first Number:");
           num1 = scanner.nextInt();
           System.out.println("Enter second Number:");
           num2 = scanner.nextInt();
           System.out.println("Enter the Operation:");
           op = scanner.next();
           result = switch (op)
            {
               case "+" -> num1 + num2;
               case "-" -> num1 - num2;
               case "*" -> num1 * num2;
               case "/" -> num1 / num2;
               case "%" -> num1 % num2;
                default -> 0;
            };

           System.out.println(result);
           System.out.println("Do you wish to continue? (y/n)");

            answer = scanner.next();

           if(answer.equals("n"))
           {
               break;
           }
        }
    }
}
