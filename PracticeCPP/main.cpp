#include <iostream>
#include <string>


class Calculator {
    public:
    void calculate() {
        int num1;
        int num2;
        char op;
        int result;
        while (true) {
            std::cout << "Enter First Number: ";
            std::cin >> num1;
            std::cout << "\nEnter Second Number: ";
            std::cin >> num2;
            std::cout << "\nEnter Operator: ";
            std::cin >> op;
            switch (op) {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                case '%':
                    result = num1 % num2;
                    break;
                default:
                    std::cout << "Invalid Operator!\n";
                    break;
            }
            std::cout << result;
            std::cout << "\nDo you want to continue? (y/n) ";
            std::string answer;
            std::cin >> answer;
            if (answer == "n") {
                break;
            }
        }
    }
};
int main()
{

    return 0;
}