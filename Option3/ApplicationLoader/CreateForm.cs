using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Option3;

namespace ApplicationLoader
{
    public partial class CreateForm : Form
    {
        private ISalary _employee;

        private bool _check = false; // Проверка на создание и изменение описания

        public CreateForm()
        {
            InitializeComponent();            
        }

        private void Acсept_Click(object sender, EventArgs e)
        {
            try
            {                
                if (SalaryRate.Checked == true) // Оклад по ставке
                {
                    string name = NameOfEmployeeSalaryRate.Text;
                    string surname = SurnameOfEmployeeSalaryRate.Text;
                    string patronymic = PatronymicOfEmployeeSalaryRate.Text;
                    int age = Convert.ToInt32(AgeOfEmployeeSalaryRate.Text);
                    double rate = Convert.ToDouble(RateOfEmployee.Text);
                    int salary = Convert.ToInt32(SalaryOfEmployee.Text);
                    string nameofwork = NameOfWorkSalaryRate.Text;

                    _employee = new SalaryRate(name, surname, patronymic, age, rate, salary, nameofwork);
                }
                if (HourlyWage.Checked == true) // Почасовая оплата
                {
                    string name = NameOfEmployeeHourlyWage.Text;
                    string surname = SurnameOfEmployeeHourlyWage.Text;
                    string patronymic = PatronymicOfEmployeeHourlyWage.Text;
                    int age = Convert.ToInt32(AgeOfEmployeeHourlyWage.Text);
                    int salaryperhour = Convert.ToInt32(SalaryPerHour.Text);
                    int hour = Convert.ToInt32(Hour.Text);
                    string nameofwork = NameOfWorkOfEmployeeHourlyWage.Text;

                    _employee = new HourlyWage(name, surname, patronymic, age, salaryperhour, hour, nameofwork);
                }
                SalaryRate.Checked = false;
                HourlyWage.Checked = false;
                SalaryRateGroupBoxRate.Visible = false;
                HourlyWageGroupBox.Visible = false;
                _check = true;
                this.Close();                                                
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

        public ISalary Employee
        {
            get
            {
                return _employee;
            }
            set
            {
                _employee = value;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SalaryRate_MouseClick(object sender, MouseEventArgs e)
        {
            SalaryRateGroupBoxRate.Visible = true;
            SalaryRate.Checked = true;
            HourlyWage.Checked = false;
            HourlyWageGroupBox.Visible = false;                      
        }

        private void HourlyWage_MouseClick(object sender, MouseEventArgs e)
        {
            HourlyWageGroupBox.Visible = true;
            HourlyWage.Checked = true;
            SalaryRate.Checked = false;
            SalaryRateGroupBoxRate.Visible = false;                     
        }

        private void Modify()
        {
            if (_employee == null)
            {
                return;
            }

            if (_employee is SalaryRate)
            {
                var salaryEmployee = (SalaryRate)_employee;
                SalaryRate.Checked = false;
                HourlyWage.Checked = true;
                SalaryRateGroupBoxRate.Visible = true;
                HourlyWageGroupBox.Visible = false;

                NameOfEmployeeSalaryRate.Text = salaryEmployee.Name;
                SurnameOfEmployeeSalaryRate.Text = salaryEmployee.Surname;
                PatronymicOfEmployeeSalaryRate.Text = salaryEmployee.Patronymic;
                AgeOfEmployeeSalaryRate.Text = Convert.ToString(salaryEmployee.Age);
                RateOfEmployee.Text = Convert.ToString(salaryEmployee.Rate);
                SalaryOfEmployee.Text = Convert.ToString(salaryEmployee.Salary);
                NameOfWorkSalaryRate.Text = Convert.ToString(salaryEmployee.NameOfWork);
            }
            else if (_employee is HourlyWage)
            {
                var hourlyWageEmployee = (HourlyWage)_employee;
                HourlyWage.Checked = true;
                HourlyWageGroupBox.Visible = true;
                SalaryRate.Checked = false;                    
                SalaryRateGroupBoxRate.Visible = false;

                NameOfEmployeeHourlyWage.Text = hourlyWageEmployee.Name;
                SurnameOfEmployeeHourlyWage.Text = hourlyWageEmployee.Surname;
                PatronymicOfEmployeeHourlyWage.Text = hourlyWageEmployee.Patronymic;
                AgeOfEmployeeHourlyWage.Text = Convert.ToString(hourlyWageEmployee.Age);
                SalaryPerHour.Text = Convert.ToString(hourlyWageEmployee.SalaryPerHour);
                Hour.Text = Convert.ToString(hourlyWageEmployee.Hour);
                NameOfWorkOfEmployeeHourlyWage.Text = Convert.ToString(hourlyWageEmployee.NameOfWork);
            }
            else
            {
                throw new NullReferenceException(" Произошёл сбой при изменении работника!");
            }            
        }

        private void CreateForm_Load(object sender, EventArgs e)
        {
            Modify();
        }

        private void CreateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //_employee = null;
            if (!_check)
            {
                var result = MessageBox.Show("Хотите выйти из редактора?", "Сообщение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SalaryRate.Checked = false;
                    HourlyWage.Checked = false;
                    SalaryRateGroupBoxRate.Visible = false;
                    HourlyWageGroupBox.Visible = false;                    
                }
            }
            NameOfEmployeeSalaryRate.Text = string.Empty;
            SurnameOfEmployeeSalaryRate.Text = string.Empty;
            PatronymicOfEmployeeSalaryRate.Text = string.Empty;
            AgeOfEmployeeSalaryRate.Text = string.Empty;
            RateOfEmployee.Text = string.Empty;
            SalaryOfEmployee.Text = string.Empty;
            NameOfWorkSalaryRate.Text = string.Empty;

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