using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ShutdownTimer
{
    public partial class ShutdownTimerForm : Form
    {
        private DateTime shutdownTime;
        private bool allowClose;
        private bool forceShutdown;

        public ShutdownTimerForm()
        {
            InitializeComponent();
            for (int hour = 0; hour <= 999; hour++)
            {
                _ = customHoursComboBox.Items.Add(hour.ToString());
            }
            for (int minute = 0; minute < 60; minute++)
            {
                _ = customMinutesComboBox.Items.Add(minute.ToString("00"));
            }
            customHoursComboBox.SelectedIndex = 1;
            customMinutesComboBox.SelectedIndex = 30;

            Icon = System.Drawing.Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            trayIcon.Icon = Icon;

            Resize += Form1_Resize;
            FormClosing += Form1_FormClosing;
            minutes15RadioButton.CheckedChanged += DurationRadioButton_CheckedChanged;
            minutes30RadioButton.CheckedChanged += DurationRadioButton_CheckedChanged;
            minutes45RadioButton.CheckedChanged += DurationRadioButton_CheckedChanged;
            minutes60RadioButton.CheckedChanged += DurationRadioButton_CheckedChanged;
            hours3RadioButton.CheckedChanged += DurationRadioButton_CheckedChanged;
            customRadioButton.CheckedChanged += DurationRadioButton_CheckedChanged;
            startButton.Click += StartButton_Click;
            cancelButton.Click += CancelButton_Click;
            countdownTimer.Tick += CountdownTimer_Tick;
            trayIcon.DoubleClick += TrayIcon_DoubleClick;
            trayIcon.MouseMove += TrayIcon_MouseMove;
            exitMenuItem.Click += ExitMenuItem_Click;
        }

        private void DurationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            customHoursComboBox.Enabled = customRadioButton.Checked;
            customMinutesComboBox.Enabled = customRadioButton.Checked;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            int minutes = minutes15RadioButton.Checked ? 30 :
                minutes30RadioButton.Checked ? 60 :
                minutes45RadioButton.Checked ? 90 :
                minutes60RadioButton.Checked ? 120 :
                hours3RadioButton.Checked ? 180 : GetCustomMinutes();

            if (minutes <= 0)
            {
                _ = MessageBox.Show("Invalid timer duration.", "Invalid duration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            forceShutdown = forceShutdownCheckBox.Checked;
            shutdownTime = DateTime.Now.AddMinutes(minutes);
            durationGroupBox.Visible = false;
            startButton.Visible = false;
            forceShutdownCheckBox.Visible = false;
            countdownLabel.Visible = true;
            cancelButton.Visible = true;
            countdownTimer.Start();
            UpdateCountdown();
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            UpdateCountdown();
        }

        private void UpdateCountdown()
        {
            TimeSpan remaining = shutdownTime - DateTime.Now;

            if (remaining <= TimeSpan.Zero)
            {
                countdownTimer.Stop();
                trayIcon.Text = "Shutdown Timer";
                ShutdownWindows(forceShutdown);
                return;
            }

            countdownLabel.Text = FormatRemaining(remaining);
            trayIcon.Text = "Shutdown in " + FormatRemaining(remaining);
        }

        private int GetCustomMinutes()
        {

            return !int.TryParse(customHoursComboBox.Text, out int hours) ||
                !int.TryParse(customMinutesComboBox.Text, out int minutes) ||
                hours < 0 || hours > 999 || minutes < 0 || minutes > 59
                ? 0
                : (hours * 60) + minutes;
        }

        private static string FormatRemaining(TimeSpan remaining)
        {
            return remaining.TotalDays >= 1 ? remaining.ToString(@"d\.hh\:mm\:ss") : remaining.ToString(@"hh\:mm\:ss");
        }

        private static void ShutdownWindows(bool forceShutdown)
        {
            using (Process process = new Process())
            {
                process.StartInfo = new ProcessStartInfo
                {
                    FileName = "shutdown.exe",
                    Arguments = forceShutdown ? "/s /f /t 0" : "/s /t 0",
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    WindowStyle = ProcessWindowStyle.Hidden
                };

                _ = process.Start();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            countdownTimer.Stop();
            shutdownTime = DateTime.MinValue;
            trayIcon.Text = "Shutdown Timer";
            durationGroupBox.Visible = true;
            startButton.Visible = true;
            forceShutdownCheckBox.Visible = true;
            countdownLabel.Visible = false;
            cancelButton.Visible = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                HideToTray();
            }
        }

        private void HideToTray()
        {
            Hide();
            ShowInTaskbar = false;
        }

        private void TrayIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();
            ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
            Activate();
        }

        private void TrayIcon_MouseMove(object sender, MouseEventArgs e)
        {
            if (shutdownTime > DateTime.Now)
            {
                trayIcon.Text = "Shutdown in " + FormatRemaining(shutdownTime - DateTime.Now);
            }
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            allowClose = true;
            trayIcon.Visible = false;
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!allowClose)
            {
                e.Cancel = true;
                HideToTray();
            }
        }

        private void ShutdownTimerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
