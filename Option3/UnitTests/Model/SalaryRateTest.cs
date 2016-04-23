using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Option3;
using NUnit.Framework;

namespace UnitTests.Model
{
    [TestFixture]
    class SalaryRateTest
    {
        // Тестирование свойства оклад в классе SalaryRate
        [TestCase(0, TestName = "Тестирование Salary при присваивании 1")]
        [TestCase(int.MaxValue, TestName = "Тестирование Salary при присваивании int.MaxValue")]
        [TestCase(222, TestName = "Тестирование Salary при присваивании 222")]
        [TestCase(333, TestName = "Тестирование Salary при присваивании 333")]
        [TestCase(1111, TestName = "Тестирование Salary при присваивании 1111")]
        public void SalaryTest(int salary)
        {
            var salaryRate = new SalaryRate();
            salaryRate.Salary = salary;
        }
        // Негативное тестирование свойства оклад в классе SalaryRate
        [TestCase(-1, TestName = "Тестирование Salary при присваивании -1")]
        [TestCase(int.MinValue, TestName = "Тестирование Salary при присваивании int.MinValue")]
        [TestCase(-22, TestName = "Тестирование Salary при присваивании -22")]
        [TestCase(-888, TestName = "Тестирование Salary при присваивании -888")]
        [TestCase(-626, TestName = "Тестирование Salary при присваивании -626")]
        public void SalaryTestNegative(int salary)
        {
            var salaryRate = new SalaryRate();
            NUnit.Framework.Assert.Throws(typeof(ArgumentException), () => { salaryRate.Salary = salary; });
        }
        // Тестирование свойства ставка в классе SalaryRate
        [TestCase(0.1, TestName = "Тестирование Rate при присваивании 1")]
        [TestCase(0.2, TestName = "Тестирование Rate при присваивании 0.2")]
        [TestCase(0.5, TestName = "Тестирование Rate при присваивании 0.5")]
        [TestCase(0.8, TestName = "Тестирование Rate при присваивании 0.8")]
        [TestCase(1, TestName = "Тестирование Rate при присваивании 1")]
        public void RateTest(double rate)
        {
            var salaryRate = new SalaryRate();
            salaryRate.Rate = rate;
        }
        // Негативное тестирование свойства ставка в классе SalaryRate
        [TestCase(-1, TestName = "Тестирование Rate при присваивании -1")]
        [TestCase(double.MinValue, TestName = "Тестирование Rate при присваивании double.MinValue")]
        [TestCase(double.MaxValue, TestName = "Тестирование Rate при присваивании double.MaxValue")]
        [TestCase(2, TestName = "Тестирование Rate при присваивании 2")]
        [TestCase(0, TestName = "Тестирование Rate при присваивании 0")]
        public void RateTestNegative(double rate)
        {
            var salaryRate = new SalaryRate();
            NUnit.Framework.Assert.Throws(typeof(ArgumentException), () => { salaryRate.Rate = rate; });
        }
        // Тестирование метода штраф в классе HourlyWage и SalaryRate
        [TestCase(0, TestName = "Тестирование Fined при присваивании 1")]
        [TestCase(int.MaxValue, TestName = "Тестирование Fined при присваивании int.MaxValue")]
        [TestCase(222, TestName = "Тестирование Fined при присваивании 222")]
        [TestCase(333, TestName = "Тестирование Fined при присваивании 333")]
        [TestCase(1111, TestName = "Тестирование Fined при присваивании 1111")]
        public void FinedTest(int fine)
        {
            var hourlyWage = new HourlyWage();
            hourlyWage.Fined(fine);
            var salaryRate = new SalaryRate();
            salaryRate.Fined(fine);
        }
        // Негативное тестирование метода штраф в классе HourlyWage и SalaryRate
        [TestCase(-1, TestName = "Тестирование Fined при присваивании -1")]
        [TestCase(int.MinValue, TestName = "Тестирование Fined при присваивании int.MinValue")]
        [TestCase(-22, TestName = "Тестирование Fined при присваивании -22")]
        [TestCase(-888, TestName = "Тестирование Fined при присваивании -888")]
        [TestCase(-626, TestName = "Тестирование Fined при присваивании -626")]
        public void FinedTestNegative(int fine)
        {
            var hourlyWage = new HourlyWage();
            NUnit.Framework.Assert.Throws(typeof(ArgumentException), () => { hourlyWage.Fined(fine); });
            var salaryRate = new SalaryRate();
            NUnit.Framework.Assert.Throws(typeof(ArgumentException), () => { salaryRate.Fined(fine); });
        }
    }
}
