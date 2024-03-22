namespace todo
{
    partial class CurrentTask
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.taskName = new System.Windows.Forms.Label();
            this.taskStatus = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Stop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // taskName
            // 
            this.taskName.AutoSize = true;
            this.taskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskName.Location = new System.Drawing.Point(26, 11);
            this.taskName.Name = "taskName";
            this.taskName.Size = new System.Drawing.Size(142, 20);
            this.taskName.TabIndex = 0;
            this.taskName.Text = "Название задачи";
            // 
            // taskStatus
            // 
            this.taskStatus.AutoSize = true;
            this.taskStatus.Location = new System.Drawing.Point(174, 16);
            this.taskStatus.Name = "taskStatus";
            this.taskStatus.Size = new System.Drawing.Size(37, 13);
            this.taskStatus.TabIndex = 1;
            this.taskStatus.Text = "Status";
            this.taskStatus.Click += new System.EventHandler(this.taskStatus_Click);
            // 
            // Start
            // 
            this.Start.AutoSize = true;
            this.Start.Location = new System.Drawing.Point(27, 43);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(35, 13);
            this.Start.TabIndex = 2;
            this.Start.Text = "label2";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(207, 69);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Закрыть";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Stop
            // 
            this.Stop.AutoSize = true;
            this.Stop.Location = new System.Drawing.Point(27, 70);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(35, 13);
            this.Stop.TabIndex = 4;
            this.Stop.Text = "label1";
            // 
            // CurrentTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.taskStatus);
            this.Controls.Add(this.taskName);
            this.Name = "CurrentTask";
            this.Size = new System.Drawing.Size(481, 111);
            this.AutoSizeChanged += new System.EventHandler(this.CurrentTask_AutoSizeChanged);
            this.Click += new System.EventHandler(this.CurrentTask_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label taskName;
        private System.Windows.Forms.Label taskStatus;
        private System.Windows.Forms.Label Start;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label Stop;
    }
}
