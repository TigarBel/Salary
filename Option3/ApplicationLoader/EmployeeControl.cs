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
                SalaryRate.Enabled = !_check;
                HourlyWage.Enabled = !_check;
                salaryRateControl1.ReadOnly = _check;
                hourlyWageControl1.ReadOnly = _check;
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
                        salaryRateControl1.Visible = true;
                        HourlyWage.Checked = false;
                        hourlyWageControl1.Visible = false;
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
            }
        }

        private void HourlyWage_MouseClick(object sender, MouseEventArgs e)
        {
            HourlyWage.Checked = true;
            hourlyWageControl1.Visible = HourlyWage.Checked;
            SalaryRate.Checked = !HourlyWage.Checked;
            salaryRateControl1.Visible = !HourlyWage.Checked;
        }

        private void SalaryRate_MouseClick(object sender, MouseEventArgs e)
        {
            SalaryRate.Checked = true;
            salaryRateControl1.Visible = SalaryRate.Checked;
            HourlyWage.Checked = !SalaryRate.Checked;
            hourlyWageControl1.Visible = !SalaryRate.Checked;            
        }
        // Смываем с обоих полей лишние символы и делаем их невидимыми
        public void ClearControl()
        {
            salaryRateControl1.ClearControl();//Очищаем контрол
            hourlyWageControl1.ClearControl();//Очищаем контрол
            SalaryRate.Checked = false;//Убираем выбранные радио батоны
            HourlyWage.Checked = false;//Убираем выбранные радио батоны          
            salaryRateControl1.Visible = SalaryRate.Checked;//Делаем невидемым
            hourlyWageControl1.Visible = HourlyWage.Checked;//Делаем невидемым              
        }
    }
}
