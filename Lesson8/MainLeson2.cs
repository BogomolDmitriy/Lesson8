using Lessons_2_Library;
using System;

namespace Lesson__1
{
    class MainLeson2
    {


        static void Main(string[] args)
        {
            int userInput;
            do
            {
                Console.WriteLine("Enter the job number:");
                userInput = Convert.ToInt32(Console.ReadLine());
                switch (userInput)
                {
                    case 1:
                        {
                            // Task№1

                            Console.WriteLine($"Task№1{Environment.NewLine}Enters 2 numbers " +
                                $"(A and B).{Environment.NewLine}Console solution (5*A+B^2)/(B-A)");
                            bool result;
                            double A;
                            double B;
                            do
                            {
                                Console.Write("Enter A=");
                                result = double.TryParse(Console.ReadLine(), out A);
                            } while (!result);

                            do
                            {
                                Console.Write("Enter B=");
                                result = double.TryParse(Console.ReadLine(), out B);
                            } while (!result);

                            if (A == 0 && B == 0)
                            {
                                Console.WriteLine("The entered values (A), (B) must not equal zero");
                                return;
                            }

                            Console.WriteLine($"Console solution{Environment.NewLine}" +
                                $"(5 * {A} + {B}^2) / ({B} - {A}) = {LessonsHomeWork2.Task1(A, B)}");

                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }

                    case 2:
                        {
                            //Task№2
                            Console.WriteLine($"Task№2{Environment.NewLine}(The user enters 2 string values (A and B)." +
                    $"{Environment.NewLine}(Swap the contents of variables A and B.");
                            
                            Console.Write("Enter A=");
                            string A = Console.ReadLine();
                            Console.Write("Enter B=");
                            string B = Console.ReadLine();
                            LessonsHomeWork2.Task2(ref A, ref B);
                            Console.WriteLine($"A={A}{Environment.NewLine}" +
                                $"B={B}");

                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }

                    case 3:
                        {
                            //Task№3

                            Console.WriteLine($"Task№3{Environment.NewLine}The user enters 2 numbers (A and B).{Environment.NewLine}" +
                                $"Print to the console the result of dividing A by B and the remainder of the division.");
                            bool result;
                            double A;
                            double B;
                            do
                            {
                                Console.Write("Enter A=");
                                result = double.TryParse(Console.ReadLine(), out A);
                            } while (!result);

                            do
                            {
                                Console.Write("Enter B=");
                                result = double.TryParse(Console.ReadLine(), out B);
                            } while (!result);

                            (double division, double remainder) = LessonsHomeWork2.Task3(A, B);

                            Console.WriteLine($"{A} / {B} = {division}{Environment.NewLine}" +
                                $"%={remainder}");

                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }

                    case 4:
                        {
                            //Task№4

                            Console.WriteLine($"Task№4{Environment.NewLine}The user enters 3 non-equal 0 numbers " +
                                $"(A, B and C).{Environment.NewLine}Output to the console the solution (X value) of the " +
                                $"standard linear equation, where A * X + B = C.");
                            bool result;
                            double A;
                            double B;
                            double C;
                            do
                            {
                                Console.Write("Enter A=");
                                result = double.TryParse(Console.ReadLine(), out A);
                            } while (!result);

                            do
                            {
                                Console.Write("Enter B=");
                                result = double.TryParse(Console.ReadLine(), out B);
                            } while (!result);

                            do
                            {
                                Console.Write("Enter C=");
                                result = double.TryParse(Console.ReadLine(), out C);
                            } while (!result);

                            Console.WriteLine($"{A} * X + {B} = {C}{Environment.NewLine}" +
                                $"x = ({C} - {B}) / {A}{Environment.NewLine}" +
                                $"x={LessonsHomeWork2.Task4(A, B, C)}");

                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }

                    case 5:
                        {
                            //Task№5

                            Console.WriteLine($"Task№5{Environment.NewLine}The user enters 4 numbers(X1, Y1, X2, Y2) " +
                                $"describing the coordinates of 2 points on the coordinate plane.{Environment.NewLine}" +
                                $"Output the equation of a straight line in the format Y = AX + B passing through these points.");
                            bool result;
                            double X1;
                            double X2;
                            double Y1;
                            double Y2;
                            do
                            {
                                Console.Write("Enter X1=");
                                result = double.TryParse(Console.ReadLine(), out X1);
                            } while (!result);

                            do
                            {
                                Console.Write("Enter X2=");
                                result = double.TryParse(Console.ReadLine(), out X2);
                            } while (!result);

                            do
                            {
                                Console.Write("Enter Y1=");
                                result = double.TryParse(Console.ReadLine(), out Y1);
                            } while (!result);

                            do
                            {
                                Console.Write("Enter Y2=");
                                result = double.TryParse(Console.ReadLine(), out Y2);
                            } while (!result);

                            (double A, double B) = LessonsHomeWork2.Task5(X1, Y1, X2, Y2);

                            Console.WriteLine($"Y={A}X+{B}");

                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Tasks solving is over");
                            break;
                        }
                }
            }
            while (userInput != 0);
        }
    }
}