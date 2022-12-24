using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace KosmoSecure
{
    public partial class UC_Settings : UserControl
    {
        private UserPreferenceChangedEventHandler UserPreferenceChanged;
        public static UC_Settings frm;
        public UC_Settings()
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

            ThemeToggler.CheckedState.BorderColor = themeColor;
            ThemeToggler.CheckedState.FillColor = themeColor;
            Themelbl.ForeColor = themeColor;
            LaunchToggle.CheckedState.BorderColor = themeColor;
            LaunchToggle.CheckedState.FillColor = themeColor;
            Launchlbl.ForeColor = themeColor;
        }
        private void UC_Settings_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme != "")
            {
                modCommon.ChangedThemeSetting(Properties.Settings.Default.Theme);
            }
            else
            {
                Properties.Settings.Default.Theme = "Dark";
                Properties.Settings.Default.Save();
                modCommon.ChangedThemeSetting("Dark");
            }
            if (Properties.Settings.Default.Theme == "Dark")
            {
                ThemeToggler.Checked = true;
            }
            else if (Properties.Settings.Default.Theme == "Light")
            {
                ThemeToggler.Checked = false;
            }
            if (modCommon.LaunchWindows == "True")
            {
                LaunchToggle.Checked = true;
            }
            else
            {
                LaunchToggle.Checked = false;
            }
        }
        private void ThemeToggler_CheckedChanged(object sender, EventArgs e)
        {
            if (ThemeToggler.Checked == true)
            {
                Properties.Settings.Default.Theme = "Dark";
                Properties.Settings.Default.Save();
                modCommon.ChangedTheme("Dark");
                modCommon.ChangedThemeSetting("Dark");
                RegistrySettings.SaveSettings();
            }
            else
            {
                Properties.Settings.Default.Theme = "Light";
                Properties.Settings.Default.Save();
                modCommon.ChangedTheme("Light");
                modCommon.ChangedThemeSetting("Light");
                RegistrySettings.SaveSettings();
            }
        }
        private void LaunchToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (LaunchToggle.Checked == true)
            {
                modCommon.LaunchWindows = "True";
                modCommon.LaunchWindow();
                RegistrySettings.SaveSettings();
            }
            else
            {
                modCommon.LaunchWindows = "False";
                modCommon.DeleteLaunchWindow();
                RegistrySettings.SaveSettings();
            }
        }
    }
}
