using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedAutoClicker
{
    public partial class HotKeyControlPanel : Form
    {
        private static ControlPanel? CallBack;
        private static Keys StartHotKey;
        private static Keys StopHotKey;
        private static Keys OldKey;
        private static HotKeyControlPanel? hkcp;
        private static string DetectText = "detect ...";

        public HotKeyControlPanel(ControlPanel cp, Keys start, Keys stop)
        {
            CallBack = cp;
            StartHotKey = start;
            StopHotKey = stop;

            InitializeComponent();
        }

        private void HotKeyControlPanel_Load(object sender, EventArgs e)
        {
            hkcp = this;
            Start_button_HotKey.Text = StartHotKey.ToString();
            Stop_button_HotKey.Text = StopHotKey.ToString();
        }

        private void HotKeyControlPanel_Closeing(object sender, FormClosingEventArgs e)
        {
            if (CallBack != null)
            {
                ControlPanel.StartHotKey = StartHotKey;
                ControlPanel.StopHotKey = StopHotKey;
                CallBack.Update_HotKeys();
            }
        }

        private static void HotKey(Button btn)
        {
            bool key = Enum.TryParse(btn.Text, out OldKey);

            if (key)
            btn.Text = DetectText;
            btn.ForeColor = Color.Red;
            btn.KeyDown += Btn_KeyDown;
        }

        private static void Btn_KeyDown(object? sender, KeyEventArgs e)
        {
            Button? btn = sender as Button;

            if (btn is not null && hkcp is not null)
            {
                if (btn.Text == DetectText)
                {
                    foreach (Button b in hkcp.Controls.OfType<Button>())
                    {
                        if (b != btn)
                        {
                            if (b.Text != e.KeyCode.ToString())
                            {
                                switch (OldKey)
                                {
                                    case var value when value == StartHotKey:
                                        StartHotKey = e.KeyCode;
                                        btn.Text = StartHotKey.ToString();
                                        break;

                                    case var value when value == StopHotKey:
                                        StopHotKey = e.KeyCode;
                                        btn.Text = StopHotKey.ToString();
                                        break;
                                }

                                btn.ForeColor = Color.Black;

                                b.Enabled = true;
                            }

                            else
                            {
                                btn.Text = OldKey.ToString();
                                btn.ForeColor = Color.Black;

                                MessageBox.Show("Key already defined!");

                                b.Enabled = true;
                            }
                        }
                    }
                    
                }
            }
        }

        private void Start_button_HotKey_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                if (sender is Button)
                {
                    foreach (Button b in Controls.OfType<Button>())
                    {
                        if (b != btn)
                        {
                            b.Enabled = false;
                        }
                    }

                    HotKey(btn);
                }
            }
        }

        private void Stop_button_HotKey_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                if (sender is Button)
                {
                    foreach (Button b in Controls.OfType<Button>())
                    {
                        if (b != btn)
                        {
                            b.Enabled = false;
                        }
                    }

                    HotKey(btn);
                }
            }
        }
    }
}
