namespace ApplicationLoader
{
    partial class CreateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateForm));
            this.SalaryRate = new System.Windows.Forms.RadioButton();
            this.HourlyWage = new System.Windows.Forms.RadioButton();
            this.SalaryRateGroupBoxRate = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameOfWorkSalaryRate = new System.Windows.Forms.TextBox();
            this.SalaryOfEmployee = new System.Windows.Forms.TextBox();
            this.RateOfEmployee = new System.Windows.Forms.TextBox();
            this.AgeOfEmployeeSalaryRate = new System.Windows.Forms.TextBox();
            this.PatronymicOfEmployeeSalaryRate = new System.Windows.Forms.TextBox();
            this.SurnameOfEmployeeSalaryRate = new System.Windows.Forms.TextBox();
            this.NameOfEmployeeSalaryRate = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.HourlyWageGroupBox = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.NameOfWorkOfEmployeeHourlyWage = new System.Windows.Forms.TextBox();
            this.Hour = new System.Windows.Forms.TextBox();
            this.SalaryPerHour = new System.Windows.Forms.TextBox();
            this.AgeOfEmployeeHourlyWage = new System.Windows.Forms.TextBox();
            this.PatronymicOfEmployeeHourlyWage = new System.Windows.Forms.TextBox();
            this.SurnameOfEmployeeHourlyWage = new System.Windows.Forms.TextBox();
            this.NameOfEmployeeHourlyWage = new System.Windows.Forms.TextBox();
            this.Acсept = new System.Windows.Forms.Button();
            this.SalaryRateGroupBoxRate.SuspendLayout();
            this.HourlyWageGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalaryRate
            // 
            this.SalaryRate.AutoCheck = false;
            this.SalaryRate.AutoSize = true;
            this.SalaryRate.Location = new System.Drawing.Point(12, 12);
            this.SalaryRate.Name = "SalaryRate";
            this.SalaryRate.Size = new System.Drawing.Size(229, 17);
            this.SalaryRate.TabIndex = 0;
            this.SalaryRate.TabStop = true;
            this.SalaryRate.Text = "Сотрудник с зарплатой оклад по ставке";
            this.SalaryRate.UseVisualStyleBackColor = true;
            this.SalaryRate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SalaryRate_MouseClick);
            // 
            // HourlyWage
            // 
            this.HourlyWage.AutoCheck = false;
            this.HourlyWage.AutoSize = true;
            this.HourlyWage.Location = new System.Drawing.Point(12, 35);
            this.HourlyWage.Name = "HourlyWage";
            this.HourlyWage.Size = new System.Drawing.Size(187, 17);
            this.HourlyWage.TabIndex = 1;
            this.HourlyWage.TabStop = true;
            this.HourlyWage.Text = "Сотрудник с почасовой оплатой";
            this.HourlyWage.UseVisualStyleBackColor = true;
            this.HourlyWage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HourlyWage_MouseClick);
            // 
            // SalaryRateGroupBoxRate
            // 
            this.SalaryRateGroupBoxRate.Controls.Add(this.label7);
            this.SalaryRateGroupBoxRate.Controls.Add(this.label6);
            this.SalaryRateGroupBoxRate.Controls.Add(this.label5);
            this.SalaryRateGroupBoxRate.Controls.Add(this.label4);
            this.SalaryRateGroupBoxRate.Controls.Add(this.label3);
            this.SalaryRateGroupBoxRate.Controls.Add(this.label2);
            this.SalaryRateGroupBoxRate.Controls.Add(this.label1);
            this.SalaryRateGroupBoxRate.Controls.Add(this.NameOfWorkSalaryRate);
            this.SalaryRateGroupBoxRate.Controls.Add(this.SalaryOfEmployee);
            this.SalaryRateGroupBoxRate.Controls.Add(this.RateOfEmployee);
            this.SalaryRateGroupBoxRate.Controls.Add(this.AgeOfEmployeeSalaryRate);
            this.SalaryRateGroupBoxRate.Controls.Add(this.PatronymicOfEmployeeSalaryRate);
            this.SalaryRateGroupBoxRate.Controls.Add(this.SurnameOfEmployeeSalaryRate);
            this.SalaryRateGroupBoxRate.Controls.Add(this.NameOfEmployeeSalaryRate);
            this.SalaryRateGroupBoxRate.Location = new System.Drawing.Point(12, 58);
            this.SalaryRateGroupBoxRate.Name = "SalaryRateGroupBoxRate";
            this.SalaryRateGroupBoxRate.Size = new System.Drawing.Size(425, 298);
            this.SalaryRateGroupBoxRate.TabIndex = 2;
            this.SalaryRateGroupBoxRate.TabStop = false;
            this.SalaryRateGroupBoxRate.Text = "Описание сотрудника";
            this.SalaryRateGroupBoxRate.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Наименование рабочего места";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Оклад";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ставка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Возраст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Имя";
            // 
            // NameOfWorkSalaryRate
            // 
            this.NameOfWorkSalaryRate.Location = new System.Drawing.Point(9, 266);
            this.NameOfWorkSalaryRate.Name = "NameOfWorkSalaryRate";
            this.NameOfWorkSalaryRate.Size = new System.Drawing.Size(140, 20);
            this.NameOfWorkSalaryRate.TabIndex = 6;
            // 
            // SalaryOfEmployee
            // 
            this.SalaryOfEmployee.Location = new System.Drawing.Point(9, 227);
            this.SalaryOfEmployee.Name = "SalaryOfEmployee";
            this.SalaryOfEmployee.Size = new System.Drawing.Size(140, 20);
            this.SalaryOfEmployee.TabIndex = 5;
            // 
            // RateOfEmployee
            // 
            this.RateOfEmployee.Location = new System.Drawing.Point(9, 188);
            this.RateOfEmployee.Name = "RateOfEmployee";
            this.RateOfEmployee.Size = new System.Drawing.Size(25, 20);
            this.RateOfEmployee.TabIndex = 4;
            // 
            // AgeOfEmployeeSalaryRate
            // 
            this.AgeOfEmployeeSalaryRate.Location = new System.Drawing.Point(9, 149);
            this.AgeOfEmployeeSalaryRate.Name = "AgeOfEmployeeSalaryRate";
            this.AgeOfEmployeeSalaryRate.Size = new System.Drawing.Size(40, 20);
            this.AgeOfEmployeeSalaryRate.TabIndex = 3;
            // 
            // PatronymicOfEmployeeSalaryRate
            // 
            this.PatronymicOfEmployeeSalaryRate.Location = new System.Drawing.Point(9, 110);
            this.PatronymicOfEmployeeSalaryRate.Name = "PatronymicOfEmployeeSalaryRate";
            this.PatronymicOfEmployeeSalaryRate.Size = new System.Drawing.Size(140, 20);
            this.PatronymicOfEmployeeSalaryRate.TabIndex = 2;
            // 
            // SurnameOfEmployeeSalaryRate
            // 
            this.SurnameOfEmployeeSalaryRate.Location = new System.Drawing.Point(9, 71);
            this.SurnameOfEmployeeSalaryRate.Name = "SurnameOfEmployeeSalaryRate";
            this.SurnameOfEmployeeSalaryRate.Size = new System.Drawing.Size(140, 20);
            this.SurnameOfEmployeeSalaryRate.TabIndex = 1;
            // 
            // NameOfEmployeeSalaryRate
            // 
            this.NameOfEmployeeSalaryRate.Location = new System.Drawing.Point(9, 32);
            this.NameOfEmployeeSalaryRate.Name = "NameOfEmployeeSalaryRate";
            this.NameOfEmployeeSalaryRate.Size = new System.Drawing.Size(140, 20);
            this.NameOfEmployeeSalaryRate.TabIndex = 0;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(353, 362);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(82, 24);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Назад";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // HourlyWageGroupBox
            // 
            this.HourlyWageGroupBox.Controls.Add(this.label8);
            this.HourlyWageGroupBox.Controls.Add(this.label9);
            this.HourlyWageGroupBox.Controls.Add(this.label10);
            this.HourlyWageGroupBox.Controls.Add(this.label11);
            this.HourlyWageGroupBox.Controls.Add(this.label12);
            this.HourlyWageGroupBox.Controls.Add(this.label13);
            this.HourlyWageGroupBox.Controls.Add(this.label14);
            this.HourlyWageGroupBox.Controls.Add(this.NameOfWorkOfEmployeeHourlyWage);
            this.HourlyWageGroupBox.Controls.Add(this.Hour);
            this.HourlyWageGroupBox.Controls.Add(this.SalaryPerHour);
            this.HourlyWageGroupBox.Controls.Add(this.AgeOfEmployeeHourlyWage);
            this.HourlyWageGroupBox.Controls.Add(this.PatronymicOfEmployeeHourlyWage);
            this.HourlyWageGroupBox.Controls.Add(this.SurnameOfEmployeeHourlyWage);
            this.HourlyWageGroupBox.Controls.Add(this.NameOfEmployeeHourlyWage);
            this.HourlyWageGroupBox.Location = new System.Drawing.Point(12, 58);
            this.HourlyWageGroupBox.Name = "HourlyWageGroupBox";
            this.HourlyWageGroupBox.Size = new System.Drawing.Size(425, 298);
            this.HourlyWageGroupBox.TabIndex = 2;
            this.HourlyWageGroupBox.TabStop = false;
            this.HourlyWageGroupBox.Text = "Описание сотрудника";
            this.HourlyWageGroupBox.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Наименование рабочего места";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Часов в месяц";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Плата за один час";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Возраст";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Отчество";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Фамилия";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Имя";
            // 
            // NameOfWorkOfEmployeeHourlyWage
            // 
            this.NameOfWorkOfEmployeeHourlyWage.Location = new System.Drawing.Point(9, 266);
            this.NameOfWorkOfEmployeeHourlyWage.Name = "NameOfWorkOfEmployeeHourlyWage";
            this.NameOfWorkOfEmployeeHourlyWage.Size = new System.Drawing.Size(140, 20);
            this.NameOfWorkOfEmployeeHourlyWage.TabIndex = 6;
            // 
            // Hour
            // 
            this.Hour.Location = new System.Drawing.Point(9, 227);
            this.Hour.Name = "Hour";
            this.Hour.Size = new System.Drawing.Size(60, 20);
            this.Hour.TabIndex = 5;
            // 
            // SalaryPerHour
            // 
            this.SalaryPerHour.Location = new System.Drawing.Point(9, 188);
            this.SalaryPerHour.Name = "SalaryPerHour";
            this.SalaryPerHour.Size = new System.Drawing.Size(60, 20);
            this.SalaryPerHour.TabIndex = 4;
            // 
            // AgeOfEmployeeHourlyWage
            // 
            this.AgeOfEmployeeHourlyWage.Location = new System.Drawing.Point(9, 149);
            this.AgeOfEmployeeHourlyWage.Name = "AgeOfEmployeeHourlyWage";
            this.AgeOfEmployeeHourlyWage.Size = new System.Drawing.Size(40, 20);
            this.AgeOfEmployeeHourlyWage.TabIndex = 3;
            // 
            // PatronymicOfEmployeeHourlyWage
            // 
            this.PatronymicOfEmployeeHourlyWage.Location = new System.Drawing.Point(9, 110);
            this.PatronymicOfEmployeeHourlyWage.Name = "PatronymicOfEmployeeHourlyWage";
            this.PatronymicOfEmployeeHourlyWage.Size = new System.Drawing.Size(140, 20);
            this.PatronymicOfEmployeeHourlyWage.TabIndex = 2;
            // 
            // SurnameOfEmployeeHourlyWage
            // 
            this.SurnameOfEmployeeHourlyWage.Location = new System.Drawing.Point(9, 71);
            this.SurnameOfEmployeeHourlyWage.Name = "SurnameOfEmployeeHourlyWage";
            this.SurnameOfEmployeeHourlyWage.Size = new System.Drawing.Size(140, 20);
            this.SurnameOfEmployeeHourlyWage.TabIndex = 1;
            // 
            // NameOfEmployeeHourlyWage
            // 
            this.NameOfEmployeeHourlyWage.Location = new System.Drawing.Point(9, 32);
            this.NameOfEmployeeHourlyWage.Name = "NameOfEmployeeHourlyWage";
            this.NameOfEmployeeHourlyWage.Size = new System.Drawing.Size(140, 20);
            this.NameOfEmployeeHourlyWage.TabIndex = 0;
            // 
            // Acсept
            // 
            this.Acсept.Location = new System.Drawing.Point(12, 363);
            this.Acсept.Name = "Acсept";
            this.Acсept.Size = new System.Drawing.Size(75, 23);
            this.Acсept.TabIndex = 3;
            this.Acсept.Text = "Ок";
            this.Acсept.UseVisualStyleBackColor = true;
            this.Acсept.Click += new System.EventHandler(this.Acсept_Click);
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(442, 394);
            this.Controls.Add(this.HourlyWageGroupBox);
            this.Controls.Add(this.Acсept);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.SalaryRateGroupBoxRate);
            this.Controls.Add(this.HourlyWage);
            this.Controls.Add(this.SalaryRate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(458, 433);
            this.MinimumSize = new System.Drawing.Size(458, 433);
            this.Name = "CreateForm";
            this.Text = "Сотрудник";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateForm_FormClosed);
            this.Load += new System.EventHandler(this.CreateForm_Load);
            this.SalaryRateGroupBoxRate.ResumeLayout(false);
            this.SalaryRateGroupBoxRate.PerformLayout();
            this.HourlyWageGroupBox.ResumeLayout(false);
            this.HourlyWageGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton SalaryRate;
        private System.Windows.Forms.RadioButton HourlyWage;
        private System.Windows.Forms.GroupBox SalaryRateGroupBoxRate;
        private System.Windows.Forms.TextBox NameOfWorkSalaryRate;
        private System.Windows.Forms.TextBox SalaryOfEmployee;
        private System.Windows.Forms.TextBox RateOfEmployee;
        private System.Windows.Forms.TextBox AgeOfEmployeeSalaryRate;
        private System.Windows.Forms.TextBox PatronymicOfEmployeeSalaryRate;
        private System.Windows.Forms.TextBox SurnameOfEmployeeSalaryRate;
        private System.Windows.Forms.TextBox NameOfEmployeeSalaryRate;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.GroupBox HourlyWageGroupBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox NameOfWorkOfEmployeeHourlyWage;
        private System.Windows.Forms.TextBox Hour;
        private System.Windows.Forms.TextBox SalaryPerHour;
        private System.Windows.Forms.TextBox AgeOfEmployeeHourlyWage;
        private System.Windows.Forms.TextBox PatronymicOfEmployeeHourlyWage;
        private System.Windows.Forms.TextBox SurnameOfEmployeeHourlyWage;
        private System.Windows.Forms.TextBox NameOfEmployeeHourlyWage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Acсept;
    }
}