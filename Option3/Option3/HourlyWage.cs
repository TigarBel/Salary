using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Option3
{
    [Serializable]
    /// <summary>
    /// Почасовая оплата
    /// </summary>
    public class HourlyWage : Person, ISalary //Hourly wage(Почсовая оплата)
    {
        /// <summary>
        /// Плата за час работы
        /// </summary>
        int _salaryPerHour;

        /// <summary>
        /// Часы за месяц работы
        /// </summary>
        int _hour;

        /// <summary>
        /// Наименование рабочего места
        /// </summary>
        string _nameofwork;

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
        public HourlyWage()
        {
            _fine = 0;
            _salaryPerHour = 0;
            _nameofwork = string.Empty;
            _nameofsalary = string.Empty;
            _hour = 0;
        }
        /// <summary>
        /// Основной конструктор
        /// </summary>
        /// <param name="salaryPerHour">Плата за час работы</param>
        /// <param name="hour">Часы работы за месяц</param>
        /// <param name="nameofwork">Наименование рабочего места</param>
        /// <param name="name">Имя сотрудника</param>
        /// <param name="surname">Фамилия сотрудника</param>
        /// <param name="patronymic">Отчество сотрудника(может отсутсвовать)</param>
        /// <param name="age">Возраст сотрудника</param>
        public HourlyWage(string name, string surname, string patronymic, int age, int salaryPerHour, int hour, string nameofwork) : base(name, surname, patronymic, age)
        {
            _fine = 0;//Изначально у сотрудника нет штрафов

            SalaryPerHour = salaryPerHour; // Плата за час работы

            Hour = hour; // Часы работы

            NameOfWork = nameofwork; // Наименование рабочего места

            _nameofsalary = "Почасовая оплата"; //Наменование зарплаты
        }
        /// <summary>
        /// Работадатель выплатил деньги за работу
        /// </summary>
        /// <returns>Часы за работу * почасовую зарплату - штрафы</returns>
        public double SalaryAccrual()
        {
            if (_hour * _salaryPerHour - _fine > 0)
            {
                double fine = _fine;
                _fine = 0;
                return _hour * _salaryPerHour - fine;// Работадатель выплатил деньги за работу
            }
            else
            {
                _fine = (_hour * _salaryPerHour - _fine) * -1;
                return 0;
            }

        }
        /// <summary>
        /// Показать личные параметры: плата за час работы, наименование рабочего места
        /// </summary>
        /// <returns></returns>
        public string ShowPersonalSettings()
        {
            return " Почасовая плата работника " + SalaryPerHour + "руб." + " по рабочему графику " + Hour + " часов в месяц";
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
        /// Время (часов работы) сотрудника
        /// </summary>
        public int Hour
        {
            get { return _hour; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(" Часов работы за месяц не может быть меньше 0!");
                }
                _hour = value;
            }
        }
        /// <summary>
        /// Почасовая оплата сотрудника
        /// </summary>
        public int SalaryPerHour
        {
            get { return _salaryPerHour; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(" Плата за час работы не может быть меньше 0!");
                }
                _salaryPerHour = value;
            }
        }
        /// <summary>
        /// Наименование зарплаты
        /// </summary>
        public string NameOfSalary
        {
            get { return _nameofsalary; }
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
    }
}
