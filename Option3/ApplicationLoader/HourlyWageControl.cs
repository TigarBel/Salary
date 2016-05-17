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
                if (value)
                {
                    NameOfEmployeeHourlyWage.ReadOnly = true;
                    SurnameOfEmployeeHourlyWage.ReadOnly = true;
                    PatronymicOfEmployeeHourlyWage.ReadOnly = true;
                    AgeOfEmployeeHourlyWage.ReadOnly = true;
                    SalaryPerHour.ReadOnly = true;
                    Hour.ReadOnly = true;
                    NameOfWorkOfEmployeeHourlyWage.ReadOnly = true;
                }
                else
                {
                    NameOfEmployeeHourlyWage.ReadOnly = false;
                    SurnameOfEmployeeHourlyWage.ReadOnly = false;
                    PatronymicOfEmployeeHourlyWage.ReadOnly = false;
                    AgeOfEmployeeHourlyWage.ReadOnly = false;
                    SalaryPerHour.ReadOnly = false;
                    Hour.ReadOnly = false;
                    NameOfWorkOfEmployeeHourlyWage.ReadOnly = false;
                }
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
                /*
                catch (FormatException exception)
                {
                    MessageBox.Show(" В чём то проблема.");
                    return null;
                }
                */
                catch (NullReferenceException exception)
                {
                    MessageBox.Show(exception.Message);
                    return null;
                }
                catch (ArgumentException exception)
                {
                    MessageBox.Show(exception.Message);
                    return null;
                }
                catch (PersonException exception)
                {
                    MessageBox.Show(exception.Message);
                    return null;
                }
            }
            set
            {
                try
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
                catch (NullReferenceException exception)
                {
                    MessageBox.Show(exception.Message);
                }
                catch (ArgumentException exception)
                {
                    MessageBox.Show(exception.Message);
                }
                catch (PersonException exception)
                {
                    MessageBox.Show(exception.Message);
                }
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
