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
    public partial class EmployeeControl : UserControl
    {
        bool _check = false;

        public EmployeeControl()
        {
            InitializeComponent();
        }

        public bool ReadOnly
        {
            get { return _check; }
            set
            {
                _check = value;
                if (_check)
                {
                    SalaryRate.Enabled = false;
                    HourlyWage.Enabled = false;

                    salaryRateControl1.ReadOnly = true;
                    hourlyWageControl1.ReadOnly = true;
                }
                else
                {
                    SalaryRate.Enabled = true;
                    HourlyWage.Enabled = true;                    

                    salaryRateControl1.ReadOnly = false;
                    hourlyWageControl1.ReadOnly = false;
                }
            }
        }

        public ISalary Employee
        {
            get
            {
                if (SalaryRate.Checked) // Оклад по ставке
                {                                        
                    return salaryRateControl1.SalaryRateEmployee;
                }
                if (HourlyWage.Checked) // Почасовая оплата
                {
                    return hourlyWageControl1.HourlyWageEmployee;
                }
                SalaryRate.Checked = false;
                HourlyWage.Checked = false;
                hourlyWageControl1.Visible = false;
                salaryRateControl1.Visible = false;
                return null;
            }
            set
            {
                    if (value is SalaryRate)
                    {
                        SalaryRate.Checked = true;
                        HourlyWage.Checked = false;
                        hourlyWageControl1.Visible = false;
                        salaryRateControl1.Visible = true;

                        salaryRateControl1.SalaryRateEmployee = (SalaryRate)value;
                    }
                    else if (value is HourlyWage)
                    {
                        HourlyWage.Checked = true;
                        hourlyWageControl1.Visible = true;
                        SalaryRate.Checked = false;
                        salaryRateControl1.Visible = false;

                        hourlyWageControl1.HourlyWageEmployee = (HourlyWage)value;
                    }
                    //else
                    //{
                    //    throw new NullReferenceException(" Произошёл сбой при изменении работника!");
                    //}               
            }
        }

        private void HourlyWage_MouseClick(object sender, MouseEventArgs e)
        {
            HourlyWage.Checked = true;
            hourlyWageControl1.Visible = true;
            SalaryRate.Checked = false;
            salaryRateControl1.Visible = false;
        }

        private void SalaryRate_MouseClick(object sender, MouseEventArgs e)
        {
            SalaryRate.Checked = true;
            HourlyWage.Checked = false;
            hourlyWageControl1.Visible = false;
            salaryRateControl1.Visible = true;
        }
        // Смываем с обоих полей лишние символы
        public void ClearControl()
        {
            salaryRateControl1.ClearControl();//Очищаем контрол
            hourlyWageControl1.ClearControl();//Очищаем контрол
            salaryRateControl1.Visible = false;//Делаем невидемым
            hourlyWageControl1.Visible = false;//Делаем невидемым
            SalaryRate.Checked = false;//Убираем выбранные радио батоны
            HourlyWage.Checked = false;//Убираем выбранные радио батоны            
        }
    }
}
