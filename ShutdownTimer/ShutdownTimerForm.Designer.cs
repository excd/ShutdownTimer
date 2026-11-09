namespace ShutdownTimer
{
    partial class ShutdownTimerForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.GroupBox durationGroupBox;
        private System.Windows.Forms.RadioButton minutes15RadioButton;
        private System.Windows.Forms.RadioButton minutes30RadioButton;
        private System.Windows.Forms.RadioButton minutes45RadioButton;
        private System.Windows.Forms.RadioButton minutes60RadioButton;
        private System.Windows.Forms.RadioButton hours3RadioButton;
        private System.Windows.Forms.RadioButton customRadioButton;
        private System.Windows.Forms.ComboBox customHoursComboBox;
        private System.Windows.Forms.ComboBox customMinutesComboBox;
        private System.Windows.Forms.CheckBox forceShutdownCheckBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label countdownLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayMenu;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.Timer countdownTimer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShutdownTimerForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.durationGroupBox = new System.Windows.Forms.GroupBox();
            this.minutes15RadioButton = new System.Windows.Forms.RadioButton();
            this.minutes30RadioButton = new System.Windows.Forms.RadioButton();
            this.minutes45RadioButton = new System.Windows.Forms.RadioButton();
            this.minutes60RadioButton = new System.Windows.Forms.RadioButton();
            this.hours3RadioButton = new System.Windows.Forms.RadioButton();
            this.customRadioButton = new System.Windows.Forms.RadioButton();
            this.customHoursComboBox = new System.Windows.Forms.ComboBox();
            this.customMinutesComboBox = new System.Windows.Forms.ComboBox();
            this.forceShutdownCheckBox = new System.Windows.Forms.CheckBox();
            this.startButton = new System.Windows.Forms.Button();
            this.countdownLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.durationGroupBox.SuspendLayout();
            this.trayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(24, 18);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(174, 30);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Shutdown timer";
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(185)))), ((int)(((byte)(195)))));
            this.instructionLabel.Location = new System.Drawing.Point(26, 55);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(232, 15);
            this.instructionLabel.TabIndex = 2;
            this.instructionLabel.Text = "Choose when Windows should shut down.";
            // 
            // durationGroupBox
            // 
            this.durationGroupBox.Controls.Add(this.minutes15RadioButton);
            this.durationGroupBox.Controls.Add(this.minutes30RadioButton);
            this.durationGroupBox.Controls.Add(this.minutes45RadioButton);
            this.durationGroupBox.Controls.Add(this.minutes60RadioButton);
            this.durationGroupBox.Controls.Add(this.hours3RadioButton);
            this.durationGroupBox.Controls.Add(this.customRadioButton);
            this.durationGroupBox.Controls.Add(this.customHoursComboBox);
            this.durationGroupBox.Controls.Add(this.customMinutesComboBox);
            this.durationGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(225)))));
            this.durationGroupBox.Location = new System.Drawing.Point(25, 88);
            this.durationGroupBox.Name = "durationGroupBox";
            this.durationGroupBox.Size = new System.Drawing.Size(360, 166);
            this.durationGroupBox.TabIndex = 3;
            this.durationGroupBox.TabStop = false;
            this.durationGroupBox.Text = "Duration";
            // 
            // minutes15RadioButton
            // 
            this.minutes15RadioButton.AutoSize = true;
            this.minutes15RadioButton.Checked = true;
            this.minutes15RadioButton.Location = new System.Drawing.Point(18, 28);
            this.minutes15RadioButton.Name = "minutes15RadioButton";
            this.minutes15RadioButton.Size = new System.Drawing.Size(83, 19);
            this.minutes15RadioButton.TabIndex = 0;
            this.minutes15RadioButton.TabStop = true;
            this.minutes15RadioButton.Text = "30 minutes";
            // 
            // minutes30RadioButton
            // 
            this.minutes30RadioButton.AutoSize = true;
            this.minutes30RadioButton.Location = new System.Drawing.Point(18, 54);
            this.minutes30RadioButton.Name = "minutes30RadioButton";
            this.minutes30RadioButton.Size = new System.Drawing.Size(83, 19);
            this.minutes30RadioButton.TabIndex = 1;
            this.minutes30RadioButton.Text = "1 hour";
            // 
            // minutes45RadioButton
            // 
            this.minutes45RadioButton.AutoSize = true;
            this.minutes45RadioButton.Location = new System.Drawing.Point(18, 80);
            this.minutes45RadioButton.Name = "minutes45RadioButton";
            this.minutes45RadioButton.Size = new System.Drawing.Size(83, 19);
            this.minutes45RadioButton.TabIndex = 2;
            this.minutes45RadioButton.Text = "1 hour 30 minutes";
            // 
            // minutes60RadioButton
            // 
            this.minutes60RadioButton.AutoSize = true;
            this.minutes60RadioButton.Location = new System.Drawing.Point(18, 106);
            this.minutes60RadioButton.Name = "minutes60RadioButton";
            this.minutes60RadioButton.Size = new System.Drawing.Size(83, 19);
            this.minutes60RadioButton.TabIndex = 3;
            this.minutes60RadioButton.Text = "2 hours";
            // 
            // hours3RadioButton
            // 
            this.hours3RadioButton.AutoSize = true;
            this.hours3RadioButton.Location = new System.Drawing.Point(170, 28);
            this.hours3RadioButton.Name = "hours3RadioButton";
            this.hours3RadioButton.Size = new System.Drawing.Size(63, 19);
            this.hours3RadioButton.TabIndex = 4;
            this.hours3RadioButton.Text = "3 hours";
            // 
            // customRadioButton
            // 
            this.customRadioButton.AutoSize = true;
            this.customRadioButton.Location = new System.Drawing.Point(170, 54);
            this.customRadioButton.Name = "customRadioButton";
            this.customRadioButton.Size = new System.Drawing.Size(70, 19);
            this.customRadioButton.TabIndex = 5;
            this.customRadioButton.Text = "Custom (hours/minutes):";
            // 
            // customHoursComboBox
            // 
            this.customHoursComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.customHoursComboBox.Enabled = false;
            this.customHoursComboBox.FormattingEnabled = true;
            this.customHoursComboBox.Location = new System.Drawing.Point(170, 79);
            this.customHoursComboBox.Name = "customHoursComboBox";
            this.customHoursComboBox.Size = new System.Drawing.Size(52, 23);
            this.customHoursComboBox.TabIndex = 6;
            // 
            // customMinutesComboBox
            // 
            this.customMinutesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.customMinutesComboBox.Enabled = false;
            this.customMinutesComboBox.FormattingEnabled = true;
            this.customMinutesComboBox.Location = new System.Drawing.Point(228, 79);
            this.customMinutesComboBox.Name = "customMinutesComboBox";
            this.customMinutesComboBox.Size = new System.Drawing.Size(52, 23);
            this.customMinutesComboBox.TabIndex = 7;
            // 
            // forceShutdownCheckBox
            // 
            this.forceShutdownCheckBox.AutoSize = true;
            this.forceShutdownCheckBox.Checked = false;
            this.forceShutdownCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(225)))));
            this.forceShutdownCheckBox.Location = new System.Drawing.Point(25, 269);
            this.forceShutdownCheckBox.Name = "forceShutdownCheckBox";
            this.forceShutdownCheckBox.Size = new System.Drawing.Size(171, 19);
            this.forceShutdownCheckBox.TabIndex = 8;
            this.forceShutdownCheckBox.Text = "Force shutdown";
            this.forceShutdownCheckBox.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(220)))));
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(25, 299);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(360, 38);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start timer";
            this.startButton.UseVisualStyleBackColor = false;
            // 
            // countdownLabel
            // 
            this.countdownLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 32F);
            this.countdownLabel.ForeColor = System.Drawing.Color.White;
            this.countdownLabel.Location = new System.Drawing.Point(25, 110);
            this.countdownLabel.Name = "countdownLabel";
            this.countdownLabel.Size = new System.Drawing.Size(360, 70);
            this.countdownLabel.TabIndex = 5;
            this.countdownLabel.Text = "00:00:00";
            this.countdownLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.countdownLabel.Visible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(25, 203);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(360, 38);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel timer";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Visible = false;
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Shutdown Timer";
            this.trayIcon.Visible = true;
            // 
            // trayMenu
            // 
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuItem});
            this.trayMenu.Name = "trayMenu";
            this.trayMenu.Size = new System.Drawing.Size(93, 26);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitMenuItem.Text = "Exit";
            // 
            // countdownTimer
            // 
            this.countdownTimer.Interval = 1000;
            // 
            // ShutdownTimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(410, 353);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.durationGroupBox);
            this.Controls.Add(this.forceShutdownCheckBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.countdownLabel);
            this.Controls.Add(this.cancelButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ShutdownTimerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shutdown Timer";
            this.Load += new System.EventHandler(this.ShutdownTimerForm_Load);
            this.durationGroupBox.ResumeLayout(false);
            this.durationGroupBox.PerformLayout();
            this.trayMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }
}
