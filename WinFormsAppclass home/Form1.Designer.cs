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
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
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
            gbtask.Controls.Add(button1);
            gbtask.Controls.Add(button2);
            gbtask.Controls.Add(label2);
            gbtask.Controls.Add(textBox1);
            gbtask.Controls.Add(label3);
            gbtask.Controls.Add(textBox2);
            gbtask.Location = new Point(12, 12);
            gbtask.Name = "gbtask";
            gbtask.Size = new Size(420, 159);
            gbtask.TabIndex = 8;
            gbtask.TabStop = false;
            gbtask.Text = "Task Form";
            // 
            // button1
            // 
            button1.Location = new Point(247, 127);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(328, 127);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "Add ToDo";
            button2.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            textBox1.Location = new Point(81, 98);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "2025-01-20";
            textBox1.Size = new Size(322, 23);
            textBox1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 59);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 8;
            label3.Text = "Task";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(81, 59);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(322, 23);
            textBox2.TabIndex = 7;
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
            gbtask.ResumeLayout(false);
            gbtask.PerformLayout();
            groupBoxList.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ListView listView1;
        private GroupBox gbtask;
        private Button button1;
        private Button button2;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private GroupBox groupBoxList;
    }
}
