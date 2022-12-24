using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using KosmoSecure.DB;
using KosmoSecure.Logic;

namespace KosmoSecure
{
    public partial class frmMain : Form
    {
        private UserPreferenceChangedEventHandler UserPreferenceChanged;
        public static frmMain frm;

        public frmMain()
        {
            frm = this;
            InitializeComponent();
            RegistrySettings.Initialice();
            RegistrySettings.LoadSettings();
            LoadTheme();
            UserPreferenceChanged = new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
            SystemEvents.UserPreferenceChanged += UserPreferenceChanged;
            this.Disposed += new EventHandler(Form_Disposed);
            UC_Main uC_ = new UC_Main();
            addUserControl(uC_);
            modCommon.plseasewait = false;
        }
        private void Form_Disposed(object sender, EventArgs e)
        {
            SystemEvents.UserPreferenceChanged -= UserPreferenceChanged;
        }
        private void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        {
            if (e.Category == UserPreferenceCategory.General || e.Category == UserPreferenceCategory.VisualStyle)
            {
                LoadTheme();
            }
        }
        public void LoadTheme()
        {
            var themeColor = Class.WinTheme.GetAccentColor();
            var lightColor = ControlPaint.Light(themeColor);
            //var darkColor = ControlPaint.Dark(themeColor);

            guna2WinProgressIndicator1.ProgressColor = themeColor;
            uI_LabelMaterial1.ForeColor = lightColor;

            try
            {
                foreach (IconButton item in PanelButton.Controls)
                {
                    item.IconColor = themeColor;
                }
            }
            catch
            {

            }
        }
        private void MiniBox_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CloseBox_Click(object sender, EventArgs e)
        {
            frm.Hide();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            RegistrySettings.LoadSettings();
            modCommon.timeralarm.AutoReset = true;
            modCommon.timeralarm.Interval = 100;
            modCommon.timeralarm.Elapsed += new System.Timers.ElapsedEventHandler(modCommon.timer_elapsed);
            modCommon.timerlist.AutoReset = true;
            modCommon.timerlist.Interval = 100;
            modCommon.timerlist.Elapsed += new System.Timers.ElapsedEventHandler(modCommon.timerlist_elapsed);
        }
        public void addUserControl(UserControl uc)
        {
            PanelContainer.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
            PanelContainer.Controls.Add(uc);
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            UC_Main _uC = new UC_Main();
            addUserControl(_uC);
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            UC_Settings _uC = new UC_Settings();
            addUserControl(_uC);
        }
        private void iconButton3_Click(object sender, EventArgs e)
        {
            timer1.Start();
            UC_Log _uC = new UC_Log();
            addUserControl(_uC);
        }
        private void iconButton4_Click(object sender, EventArgs e)
        {
            timer1.Start();
            UC_Alarm _uC = new UC_Alarm();
            addUserControl(_uC);
        }
        private void iconButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void iconButton5_MouseEnter(object sender, EventArgs e)
        {
            iconButton5.IconChar = IconChar.DoorOpen;
        }
        private void iconButton5_MouseLeave(object sender, EventArgs e)
        {
            iconButton5.IconChar = IconChar.DoorClosed;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (modCommon.plseasewait == true)
            {
                timer1.Stop();
                PlseaseWait.Visible = false;
                PanelContainer.Visible = true;
            }
            else
            {
                PlseaseWait.Visible = true;
                PanelContainer.Visible = false;
            }
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frm.Show();
        }
    }
}
