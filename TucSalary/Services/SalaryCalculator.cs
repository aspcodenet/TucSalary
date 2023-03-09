using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TucSalary.Services
{
    public class SalaryCalculator
    {
        public int Calculate(string namn, int hours, int age)
        {
            var hourlySalary = 0;
            if (age < 30) hourlySalary = 100;
            else if (age >= 30 && age <= 50) hourlySalary = 120;
            else hourlySalary = 130;
            //var hourlySalary = 100;
            //if (age >= 30 && age <= 50) hourlySalary = 120;
            //else if (age > 50) hourlySalary = 130;
            if (namn == "Stefan")
            {
                hourlySalary = Convert.ToInt32(hourlySalary*1.1);
            }

            return hourlySalary * hours;
        }
    }
}
