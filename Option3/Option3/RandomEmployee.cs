using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Option3
{
    public class RandomEmployee
    {
        public ISalary Employee
        {
            get
            {
                var rand = new Random();
                int number = rand.Next(2);
                string[] nameM =
                {
                    "Владимир", "Владислав", "Вячеслав", "Георгий", "Александр", "Алексей", "Иван",
                    "Евгений"
                };
                string[] nameF = {"Александра", "Анна", "Анастасия", "Галина", "Елена", "Елизавета", "Екатерина"};
                string[] surnameM =
                {
                    "Петров", "Сидоров", "Кузнецов", "Григорьев", "Хохлов", "Колганов", "Харлампьев",
                    "Васильев", "Урываев", "Тихонов", "Песков", "Темников", "Гаврилов", "Иванов", "Фиников"
                };
                string[] surnameF =
                {
                    "Петрова", "Сидорова", "Кузнецова", "Григорьева", "Хохлова", "Колганова", "Харлампьева",
                    "Васильева", "Урываева", "Тихонова", "Пескова", "Темникова", "Гаврилова", "Иванова", "Финикова"
                };
                string[] patronymicM =
                {
                    "Владимирович", "Владиславович", "Вячеславович", "Георгиевич", "Александрович",
                    "Алексеевич", "Иванович", "Евгениевич"
                };
                string[] patronymicF =
                {
                    "Владимировна", "Владиславна", "Вячеславна", "Георгиевна", "Александрвна",
                    "Алексеевна", "Ивановна", "Евгениевна"
                };
                string[] nameofwork =
                {
                    "техник", "оператор", "менеджер", "связной", "секретарь", "машинист", "диспетчер",
                    "механик"
                };

                if (number == 1)
                {
                    number = rand.Next(2);
                    if (number == 1)
                    {
                        number = rand.Next(nameM.Length);
                        string nameEmployee = nameM[number];

                        number = rand.Next(surnameM.Length);
                        string surnameEmployee = surnameM[number];

                        number = rand.Next(patronymicM.Length);
                        string patronymicEmployee = patronymicM[number];

                        int ageEmployee = rand.Next(47) + 18;

                        double rateEmployee = Convert.ToDouble(rand.Next(1, 10))/10;

                        int salaryEmployee = rand.Next(60001) + 10000;

                        number = rand.Next(nameofwork.Length);
                        string nameofworkEmployee = nameofwork[number];

                        SalaryRate employee = new SalaryRate(nameEmployee, surnameEmployee, patronymicEmployee,
                            ageEmployee, rateEmployee,
                            salaryEmployee, nameofworkEmployee);
                        return employee;
                    }
                    else
                    {
                        number = rand.Next(nameF.Length);
                        string nameEmployee = nameF[number];

                        number = rand.Next(surnameF.Length);
                        string surnameEmployee = surnameF[number];

                        number = rand.Next(patronymicF.Length);
                        string patronymicEmployee = patronymicF[number];

                        int ageEmployee = rand.Next(47) + 18;

                        double rateEmployee = Convert.ToDouble(rand.Next(1, 10))/10;

                        int salaryEmployee = rand.Next(60001) + 10000;

                        number = rand.Next(nameofwork.Length);
                        string nameofworkEmployee = nameofwork[number];

                        SalaryRate employee = new SalaryRate(nameEmployee, surnameEmployee, patronymicEmployee,
                            ageEmployee, rateEmployee,
                            salaryEmployee, nameofworkEmployee);
                        return employee;
                    }

                }
                else
                {
                    number = rand.Next(2);
                    if (number == 1)
                    {
                        number = rand.Next(nameM.Length);
                        string nameEmployee = nameM[number];

                        number = rand.Next(surnameM.Length);
                        string surnameEmployee = surnameM[number];

                        number = rand.Next(patronymicM.Length);
                        string patronymicEmployee = patronymicM[number];

                        int ageEmployee = rand.Next(18, 65);

                        int salaryPerHourEmployee = rand.Next(100, 500);

                        int hourEmployee = rand.Next(32, 160);

                        number = rand.Next(nameofwork.Length);
                        string nameofworkEmployee = nameofwork[number];

                        HourlyWage employee = new HourlyWage(nameEmployee, surnameEmployee, patronymicEmployee,
                            ageEmployee, salaryPerHourEmployee,
                            hourEmployee, nameofworkEmployee);
                        return employee;
                    }
                    else
                    {
                        number = rand.Next(nameF.Length);
                        string nameEmployee = nameF[number];

                        number = rand.Next(surnameF.Length);
                        string surnameEmployee = surnameF[number];

                        number = rand.Next(patronymicF.Length);
                        string patronymicEmployee = patronymicF[number];

                        int ageEmployee = rand.Next(18, 65);

                        int salaryPerHourEmployee = rand.Next(100, 500);

                        int hourEmployee = rand.Next(32, 160);

                        number = rand.Next(nameofwork.Length);
                        string nameofworkEmployee = nameofwork[number];

                        HourlyWage employee = new HourlyWage(nameEmployee, surnameEmployee, patronymicEmployee,
                            ageEmployee, salaryPerHourEmployee,
                            hourEmployee, nameofworkEmployee);
                        return employee;
                    }
                }
            }
        }
    }
}
