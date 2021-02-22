using System;
using System.Linq;
namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)

        {


            Console.Write("Enter a String : ");
            string inputString = Console.ReadLine();
            string resultString = string.Empty;
            for (int i = 0; i < inputString.Length; i++)
            {
                if (!resultString.Contains(inputString[i]))
                {
                    resultString += inputString[i];
                }

         string firstFivCharWithSubString =
    !String.IsNullOrWhiteSpace(resultString) && resultString.Length >= 15
    ? resultString.Substring(0, 15)
    : resultString;

            }
                Console.WriteLine(resultString.Substring(0, 15).Replace('$', '£').Replace('_', 'j').Replace('4', '5'));
                Console.ReadKey();
            }
        }
    }



