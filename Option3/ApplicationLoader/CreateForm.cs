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
        /// <summary>
        /// Работник, хранимый в этой форме
        /// </summary>
        private ISalary _employee;        

        public CreateForm()
        {
            InitializeComponent();        
        }        
        /// <summary>
        /// Свойства работника
        /// </summary>
        public ISalary Employee
        {
            get
            {
                return _employee;
            }
            set
            {
                _employee = value;
                employeeControlCreateForm.Employee = value;
            }
        }
        /// <summary>
        /// AcceptButton кнопка по завершению создания работника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Acсept_Click(object sender, EventArgs e)
        {
            _employee = employeeControlCreateForm.Employee;
            if (_employee != null)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show(" Поля не заполнены.");
            }
        }
        /// <summary>
        /// CancelButton кнопка для прерывания процесса создания работника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_Click(object sender, EventArgs e)
        {
            _employee = null;
            this.Close();
        }
        /// <summary>
        /// Метод вызываемый при закрывании формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            employeeControlCreateForm.ClearControl(); // Очищаем поля конролов и делаем их невидимыми
        }
    }
}