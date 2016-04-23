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
    public class PersonTest
    {
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
    }
}
