namespace ApplicationLoader
{
    partial class SalaryMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalaryMainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RandomEmploy = new System.Windows.Forms.Button();
            this.SearchEmployee = new System.Windows.Forms.Button();
            this.ChangeDescription = new System.Windows.Forms.Button();
            this.RemoveEmployee = new System.Windows.Forms.Button();
            this.AddEmployee = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryAccrual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.employeeControlMainForm = new ApplicationLoader.EmployeeControl();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.RandomEmploy);
            this.groupBox1.Controls.Add(this.SearchEmployee);
            this.groupBox1.Controls.Add(this.ChangeDescription);
            this.groupBox1.Controls.Add(this.RemoveEmployee);
            this.groupBox1.Controls.Add(this.AddEmployee);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1149, 527);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "База данных о сотрудниках";
            // 
            // RandomEmploy
            // 
            this.RandomEmploy.Location = new System.Drawing.Point(1016, 498);
            this.RandomEmploy.Name = "RandomEmploy";
            this.RandomEmploy.Size = new System.Drawing.Size(127, 23);
            this.RandomEmploy.TabIndex = 5;
            this.RandomEmploy.Text = "Случайный сотрудник";
            this.RandomEmploy.UseVisualStyleBackColor = true;
            this.RandomEmploy.Click += new System.EventHandler(this.RandomEmploy_Click);
            // 
            // SearchEmployee
            // 
            this.SearchEmployee.Location = new System.Drawing.Point(529, 498);
            this.SearchEmployee.Name = "SearchEmployee";
            this.SearchEmployee.Size = new System.Drawing.Size(175, 23);
            this.SearchEmployee.TabIndex = 4;
            this.SearchEmployee.Text = "Найти сотрудника по описанию";
            this.SearchEmployee.UseVisualStyleBackColor = true;
            this.SearchEmployee.Click += new System.EventHandler(this.SearchEmployee_Click);
            // 
            // ChangeDescription
            // 
            this.ChangeDescription.Location = new System.Drawing.Point(154, 498);
            this.ChangeDescription.Name = "ChangeDescription";
            this.ChangeDescription.Size = new System.Drawing.Size(182, 23);
            this.ChangeDescription.TabIndex = 3;
            this.ChangeDescription.Text = "Изменить описание сотрудника";
            this.ChangeDescription.UseVisualStyleBackColor = true;
            this.ChangeDescription.Click += new System.EventHandler(this.ChangeDescription_Click);
            // 
            // RemoveEmployee
            // 
            this.RemoveEmployee.Location = new System.Drawing.Point(342, 498);
            this.RemoveEmployee.Name = "RemoveEmployee";
            this.RemoveEmployee.Size = new System.Drawing.Size(181, 23);
            this.RemoveEmployee.TabIndex = 2;
            this.RemoveEmployee.Text = "Удалить из списка сотрудника";
            this.RemoveEmployee.UseVisualStyleBackColor = true;
            this.RemoveEmployee.Click += new System.EventHandler(this.RemoveEmployee_Click);
            // 
            // AddEmployee
            // 
            this.AddEmployee.Location = new System.Drawing.Point(6, 498);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(142, 23);
            this.AddEmployee.TabIndex = 1;
            this.AddEmployee.Text = "Добавить сотрудника";
            this.AddEmployee.UseVisualStyleBackColor = true;
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.name,
            this.surname,
            this.patronymic,
            this.age,
            this.salary,
            this.description,
            this.salaryAccrual});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1137, 473);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // number
            // 
            this.number.HeaderText = "#";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Width = 50;
            // 
            // name
            // 
            this.name.HeaderText = "Имя";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // surname
            // 
            this.surname.HeaderText = "Фамилия";
            this.surname.Name = "surname";
            this.surname.ReadOnly = true;
            // 
            // patronymic
            // 
            this.patronymic.HeaderText = "Отчество";
            this.patronymic.Name = "patronymic";
            this.patronymic.ReadOnly = true;
            // 
            // age
            // 
            this.age.HeaderText = "Возраст";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            this.age.Width = 60;
            // 
            // salary
            // 
            this.salary.HeaderText = "Вид зарплаты";
            this.salary.Name = "salary";
            this.salary.ReadOnly = true;
            this.salary.Width = 110;
            // 
            // description
            // 
            this.description.HeaderText = "Описание";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 460;
            // 
            // salaryAccrual
            // 
            this.salaryAccrual.HeaderText = "Зарплата в руб.";
            this.salaryAccrual.Name = "salaryAccrual";
            this.salaryAccrual.ReadOnly = true;
            this.salaryAccrual.Width = 120;
            // 
            // CreateToolStripMenuItem2
            // 
            this.CreateToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem});
            this.CreateToolStripMenuItem2.Name = "CreateToolStripMenuItem2";
            this.CreateToolStripMenuItem2.Size = new System.Drawing.Size(48, 20);
            this.CreateToolStripMenuItem2.Text = "Файл";
            // 
            // CreateToolStripMenuItem
            // 
            this.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            this.CreateToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.CreateToolStripMenuItem.Text = "Создать";
            this.CreateToolStripMenuItem.Click += new System.EventHandler(this.CreateToolStripMenuItem_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.OpenToolStripMenuItem.Text = "Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1602, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // employeeControlMainForm
            // 
            this.employeeControlMainForm.Employee = null;
            this.employeeControlMainForm.Location = new System.Drawing.Point(1167, 46);
            this.employeeControlMainForm.Name = "employeeControlMainForm";
            this.employeeControlMainForm.ReadOnly = false;
            this.employeeControlMainForm.Size = new System.Drawing.Size(433, 386);
            this.employeeControlMainForm.TabIndex = 2;
            // 
            // SalaryMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1602, 557);
            this.Controls.Add(this.employeeControlMainForm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1618, 596);
            this.MinimumSize = new System.Drawing.Size(1618, 596);
            this.Name = "SalaryMainForm";
            this.Text = "База по зарплатам сотрудников";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SalaryMainForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem CreateToolStripMenuItem2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button AddEmployee;
        private System.Windows.Forms.Button RemoveEmployee;
        private System.Windows.Forms.Button ChangeDescription;
        private System.Windows.Forms.Button SearchEmployee;
        private System.Windows.Forms.ToolStripMenuItem CreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.Button RandomEmploy;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryAccrual;
        private EmployeeControl employeeControlMainForm;
    }
}

