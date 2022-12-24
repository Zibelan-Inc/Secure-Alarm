using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KosmoSecure.Properties;
using Microsoft.Win32;

namespace KosmoSecure
{
    public partial class UC_Main : UserControl
    {
        private UserPreferenceChangedEventHandler UserPreferenceChanged;
        public static UC_Main frm;
        public UC_Main()
        {
            frm = this;
            InitializeComponent();
            LoadTheme();
            UserPreferenceChanged = new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
            SystemEvents.UserPreferenceChanged += UserPreferenceChanged;
            this.Disposed += new EventHandler(Form_Disposed);
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
            //var lightColor = ControlPaint.Light(themeColor);
            //var darkColor = ControlPaint.Dark(themeColor);

            TimeLostText.BorderColor = themeColor;
            TimePingText.BorderColor = themeColor;
        }
        private void UC_Main_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme != "")
            {
                modCommon.ChangedTheme(Properties.Settings.Default.Theme);
            }
            else
            {
                Properties.Settings.Default.Theme = "Dark";
                Properties.Settings.Default.Save();
                modCommon.ChangedTheme("Dark");
            }
            RegistrySettings.LoadSettings();
            TimeLostText.Text = modCommon.timelost;
            TimePingText.Text = modCommon.timeping;
            state();
        }
        public void state()
        {
            if(modCommon.estatecheked == true)
            {
                ButtonStart.Text = "Disable";
                ButtonStart.ForeColor = Color.FromArgb(255, 179, 2);
                ButtonStart.BorderColor = Color.FromArgb(255, 179, 2);
                ButtonStart.OnHoverBaseColor = Color.FromArgb(255, 179, 2);
                ButtonStart.OnHoverBorderColor = Color.FromArgb(255, 179, 2);
                ButtonStart.OnHoverForeColor = Color.FromArgb(16, 22, 32);
                frmMain.frm.PanelNotifi.FillColor = Color.FromArgb(42, 171, 160);
                frmMain.frm.GunaPictureBox1.Image = Resources.success;
                frmMain.frm.GunaLabel1.Text = "Alarm Enabled";
            }
            else
            {
                ButtonStart.Text = "Enabled";
                ButtonStart.ForeColor = Color.FromArgb(42, 171, 160);
                ButtonStart.BorderColor = Color.FromArgb(42, 171, 160);
                ButtonStart.OnHoverBaseColor = Color.FromArgb(42, 171, 160);
                ButtonStart.OnHoverBorderColor = Color.FromArgb(42, 171, 160);
                ButtonStart.OnHoverForeColor = Color.FromArgb(16, 22, 32);
                frmMain.frm.PanelNotifi.FillColor = Color.FromArgb(255, 179, 2);
                frmMain.frm.GunaPictureBox1.Image = Resources.warning;
                frmMain.frm.GunaLabel1.Text = "Alarm Disabled";
            }
        }
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            modCommon.iTiempoEspera = Convert.ToInt32(TimePingText.Text);
            if(modCommon.roboestate == true)
            {
                modCommon.StopAlarm();
                modCommon.estatecheked = false;
                modCommon.roboestate = false;
                state();
            }
            else
            {
                if (modCommon.estatecheked == true)
                {
                    modCommon.AddLog("System Stop", "");
                    modCommon.estatecheked = false;
                    modCommon.StopAlarm();
                    modCommon.statealarm = "False";
                    RegistrySettings.SaveSettings();
                    state();
                }
                else
                {
                    modCommon.AddLog("System StartUp", "");
                    modCommon.estatecheked = true;
                    if (TimeLostText.Text != "" && TimePingText.Text != "")
                    {
                        modCommon.timelost = TimeLostText.Text;
                        modCommon.timeping = TimePingText.Text;
                        modCommon.Alarm();
                        modCommon.statealarm = "True";
                        RegistrySettings.SaveSettings();
                        state();
                    }
                    modCommon.Alarm();
                    modCommon.timeralarm.Start();
                    modCommon.timerlist.Start();
                }
            }
        }
    }
}
