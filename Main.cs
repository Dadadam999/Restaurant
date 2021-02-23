using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Main : Form
    {
        public static Main selfref { get; set; }
        public Main()
        {
            InitializeComponent();
            selfref = this;
            ManangerControls.InitControls(WorkSpace);
            ManangerControls.ShowControl("Home");
        }

        //Перемещение формы
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FromExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FromMaximum_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void FromTray_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void Logo_Click(object sender, EventArgs e)
        {
            ManangerControls.ShowControl("Home");
        }

        private void ClientSelectBtn_Click(object sender, EventArgs e)
        {
            ManangerControls.ShowControl("ClientList");
        }

        private void OrderSelectBtn_Click(object sender, EventArgs e)
        {
            ManangerControls.ShowControl("OrderList");
        }

        private void MenuSelectBtn_Click(object sender, EventArgs e)
        {
            ManangerControls.ShowControl("MenuList");
        }

        private void WaiterSelectBtn_Click(object sender, EventArgs e)
        {
            ManangerControls.ShowControl("WaiterList");
        }
    }
}
