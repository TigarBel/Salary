using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Option3
{
    [Serializable]
    /// <summary>
    /// Оклад и ставка
    /// </summary>
    public class SalaryRate : Person, ISalary //Salary rate(Оклад и ставка)
    {
        /// <summary>
        /// Ставка
        /// </summary>
        double _rate; // Ставка

        /// <summary>
        /// Оклад
        /// </summary>
        double _salary; // Оклад 

        /// <summary>
        /// Наименование рабочего места
        /// </summary>
        string _nameofwork; // Наименование рабочего места

        /// <summary>
        /// Наменование зарплаты
        /// </summary>
        string _nameofsalary;

        /// <summary>
        /// Долг(от штрафа)
        /// </summary>
        double _fine;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public SalaryRate()
        {
            _fine = 0;
            _rate = 0;
            _nameofwork = string.Empty;
            _nameofsalary = string.Empty;
        }
        /// <summary>
        /// Стандартный коструктор
        /// </summary>
        /// <param name="rate">Ставка</param>
        /// <param name="salary">Оклад</param>
        /// <param name="nameofwork">Наименование рабочего места</param>
        /// <param name="name">Имя сотрудника</param>
        /// <param name="suname">Фамилия сотрудника</param>
        /// <param name="patronymic">Отчество сотрудника(может отсутсвовать)</param>
        /// <param name="age">Возраст сотрудника</param>
        public SalaryRate(string name, string suname, string patronymic, int age, double rate, int salary, string nameofwork)
            : base(name, suname, patronymic, age)
        {
            _fine = 0;//Изначально у сотрудника нет штрафов

            Rate = rate; // Ставка

            Salary = salary; // Оклад

            NameOfWork = nameofwork; // Наименование рабочего места

            _nameofsalary = "Оклад по ставке"; //Наменование зарплаты
        }
        /// <summary>
        /// Работадатель выплатил деньги за работу
        /// </summary>
        /// <returns>Ставак * оклад</returns>
        public double SalaryAccrual()
        {
            if (double.IsInfinity(Rate * Salary)) { throw new Exception("Зарплата больше хранимого значения!");}
            if (Rate * Salary - _fine > 0)
            {
                double fine = _fine;
                _fine = 0;
                return Rate * Salary - fine;// Работадатель выплатил деньги за работу
            }
            else
            {
                _fine = (Rate * Salary - _fine) * -1;// Работадатель не выплатил деньги, т.к. был выплачен штраф
                return 0;
            }
        }
        /// <summary>
        /// Вывод строки: оклад, ставка, наименование работы
        /// </summary>
        /// <returns></returns>
        public string ShowPersonalSettings()
        {
            return " Оклад " + Salary + "руб. по ставке " + Rate + " работника " + NameOfWork;
        }
        /// <summary>
        /// Выписать штраф
        /// </summary>
        public void Fined(int fine)
        {
            if (fine < 0)
            {
                throw new ArgumentException(" Штраф не может быть меньше 0!");
            }
            _fine = (double)fine;
        }
        /// <summary>
        /// Ставка(от 0 до 1)
        /// </summary>
        public double Rate
        {
            get { return _rate; }
            set
            {
                if ((value <= 0) || (value > 1))
                {
                    throw new ArgumentException(" Ставка не должна быть меньше 0 и больше 1!");
                }
                _rate = value;
            }
        }
        /// <summary>
        /// Наименование рабочего места
        /// </summary>
        public string NameOfWork
        {
            get { return _nameofwork; }
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException(" Не заполненно место работы!");
                }
                _nameofwork = value; // Наименование рабочего места
            }
        }
        /// <summary>
        /// Наименование зарплаты
        /// </summary>
        public string NameOfSalary
        {
            get { return _nameofsalary; }
            set
            {
                if (value != "Оклад по ставке")
                {
                    throw new ArgumentException(" Ошибка в названии");
                }
                _nameofsalary = value;
            }
        }
        /// <summary>
        /// Оклад
        /// </summary>
        public double Salary
        {
            get { return _salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(" Оклад не может быть меньше 0!");
                }
                _salary = value;
            }
        }
    } 
}
