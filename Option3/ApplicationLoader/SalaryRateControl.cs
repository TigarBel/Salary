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
    public partial class SalaryRateControl : UserControl
    {
        public SalaryRateControl()
        {
            InitializeComponent();
        }

        public bool ReadOnly
        {
            set
            {
                NameOfEmployeeSalaryRate.ReadOnly = value;
                SurnameOfEmployeeSalaryRate.ReadOnly = value;
                PatronymicOfEmployeeSalaryRate.ReadOnly = value;
                AgeOfEmployeeSalaryRate.ReadOnly = value;
                RateOfEmployee.ReadOnly = value;
                SalaryOfEmployee.ReadOnly = value;
                NameOfWorkSalaryRate.ReadOnly = value;
            }
        }

        public SalaryRate SalaryRateEmployee
        {
            get
            {
                try
                {
                    SalaryRate employee = new SalaryRate(
                                NameOfEmployeeSalaryRate.Text,
                                SurnameOfEmployeeSalaryRate.Text,
                                PatronymicOfEmployeeSalaryRate.Text,
                                Convert.ToInt32(AgeOfEmployeeSalaryRate.Text),
                                Convert.ToDouble(RateOfEmployee.Text),
                                Convert.ToInt32(SalaryOfEmployee.Text),
                                NameOfWorkSalaryRate.Text);                    
                    return employee;
                }
                catch (Exception exception)
                {
                    if (exception is NullReferenceException || exception is ArgumentException || exception is PersonException)
                    {
                        MessageBox.Show(exception.Message);
                        return null;
                    }
                    else if (exception is FormatException)
                    {
                        MessageBox.Show(" В поле: <Возраст>; <Ставка>; <Оклад> - было введено не числовое значение.");
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
                var salaryEmployee = (SalaryRate)value;
                NameOfEmployeeSalaryRate.Text = salaryEmployee.Name;
                SurnameOfEmployeeSalaryRate.Text = salaryEmployee.Surname;
                PatronymicOfEmployeeSalaryRate.Text = salaryEmployee.Patronymic;
                AgeOfEmployeeSalaryRate.Text = Convert.ToString(salaryEmployee.Age);
                RateOfEmployee.Text = Convert.ToString(salaryEmployee.Rate);
                SalaryOfEmployee.Text = Convert.ToString(salaryEmployee.Salary);
                NameOfWorkSalaryRate.Text = Convert.ToString(salaryEmployee.NameOfWork);
            }
        }
        // Смываем с полей лишние символы
        public void ClearControl()
        {            
            NameOfEmployeeSalaryRate.Text = string.Empty;
            SurnameOfEmployeeSalaryRate.Text = string.Empty;
            PatronymicOfEmployeeSalaryRate.Text = string.Empty;
            AgeOfEmployeeSalaryRate.Text = string.Empty;
            RateOfEmployee.Text = string.Empty;
            SalaryOfEmployee.Text = string.Empty;
            NameOfWorkSalaryRate.Text = string.Empty;
        }
    }
}
