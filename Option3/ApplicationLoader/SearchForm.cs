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
    public partial class SearchForm : Form
    {
        //private SalaryMainForm frm;

        private List<ISalary> _localList = new List<ISalary>();

        public SearchForm()
        {
            InitializeComponent();
            //localList = l;
            //frm = mainForm;
        }

        private void searchStart_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = false;
                string search = searchTextBox.Text;
                if (search == String.Empty) { MessageBox.Show("Не было введенно ключевое слова(а)."); return; }
                dataGridView1.Rows.Clear();
                foreach (var person in _localList)
                {
                    string personString = person.Name + ' ' + person.Surname + ' ' + person.Patronymic
                        + ' ' + person.Age + ' ' + person.NameOfSalary +' ' + person.ShowPersonalSettings();
                    for (int i = 0; i < personString.Length; i++)
                    {
                        if (search[0] == personString[i])
                        {
                            if (search.Length + i <= personString.Length)
                            {
                                for (int j = 0; j < search.Length; j++)
                                {
                                    if(search[j] != personString[j + i])
                                    {
                                        break;
                                    }
                                    if(j == search.Length - 1)
                                    {
                                        check = true; // Если нашли что искали
                                        int number = dataGridView1.RowCount;
                                        dataGridView1.Rows.Add(number, person.Name, person.Surname, 
                                            person.Patronymic,person.Age, person.NameOfSalary, 
                                            person.ShowPersonalSettings());
                                    }
                                }
                            }
                            if(check) // Входим из цикла
                            {
                                break;
                            }
                        }
                    }
                }
                if(dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("Этого(их) сотрудника(ов) нет в списке.");
                }
                _localList.Clear();
            }
            catch
            {
                MessageBox.Show("Произошла ошибка.");
            }
        }

        public List<ISalary> LocalList
        { set { _localList = value; } }
    }
}
