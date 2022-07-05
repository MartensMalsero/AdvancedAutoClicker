namespace AdvancedAutoClicker
{
    partial class HotKeyControlPanel
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
            this.Start_button_HotKey = new System.Windows.Forms.Button();
            this.Stop_button_HotKey = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Start_button_HotKey
            // 
            this.Start_button_HotKey.Location = new System.Drawing.Point(387, 21);
            this.Start_button_HotKey.Name = "Start_button_HotKey";
            this.Start_button_HotKey.Size = new System.Drawing.Size(150, 46);
            this.Start_button_HotKey.TabIndex = 0;
            this.Start_button_HotKey.Text = "button1";
            this.Start_button_HotKey.UseVisualStyleBackColor = true;
            this.Start_button_HotKey.Click += new System.EventHandler(this.Start_button_HotKey_Click);
            // 
            // Stop_button_HotKey
            // 
            this.Stop_button_HotKey.Location = new System.Drawing.Point(387, 81);
            this.Stop_button_HotKey.Name = "Stop_button_HotKey";
            this.Stop_button_HotKey.Size = new System.Drawing.Size(150, 46);
            this.Stop_button_HotKey.TabIndex = 1;
            this.Stop_button_HotKey.Text = "button2";
            this.Stop_button_HotKey.UseVisualStyleBackColor = true;
            this.Stop_button_HotKey.Click += new System.EventHandler(this.Stop_button_HotKey_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "HotKey for start button :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "HotKey for stop button :";
            // 
            // HotKeyControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 151);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Stop_button_HotKey);
            this.Controls.Add(this.Start_button_HotKey);
            this.Name = "HotKeyControlPanel";
            this.Text = "Advanced Auto Clicker - HotKey Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HotKeyControlPanel_Closeing);
            this.Load += new System.EventHandler(this.HotKeyControlPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Start_button_HotKey;
        private Button Stop_button_HotKey;
        private Label label1;
        private Label label2;
    }
}