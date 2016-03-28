using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Option3;

namespace ConsoleLoader
{
    class MainOption
    {
        static void Main()
        {
            try
            {
                HourlyWage vovaPutin = new HourlyWage("Вова", "Путин", "", 60, 700, 107, "Гос.");
                Console.WriteLine(vovaPutin.ShowPerson());
                Console.WriteLine(vovaPutin.ShowPersonalSettings());

                Console.WriteLine(" Этот сотрудник заработал за месяц " + vovaPutin.SalaryAccrual() + "руб.");
                vovaPutin.Fined(500);
                Console.WriteLine(" Этот сотрудник заработал за месяц " + vovaPutin.SalaryAccrual() + "руб.");
                Console.WriteLine(" Этот сотрудник заработал за месяц " + vovaPutin.SalaryAccrual() + "руб.");

                List<ISalary> list = new List<ISalary>();
                list.Add(vovaPutin);
                SalaryRate dimaMedvedew = new SalaryRate("Дима", "Медведев","", 40, 0.2, 100000, "Гос.");
                list.Add(dimaMedvedew);
                Console.WriteLine();
                foreach (ISalary person in list)
                {
                    Console.WriteLine(person.ShowPerson());
                    Console.WriteLine(person.ShowPersonalSettings());
                    Console.WriteLine(" Этот сотрудник заработал за месяц " + person.SalaryAccrual() + "руб.");
                    Console.WriteLine();
                }
            }
            catch (NullReferenceException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (PersonException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch
            {
                Console.WriteLine(" Произошёл сбой в программе.");
            }
            Console.ReadLine();
        }
    }
}
