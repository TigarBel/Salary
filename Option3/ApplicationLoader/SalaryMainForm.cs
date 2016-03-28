using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
using Newtonsoft.Json;
using Option3;

namespace ApplicationLoader
{
    public partial class SalaryMainForm : Form
    {
        //private DataTable _datatable;   

        private List<ISalary> list = new List<ISalary>();

        private CreateForm _createForm = new CreateForm();

        private SearchForm _searchForm = new SearchForm();      

        public SalaryMainForm()
        {
            InitializeComponent();
            //CreateDataTable();            
        }

        //private void CreateDataTable()
        //{
        //    _datatable = new DataTable();
        //    var column = new DataColumn("#")
        //    {
        //        Caption = "Number",
        //        DataType = typeof(int),
        //        ReadOnly = true
        //    };
        //    _datatable.Columns.Add(column);
        //    var column2 = new DataColumn("Имя")
        //    {
        //        Caption = "Name",
        //        DataType = typeof(string),
        //        ReadOnly = true
        //    };
        //    _datatable.Columns.Add(column2);
        //    var column3 = new DataColumn("Фамилия")
        //    {
        //        Caption = "Surname",
        //        DataType = typeof(string),
        //        ReadOnly = true
        //    };
        //    _datatable.Columns.Add(column3);
        //    var column4 = new DataColumn("Отчество")
        //    {
        //        Caption = "Patronymic",
        //        DataType = typeof(string),
        //        ReadOnly = true
        //    };
        //    _datatable.Columns.Add(column4);
        //    var column5 = new DataColumn("Возраст")
        //    {
        //        Caption = "Age",
        //        DataType = typeof(int),
        //        ReadOnly = true
        //    };
        //    _datatable.Columns.Add(column5);
        //    var column6 = new DataColumn("Вид зарплаты")
        //    {
        //        Caption = "Salary",
        //        DataType = typeof(string),
        //        ReadOnly = true
        //    };
        //    _datatable.Columns.Add(column6);
        //    var column7 = new DataColumn("Описание")
        //    {
        //        Caption = "Description",
        //        DataType = typeof(string),
        //        ReadOnly = true
        //    };
        //    _datatable.Columns.Add(column7);
        //    dataGridView1.DataSource = _datatable;
        //}

        private void AddEmployee_Click(object sender, EventArgs e)
        {                                             
            _createForm.ShowDialog(); //Вызов окна
            if (_createForm.Employee != null) list.Add(_createForm.Employee); // Вносим в список работника, если форма хранит описание сотрудника  
            FillingTable(); // Заполняем таблицу
            _createForm.Employee = null; // Сносим объект с второй формы
        }

        private void RemoveEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    var result = MessageBox.Show("Действительно хотите удалить сотрудника из списка?", "Внимание!", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        if (list.Count == 1) // Проверка на количество объектов в списке
                        {
                            list.Clear(); // Если остался один
                        }
                        else
                        {
                            int id = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());                            
                            list.RemoveAt(id); // Если больше одного
                        }
                        FillingTable(); // Заполняем таблицу
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChangeDescription_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                _createForm.Employee = list[dataGridView1.CurrentRow.Index]; // Вносим выбранный объект в новую форму
                _createForm.ShowDialog(); //Вызов окна
                list[dataGridView1.CurrentRow.Index] = _createForm.Employee; // Вносим в список работника
                FillingTable(); // Заполняем таблицу
                _createForm.Employee = null; // Сносим объект с второй формы
            }
        }     

        private void SalaryMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Хотите выйти? Не сохранённые данные будут удалены!", 
                "Внимание!", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Заполнение таблицы списком
        /// </summary>
        private void FillingTable()
        {
            dataGridView1.Rows.Clear(); // Очищаем таблицу           
            foreach (ISalary person in list) // Заполняем таблицу
            {
                int number = dataGridView1.RowCount;
                dataGridView1.Rows.Add(number, person.Name, person.Surname, person.Patronymic,
                    person.Age, person.NameOfSalary, person.ShowPersonalSettings());
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter =
                    "myfile files (*.myfile)|*.myfile|txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.RestoreDirectory = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filename = saveFileDialog.FileName;

                    var serializer = new JsonSerializer
                    {
                        NullValueHandling = NullValueHandling.Ignore,
                        TypeNameHandling = TypeNameHandling.Auto,
                        Formatting = Newtonsoft.Json.Formatting.Indented
                    };
                    using (StreamWriter sw = new StreamWriter(filename))
                    {
                        using (JsonWriter writer = new JsonTextWriter(sw))
                        {
                            serializer.Serialize(writer, list);
                        }
                    }

                    // Xml Сериализация***
                    //XmlSerializer serialize = new XmlSerializer(typeof(DataTable));

                    //// Creates a DataSet; adds a table, column, and ten rows.
                    //DataTable table = new DataTable("myTable");
                    //DataColumn c0 = new DataColumn("Имя");
                    //table.Columns.Add(c0);
                    //DataColumn c1 = new DataColumn("Фамилия");
                    //table.Columns.Add(c1);
                    //DataColumn c2 = new DataColumn("Отчество");
                    //table.Columns.Add(c2);
                    //DataColumn c3 = new DataColumn("Возраст");
                    //table.Columns.Add(c3);
                    //DataColumn c4 = new DataColumn("Вид зарплаты");
                    //table.Columns.Add(c4);
                    //DataColumn c5 = new DataColumn("Ставка/Почасовая оплата");
                    //table.Columns.Add(c5);
                    //DataColumn c6 = new DataColumn("Оклад/Часов рабочего месяца");
                    //table.Columns.Add(c6);
                    //DataColumn c7 = new DataColumn("Должность");
                    //table.Columns.Add(c7);
                    //foreach (ISalary person in list) // Заполняем таблицу данных для сериализации
                    //{
                    //    if (person is SalaryRate) // Заполняем таблицу объектом SalaryRate
                    //    {
                    //        var employee = (SalaryRate)person;
                    //        table.Rows.Add(employee.Name, employee.Surname, employee.Patronymic,
                    //            employee.Age, employee.NameOfSalary, employee.Rate, employee.Salary,
                    //            employee.NameOfWork);
                    //    }
                    //    else if (person is HourlyWage) // Заполняем таблицу объектом HourlyWage
                    //    {
                    //        var employee = (HourlyWage)person;
                    //        table.Rows.Add(employee.Name, employee.Surname, employee.Patronymic,
                    //            employee.Age, employee.NameOfSalary, employee.SalaryPerHour, employee.Hour,
                    //            employee.NameOfWork);
                    //    }
                    //    else { throw new Exception(); } // Если в ряды затисался шпион
                    //}
                    //TextWriter writer = new StreamWriter(filename);
                    //serialize.Serialize(writer, table);
                    //writer.Close();

                    MessageBox.Show("Сохранение прошло успешно.");
                }

                                
            }
            catch
            {
                MessageBox.Show("Произошла ошибка. Файл не сохранился.");
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                list.Clear();

                var openFileDialog = new OpenFileDialog();
                openFileDialog.Filter =
                    "myfile files (*.myfile)|*.myfile|txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filename = openFileDialog.FileName;

                    var deserializer = new JsonSerializer
                    {
                        NullValueHandling = NullValueHandling.Ignore,
                        TypeNameHandling = TypeNameHandling.Auto,
                        Formatting = Newtonsoft.Json.Formatting.Indented
                    };
                    using (StreamReader sr = new StreamReader(filename))
                    {
                        using (JsonReader reader = new JsonTextReader(sr))
                        {
                            list = deserializer.Deserialize<List<ISalary>>(reader);
                        }
                    }

                    // Xml Десериализация***
                    //// Create an instance of the XmlSerializer specifying type and namespace.
                    //XmlSerializer serializer = new XmlSerializer(typeof(DataTable));

                    //// A FileStream is needed to read the XML document.
                    //FileStream fs = new FileStream(filename, FileMode.Open);
                    //XmlReader reader = XmlReader.Create(fs);

                    //// Declare an object variable of the type to be deserialized.
                    //DataTable table;

                    //// Use the Deserialize method to restore the object's state.
                    //table = (DataTable)serializer.Deserialize(reader);
                    ////dataGridView1.DataSource = table;
                    //fs.Close();
                    //for (int i = 0; i < table.Rows.Count; i++)
                    //{
                    //    ISalary employee;
                    //    // Если в строке хранится объект SalaryRate
                    //    if (table.Rows[i]["Вид зарплаты"].ToString() == "Оклад по ставке")
                    //    { // Заполняем новый объект
                    //        employee = new SalaryRate(table.Rows[i]["Имя"].ToString(),
                    //            table.Rows[i]["Фамилия"].ToString(),
                    //            table.Rows[i]["Отчество"].ToString(),
                    //            Convert.ToInt32(table.Rows[i]["Возраст"].ToString()),
                    //            Convert.ToDouble(table.Rows[i]["Ставка/Почасовая оплата"].ToString()),
                    //            Convert.ToInt32(table.Rows[i]["Оклад/Часов рабочего месяца"].ToString()),
                    //            table.Rows[i]["Должность"].ToString());
                    //        list.Add(employee); // Вносим в список
                    //    }
                    //    if (table.Rows[i]["Вид зарплаты"].ToString() == "Почасовая оплата") // Если в строке хранится объект HourlyWage
                    //    { // Заполняем новый объект
                    //        employee = new HourlyWage(table.Rows[i]["Имя"].ToString(),
                    //            table.Rows[i]["Фамилия"].ToString(),
                    //            table.Rows[i]["Отчество"].ToString(),
                    //            Convert.ToInt32(table.Rows[i]["Возраст"].ToString()),
                    //            Convert.ToInt32(table.Rows[i]["Ставка/Почасовая оплата"].ToString()),
                    //            Convert.ToInt32(table.Rows[i]["Оклад/Часов рабочего месяца"].ToString()),
                    //            table.Rows[i]["Должность"].ToString());
                    //        list.Add(employee); // Вносим в список
                    //    }
                    //}
                }
                FillingTable(); // Заполняем таблицу
            }
            catch(Exception ex)
            {
                //MessageBox.Show("Произошла ошибка. Файл не был открыт.");
                MessageBox.Show(ex.Message);
            }
        }
        //Кнопка по вызову формы по поиску сотрудника
        private void SearchEmployee_Click(object sender, EventArgs e)
        {
            _searchForm.LocalList = list;
            _searchForm.ShowDialog();
        }
        // Кнопка создания новой базы данных
        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var result = MessageBox.Show("Создать новую базу данных? Не сохранённые данные будут удалены!",
                    "Внимание!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    list.Clear();
                    dataGridView1.Rows.Clear();
                }
            }
        }
        /// <summary>
        /// Кнопка по созданию случайных сотрудников
        /// </summary>
        /// <param name="sender">ничего</param>
        /// <param name="e">ничего</param>
        private void RandomEmploy_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            int number = rand.Next(2);
            string[] nameM = { "Владимир", "Владислав", "Вячеслав", "Георгий", "Александр", "Алексей", "Иван", "Евгений" };
            string[] nameF = { "Александра", "Анна", "Анастасия", "Галина", "Елена", "Елизавета", "Екатерина" };
            string[] surnameM = { "Петров", "Сидоров", "Кузнецов", "Григорьев", "Хохлов", "Колганов", "Харлампьев",
		        "Васильев", "Урываев", "Тихонов", "Песков", "Темников", "Гаврилов", "Иванов", "Фиников" };
            string[] surnameF = { "Петрова", "Сидорова", "Кузнецова", "Григорьева", "Хохлова", "Колганова", "Харлампьева",
		        "Васильева", "Урываева", "Тихонова", "Пескова", "Темникова", "Гаврилова", "Иванова", "Финикова" };
            string[] patronymicM = { "Владимирович", "Владиславович", "Вячеславович", "Георгиевич", "Александрович", "Алексеевич", "Иванович", "Евгениевич" };
            string[] patronymicF = { "Владимировна", "Владиславна", "Вячеславна", "Георгиевна", "Александрвна", "Алексеевна", "Ивановна", "Евгениевна" };
            string[] nameofwork = { "техник", "оператор", "менеджер", "связной", "секретарь", "машинист", "диспетчер", "механик" };

            if (number == 1)
            {
                number = rand.Next(2);
                if (number == 1)
                {
                    number = rand.Next(nameM.Length);
                    string nameEmployee = nameM[number];

                    number = rand.Next(surnameM.Length);
                    string surnameEmployee = surnameM[number];

                    number = rand.Next(patronymicM.Length);
                    string patronymicEmployee = patronymicM[number];

                    int ageEmployee = rand.Next(47) + 18;

                    double rateEmployee = Convert.ToDouble(rand.Next(1, 10)) / 10;
                   
                    int salaryEmployee = rand.Next(60001) + 10000;

                    number = rand.Next(nameofwork.Length);
                    string nameofworkEmployee = nameofwork[number];

                    SalaryRate employee = new SalaryRate(nameEmployee, surnameEmployee, patronymicEmployee, ageEmployee, rateEmployee,
                    salaryEmployee, nameofworkEmployee);
                    list.Add(employee);
                }
                else
                {
                    number = rand.Next(nameF.Length);
                    string nameEmployee = nameF[number];

                    number = rand.Next(surnameF.Length);
                    string surnameEmployee = surnameF[number];

                    number = rand.Next(patronymicF.Length);
                    string patronymicEmployee = patronymicF[number];

                    int ageEmployee = rand.Next(47) + 18;

                    double rateEmployee = Convert.ToDouble(rand.Next(1, 10)) / 10;

                    int salaryEmployee = rand.Next(60001) + 10000;

                    number = rand.Next(nameofwork.Length);
                    string nameofworkEmployee = nameofwork[number];

                    SalaryRate employee = new SalaryRate(nameEmployee, surnameEmployee, patronymicEmployee, ageEmployee, rateEmployee,
                    salaryEmployee, nameofworkEmployee);
                    list.Add(employee);
                }
                
            }
            else
            {
                number = rand.Next(2);
                if (number == 1)
                {
                    number = rand.Next(nameM.Length);
                    string nameEmployee = nameM[number];

                    number = rand.Next(surnameM.Length);
                    string surnameEmployee = surnameM[number];

                    number = rand.Next(patronymicM.Length);
                    string patronymicEmployee = patronymicM[number];

                    int ageEmployee = rand.Next(18, 65);

                    int salaryPerHourEmployee = rand.Next(100, 500);

                    int hourEmployee = rand.Next(32,160);

                    number = rand.Next(nameofwork.Length);
                    string nameofworkEmployee = nameofwork[number];

                    HourlyWage employee = new HourlyWage(nameEmployee, surnameEmployee, patronymicEmployee, ageEmployee, salaryPerHourEmployee,
                    hourEmployee, nameofworkEmployee);
                    list.Add(employee);
                }
                else
                {
                    number = rand.Next(nameF.Length);
                    string nameEmployee = nameF[number];

                    number = rand.Next(surnameF.Length);
                    string surnameEmployee = surnameF[number];

                    number = rand.Next(patronymicF.Length);
                    string patronymicEmployee = patronymicF[number];

                    int ageEmployee = rand.Next(18,65);

                    int salaryPerHourEmployee = rand.Next(100,500);

                    int hourEmployee = rand.Next(32, 160);

                    number = rand.Next(nameofwork.Length);
                    string nameofworkEmployee = nameofwork[number];

                    HourlyWage employee = new HourlyWage(nameEmployee, surnameEmployee, patronymicEmployee, ageEmployee, salaryPerHourEmployee,
                    hourEmployee, nameofworkEmployee);
                    list.Add(employee);
                }
            }            
            FillingTable(); // Заполняем таблицу
            _createForm.Employee = null; // Сносим объект с второй формы
        }        
    }
}