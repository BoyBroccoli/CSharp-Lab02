using Microsoft.VisualStudio.TestTools.UnitTesting;
using Polymorphism;
using System;

namespace PolymorphismTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateWeeklySalaryForEmpTest_70Wage55HrRturns2800Dolls()
        {
            // Arrange
            int weeklyHours = 55;
            int wage = 70;
            int salary = 40 * wage;
            Employee e = new Employee();

            string expectedResponse = String.Format("\nThis ANGRY EMPLOYEE worked {0} hrs. " +
                              "Paid for 40 hrs at $ {1}" +
                              "/hr = ${2} \n", weeklyHours, wage, salary);

            // Act
            string response = e.CalculateWeeklySalary(weeklyHours, wage);

            // Assert
            Assert.AreEqual(response, expectedResponse);
        }

        [TestMethod]
        public void CalculateWeeklySalaryForContractorTest_70Wage55HrRturns3850Dolls()
        {
            // Arrange
            int weeklyHours = 55;
            int wage = 70;
            int salary = weeklyHours * wage;
            Contractor e = new Contractor();

            string expectedResponse = String.Format("\nThis HAPPY CONTRACTOR worked {0} hrs. " +
                              "Paid for {0} hrs at $ {1}" +
                              "/hr = ${2} ", weeklyHours, wage, salary);

            // Act
            string response = e.CalculateWeeklySalary(weeklyHours, wage);

            // Assert
            Assert.AreEqual(response, expectedResponse);
        }

        [TestMethod]
        public void CalculateWeeklySalaryForEmployeeTest_70Wage55HrDoesNotReturnCorrectString() 
        {
            // Arrange
            int weeklyHours = 55;
            int wage = 70;
            int salary = 40 * wage;
            Employee e = new Employee();

            string expectedResponse = String.Format("\n Problem 1 - This ANGRY EMPLOYEE worked {0} hrs. " +
                              "Paid for 40 hrs at $ {1}" +
                              "/hr = ${2} \n", weeklyHours, wage, salary);

            // Act
            string response = e.CalculateWeeklySalary(weeklyHours, wage);

            // Assert
            Assert.AreNotEqual(response, expectedResponse);
        }

        [TestMethod]
        public void CalculateWeeklySalaryForContractorTest_70Wage55HrDoesNotReturnCorrectString()
        {
            // Arrange
            int weeklyHours = 55;
            int wage = 70;
            int salary = weeklyHours * wage;
            Contractor e = new Contractor();

            string expectedResponse = String.Format("\nProblem 2- This HAPPY CONTRACTOR worked {0} hrs. " +
                              "Paid for {0} hrs at $ {1}" +
                              "/hr = ${2} ", weeklyHours, wage, salary);

            // Act
            string response = e.CalculateWeeklySalary(weeklyHours, wage);

            // Assert
            Assert.AreNotEqual(response, expectedResponse);
        }
    }
}
