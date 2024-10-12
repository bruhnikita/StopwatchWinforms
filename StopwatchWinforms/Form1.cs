using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace StopwatchWinforms
{
    public partial class Form1 : Form
    {
        private Stopwatch stopwatch;
        private System.Windows.Forms.Timer timer;
        private TimeSpan countdownTime;
        private bool isTimerRunning = false;

        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            stopwatch = new Stopwatch();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; 
            timer.Tick += Timer_Tick;

            lblStopwatchTime.Text = "00:00:00"; 
            lblTimerTime.Text = "00:00:00"; 
        }

        private void btnStartStopwatch_Click(object sender, EventArgs e)
        {
            if (stopwatch.IsRunning)
            {
                stopwatch.Stop();
                btnStartStopwatch.Text = "Запустить секундомер";
            }
            else
            {
                stopwatch.Start();
                btnStartStopwatch.Text = "Стоп";
                timer.Start(); 
            }
        }

        private void UpdateStopwatchDisplay()
        {
            lblStopwatchTime.Text = stopwatch.Elapsed.ToString(@"hh\:mm\:ss");
        }

        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            if (isTimerRunning)
            {
                timer.Stop();
                isTimerRunning = false;
                btnStartTimer.Text = "Запустить таймер";
                lblTimerTime.Text = "00:00:00"; 
            }
            else
            {
                if (TimeSpan.TryParse(txtTimerInput.Text, out countdownTime))
                {
                    lblTimerTime.Text = countdownTime.ToString(@"hh\:mm\:ss");
                    isTimerRunning = true;
                    timer.Start();
                    btnStartTimer.Text = "Стоп";
                }
                else
                {
                    MessageBox.Show("Введите корректное время в формате ЧЧ:ММ:СС");
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (isTimerRunning && countdownTime > TimeSpan.Zero)
            {
                countdownTime = countdownTime.Add(TimeSpan.FromSeconds(-1));
                lblTimerTime.Text = countdownTime.ToString(@"hh\:mm\:ss");
            }
            else if (isTimerRunning && countdownTime <= TimeSpan.Zero)
            {
                timer.Stop();
                isTimerRunning = false;
                btnStartTimer.Text = "Запустить таймер";
                lblTimerTime.Text = "00:00:00"; 
                MessageBox.Show("Время вышло!");
            }

            if (stopwatch.IsRunning)
            {
                UpdateStopwatchDisplay();
            }
        }

        private void btnAllReset_Click(object sender, EventArgs e)
        {
            if (stopwatch.IsRunning)
            {
                stopwatch.Stop();
                btnStartStopwatch.Text = "Запустить секундомер";
            }
            lblStopwatchTime.Text = "00:00:00"; 


            if (isTimerRunning)
            {
                timer.Stop();
                isTimerRunning = false;
                btnStartTimer.Text = "Запустить таймер";
            }
            lblTimerTime.Text = "00:00:00"; 
            txtTimerInput.Clear(); 
        }

    }
}
