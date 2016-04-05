using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UnitTests.Model
{
    [TestFixture]
    public class PersonTest
    {
        /// <summary>
        /// Имя сотрудника
        /// </summary>
        string _name;//Имя

        /// <summary>
        /// Фамилия сотрудника
        /// </summary>
        string _surname;//Фамилия

        /// <summary>
        /// Отчество сотрудника(может отсутсвовать)
        /// </summary>
        string _patronymic;//Фамилия

        /// <summary>
        /// Возраст сотрудника
        /// </summary>
        int _age;//Возраст

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public PersonTest()
        {
            _name = string.Empty;
            _surname = string.Empty;
            _patronymic = string.Empty;
            _age = 0;
        }

        /// <summary>
        /// Стандартный конструктор
        /// </summary>
        /// <param name="name">Имя сотрудника</param>
        /// <param name="surname">Фамилия сотрудника</param>
        /// <param name="patronymic">Отчество сотрудника(может отсутсвовать)</param>
        /// <param name="age">Возраст сотрудника</param>
        public PersonTest(string name, string surname, string patronymic, int age)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Age = age;
        }
        
        /// <summary>
        /// Имя сотрудника
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException(" Не заполненно поле Имя!");
                }
                for (int i = 0; i < value.Length; i++)
                {
                    if (Char.IsDigit(value[i])) //набор чисел
                    {
                        throw new Exception(" В Имени не должно быть цифр!");
                    }
                    if (i == 0)
                    {
                        if ((value[0] < 'А') || (value[0] > 'Я')) //от А до Я
                        {
                            throw new Exception(" Имя должны быть с заглавной буквы!");
                        }
                    }
                }
                _name = value;
            }
        }

        /// <summary>
        /// Фамилию сотрудника
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException(" Не заполненно поле Фамилия!");
                }
                for (int i = 0; i < value.Length; i++)
                {

                    if (Char.IsDigit(value[i])) //набор чисел
                    {
                        throw new Exception(" В Фамилии не должно быть цифр!");
                    }
                    if (i == 0)
                    {
                        if ((value[0] < 'А') || (value[0] > 'Я')) //от А до Я
                        {
                            throw new Exception(" Фамилия должна быть с заглавной буквы!");
                        }
                    }
                }
                _surname = value;
            }
        }

        /// <summary>
        /// Отчество сотрудника(может отсутсвовать)
        /// </summary>
        public string Patronymic
        {
            get
            {
                return _patronymic;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {

                        if (Char.IsDigit(value[i])) //набор чисел
                        {
                            throw new Exception(" В Отчестве не должно быть цифр!");
                        }
                        if (i == 0)
                        {
                            if ((value[0] < 'А') || (value[0] > 'Я')) //от А до Я
                            {
                                throw new Exception(" Отчество должно быть с заглавной буквы!");
                            }
                        }
                    }
                }
                _patronymic = value;
            }
        }
       
        /// <summary>
        /// Возраст сотрудника
        /// </summary>
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 18)
                {
                    throw new Exception(" Лицам до 18 регистрация запрещена!");
                }
                if (value > 65)
                {
                    throw new Exception(" Пенсионерам регистрация запрещена!");
                }
                _age = value;
            }
        }

        /// <summary>
        /// Вывод строки: Имя, Фамилия, Возраст сотрудника
        /// </summary>
        /// <returns></returns>
        public string ShowPerson()
        {
            //return " Имя " + Name + " фамилия " + _surname + ", " + _age + " лет";
            return " " + Name + " " + Surname + " " + Patronymic + ", " + Age + " лет";
        }
    }    
}
