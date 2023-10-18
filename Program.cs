

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a expression in the form 'number1 operation(+-*/) number2' separated by a space: \n");
            string expression = Console.ReadLine();
            string[] dataArray = expression.Split();

            int number1 = int.Parse(dataArray[0]);
            string op = dataArray[1];
            char operation = char.Parse(op);
            int number2 = int.Parse(dataArray[2]);
            int result = 0;


            if (operation == '+')
            {
                result = number1 + number2;
            }

            else if (operation == '-')
            {
                result = number1 - number2;
            }

            else if (operation == '*')
            {
                result = number1 * number2;
            }

            else if (operation == '/')
            {
                if (number2 != 0)
                    result = number1 / number2;
                else Console.WriteLine("You can't divide by 0!");
            }
            else
            {
                Console.WriteLine("Unknown operator");
            }

            Console.WriteLine(result);

        }
    }
}