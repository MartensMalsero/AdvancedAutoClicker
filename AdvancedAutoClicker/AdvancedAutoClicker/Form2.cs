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
    public partial class Form2 : MainForms
    {
        private static ControlPanel? CallBack;
        public Form2(ControlPanel cp)
        {
            CallBack = cp;

            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            Opacity = 0.004;
        }

        private void Form2_MouseClick(object? sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (CallBack != null)
            {
                if (e.Button == MouseButtons.Left)
                {
                    ControlPanel.Picklocation_X = e.X;
                    ControlPanel.Picklocation_Y = e.Y;
                    ControlPanel.Update_Pick_location(CallBack);

                    Close();
                }

                if (e.Button == MouseButtons.Right)
                {
                    Close();
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Cursor.Current is not null)
            Cursor = new Cursor(Cursor.Current.Handle);
            Cursor = Cursors.Cross;
            MouseClick += Form2_MouseClick;
        }
    }
}
