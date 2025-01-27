namespace WinFormsAppclass_home
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            listView1 = new ListView();
            gbtask = new GroupBox();
            buttonClear = new Button();
            buttonAdd = new Button();
            label2 = new Label();
            textBoxDueDate = new TextBox();
            label3 = new Label();
            textBoxTask = new TextBox();
            groupBoxList = new GroupBox();
            gbtask.SuspendLayout();
            groupBoxList.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(20, 22);
            listView1.Name = "listView1";
            listView1.Size = new Size(383, 382);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // gbtask
            // 
            gbtask.Controls.Add(buttonClear);
            gbtask.Controls.Add(buttonAdd);
            gbtask.Controls.Add(label2);
            gbtask.Controls.Add(textBoxDueDate);
            gbtask.Controls.Add(label3);
            gbtask.Controls.Add(textBoxTask);
            gbtask.Location = new Point(12, 12);
            gbtask.Name = "gbtask";
            gbtask.Size = new Size(420, 159);
            gbtask.TabIndex = 8;
            gbtask.TabStop = false;
            gbtask.Text = "Task Form";
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(247, 127);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 23);
            buttonClear.TabIndex = 12;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(328, 127);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 11;
            buttonAdd.Text = "Add ToDo";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 106);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 10;
            label2.Text = "Due Date";
            // 
            // textBoxDueDate
            // 
            textBoxDueDate.Location = new Point(81, 98);
            textBoxDueDate.Name = "textBoxDueDate";
            textBoxDueDate.PlaceholderText = "2025-01-20";
            textBoxDueDate.Size = new Size(322, 23);
            textBoxDueDate.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 59);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 8;
            label3.Text = "Task";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(81, 59);
            textBoxTask.Name = "textBoxTask";
            textBoxTask.Size = new Size(322, 23);
            textBoxTask.TabIndex = 7;
            // 
            // groupBoxList
            // 
            groupBoxList.Controls.Add(listView1);
            groupBoxList.Location = new Point(12, 195);
            groupBoxList.Name = "groupBoxList";
            groupBoxList.Size = new Size(420, 410);
            groupBoxList.TabIndex = 9;
            groupBoxList.TabStop = false;
            groupBoxList.Text = "Task List";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 617);
            Controls.Add(groupBoxList);
            Controls.Add(gbtask);
            Name = "Form1";
            Text = "ToDo App";
            Load += Form1_Load;
            gbtask.ResumeLayout(false);
            gbtask.PerformLayout();
            groupBoxList.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ListView listView1;
        private GroupBox gbtask;
        private Button buttonClear;
        private Button buttonAdd;
        private Label label2;
        private TextBox textBoxDueDate;
        private Label label3;
        private TextBox textBoxTask;
        private GroupBox groupBoxList;
    }
}
