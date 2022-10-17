using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            var input = Console.ReadLine();
            var calculator = new Calculator();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Enter 2 integers to add");
                    string addNumber1, addNumber2;
                    getInputs(out addNumber1, out addNumber2);

                    if (int.TryParse(addNumber1, out int addNumOne) && int.TryParse(addNumber2, out int addNumTwo))
                    {
                        Console.Write($"{addNumber1} + {addNumber2} = ");
                        Console.Write(calculator.Add(addNumOne, addNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "2":
                    Console.WriteLine("Enter 2 integers to subtract");
                    string subtractNumber1, subtractNumber2;
                    getInputs(out subtractNumber1, out subtractNumber2);

                    if (int.TryParse(subtractNumber1, out int subNumOne) && int.TryParse(subtractNumber2, out int subNumTwo))
                    {
                        Console.Write($"{subtractNumber1} - {subtractNumber2} = ");
                        Console.Write(calculator.Subtract(subNumOne, subNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "3":
                    Console.WriteLine("Enter 2 integers to multiply");
                    string multiplyNumber1, multiplyNumber2;
                    getInputs(out multiplyNumber1, out multiplyNumber2);
                   

                    if (int.TryParse(multiplyNumber1, out int multiplyNumOne) && int.TryParse(multiplyNumber2, out int multiplyNumTwo))
                        

                        {
                        Console.Write($"{multiplyNumber1} * {multiplyNumber2}= ");
                        Console.Write(calculator.Multiply(multiplyNumOne, multiplyNumTwo));
                    }

                    else
                    { 
                          Console.WriteLine("One or more of the numbers is not an int");

                    }
                    
                    break;

                case "4":
                    Console.WriteLine("Enter 2 integers to divide");
                    string divideNumber1, divideNumber2;
                    getInputs(out divideNumber1, out divideNumber2);

                  
                    if (double.TryParse(divideNumber1, out double divNumOne) && double.TryParse(divideNumber2, out double divNumTwo))
                    {
                        Console.Write($"{divideNumber1} / {divideNumber2} = ");
                        Console.Write(calculator.Divide(divNumOne, divNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                default:
                    Console.WriteLine("Unknown input");
                    break;
            }
        }

        private static void getInputs(out string number1, out string number2)
        {
            number1 = Console.ReadLine();
            number2 = Console.ReadLine();
        }
    }
}