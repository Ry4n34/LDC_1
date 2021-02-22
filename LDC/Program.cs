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
            }

            if (inputString.Length > 15)
            {
                //shorten string
                inputString = resultString.Substring(0, 15);
            }
            Console.WriteLine(resultString.Replace('$', '£').Replace('_', 'j').Replace('4', '5'));
            Console.ReadKey();
        }
    }
}

