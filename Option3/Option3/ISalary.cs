using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Option3
{
    /// <summary>
    /// Интерфейс для взаимодействия с зарплатами предприятия
    /// </summary>
    public interface ISalary : IPerson
    {
        /// <summary>
        /// Метод для выдачи зарплаты
        /// </summary>
        /// <returns></returns>
        double SalaryAccrual();
        
        /// <summary>
        /// Метод для вывода строки в котором содержатся описанные атрибуты класса
        /// </summary>
        /// <returns></returns>
        string ShowPersonalSettings();

        /// <summary>
        /// Наименование зарплаты
        /// </summary>
        string NameOfSalary { get; }

        /// <summary>
        /// Выписать штраф
        /// </summary>
        void Fined(int fine);
    }
}
