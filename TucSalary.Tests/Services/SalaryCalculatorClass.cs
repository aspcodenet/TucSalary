using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TucSalary.Services;

namespace TucSalary.Tests.Services{

    [TestClass]
    public class SalaryCalculatorClass
    {
        private readonly SalaryCalculator sut;
        public SalaryCalculatorClass()
        {
           sut = new SalaryCalculator();
        }

        [TestMethod]
        public void When_name_is_not_stefan_and_age_is_under_30_should_earn_100_an_hour()
        {
            // ARRANGE
            int age = 20;
            // ACT
            
            var result = sut.Calculate("a", 10, age);
            
            // ASSERT
            Assert.AreEqual(1000, result);

        }


        [TestMethod]
        public void When_name_is_stefan_and_age_is_under_30_should_earn_110_an_hour()
        {
            // ARRANGE
            int age = 20;
            var name = "Stefan";
            // ACT

            var result = sut.Calculate(name, 10, age);

            // ASSERT
            Assert.AreEqual(1100, result);

        }


    }
}
