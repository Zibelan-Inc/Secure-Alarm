using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KosmoSecure.frmMain;

namespace KosmoSecure
{
    public class RegistrySettings
    {
        public static RegistryKey XNova { get; private set; }
        public static void Initialice()
        {
            XNova = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Kosmo\KosmoSecure\", true);
            if (XNova == null)
            {
                Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Kosmo\KosmoSecure\");
                XNova = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Kosmo\KosmoSecure\", true);
                SaveSettings();
                modCommon.LaunchWindow();
            }
        }
        public static void SaveSettings()
        {
            try { XNova.SetValue("Theme", Properties.Settings.Default.Theme); } catch { }
            try { XNova.SetValue("Launch", modCommon.LaunchWindows); } catch { }
            try { XNova.SetValue("State", modCommon.statealarm); } catch { }
            try { XNova.SetValue("TimeLost", UC_Main.frm.TimeLostText.Text); } catch { }
            try { XNova.SetValue("TimePing", UC_Main.frm.TimePingText.Text); } catch { }
        }
        public static void LoadSettings()
        {
            try { Properties.Settings.Default.Theme = (string)XNova.GetValue("Theme", RegistryValueKind.String); } catch { }
            try { modCommon.LaunchWindows = (string)XNova.GetValue("Launch", RegistryValueKind.String); } catch { }
            try { modCommon.statealarm = (string)XNova.GetValue("State", RegistryValueKind.String); } catch { }
            try { modCommon.timelost = (string)XNova.GetValue("TimeLost", RegistryValueKind.String); } catch { }
            try { modCommon.timeping = (string)XNova.GetValue("TimePing", RegistryValueKind.String); } catch { }
        }
    }
}
