using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Employee Details");
            Console.WriteLine("-----------------------");

            // Get employee details from the user
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Employee Name: ");
            string name = Console.ReadLine();

            Console.Write("Employee Gender(M/F): ");
            string gender = Console.ReadLine();

            Console.Write("Employee Salary: ");
            double salary = double.Parse(Console.ReadLine());

            Console.Write("DOJ (Date of Joining(dd-mm-yyyy)): ");
            DateTime doj = DateTime.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Employee Details");
            Console.WriteLine("---------------------------------------------");

            // Display employee details
            Console.WriteLine("ID \tEmployee Name \tEmployee Gender \tEmployee Salary \tDOJ");
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine($"{id}\t{name}\t\t{gender}\t\t{salary}\t\t{doj.ToShortDateString()}");
            Console.WriteLine();

            // Calculate and display tax amount
            double taxRate = (salary > 90000) ? 0.3 : 0.15;
            double taxAmount = salary * taxRate;
            Console.WriteLine($"Tax Rate: {taxRate * 100}%");
            Console.WriteLine($"Tax Amount: {taxAmount}");

            Console.WriteLine();
            Console.WriteLine("You have to pay: --------------");
        }
    }
}
