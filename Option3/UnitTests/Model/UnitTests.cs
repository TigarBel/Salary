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
    public class UnitTests
    {
        [Test]
        // Тестирование свойства имя в классе Person
        [TestCase("Егор", TestName = "Тестирование Name при присваивании Егор.")]
        [TestCase("Е", TestName = "Тестирование Name при присваивании Е.")]
        [TestCase("Е-Е", TestName = "Тестирование Name при присваивании Е-Е.")]
        [TestCase("Егор-Евгеньевич", TestName = "Тестирование Name при присваивании Егор-Евгеньевич.")]
        [TestCase("Егор-Е-А", TestName = "Тестирование Name при присваивании Егор-Е-А.")]    
        public void NameTest(string name)
        {
            var salaryRate = new SalaryRate();
            salaryRate.Name = name;
        }
        // Негативное тестирование свойства имя в классе Person
        [TestCase("Его,р", TestName = "Тестирование Name при присваивании Его,р.")]
        [TestCase("Еr", TestName = "Тестирование Name при присваивании Еr.")]
        [TestCase("Его-", TestName = "Тестирование Name при присваивании Его-.")]
        [TestCase("-Евгеньевич", TestName = "Тестирование Name при присваивании -Евгеньевич.")]
        [TestCase("ЕЕА", TestName = "Тестирование Name при присваивании ЕЕА.")]
        public void NameTestNegative(string name)
        {
            var salaryRate = new SalaryRate();
            NUnit.Framework.Assert.Throws(typeof(PersonException), () => { salaryRate.Name = name; });
        }
        // Тестирование свойства возраст в классе Person
        [TestCase(18, TestName = "Тестирование Age при присваивании 18")]
        [TestCase(22, TestName = "Тестирование Age при присваивании 22")]
        [TestCase(65, TestName = "Тестирование Age при присваивании 65")]
        [TestCase(20, TestName = "Тестирование Age при присваивании 20")]
        [TestCase(47, TestName = "Тестирование Age при присваивании 47")]
        public void AgeTest(int age)
        {
            var salaryRate = new SalaryRate();
            salaryRate.Age = age;
        }
        // Негативное тестирование свойства возраст в классе Person
        [TestCase(int.MinValue, TestName = "Тестирование Age при присваивании int.MinValue")]
        [TestCase(int.MaxValue, TestName = "Тестирование Age при присваивании int.MaxValue")]
        [TestCase(-1, TestName = "Тестирование Age при присваивании -1")]
        [TestCase(17, TestName = "Тестирование Age при присваивании 17")]
        [TestCase(66, TestName = "Тестирование Age при присваивании 66")]
        public void AgeTestNegative(int age)
        {
            var salaryRate = new SalaryRate();
            NUnit.Framework.Assert.Throws(typeof(PersonException), () => { salaryRate.Age = age; });
        }
        // Тестирование свойства часы в классе HourlyWage
        [TestCase(0, TestName = "Тестирование Hour при присваивании 1")]
        [TestCase(int.MaxValue, TestName = "Тестирование Hour при присваивании int.MaxValue")]
        [TestCase(222, TestName = "Тестирование Hour при присваивании 222")]
        [TestCase(333, TestName = "Тестирование Hour при присваивании 333")]
        [TestCase(1111, TestName = "Тестирование Hour при присваивании 1111")]
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
