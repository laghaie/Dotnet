using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool a = true;
            //bool b = false;

            //bool c = a && b;
            //bool d = a || b;

            //Console.WriteLine(c);
            //Console.WriteLine(d);

            //Console.WriteLine("Enter Number One: ");
            //int numberOne = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Number Two: ");
            //int numberTwo = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Number Three: ");
            //int numberThree = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Number Four: ");
            //int numberFour = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Number Five: ");
            //int numberFive = Convert.ToInt32(Console.ReadLine());

            //int average = (numberOne + numberTwo + numberThree + numberFour + numberFive) / 5;

            //if (average <= 5)
            //    Console.WriteLine("Very Weak");
            //else if (average >= 6 && average <= 10)
            //    Console.WriteLine("Weak");
            //else if (average >= 11 && average <= 15)
            //    Console.WriteLine("Good");
            //else if (average >= 16 && average <= 20)
            //    Console.WriteLine("Very Good");
            //else
            //    Console.WriteLine("Out of range");


            //bool isSuccess = true;
            //string msg;

            //if (isSuccess)
            //    msg = "Success";
            //else
            //    msg = "Unsuccess";

            //msg = isSuccess ? "Success" : "Unsuccess";
            //msg = isSuccess ? "Success" :
            //     !isSuccess ? "Unsuccess" :
            //     "";

            //Console.WriteLine(msg);

            //Console.WriteLine("[0]: Red, [1]: Blue, [2]: Green, [3]: Pink");
            //Console.WriteLine("Enter your color:");

            //string selectedColor = Console.ReadLine();

            //switch (selectedColor)
            //{
            //    case "0":
            //        Console.WriteLine("Your color Red");
            //        break;
            //    case "1":
            //        Console.WriteLine("Your color Blur");
            //        break;
            //    case "2":
            //        Console.WriteLine("Your color Green");
            //        break;
            //    case "3":
            //        Console.WriteLine("Your color Pink");
            //        break;
            //    default:
            //        Console.WriteLine("Not Found!");
            //        break;
            //}


            //while (true)
            //{
            //    Console.WriteLine("OK");

            //    break;
            //}

            //int count = 1;
            //while (count <= 10)
            //{
            //    //count = count + 1;
            //    //count += 1;

            //    Console.WriteLine(count);
            //    count++;
            //}

            Console.WriteLine("Enter number of iteriation");
            short numberOfLoop = Convert.ToInt16(Console.ReadLine());
            short index = 0;
            int entredNumber = 0;

            while (index < numberOfLoop)
            {
                Console.Write($"Enter number {++index}: ");
                entredNumber += int.Parse(Console.ReadLine());
                //index++;
            }

            int average = entredNumber / numberOfLoop;

            Console.WriteLine($"Average is {average}");

            Console.ReadKey();
        }
    }
}
