using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Option3
{   
    /// <summary>
    /// Интерфейс для работы с классом Person
    /// </summary>
    public interface IPerson
    {
        /// <summary>
        /// Имя
        /// </summary>
        string Name { get; set;}

        /// <summary>
        /// Фамилия
        /// </summary>
        string Surname { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        string Patronymic { get; set; }

        /// <summary>
        /// Возраст
        /// </summary>
        int Age { get; set; }

        /// <summary>
        /// Строка с выводом: Имя, Фамилии, Возраста персоны
        /// </summary>
        /// <returns></returns>
        string ShowPerson();
    }        
}