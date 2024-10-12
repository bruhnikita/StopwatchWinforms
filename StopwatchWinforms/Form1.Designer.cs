namespace StopwatchWinforms
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
            btnStartTimer = new Button();
            btnStartStopwatch = new Button();
            lblTimerTime = new Label();
            lblStopwatchTime = new Label();
            txtTimerInput = new TextBox();
            btnAllReset = new Button();
            SuspendLayout();
            // 
            // btnStartTimer
            // 
            btnStartTimer.Dock = DockStyle.Bottom;
            btnStartTimer.Location = new Point(0, 236);
            btnStartTimer.Name = "btnStartTimer";
            btnStartTimer.Size = new Size(435, 50);
            btnStartTimer.TabIndex = 0;
            btnStartTimer.Text = "Запустить таймер";
            btnStartTimer.UseVisualStyleBackColor = true;
            btnStartTimer.Click += btnStartTimer_Click;
            // 
            // btnStartStopwatch
            // 
            btnStartStopwatch.Dock = DockStyle.Bottom;
            btnStartStopwatch.Location = new Point(0, 186);
            btnStartStopwatch.Name = "btnStartStopwatch";
            btnStartStopwatch.Size = new Size(435, 50);
            btnStartStopwatch.TabIndex = 1;
            btnStartStopwatch.Text = "Запустить секундомер";
            btnStartStopwatch.UseVisualStyleBackColor = true;
            btnStartStopwatch.Click += btnStartStopwatch_Click;
            // 
            // lblTimerTime
            // 
            lblTimerTime.AutoSize = true;
            lblTimerTime.Dock = DockStyle.Fill;
            lblTimerTime.Location = new Point(0, 0);
            lblTimerTime.Name = "lblTimerTime";
            lblTimerTime.Size = new Size(49, 15);
            lblTimerTime.TabIndex = 3;
            lblTimerTime.Text = "00:00:00";
            // 
            // lblStopwatchTime
            // 
            lblStopwatchTime.AutoSize = true;
            lblStopwatchTime.Location = new Point(0, 15);
            lblStopwatchTime.Name = "lblStopwatchTime";
            lblStopwatchTime.Size = new Size(49, 15);
            lblStopwatchTime.TabIndex = 4;
            lblStopwatchTime.Text = "00:00:00";
            // 
            // txtTimerInput
            // 
            txtTimerInput.Location = new Point(2, 39);
            txtTimerInput.Name = "txtTimerInput";
            txtTimerInput.PlaceholderText = "Введите время для таймера (HH:mm:ss)";
            txtTimerInput.Size = new Size(433, 23);
            txtTimerInput.TabIndex = 5;
            // 
            // btnAllReset
            // 
            btnAllReset.Dock = DockStyle.Bottom;
            btnAllReset.Location = new Point(0, 136);
            btnAllReset.Name = "btnAllReset";
            btnAllReset.Size = new Size(435, 50);
            btnAllReset.TabIndex = 6;
            btnAllReset.Text = "Сброс";
            btnAllReset.UseVisualStyleBackColor = true;
            btnAllReset.Click += btnAllReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 286);
            Controls.Add(btnAllReset);
            Controls.Add(txtTimerInput);
            Controls.Add(lblStopwatchTime);
            Controls.Add(lblTimerTime);
            Controls.Add(btnStartStopwatch);
            Controls.Add(btnStartTimer);
            Name = "Form1";
            Text = "Секундомер и Таймер";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Button btnStartTimer;
        private Button btnStartStopwatch;
        private Label lblTimerTime;
        private Label lblStopwatchTime;
        private TextBox txtTimerInput;
        private Button btnAllReset;
    }
}
