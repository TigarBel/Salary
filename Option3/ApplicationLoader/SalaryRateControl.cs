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
                if (value)
                {
                    NameOfEmployeeSalaryRate.ReadOnly = true;
                    SurnameOfEmployeeSalaryRate.ReadOnly = true;
                    PatronymicOfEmployeeSalaryRate.ReadOnly = true;
                    AgeOfEmployeeSalaryRate.ReadOnly = true;
                    RateOfEmployee.ReadOnly = true;
                    SalaryOfEmployee.ReadOnly = true;
                    NameOfWorkSalaryRate.ReadOnly = true;
                }
                else
                {
                    NameOfEmployeeSalaryRate.ReadOnly = false;
                    SurnameOfEmployeeSalaryRate.ReadOnly = false;
                    PatronymicOfEmployeeSalaryRate.ReadOnly = false;
                    AgeOfEmployeeSalaryRate.ReadOnly = false;
                    RateOfEmployee.ReadOnly = false;
                    SalaryOfEmployee.ReadOnly = false;
                    NameOfWorkSalaryRate.ReadOnly = false;
                }
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
                    var salaryEmployee = (SalaryRate)value;
                    NameOfEmployeeSalaryRate.Text = salaryEmployee.Name;
                    SurnameOfEmployeeSalaryRate.Text = salaryEmployee.Surname;
                    PatronymicOfEmployeeSalaryRate.Text = salaryEmployee.Patronymic;
                    AgeOfEmployeeSalaryRate.Text = Convert.ToString(salaryEmployee.Age);
                    RateOfEmployee.Text = Convert.ToString(salaryEmployee.Rate);
                    SalaryOfEmployee.Text = Convert.ToString(salaryEmployee.Salary);
                    NameOfWorkSalaryRate.Text = Convert.ToString(salaryEmployee.NameOfWork);
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
