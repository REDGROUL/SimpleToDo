namespace todo
{
    partial class Tasks
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.datetime_stop = new System.Windows.Forms.DateTimePicker();
            this.saveTask = new System.Windows.Forms.Button();
            this.datetime_start = new System.Windows.Forms.DateTimePicker();
            this.newTaskStatus = new System.Windows.Forms.ComboBox();
            this.newTaskName = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.datetime_stop);
            this.splitContainer1.Panel1.Controls.Add(this.saveTask);
            this.splitContainer1.Panel1.Controls.Add(this.datetime_start);
            this.splitContainer1.Panel1.Controls.Add(this.newTaskStatus);
            this.splitContainer1.Panel1.Controls.Add(this.newTaskName);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(886, 512);
            this.splitContainer1.SplitterDistance = 295;
            this.splitContainer1.TabIndex = 0;
            // 
            // datetime_stop
            // 
            this.datetime_stop.Location = new System.Drawing.Point(13, 106);
            this.datetime_stop.Name = "datetime_stop";
            this.datetime_stop.Size = new System.Drawing.Size(266, 20);
            this.datetime_stop.TabIndex = 5;
            // 
            // saveTask
            // 
            this.saveTask.Location = new System.Drawing.Point(13, 135);
            this.saveTask.Name = "saveTask";
            this.saveTask.Size = new System.Drawing.Size(266, 23);
            this.saveTask.TabIndex = 4;
            this.saveTask.Text = "save";
            this.saveTask.UseVisualStyleBackColor = true;
            this.saveTask.Click += new System.EventHandler(this.saveTask_Click);
            // 
            // datetime_start
            // 
            this.datetime_start.Location = new System.Drawing.Point(13, 80);
            this.datetime_start.Name = "datetime_start";
            this.datetime_start.Size = new System.Drawing.Size(266, 20);
            this.datetime_start.TabIndex = 3;
            // 
            // newTaskStatus
            // 
            this.newTaskStatus.FormattingEnabled = true;
            this.newTaskStatus.Items.AddRange(new object[] {
            "Новая",
            "В работе",
            "Завершено"});
            this.newTaskStatus.Location = new System.Drawing.Point(13, 53);
            this.newTaskStatus.Name = "newTaskStatus";
            this.newTaskStatus.Size = new System.Drawing.Size(266, 21);
            this.newTaskStatus.TabIndex = 2;
            // 
            // newTaskName
            // 
            this.newTaskName.Location = new System.Drawing.Point(13, 27);
            this.newTaskName.Name = "newTaskName";
            this.newTaskName.Size = new System.Drawing.Size(266, 20);
            this.newTaskName.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(587, 512);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 512);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Tasks";
            this.Text = "Tasks";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tasks_FormClosing);
            this.Resize += new System.EventHandler(this.Tasks_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox newTaskName;
        private System.Windows.Forms.DateTimePicker datetime_stop;
        private System.Windows.Forms.Button saveTask;
        private System.Windows.Forms.DateTimePicker datetime_start;
        private System.Windows.Forms.ComboBox newTaskStatus;
    }
}