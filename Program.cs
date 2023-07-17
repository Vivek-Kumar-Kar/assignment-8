using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salary Calculation System");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Choose Employee Type:");
            Console.WriteLine("1. HR");
            Console.WriteLine("2. Admin");
            Console.WriteLine("3. Software Developer");
            Console.Write("Enter employee type (1-3): ");
            int employeeType = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter working hours: ");
            int workingHours = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of working days: ");
            int numWorkingDays = Convert.ToInt32(Console.ReadLine());

            int projectHandles = 0;
            int extras = 0;

            switch (employeeType)
            {
                case 1: // HR
                    projectHandles = 1;
                    break;
                case 2: // Admin
                    Console.Write("Enter the project handles: ");
                    projectHandles = Convert.ToInt32(Console.ReadLine());
                    break;
                case 3: // Software Developer
                    Console.Write("Enter the project handles: ");
                    projectHandles = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter extras: ");
                    extras = Convert.ToInt32(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Invalid employee ");
                    return;
            }

            int monthlySalary = CalculateMonthlySalary(employeeType, workingHours, numWorkingDays, projectHandles, extras);

            Console.WriteLine("Monthly Salary: $" + monthlySalary);
        }

        static int CalculateMonthlySalary(int employeeType, int workingHours, int numWorkingDays, int projectHandles, int extras)
        {
            int baseSalary = workingHours * numWorkingDays * 100;
            int projectBonus = projectHandles * 3000;
            int extrasBonus = extras * 2000;

            int totalSalary = baseSalary + projectBonus + extrasBonus;

            return totalSalary;
        }
    }

}
