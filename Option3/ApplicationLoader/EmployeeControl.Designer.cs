namespace ApplicationLoader
{
    partial class EmployeeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HourlyWage = new System.Windows.Forms.RadioButton();
            this.SalaryRate = new System.Windows.Forms.RadioButton();
            this.salaryRateControl1 = new ApplicationLoader.SalaryRateControl();
            this.hourlyWageControl1 = new ApplicationLoader.HourlyWageControl();
            this.SuspendLayout();
            // 
            // HourlyWage
            // 
            this.HourlyWage.AutoCheck = false;
            this.HourlyWage.AutoSize = true;
            this.HourlyWage.Location = new System.Drawing.Point(3, 26);
            this.HourlyWage.Name = "HourlyWage";
            this.HourlyWage.Size = new System.Drawing.Size(187, 17);
            this.HourlyWage.TabIndex = 6;
            this.HourlyWage.TabStop = true;
            this.HourlyWage.Text = "Сотрудник с почасовой оплатой";
            this.HourlyWage.UseVisualStyleBackColor = true;
            this.HourlyWage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HourlyWage_MouseClick);
            // 
            // SalaryRate
            // 
            this.SalaryRate.AutoCheck = false;
            this.SalaryRate.AutoSize = true;
            this.SalaryRate.Location = new System.Drawing.Point(3, 3);
            this.SalaryRate.Name = "SalaryRate";
            this.SalaryRate.Size = new System.Drawing.Size(229, 17);
            this.SalaryRate.TabIndex = 5;
            this.SalaryRate.TabStop = true;
            this.SalaryRate.Text = "Сотрудник с зарплатой оклад по ставке";
            this.SalaryRate.UseVisualStyleBackColor = true;
            this.SalaryRate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SalaryRate_MouseClick);
            // 
            // salaryRateControl1
            // 
            this.salaryRateControl1.Location = new System.Drawing.Point(3, 49);
            this.salaryRateControl1.Name = "salaryRateControl1";
            this.salaryRateControl1.Size = new System.Drawing.Size(433, 306);
            this.salaryRateControl1.TabIndex = 12;
            this.salaryRateControl1.Visible = false;
            // 
            // hourlyWageControl1
            // 
            this.hourlyWageControl1.Location = new System.Drawing.Point(3, 49);
            this.hourlyWageControl1.Name = "hourlyWageControl1";
            this.hourlyWageControl1.Size = new System.Drawing.Size(431, 304);
            this.hourlyWageControl1.TabIndex = 11;
            this.hourlyWageControl1.Visible = false;
            // 
            // EmployeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.salaryRateControl1);
            this.Controls.Add(this.hourlyWageControl1);
            this.Controls.Add(this.HourlyWage);
            this.Controls.Add(this.SalaryRate);
            this.Name = "EmployeeControl";
            this.Size = new System.Drawing.Size(434, 351);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton HourlyWage;
        private System.Windows.Forms.RadioButton SalaryRate;
        private HourlyWageControl hourlyWageControl1;
        private SalaryRateControl salaryRateControl1;
    }
}
