using System;

namespace salary_calculator_BITC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal salary = 200000;
            decimal incomeTax_per = 20;
            decimal stampDuty = 3000;
            decimal socialFee = 10000;
            Console.WriteLine($"Salary: {salary}");

            salaryCalculator(ref salary, ref incomeTax_per, socialFee, stampDuty);

            Console.WriteLine($"Income Tax: {incomeTax_per}");
            Console.WriteLine($"Stamp duty: {stampDuty}");
            Console.WriteLine($"Social fee: {socialFee}");
            Console.WriteLine($"\nClean Balance: {salary}");
        }
        static bool salaryCalculator(ref decimal salary, ref decimal incomeTax_per, in decimal socialFee, decimal stampDuty)
        {
            incomeTax_per = salary * (incomeTax_per / 100);
            salary -= incomeTax_per + socialFee + stampDuty;
            return true;
        }
    }
}
