namespace WinFormsTODO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddTODO = new Button();
            txtTask = new TextBox();
            Task = new Label();
            DueDate = new Label();
            txtDueDate = new TextBox();
            btnClear = new Button();
            gbTaskForm = new GroupBox();
            gbTaskList = new GroupBox();
            gbTaskForm.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddTODO
            // 
            btnAddTODO.Location = new Point(322, 126);
            btnAddTODO.Name = "btnAddTODO";
            btnAddTODO.Size = new Size(75, 23);
            btnAddTODO.TabIndex = 0;
            btnAddTODO.Text = "Add TODO";
            btnAddTODO.UseVisualStyleBackColor = true;
            // 
            // txtTask
            // 
            txtTask.Location = new Point(131, 40);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(266, 23);
            txtTask.TabIndex = 1;
            // 
            // Task
            // 
            Task.AutoSize = true;
            Task.Location = new Point(73, 40);
            Task.Name = "Task";
            Task.Size = new Size(30, 15);
            Task.TabIndex = 2;
            Task.Text = "Task";
            Task.Click += label1_Click;
            // 
            // DueDate
            // 
            DueDate.AutoSize = true;
            DueDate.Location = new Point(73, 94);
            DueDate.Name = "DueDate";
            DueDate.Size = new Size(55, 15);
            DueDate.TabIndex = 3;
            DueDate.Text = "Due Date";
            // 
            // txtDueDate
            // 
            txtDueDate.Location = new Point(131, 94);
            txtDueDate.Name = "txtDueDate";
            txtDueDate.Size = new Size(266, 23);
            txtDueDate.TabIndex = 4;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(241, 126);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // gbTaskForm
            // 
            gbTaskForm.Controls.Add(txtTask);
            gbTaskForm.Controls.Add(btnClear);
            gbTaskForm.Controls.Add(btnAddTODO);
            gbTaskForm.Controls.Add(txtDueDate);
            gbTaskForm.Controls.Add(Task);
            gbTaskForm.Controls.Add(DueDate);
            gbTaskForm.Location = new Point(138, 26);
            gbTaskForm.Name = "gbTaskForm";
            gbTaskForm.Size = new Size(506, 163);
            gbTaskForm.TabIndex = 6;
            gbTaskForm.TabStop = false;
            gbTaskForm.Text = "Task Form";
            // 
            // gbTaskList
            // 
            gbTaskList.Location = new Point(138, 228);
            gbTaskList.Name = "gbTaskList";
            gbTaskList.Size = new Size(506, 202);
            gbTaskList.TabIndex = 7;
            gbTaskList.TabStop = false;
            gbTaskList.Text = "Task List";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbTaskList);
            Controls.Add(gbTaskForm);
            Name = "Form1";
            Text = "Form1";
            gbTaskForm.ResumeLayout(false);
            gbTaskForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddTODO;
        private TextBox txtTask;
        private Label Task;
        private Label DueDate;
        private TextBox txtDueDate;
        private Button btnClear;
        private GroupBox gbTaskForm;
        private GroupBox gbTaskList;
    }
}
