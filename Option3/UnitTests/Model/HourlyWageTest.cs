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
    class HourlyWageTest
    {
        // Тестирование свойства часы в классе HourlyWage
        [TestCase(0, TestName = "Тестирование Hour при присваивании 1")]
        [TestCase(672, TestName = "Тестирование Hour при присваивании 672")]
        [TestCase(222, TestName = "Тестирование Hour при присваивании 222")]
        [TestCase(333, TestName = "Тестирование Hour при присваивании 333")]
        [TestCase(1, TestName = "Тестирование Hour при присваивании 1")]
        public void HourTest(int hour)
        {
            var hourlyWage = new HourlyWage();
            hourlyWage.Hour = hour;
        }
        // Негативное тестирование свойства часы в классе HourlyWage
        [TestCase(-1, TestName = "Тестирование Hour при присваивании -1")]
        [TestCase(int.MinValue, TestName = "Тестирование Hour при присваивании int.MinValue")]
        [TestCase(-22, TestName = "Тестирование Hour при присваивании -22")]
        [TestCase(-888, TestName = "Тестирование Hour при присваивании -888")]
        [TestCase(-626, TestName = "Тестирование Hour при присваивании -626")]
        public void HourTestNegative(int hour)
        {
            var hourlyWage = new HourlyWage();
            NUnit.Framework.Assert.Throws(typeof(ArgumentException), () => { hourlyWage.Hour = hour; });
        }
        // Тестирование свойства почасовая оплата в классе HourlyWage
        [TestCase(0, TestName = "Тестирование SalaryPerHour при присваивании 1")]
        [TestCase(int.MaxValue, TestName = "Тестирование SalaryPerHour при присваивании int.MaxValue")]
        [TestCase(222, TestName = "Тестирование SalaryPerHour при присваивании 222")]
        [TestCase(333, TestName = "Тестирование SalaryPerHour при присваивании 333")]
        [TestCase(1111, TestName = "Тестирование SalaryPerHour при присваивании 1111")]
        public void SalaryPerHourTest(int salaryPerHour)
        {
            var hourlyWage = new HourlyWage();
            hourlyWage.SalaryPerHour = salaryPerHour;
        }
        // Негативное тестирование свойства почасовая оплата в классе HourlyWage
        [TestCase(-1, TestName = "Тестирование SalaryPerHour при присваивании -1")]
        [TestCase(int.MinValue, TestName = "Тестирование SalaryPerHour при присваивании int.MinValue")]
        [TestCase(-22, TestName = "Тестирование SalaryPerHour при присваивании -22")]
        [TestCase(-888, TestName = "Тестирование SalaryPerHour при присваивании -888")]
        [TestCase(-626, TestName = "Тестирование SalaryPerHour при присваивании -626")]
        public void SalaryPerHourTestNegative(int salaryPerHour)
        {
            var hourlyWage = new HourlyWage();
            NUnit.Framework.Assert.Throws(typeof(ArgumentException), () => { hourlyWage.SalaryPerHour = salaryPerHour; });
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
