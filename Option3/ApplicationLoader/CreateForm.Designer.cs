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
            this.CancelButton = new System.Windows.Forms.Button();
            this.AcсeptButton = new System.Windows.Forms.Button();
            this.employeeControlCreateForm = new ApplicationLoader.EmployeeControl();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(353, 362);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(82, 24);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Назад";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AcсeptButton
            // 
            this.AcсeptButton.Location = new System.Drawing.Point(12, 363);
            this.AcсeptButton.Name = "AcсeptButton";
            this.AcсeptButton.Size = new System.Drawing.Size(75, 23);
            this.AcсeptButton.TabIndex = 3;
            this.AcсeptButton.Text = "Ок";
            this.AcсeptButton.UseVisualStyleBackColor = true;
            this.AcсeptButton.Click += new System.EventHandler(this.Acсept_Click);
            // 
            // employeeControlCreateForm
            // 
            this.employeeControlCreateForm.Employee = null;
            this.employeeControlCreateForm.Location = new System.Drawing.Point(12, 6);
            this.employeeControlCreateForm.Name = "employeeControlCreateForm";
            this.employeeControlCreateForm.ReadOnly = false;
            this.employeeControlCreateForm.Size = new System.Drawing.Size(434, 351);
            this.employeeControlCreateForm.TabIndex = 5;
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(446, 394);
            this.Controls.Add(this.employeeControlCreateForm);
            this.Controls.Add(this.AcсeptButton);
            this.Controls.Add(this.CancelButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(462, 433);
            this.MinimumSize = new System.Drawing.Size(462, 433);
            this.Name = "CreateForm";
            this.Text = "Сотрудник";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AcсeptButton;
        private EmployeeControl employeeControlCreateForm;
    }
}