using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsSummer17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thank you for eating at Daniel's Delicacies!");
            Console.WriteLine("What is your total bill?");
            double billTotal = double.Parse(Console.ReadLine());
            //PEMDAS
            double discountTen = (billTotal - (billTotal * .10d));
            double discountFive = (billTotal - (billTotal * .05d));
            double billSplit;

            Console.WriteLine("How many people in your party?");
            int numberOfPeople = int.Parse(Console.ReadLine());

            if (billTotal >= 50)
            {
                Console.WriteLine("You will get a ten percent discount!");
                Console.WriteLine("Your total with your discount: $" + discountTen);
                billSplit = discountTen / numberOfPeople;
                Console.WriteLine("Each person in your party will pay $" + billSplit);
            }
            else
            {
                Console.WriteLine("You will get a fiver percent discount!");
                Console.WriteLine("Your total with your discount: $" + discountFive);
                billSplit = discountFive / numberOfPeople;
                Console.WriteLine("Each person in your party will pay $" + billSplit);
            }

        }
    }
}
