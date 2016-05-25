using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Option3;

namespace ApplicationLoader
{
    public partial class HourlyWageControl : UserControl
    {
        public HourlyWageControl()
        {
            InitializeComponent();
        }

        public bool ReadOnly
        {
            set
            {
                NameOfEmployeeHourlyWage.ReadOnly = value;
                SurnameOfEmployeeHourlyWage.ReadOnly = value;
                PatronymicOfEmployeeHourlyWage.ReadOnly = value;
                AgeOfEmployeeHourlyWage.ReadOnly = value;
                SalaryPerHour.ReadOnly = value;
                Hour.ReadOnly = value;
                NameOfWorkOfEmployeeHourlyWage.ReadOnly = value;                
            }
        }

        public HourlyWage HourlyWageEmployee
        {
            get
            {
                try
                {
                    HourlyWage employee = new HourlyWage(
                        NameOfEmployeeHourlyWage.Text,
                        SurnameOfEmployeeHourlyWage.Text,
                        PatronymicOfEmployeeHourlyWage.Text,
                        Convert.ToInt32(AgeOfEmployeeHourlyWage.Text),
                        Convert.ToInt32(SalaryPerHour.Text),
                        Convert.ToInt32(Hour.Text),
                        NameOfWorkOfEmployeeHourlyWage.Text);
                    return employee;
                }                
                catch (Exception exception)
                {
                    if (exception is NullReferenceException || exception is ArgumentException || exception is PersonException)
                    {
                        MessageBox.Show(exception.Message);
                        return null;
                    }
                    else if(exception is FormatException)
                    {
                        MessageBox.Show(" В поле: <Возраст>; <Плата за один час>; <Часов в месяц> - было введено не числовое значение.");
                        return null;
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            set
            {
                var hourlyWageEmployee = (HourlyWage)value;
                NameOfEmployeeHourlyWage.Text = hourlyWageEmployee.Name;
                SurnameOfEmployeeHourlyWage.Text = hourlyWageEmployee.Surname;
                PatronymicOfEmployeeHourlyWage.Text = hourlyWageEmployee.Patronymic;
                AgeOfEmployeeHourlyWage.Text = Convert.ToString(hourlyWageEmployee.Age);
                SalaryPerHour.Text = Convert.ToString(hourlyWageEmployee.SalaryPerHour);
                Hour.Text = Convert.ToString(hourlyWageEmployee.Hour);
                NameOfWorkOfEmployeeHourlyWage.Text = Convert.ToString(hourlyWageEmployee.NameOfWork);
            }
        }
        // Смываем с полей лишние символы
        public void ClearControl()
        {
            NameOfEmployeeHourlyWage.Text = string.Empty;
            SurnameOfEmployeeHourlyWage.Text = string.Empty;
            PatronymicOfEmployeeHourlyWage.Text = string.Empty;
            AgeOfEmployeeHourlyWage.Text = string.Empty;
            SalaryPerHour.Text = string.Empty;
            Hour.Text = string.Empty;
            NameOfWorkOfEmployeeHourlyWage.Text = string.Empty;
        }
    }
}
