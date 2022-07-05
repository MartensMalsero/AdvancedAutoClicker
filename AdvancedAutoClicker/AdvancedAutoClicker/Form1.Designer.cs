namespace AdvancedAutoClicker
{
    partial class ControlPanel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Milli_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Secs_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Mins_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Hrs_TextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Click_Type = new System.Windows.Forms.ComboBox();
            this.Mouse_button = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Pick_location_Y = new System.Windows.Forms.TextBox();
            this.Pick_location_X = new System.Windows.Forms.TextBox();
            this.Pick_location_button = new System.Windows.Forms.Button();
            this.Pick_location = new System.Windows.Forms.RadioButton();
            this.Current_location = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Repeat_until_stopped = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.Repeat_Counter = new System.Windows.Forms.DomainUpDown();
            this.Repeat_until_Event = new System.Windows.Forms.RadioButton();
            this.Repeat = new System.Windows.Forms.RadioButton();
            this.Start_button = new System.Windows.Forms.Button();
            this.Stop_button = new System.Windows.Forms.Button();
            this.Hotkey_button = new System.Windows.Forms.Button();
            this.Record_playback_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Milli_TextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Secs_TextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Mins_TextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Hrs_TextBox);
            this.groupBox1.Location = new System.Drawing.Point(22, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(929, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Click interval";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(776, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "milliseconds";
            // 
            // Milli_TextBox
            // 
            this.Milli_TextBox.Location = new System.Drawing.Point(663, 47);
            this.Milli_TextBox.Margin = new System.Windows.Forms.Padding(6);
            this.Milli_TextBox.Name = "Milli_TextBox";
            this.Milli_TextBox.Size = new System.Drawing.Size(99, 39);
            this.Milli_TextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(559, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "secs";
            // 
            // Secs_TextBox
            // 
            this.Secs_TextBox.Location = new System.Drawing.Point(446, 47);
            this.Secs_TextBox.Margin = new System.Windows.Forms.Padding(6);
            this.Secs_TextBox.Name = "Secs_TextBox";
            this.Secs_TextBox.Size = new System.Drawing.Size(99, 39);
            this.Secs_TextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "mins";
            // 
            // Mins_TextBox
            // 
            this.Mins_TextBox.Location = new System.Drawing.Point(228, 47);
            this.Mins_TextBox.Margin = new System.Windows.Forms.Padding(6);
            this.Mins_TextBox.Name = "Mins_TextBox";
            this.Mins_TextBox.Size = new System.Drawing.Size(99, 39);
            this.Mins_TextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "hours";
            // 
            // Hrs_TextBox
            // 
            this.Hrs_TextBox.Location = new System.Drawing.Point(11, 47);
            this.Hrs_TextBox.Margin = new System.Windows.Forms.Padding(6);
            this.Hrs_TextBox.Name = "Hrs_TextBox";
            this.Hrs_TextBox.Size = new System.Drawing.Size(99, 39);
            this.Hrs_TextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Click_Type);
            this.groupBox2.Controls.Add(this.Mouse_button);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(22, 177);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(455, 271);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Click options";
            // 
            // Click_Type
            // 
            this.Click_Type.FormattingEnabled = true;
            this.Click_Type.Location = new System.Drawing.Point(228, 124);
            this.Click_Type.Margin = new System.Windows.Forms.Padding(6);
            this.Click_Type.Name = "Click_Type";
            this.Click_Type.Size = new System.Drawing.Size(195, 40);
            this.Click_Type.TabIndex = 8;
            // 
            // Mouse_button
            // 
            this.Mouse_button.FormattingEnabled = true;
            this.Mouse_button.Location = new System.Drawing.Point(228, 62);
            this.Mouse_button.Margin = new System.Windows.Forms.Padding(6);
            this.Mouse_button.Name = "Mouse_button";
            this.Mouse_button.Size = new System.Drawing.Size(195, 40);
            this.Mouse_button.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 130);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "Click type :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mouse button :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.Pick_location_Y);
            this.groupBox4.Controls.Add(this.Pick_location_X);
            this.groupBox4.Controls.Add(this.Pick_location_button);
            this.groupBox4.Controls.Add(this.Pick_location);
            this.groupBox4.Controls.Add(this.Current_location);
            this.groupBox4.Location = new System.Drawing.Point(22, 461);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox4.Size = new System.Drawing.Size(929, 151);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cursor position";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(737, 58);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 32);
            this.label9.TabIndex = 16;
            this.label9.Text = "Y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(594, 60);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 32);
            this.label8.TabIndex = 9;
            this.label8.Text = "X";
            // 
            // Pick_location_Y
            // 
            this.Pick_location_Y.Location = new System.Drawing.Point(776, 55);
            this.Pick_location_Y.Margin = new System.Windows.Forms.Padding(6);
            this.Pick_location_Y.Name = "Pick_location_Y";
            this.Pick_location_Y.Size = new System.Drawing.Size(93, 39);
            this.Pick_location_Y.TabIndex = 15;
            // 
            // Pick_location_X
            // 
            this.Pick_location_X.Location = new System.Drawing.Point(634, 55);
            this.Pick_location_X.Margin = new System.Windows.Forms.Padding(6);
            this.Pick_location_X.Name = "Pick_location_X";
            this.Pick_location_X.Size = new System.Drawing.Size(93, 39);
            this.Pick_location_X.TabIndex = 14;
            // 
            // Pick_location_button
            // 
            this.Pick_location_button.Location = new System.Drawing.Point(409, 55);
            this.Pick_location_button.Margin = new System.Windows.Forms.Padding(6);
            this.Pick_location_button.Name = "Pick_location_button";
            this.Pick_location_button.Size = new System.Drawing.Size(160, 49);
            this.Pick_location_button.TabIndex = 13;
            this.Pick_location_button.Text = "Pick location";
            this.Pick_location_button.UseVisualStyleBackColor = true;
            this.Pick_location_button.Click += new System.EventHandler(this.Pick_location_button_Click);
            // 
            // Pick_location
            // 
            this.Pick_location.AutoSize = true;
            this.Pick_location.Location = new System.Drawing.Point(364, 66);
            this.Pick_location.Margin = new System.Windows.Forms.Padding(6);
            this.Pick_location.Name = "Pick_location";
            this.Pick_location.Size = new System.Drawing.Size(27, 26);
            this.Pick_location.TabIndex = 12;
            this.Pick_location.TabStop = true;
            this.Pick_location.UseVisualStyleBackColor = true;
            // 
            // Current_location
            // 
            this.Current_location.AutoSize = true;
            this.Current_location.Location = new System.Drawing.Point(30, 66);
            this.Current_location.Margin = new System.Windows.Forms.Padding(6);
            this.Current_location.Name = "Current_location";
            this.Current_location.Size = new System.Drawing.Size(217, 36);
            this.Current_location.TabIndex = 11;
            this.Current_location.TabStop = true;
            this.Current_location.Text = "Current location";
            this.Current_location.UseVisualStyleBackColor = true;
            this.Current_location.CheckedChanged += new System.EventHandler(this.Current_location_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Repeat_until_stopped);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.Repeat_Counter);
            this.groupBox3.Controls.Add(this.Repeat_until_Event);
            this.groupBox3.Controls.Add(this.Repeat);
            this.groupBox3.Location = new System.Drawing.Point(496, 177);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(455, 271);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Click repeat";
            // 
            // Repeat_until_stopped
            // 
            this.Repeat_until_stopped.AutoSize = true;
            this.Repeat_until_stopped.Location = new System.Drawing.Point(46, 186);
            this.Repeat_until_stopped.Margin = new System.Windows.Forms.Padding(6);
            this.Repeat_until_stopped.Name = "Repeat_until_stopped";
            this.Repeat_until_stopped.Size = new System.Drawing.Size(267, 36);
            this.Repeat_until_stopped.TabIndex = 10;
            this.Repeat_until_stopped.TabStop = true;
            this.Repeat_until_stopped.Text = "Repeat until stopped";
            this.Repeat_until_stopped.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(358, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 32);
            this.label7.TabIndex = 9;
            this.label7.Text = "times";
            // 
            // Repeat_Counter
            // 
            this.Repeat_Counter.Location = new System.Drawing.Point(232, 64);
            this.Repeat_Counter.Margin = new System.Windows.Forms.Padding(6);
            this.Repeat_Counter.Name = "Repeat_Counter";
            this.Repeat_Counter.Size = new System.Drawing.Size(115, 39);
            this.Repeat_Counter.TabIndex = 2;
            this.Repeat_Counter.Text = "1";
            // 
            // Repeat_until_Event
            // 
            this.Repeat_until_Event.AutoSize = true;
            this.Repeat_until_Event.Location = new System.Drawing.Point(46, 132);
            this.Repeat_until_Event.Margin = new System.Windows.Forms.Padding(6);
            this.Repeat_until_Event.Name = "Repeat_until_Event";
            this.Repeat_until_Event.Size = new System.Drawing.Size(345, 36);
            this.Repeat_until_Event.TabIndex = 1;
            this.Repeat_until_Event.TabStop = true;
            this.Repeat_until_Event.Text = "Repeat until event triggered";
            this.Repeat_until_Event.UseVisualStyleBackColor = true;
            // 
            // Repeat
            // 
            this.Repeat.AutoSize = true;
            this.Repeat.Location = new System.Drawing.Point(46, 64);
            this.Repeat.Margin = new System.Windows.Forms.Padding(6);
            this.Repeat.Name = "Repeat";
            this.Repeat.Size = new System.Drawing.Size(118, 36);
            this.Repeat.TabIndex = 0;
            this.Repeat.TabStop = true;
            this.Repeat.Text = "Repeat";
            this.Repeat.UseVisualStyleBackColor = true;
            // 
            // Start_button
            // 
            this.Start_button.Location = new System.Drawing.Point(22, 625);
            this.Start_button.Margin = new System.Windows.Forms.Padding(6);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(455, 107);
            this.Start_button.TabIndex = 3;
            this.Start_button.Text = "Start";
            this.Start_button.UseVisualStyleBackColor = true;
            this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
            this.Start_button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Start_button_KeyDown);
            // 
            // Stop_button
            // 
            this.Stop_button.Location = new System.Drawing.Point(496, 625);
            this.Stop_button.Margin = new System.Windows.Forms.Padding(6);
            this.Stop_button.Name = "Stop_button";
            this.Stop_button.Size = new System.Drawing.Size(455, 107);
            this.Stop_button.TabIndex = 4;
            this.Stop_button.Text = "Stop";
            this.Stop_button.UseVisualStyleBackColor = true;
            this.Stop_button.Click += new System.EventHandler(this.Stop_button_Click);
            this.Stop_button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Stop_button_KeyDown);
            // 
            // Hotkey_button
            // 
            this.Hotkey_button.Location = new System.Drawing.Point(22, 745);
            this.Hotkey_button.Margin = new System.Windows.Forms.Padding(6);
            this.Hotkey_button.Name = "Hotkey_button";
            this.Hotkey_button.Size = new System.Drawing.Size(455, 107);
            this.Hotkey_button.TabIndex = 5;
            this.Hotkey_button.Text = "Hotkey setting";
            this.Hotkey_button.UseVisualStyleBackColor = true;
            this.Hotkey_button.Click += new System.EventHandler(this.Hotkey_button_Click);
            // 
            // Record_playback_button
            // 
            this.Record_playback_button.Location = new System.Drawing.Point(496, 745);
            this.Record_playback_button.Margin = new System.Windows.Forms.Padding(6);
            this.Record_playback_button.Name = "Record_playback_button";
            this.Record_playback_button.Size = new System.Drawing.Size(455, 107);
            this.Record_playback_button.TabIndex = 6;
            this.Record_playback_button.Text = "Record / Playback\r\n (WIP)";
            this.Record_playback_button.UseVisualStyleBackColor = true;
            this.Record_playback_button.Click += new System.EventHandler(this.Record_playback_button_Click);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 864);
            this.Controls.Add(this.Record_playback_button);
            this.Controls.Add(this.Hotkey_button);
            this.Controls.Add(this.Stop_button);
            this.Controls.Add(this.Start_button);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(997, 1000);
            this.Name = "ControlPanel";
            this.Text = "Advanced Auto Clicker";
            this.Load += new System.EventHandler(this.AdvancedAutoClicker_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private TextBox Milli_TextBox;
        private Label label3;
        private TextBox Secs_TextBox;
        private Label label2;
        private TextBox Mins_TextBox;
        private Label label1;
        private TextBox Hrs_TextBox;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private Button Start_button;
        private Button Stop_button;
        private Button Hotkey_button;
        private Button Record_playback_button;
        private ComboBox Click_Type;
        private ComboBox Mouse_button;
        private Label label6;
        private Label label5;
        private Label label9;
        private Label label8;
        private TextBox Pick_location_Y;
        private TextBox Pick_location_X;
        private Button Pick_location_button;
        private RadioButton Pick_location;
        private RadioButton Current_location;
        private RadioButton Repeat_until_stopped;
        private Label label7;
        private DomainUpDown Repeat_Counter;
        private RadioButton Repeat_until_Event;
        private RadioButton Repeat;
    }
}