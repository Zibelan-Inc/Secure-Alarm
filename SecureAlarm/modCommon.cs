using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using KosmoSecure.Class;
using FontAwesome.Sharp;
using KosmoSecure.DB;
using KosmoSecure.Logic;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Drawing;
using KosmoSecure.Properties;

namespace KosmoSecure
{
    public class modCommon
    {
        public static string LaunchWindows;
        public static bool plseasewait;
        public static bool estatecheked;
        public static bool roboestate;
        public static string timelost;
        public static string timeping;
        public static bool estatealarm;
        public static int contp;
        public static int[] contpp = new int[500];
        public static string statealarm;

        public static Ping HacerPing = new Ping();
        public static int iTiempoEspera;
        public static PingReply RespuestaPing;

        public static System.Timers.Timer timeralarm = new System.Timers.Timer(100);
        public static System.Timers.Timer timerlist = new System.Timers.Timer(60000);
        public static System.Media.SoundPlayer player = new System.Media.SoundPlayer(Directory.GetCurrentDirectory() + @"\Sirena.wav");
        public static List<string> _alarm = new List<string>();
        public static void LaunchWindow()
        {
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
                try
                {
                    registryKey.SetValue(Application.ProductName, Application.ExecutablePath.ToString());
                }
                catch { }
            }
            catch { }
        }
        public static void DeleteLaunchWindow()
        {
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
                try
                {
                    registryKey.DeleteValue(Application.ProductName);
                }
                catch { }
            }
            catch { }
        }
        public static void ChangedTheme(string Theme)
        {
            var themeColor = Class.WinTheme.GetAccentColor();
            //var lightColor = ControlPaint.Light(themeColor);
            //var darkColor = ControlPaint.Dark(themeColor);
            Themes.ThemeSelect(Theme);
            try { frmMain.frm.BackColor = Themes.Panel; } catch { };
            try { frmMain.frm.lblTittle.ForeColor = Themes.FuenteA; } catch { };
            try { frmMain.frm.PanelButton.FillColor = Themes.Panel; } catch { };
            try { UC_Main.frm.BackColor = Themes.Panel; } catch { }
            try { UC_Main.frm.GunaLabel2.ForeColor = Themes.FuenteA; } catch { };
            try { UC_Main.frm.GunaLabel3.ForeColor = Themes.FuenteA; } catch { };
            try { UC_Main.frm.TimeLostText.ForeColor = Themes.FuenteA; } catch { };
            try { UC_Main.frm.TimePingText.ForeColor = Themes.FuenteA; } catch { };
            try { UC_Main.frm.TimeLostText.FillColor = Themes.Panel; } catch { };
            try { UC_Main.frm.TimePingText.FillColor = Themes.Panel; } catch { };

            try
            {
                foreach (IconButton item in frmMain.frm.PanelButton.Controls)
                {
                    item.ForeColor = Themes.FuenteB;
                    item.IconColor = themeColor;
                    item.BackColor = Themes.Panel;
                }
            }
            catch
            {

            }
        }
        public static void ChangedThemeSetting(string Theme)
        {
            var themeColor = Class.WinTheme.GetAccentColor();
            //var lightColor = ControlPaint.Light(themeColor);
            //var darkColor = ControlPaint.Dark(themeColor);
            Themes.ThemeSelect(Theme);
            try { UC_Settings.frm.BackColor = Themes.Panel; } catch { };
            try { UC_Settings.frm.lblPanel1.ForeColor = Themes.FuenteA; } catch { };
            try { UC_Settings.frm.lblPanel2.ForeColor = Themes.FuenteA; } catch { };
        }
        public static void ChangedThemeAlarm(string Theme)
        {
            var themeColor = Class.WinTheme.GetAccentColor();
            //var lightColor = ControlPaint.Light(themeColor);
            //var darkColor = ControlPaint.Dark(themeColor);
            Themes.ThemeSelect(Theme);
            try { UC_Alarm.frm.BackColor = Themes.Panel; } catch { };
            try { UC_Alarm.frm.PanelContainer.BackColor = Themes.Panel; } catch { };
            try { UC_Alarm.frm.guna2Panel2.BackColor = Themes.Panel; } catch { };
            try { UC_Alarm.frm.gunaVScrollBar1.ScrollIdleColor = Themes.PanelButton; } catch { };
            try { UC_Alarm.frm.GunaLabel1.ForeColor = Themes.FuenteA; } catch { };
            try { UC_Alarm.frm.GunaLabel2.ForeColor = Themes.FuenteA; } catch { };
            try { UC_Alarm.frm.GunaLabel3.ForeColor = Themes.FuenteA; } catch { };
            try { UC_Alarm.frm.GunaLabel4.ForeColor = Themes.FuenteA; } catch { };
            try { UC_Alarm.frm.GunaLabel5.ForeColor = Themes.FuenteA; } catch { };
            try { UC_Alarm.frm.NameBox.ForeColor = Themes.FuenteA; } catch { };
            try { UC_Alarm.frm.TextIP.ForeColor = Themes.FuenteA; } catch { };
            try { UC_Alarm.frm.EstateCheked.ForeColor = Themes.FuenteA; } catch { };
            try { UC_Alarm.frm.ProgramerChecked.ForeColor = Themes.FuenteA; } catch { };
            try { UC_Alarm.frm.MondayChecked.ForeColor = Themes.FuenteA; } catch { };
            try { UC_Alarm.frm.TuesdayChecked.ForeColor = Themes.FuenteA; } catch { };
            try { UC_Alarm.frm.WednesdayChecked.ForeColor = Themes.FuenteA; } catch { };
            try { UC_Alarm.frm.ThursdayChecked.ForeColor = Themes.FuenteA; } catch { };
            try { UC_Alarm.frm.FridayComboBox.ForeColor = Themes.FuenteA; } catch { };
            try { UC_Alarm.frm.SaturdayChecked.ForeColor = Themes.FuenteA; } catch { };
            try { UC_Alarm.frm.SundayChecked.ForeColor = Themes.FuenteA; } catch { };

            try
            {
                foreach (Guna.UI2.WinForms.Guna2Separator item in UC_Alarm.frm.PanelContainer.Controls)
                {
                    item.FillColor = Themes.FuenteA;
                }
            }
            catch
            {

            }
        }
        public static void ChangedThemeLog(string Theme)
        {
            var themeColor = Class.WinTheme.GetAccentColor();
            //var lightColor = ControlPaint.Light(themeColor);
            //var darkColor = ControlPaint.Dark(themeColor);
            Themes.ThemeSelect(Theme);
            try { UC_Log.frm.BackColor = Themes.Panel; } catch { };
            if(Theme == "Dark")
                try { UC_Log.frm.dtLog.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark; } catch { }
            else
                try { UC_Log.frm.dtLog.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light; } catch { }
            try { UC_Log.frm.dtLog.ThemeStyle.HeaderStyle.ForeColor = Themes.FuenteA; } catch { };
        }
        public static void timer_elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            string _ip;
            if (NetworkInterface.GetIsNetworkAvailable() == true)
            {
                int contp1 = 0;
                while (contp1 < _alarm.Count)
                {
                    try { RespuestaPing = HacerPing.Send(_alarm[contp1], iTiempoEspera); } catch { }
                    if (RespuestaPing.Status == IPStatus.Success)
                    {
                        AddLog("Lost IP", _alarm[contp1] + ":" + Convert.ToString(contp));
                        AddValues(contpp[contp1]);
                        contpp[contp1] = 0;
                    }
                    else
                    {
                        contpp[contp1]++;
                        AddValues(contpp[contp1]);
                    }
                    if(contpp[contp1] >= Convert.ToInt32(timelost))
                    {
                        if(estatealarm == false)
                        {
                            estatealarm = true;
                            _ip = _alarm[contp1];
                            contpp[contp1] = 0;
                            Robb(_ip);
                        }
                    }
                    if (contpp[contp1] <= _alarm.Count)
                    {
                        contp1++;
                    }
                }
            }
            else
            {
                Robb("0");
            }
        }
        public static void timerlist_elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Alarm();
        }
        public static void Alarm()
        {
            if (NetworkInterface.GetIsNetworkAvailable() == true)
            {
                timelost = UC_Main.frm.TimeLostText.Text;
                timeping = UC_Main.frm.TimePingText.Text;
                AlarmLogic.instancia.Listar();
                if (AlarmLogic.olista.Count > 0)
                {
                    bool _state, _programado;
                    string _ip, _time1, _time2;
                    bool _monday, _tuesday, _wednesday, _thursday, _friday, _saturday, _sunday;

                    _alarm.Clear();
                    for (int i = 0; i <= AlarmLogic.olista.Count - 1; i++)
                    {
                        _state = Convert.ToBoolean(AlarmLogic.olista[i].State);
                        _programado = Convert.ToBoolean(AlarmLogic.olista[i].Programer);
                        _ip = AlarmLogic.olista[i].IP;

                        if (_state == true)
                        {
                            if (_programado == false)
                            {
                                _alarm.Add(_ip);
                            }
                            else
                            {
                                _time1 = AlarmLogic.olista[i].HourEnabled;
                                _time2 = AlarmLogic.olista[i].HourDisabled;
                                string _hour = DateTime.Now.ToString("HH:mm:ss");

                                if (_hour.CompareTo(_time1) >= 0)
                                {
                                    if (_hour.CompareTo(_time2) <= 0)
                                    {
                                        _monday = Convert.ToBoolean(AlarmLogic.olista[i].Monday);
                                        _tuesday = Convert.ToBoolean(AlarmLogic.olista[i].Tuesday);
                                        _wednesday = Convert.ToBoolean(AlarmLogic.olista[i].Wednesday);
                                        _thursday = Convert.ToBoolean(AlarmLogic.olista[i].Thursday);
                                        _friday = Convert.ToBoolean(AlarmLogic.olista[i].Friday);
                                        _saturday = Convert.ToBoolean(AlarmLogic.olista[i].Saturday);
                                        _sunday = Convert.ToBoolean(AlarmLogic.olista[i].Sunday);
                                        string _day;
                                        bool acces = false;
                                        _day = Application.CurrentCulture.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek).ToString();

                                        if (_day == "Lunes".ToLower().ToString())
                                        {
                                            if (_monday == true)
                                                acces = true;
                                        }
                                        else if (_day == "Martes".ToLower().ToString())
                                        {
                                            if (_tuesday == true)
                                                acces = true;
                                        }
                                        else if (_day == "Miercoles".ToLower().ToString())
                                        {
                                            if (_wednesday == true)
                                                acces = true;
                                        }
                                        else if (_day == "Jueves".ToLower().ToString())
                                        {
                                            if (_thursday == true)
                                                acces = true;
                                        }
                                        else if (_day == "Viernes".ToLower().ToString())
                                        {
                                            if (_friday == true)
                                                acces = true;
                                        }
                                        else if (_day == "Sabado".ToLower().ToString())
                                        {
                                            if (_saturday == true)
                                                acces = true;
                                        }
                                        else if (_day == "Domingo".ToLower().ToString())
                                        {
                                            if (_sunday == true)
                                                acces = true;
                                        }
                                        if (acces == true)
                                        {
                                            _alarm.Add(_ip);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    contp = 0;
                    while (contp < AlarmLogic.olista.Count - 1)
                    {
                        RespuestaPing = HacerPing.Send(_alarm[contp], iTiempoEspera);
                        if (RespuestaPing.Status == IPStatus.Success)
                        {
                            estatealarm = true;
                            AddLog("Lost IP", _alarm[contp] + ":" + Convert.ToString(contp));
                        }
                        else
                        {
                            AddLog("IP", _alarm[contp] + ":" + Convert.ToString(contp));
                        }
                        contp++;
                    }
                    timeralarm.Interval = 1000;//Convert.ToInt32(timeping) * 1000;
                    contp = 0;
                    while (contp < _alarm.Count)
                    {
                        contpp[contp] = 0;
                        contp++;
                    }
                    if (estatealarm == false)
                    {
                        timeralarm.Start();
                    }
                }
            }
            else
            {
                Robb("0");
            }
        }
        public static void StopAlarm()
        {
            estatealarm = false;
            timeralarm.Stop();
            timerlist.Stop();
            player.Stop();
            frmMain.frm.PanelNotifi.FillColor = Color.FromArgb(255, 179, 2);
            frmMain.frm.GunaPictureBox1.Image = Resources.warning;
            frmMain.frm.GunaLabel1.Text = "Alarm Disabled";
            UC_Main.frm.ButtonStart.Text = "Enabled";
        }
        public static void Robb(string ip)
        {
            timeralarm.Stop();
            roboestate = true;
            AddLog("They are robbing you",ip);
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Sirena.wav"))
            {
                player.Play();
                frmMain.frm.GunaLabel1.Text = "They are robbing you";
                frmMain.frm.PanelNotifi.FillColor = Color.FromArgb(42, 171, 160);
                frmMain.frm.GunaPictureBox1.Image = Resources.warning;
                UC_Main.frm.ButtonStart.Text = "Stop";
            }
            else
            {
                AddLog("Sirena.wav is nothing", ip);
            }
        }
        public static void AddLog(string description, string ip)
        {
            Log obj = new Log()
            {
                Date = DateTime.Now.ToString(),
                Description = description,
                IP = ip
            };
            bool respuesta = LogLogic.instancia.Add(obj);
            if (respuesta)
            {

            }
        }
        public static void AddValues(int _values)
        {
            Stadistic obj = new Stadistic()
            {
                Date = _values
            };
            bool respuesta = StadisticLogic.instancia.Add(obj);
            if (respuesta)
            {

            }
        }
    }
}
