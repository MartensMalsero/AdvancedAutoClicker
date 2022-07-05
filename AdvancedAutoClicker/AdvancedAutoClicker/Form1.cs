using System;
using System.Runtime.InteropServices;
using System.Windows.Input;
using Cursor = System.Windows.Forms.Cursor;
using Cursors = System.Windows.Forms.Cursors;
using Timer = System.Timers.Timer;

namespace AdvancedAutoClicker
{
    public partial class ControlPanel : Form
    {
        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out POINT lpPoint);

        [DllImport("user32.dll")]
        public static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern short GetKeyState(int keyCode);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);



        [Flags]
        private enum KeyStates
        {
            None = 0,
            Down = 1,
            Toggled = 2
        }

        public struct POINT
        {
            public int X;
            public int Y;
        }



        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_MIDDLEDOWN = 0x002;
        private const int MOUSEEVENTF_MIDDLEUP = 0x004;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;


        private static Timer? timer, HotKeyTimer, EventTimer;
        private static Point mousePosition;
        public static Keys StartHotKey { get; set; } = Keys.F6;
        public static Keys StopHotKey { get; set; } = Keys.F7;
        public static int Picklocation_X { get; set; } = 0;
        public static int Picklocation_Y { get; set; } = 0;
        private static int Record_Playback = 0;

        public ControlPanel()
        {
            InitializeComponent();
        }

        private static void EnDisablePickLocation(ControlPanel cp, bool state)
        {
            //Disable or enable "Pick location"
            cp.Pick_location_button.Enabled = state;
            cp.Pick_location_X.Enabled = state;
            cp.Pick_location_Y.Enabled = state;
        }

        private Point GetMousePoint()
        {
            return (Current_location.Checked) ? MousePosition : new Point(Convert.ToInt32(Pick_location_X.Text), Convert.ToInt32(Pick_location_Y.Text));
        }

        private void MouseEvent(object? sender, System.Timers.ElapsedEventArgs e)
        {
            Cursor.Position = GetMousePoint();
            ControlPanel cp = this;

            cp.Invoke(new Action(() =>
            {
                if (Cursor.Current is not null)
                Cursor = new Cursor(Cursor.Current.Handle);

                if (Repeat.Checked)
                {
                    if (timer is not null && timer.Enabled) timer.Enabled = false;

                    for (uint i = 0; i < Convert.ToUInt32(Repeat_Counter.Text); i++)
                    {
                        MouseEventHandler(Mouse_button.Text, Convert.ToUInt32(Cursor.Position.X), Convert.ToUInt32(Cursor.Position.Y));
                    }

                    Stop_button.PerformClick();
                }

                if (Repeat_until_Event.Checked || Repeat_until_stopped.Checked)
                {
                    MouseEventHandler(Mouse_button.Text, Convert.ToUInt32(Cursor.Position.X), Convert.ToUInt32(Cursor.Position.Y));
                }
            }));
        }

        private void MouseEventHandler(string MB_Button, uint X, uint Y)
        {
            switch (MB_Button)
            {
                case "Left":

                    if (Click_Type.Text == "Single")
                    {
                        mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
                    }

                    else
                    {
                        mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
                        mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
                    }

                    break;

                case "Middle":

                    if (Click_Type.Text == "Single")
                    {
                        mouse_event(MOUSEEVENTF_MIDDLEDOWN | MOUSEEVENTF_MIDDLEUP, X, Y, 0, 0);
                    }

                    else
                    {
                        mouse_event(MOUSEEVENTF_MIDDLEDOWN | MOUSEEVENTF_MIDDLEUP, X, Y, 0, 0);
                        mouse_event(MOUSEEVENTF_MIDDLEDOWN | MOUSEEVENTF_MIDDLEUP, X, Y, 0, 0);
                    }

                    break;

                case "Right":

                    if (Click_Type.Text == "Single")
                    {
                        mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, X, Y, 0, 0);
                    }

                    else
                    {
                        mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, X, Y, 0, 0);
                        mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, X, Y, 0, 0);
                    }

                    break;
            }
        }

        private static KeyStates GetKeyState(Keys key)
        {
            KeyStates state = KeyStates.None;

            short retVal = GetKeyState((int)key);

            //If the high-order bit is 1, the key is down
            //otherwise, it is up.
            if ((retVal & 0x8000) == 0x8000)
                state |= KeyStates.Down;

            //If the low-order bit is 1, the key is toggled.
            if ((retVal & 1) == 1)
                state |= KeyStates.Toggled;

            return state;
        }

        public static bool IsKeyDown(Keys key)
        {
            return KeyStates.Down == (GetKeyState(key) & KeyStates.Down);
        }

        public static bool IsKeyToggled(Keys key)
        {
            return KeyStates.Toggled == (GetKeyState(key) & KeyStates.Toggled);
        }
        private void OnMouseKeyboardEvent(object? sender, System.Timers.ElapsedEventArgs e)
        {
            if (Repeat_until_Event.Checked)
            {
                if (mousePosition != MousePosition)
                {
                    mousePosition = MousePosition;
                    if (timer != null && timer.Enabled)
                    {
                        timer.Enabled = false;
                        Thread.Sleep(1000);
                        timer.Enabled = true;
                    }
                }

                else
                {
                    foreach (Keys k in Enum.GetValues(typeof(Keys)))
                    {
                        if (IsKeyDown(k))
                        {
                            if (timer != null && timer.Enabled)
                            {
                                timer.Enabled = false;
                                Thread.Sleep(1000);
                                timer.Enabled = true;
                            }
                        }
                    }
                }
            }
        }

        private void AdvancedAutoClicker_Load(object sender, EventArgs e)
        {
            Mins_TextBox.Text = "5";
            Repeat_until_Event.Checked = true;
            Pick_location.Checked = true;
            Pick_location_X.Text = Picklocation_X.ToString();
            Pick_location_Y.Text = Picklocation_Y.ToString();

            Mouse_button.Items.AddRange(new object[] {
                "Left",
                "Middle",
                "Right"
            });

            Mouse_button.Text = Mouse_button.Items[0].ToString();

            Click_Type.Items.AddRange(new object[] {
                "Single",
                "Double"
            });

            Click_Type.Text = Click_Type.Items[0].ToString();

            Start_button.Text += " (" + StartHotKey.ToString() + ")";
            Stop_button.Text += " (" + StopHotKey.ToString() + ")";
            Stop_button.Enabled = false;

            EnDisablePickLocation(this, true);

            HotKeyTimer = new()
            {
                Interval = 1,
                AutoReset = true,
                Enabled = true
            };

            HotKeyTimer.Elapsed += HotKeyTimerEvent;
        }

        private void HotKeyTimerEvent(object? sender, System.Timers.ElapsedEventArgs e)
        {
            ControlPanel cp = this;

            if (IsKeyDown(StartHotKey))
            {
                if (Start_button.Enabled)
                {
                    cp.Invoke(new Action(() =>
                    {
                        Start_button.PerformClick();
                    }));
                }
            }

            if (IsKeyDown(StopHotKey))
            {
                if (Stop_button.Enabled)
                {
                    cp.Invoke(new Action(() =>
                    {
                        Stop_button.PerformClick();
                    }));
                }
            }
        }

        private void Current_location_CheckedChanged(object sender, EventArgs e)
        {
            if (Current_location.Checked)
            {
                EnDisablePickLocation(this, false);
            }

            else
            {
                EnDisablePickLocation(this, true);
            }
        }

        private void Pick_location_button_Click(object sender, EventArgs e)
        {
            Form2 Selection = new(this);
            Selection.Show(this);
        }

        public static void Update_Pick_location(ControlPanel cp)
        {
            cp.Pick_location_X.Text = Picklocation_X.ToString();
            cp.Pick_location_Y.Text = Picklocation_Y.ToString();
        }

        private void Start_button_Click(object? sender, EventArgs e)
        {
            int time = 0;

            if (Hrs_TextBox.Text.Length > 0) time += Convert.ToInt32(Hrs_TextBox.Text) * 3600000;
            if (Mins_TextBox.Text.Length > 0) time += Convert.ToInt32(Mins_TextBox.Text) * 60000;
            if (Secs_TextBox.Text.Length > 0) time += Convert.ToInt32(Secs_TextBox.Text) * 1000;
            if (Milli_TextBox.Text.Length > 0) time += Convert.ToInt32(Milli_TextBox.Text);

            if (!Repeat.Checked)
            {
                timer = new()
                {
                    Interval = time,
                    AutoReset = true,
                    Enabled = true
                };

                timer.Elapsed += MouseEvent;

                EventTimer = new()
                {
                    Interval = 1,
                    AutoReset = true,
                    Enabled = true
                };

                EventTimer.Elapsed += OnMouseKeyboardEvent;
            }

            else
            {
                timer = new()
                {
                    Interval = time,
                    AutoReset = false,
                    Enabled = true
                };

                timer.Elapsed += MouseEvent;
            }

            Start_button.Enabled = false;
            Stop_button.Enabled = true;
            Stop_button.Focus();

            foreach (GroupBox grp in Controls.OfType<GroupBox>())
            {
                grp.Enabled = false;
            }
        }

        private async void Stop_button_Click(object? sender, EventArgs e)
        {
            string StopButtonText = Stop_button.Text;
            Stop_button.Text = "In progress please wait ...";
            Stop_button.Enabled = false;

            await Task.Run(() =>
            {
                if (EventTimer is not null && timer is not null)
                {
                    while (EventTimer.Enabled)
                    {
                        EventTimer.Enabled = false;
                        Thread.Sleep(2500);
                        if (!EventTimer.Enabled)
                        {
                            while (timer.Enabled)
                            {
                                timer.Enabled = false;
                                Thread.Sleep(2500);
                            }
                        }
                    }
                }
            });

            Stop_button.Text = StopButtonText;

            Start_button.Enabled = true;

            foreach (GroupBox grp in Controls.OfType<GroupBox>())
            {
                grp.Enabled = true;
            }
        }

        //WIP
        private void Hotkey_button_Click(object sender, EventArgs e)
        {
            HotKeyControlPanel ChangeHotKey = new(this, StartHotKey, StopHotKey);
            ChangeHotKey.Show(this);
        }

        public void Update_HotKeys()
        {
            Start_button.Text = "Start (" + StartHotKey.ToString() + ")";
            Stop_button.Text = "Stop (" + StopHotKey.ToString() + ")";
        }

        private void Start_button_KeyDown(object? sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == StartHotKey)
            {
                Start_button.Click += Start_button_Click;
            }
        }

        private void Stop_button_KeyDown(object? sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == StopHotKey)
            {
                Stop_button.Click += Stop_button_Click;
            }
        }

        //WIP
        private void Record_playback_button_Click(object sender, EventArgs e)
        {
            POINT current_pos, prev_pos;
            List<POINT> coords = new();

            if (Record_Playback == 0)
            {
                Record_Playback = 1;

                prev_pos.X = 0;
                prev_pos.Y = 0;

                do
                {
                    if (GetCursorPos(out current_pos))
                    {
                        if ((current_pos.X != prev_pos.X) || (current_pos.Y != prev_pos.Y))
                        {
                            coords.Add(current_pos);
                        }

                        prev_pos.X = current_pos.X;
                        prev_pos.Y = current_pos.Y;
                    }

                } while (Record_Playback == 1);
            }

            if (Record_Playback == 1)
            {

            }
        }
    }
}