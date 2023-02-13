using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class SalaryCalculator
    {
        const int HoursInYear = 2080;

        public decimal GetAnnualSalary(decimal hourlyWage) => hourlyWage * HoursInYear;

        public decimal GetHourlyWage(int annualSalary) =>  annualSalary / HoursInYear;

        public TaxData TaxWithheld(double weeklySalry, int numDependents)
        {
            if (numDependents < 0) 
            {
                throw new InvalidOperationException ("Number dependents cannot be negative.");
            }

            if (weeklySalry <= 0) 
            {
                throw new InvalidOperationException("Weekly salary must be greater than zero.");
            }
            double ProvincialTaxWithheld = weeklySalry * 0.06;
            double FederalTaxWithheld = weeklySalry * 0.25;
            double DependentDeduction = weeklySalry * numDependents * 0.02;
            double TotalWithheld = ProvincialTaxWithheld + FederalTaxWithheld - DependentDeduction;
            double TotalTakeHome = weeklySalry - TotalWithheld;

            TaxData td = new TaxData(ProvincialTaxWithheld, FederalTaxWithheld, DependentDeduction, TotalWithheld, TotalTakeHome);
            return td;
        }

    }
}
