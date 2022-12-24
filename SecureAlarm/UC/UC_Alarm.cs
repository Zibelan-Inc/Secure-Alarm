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
using KosmoSecure.DB;
using KosmoSecure.Logic;
using KosmoSecure.Class;
using System.Net;

namespace KosmoSecure
{
    public partial class UC_Alarm : UserControl
    {
        private UserPreferenceChangedEventHandler UserPreferenceChanged;
        public static UC_Alarm frm;
        Guna.UI.Lib.ScrollBar.PanelScrollHelper vScrollHelper;

        Alarm _alarm;
        int id;
        public UC_Alarm()
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
            var lightColor = ControlPaint.Light(themeColor);
            var darkColor = ControlPaint.Dark(themeColor);

            gunaVScrollBar1.ThumbColor = themeColor;
            gunaVScrollBar1.ThumbHoverColor = lightColor;
            gunaVScrollBar1.ThumbPressedColor = darkColor;
            NameBox.BorderColor = themeColor;
            TextIP.BorderColor = themeColor;
            EstateCheked.CheckedState.BorderColor = themeColor;
            EstateCheked.CheckedState.FillColor = themeColor;
            ProgramerChecked.CheckedState.BorderColor = themeColor;
            ProgramerChecked.CheckedState.FillColor = themeColor;
            HoraComboBox.FillColor = themeColor;
            HoraComboBox.ForeColor = lightColor;
            MinutosComboBox.FillColor = themeColor;
            MinutosComboBox.ForeColor = lightColor;
            TiempoComboBox.FillColor = themeColor;
            TiempoComboBox.ForeColor = lightColor;
            Hora2ComboBox.FillColor = themeColor;
            Hora2ComboBox.ForeColor = lightColor;
            Minutos2ComboBox.FillColor = themeColor;
            Minutos2ComboBox.ForeColor = lightColor;
            Tiempo2ComboBox.FillColor = themeColor;
            Tiempo2ComboBox.ForeColor = lightColor;
            MondayChecked.CheckedState.BorderColor = themeColor;
            MondayChecked.CheckedState.FillColor = themeColor;
            TuesdayChecked.CheckedState.BorderColor = themeColor;
            TuesdayChecked.CheckedState.FillColor = themeColor;
            WednesdayChecked.CheckedState.BorderColor = themeColor;
            WednesdayChecked.CheckedState.FillColor = themeColor;
            ThursdayChecked.CheckedState.BorderColor = themeColor;
            ThursdayChecked.CheckedState.FillColor = themeColor;
            FridayComboBox.CheckedState.BorderColor = themeColor;
            FridayComboBox.CheckedState.FillColor = themeColor;
            SaturdayChecked.CheckedState.BorderColor = themeColor;
            SaturdayChecked.CheckedState.FillColor = themeColor;
            SundayChecked.CheckedState.BorderColor = themeColor;
            SundayChecked.CheckedState.FillColor = themeColor;
            ButtonAdd.ForeColor = themeColor;
            ButtonAdd.BorderColor = themeColor;
            ButtonAdd.OnHoverBaseColor = themeColor;
            ButtonAdd.OnHoverBorderColor = themeColor;
            ButtonAdd.OnHoverForeColor = Themes.Panel;
        }
        private void UC_Alarm_Load(object sender, EventArgs e)
        {
            LoadAlarm();
            if (Properties.Settings.Default.Theme != "")
            {
                modCommon.ChangedThemeAlarm(Properties.Settings.Default.Theme);
            }
            else
            {
                Properties.Settings.Default.Theme = "Dark";
                Properties.Settings.Default.Save();
                modCommon.ChangedThemeAlarm("Dark");
            }
        }
        private void PanelContainer_Resize(object sender, EventArgs e)
        {
            if (vScrollHelper is object) vScrollHelper.UpdateScrollBar();
        }
        private void ProgramerChecked_CheckedChanged(object sender, EventArgs e)
        {
            if(ProgramerChecked.Checked == true)
            {
                HoraComboBox.Enabled = true;
                MinutosComboBox.Enabled = true;
                TiempoComboBox.Enabled = true;
                Hora2ComboBox.Enabled = true;
                Minutos2ComboBox.Enabled = true;
                Tiempo2ComboBox.Enabled = true;
                MondayChecked.Enabled = true;
                TuesdayChecked.Enabled = true;
                WednesdayChecked.Enabled = true;
                ThursdayChecked.Enabled = true;
                FridayComboBox.Enabled = true;
                SaturdayChecked.Enabled = true;
                SundayChecked.Enabled = true;
            }
            else
            {
                HoraComboBox.Enabled = false;
                MinutosComboBox.Enabled = false;
                TiempoComboBox.Enabled = false;
                Hora2ComboBox.Enabled = false;
                Minutos2ComboBox.Enabled = false;
                Tiempo2ComboBox.Enabled = false;
                MondayChecked.Enabled = false;
                TuesdayChecked.Enabled = false;
                WednesdayChecked.Enabled = false;
                ThursdayChecked.Enabled = false;
                FridayComboBox.Enabled = false;
                SaturdayChecked.Enabled = false;
                SundayChecked.Enabled = false;
            }
        }
        public void LoadAlarm()
        {
            PanelContainer.Controls.Clear();
            var themeColor = Class.WinTheme.GetAccentColor();
            var lightColor = ControlPaint.Light(themeColor);
            //var darkColor = ControlPaint.Dark(themeColor);
            AlarmLogic.instancia.Listar();
            vScrollHelper = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(PanelContainer, gunaVScrollBar1, true);
            for (int i = 0; i <= AlarmLogic.olista.Count -1; i++)
            {
                Guna.UI2.WinForms.Guna2Panel a = new Guna.UI2.WinForms.Guna2Panel();
                UIDC.UI_LabelMaterial b = new UIDC.UI_LabelMaterial();
                FontAwesome.Sharp.IconButton c = new FontAwesome.Sharp.IconButton();
                FontAwesome.Sharp.IconButton d = new FontAwesome.Sharp.IconButton();
                //Guna.UI2.WinForms.Guna2Separator e = new Guna.UI2.WinForms.Guna2Separator();
                var temp = AlarmLogic.olista[i];

                //e.BackColor = Color.Transparent;
                //e.Name = temp.Name;
                //e.FillColor = Themes.FuenteA;
                //e.Location = new Point(116, 0);

                d.BackColor = Themes.Panel;
                d.Location = new Point(350, 0);
                d.Size = new Size(42, 42);
                d.FlatAppearance.BorderSize = 0;
                d.FlatStyle = FlatStyle.Flat;
                d.IconChar = FontAwesome.Sharp.IconChar.Edit;
                d.IconColor = themeColor;
                d.IconFont = FontAwesome.Sharp.IconFont.Auto;
                d.IconSize = 30;
                d.Name = Convert.ToString(i);
                d.MouseClick += new MouseEventHandler(EditButton_Click);

                c.BackColor = Themes.Panel;
                c.Location = new Point(390, 0);
                c.Size = new Size(42, 42);
                c.FlatAppearance.BorderSize = 0;
                c.FlatStyle = FlatStyle.Flat;
                c.IconChar = FontAwesome.Sharp.IconChar.Times;
                c.IconColor = themeColor;
                c.IconFont = FontAwesome.Sharp.IconFont.Auto;
                c.IconSize = 30;
                c.Name = Convert.ToString(i);
                c.MouseClick += new MouseEventHandler(DeleteButton_Click);

                b.AutoSize = true;
                b.BackColor = Color.Transparent;
                b.Font = new Font("Segoe UI", 10F);
                b.ForeColor = lightColor;
                b.Location = new Point(6, 11);
                b.Name = temp.Name;
                b.Text = temp.Name;

                a.Controls.Add(b);
                a.Controls.Add(c);
                a.Controls.Add(d);
                if (i != 0)
                    //a.Controls.Add(e);
                a.Name = temp.Name;
                a.Size = new Size(432, 42);
                a.BackColor = Color.Transparent;
                a.FillColor = Themes.Panel;

                PanelContainer.Controls.Add(a);
            }
            modCommon.plseasewait = true;
            vScrollHelper.UpdateScrollBar();

            if (PanelContainer.Controls.Count > 8)
            {
                gunaVScrollBar1.Visible = true;
            }
            else
            {
                gunaVScrollBar1.Visible = false;
            }
        }
        internal static bool IsValidIp(string ip)
        {
            return IPAddress.TryParse(ip, out IPAddress address);
        }
        private void TxtIP_TextChanged(object sender, EventArgs e)
        {
            var themeColor = Class.WinTheme.GetAccentColor();
            if (IsValidIp(TextIP.Text))
            {
                TextIP.FocusedState.BorderColor = themeColor;
            }
            else
                TextIP.FocusedState.BorderColor = Color.Red;
        }
        private void EditButton_Click(object sender, MouseEventArgs e)
        {
            string _hour, _hour2, _min, _min2;

            HoraComboBox.Enabled = true;
            MinutosComboBox.Enabled = true;
            TiempoComboBox.Enabled = true;
            Hora2ComboBox.Enabled = true;
            Minutos2ComboBox.Enabled = true;
            Tiempo2ComboBox.Enabled = true;
            MondayChecked.Enabled = true;
            TuesdayChecked.Enabled = true;
            WednesdayChecked.Enabled = true;
            ThursdayChecked.Enabled = true;
            FridayComboBox.Enabled = true;
            SaturdayChecked.Enabled = true;
            SundayChecked.Enabled = true;

            FontAwesome.Sharp.IconButton _sender = sender as FontAwesome.Sharp.IconButton;
            id = AlarmLogic.olista[Convert.ToInt32(_sender.Name)].id;
            NameBox.Text = AlarmLogic.olista[Convert.ToInt32(_sender.Name)].Name;
            TextIP.Text = AlarmLogic.olista[Convert.ToInt32(_sender.Name)].IP;
            if (AlarmLogic.olista[Convert.ToInt32(_sender.Name)].State == 1)
                EstateCheked.Checked = true;
            else
                EstateCheked.Checked = false;
            if (AlarmLogic.olista[Convert.ToInt32(_sender.Name)].Programer == 1)
                ProgramerChecked.Checked = true;
            else
                ProgramerChecked.Checked = false;
            if(ProgramerChecked.Checked == true)
            {
                _hour = AlarmLogic.olista[Convert.ToInt32(_sender.Name)].HourEnabled.Split(':')[0];
                _min = AlarmLogic.olista[Convert.ToInt32(_sender.Name)].HourEnabled.Split(':')[1];
                if (Convert.ToInt32(_hour) >= 12)
                    TiempoComboBox.SelectedItem = "PM";
                if (_hour == "13")
                    _hour = "01";
                else if (_hour == "14")
                    _hour = "02";
                else if (_hour == "15")
                    _hour = "03";
                else if (_hour == "16")
                    _hour = "04";
                else if (_hour == "17")
                    _hour = "05";
                else if (_hour == "18")
                    _hour = "06";
                else if (_hour == "19")
                    _hour = "07";
                else if (_hour == "20")
                    _hour = "08";
                else if (_hour == "21")
                    _hour = "09";
                else if (_hour == "22")
                    _hour = "10";
                else if (_hour == "23")
                {
                    if (_min == "59")
                    {
                        _hour = "12";
                        _min = "00";
                    }
                    else
                        _hour = "11";
                }
                else
                    TiempoComboBox.SelectedItem = "AM";
                if (_hour == "1")
                    _hour = "01";
                else if (_hour == "2")
                    _hour = "02";
                else if (_hour == "3")
                    _hour = "03";
                else if (_hour == "4")
                    _hour = "04";
                else if (_hour == "5")
                    _hour = "05";
                else if (_hour == "6")
                    _hour = "06";
                else if (_hour == "7")
                    _hour = "07";
                else if (_hour == "8")
                    _hour = "08";
                else if (_hour == "9")
                    _hour = "09";
                else if (_hour == "10")
                    _hour = "10";
                else if (_hour == "11")
                    _hour = "11";
                else if (_hour == "12")
                    _hour = "12";
                HoraComboBox.SelectedItem = _hour;
                MinutosComboBox.SelectedItem = _min;
                _hour2 = AlarmLogic.olista[Convert.ToInt32(_sender.Name)].HourDisabled.Split(':')[0];
                _min2 = AlarmLogic.olista[Convert.ToInt32(_sender.Name)].HourDisabled.Split(':')[1];
                if (Convert.ToInt32(_hour2) >= 12)
                    Tiempo2ComboBox.SelectedItem = "PM";
                if (_hour2 == "13")
                    _hour2 = "01";
                else if (_hour2 == "14")
                    _hour2 = "02";
                else if (_hour2 == "15")
                    _hour2 = "03";
                else if (_hour2 == "16")
                    _hour2 = "04";
                else if (_hour2 == "17")
                    _hour2 = "05";
                else if (_hour2 == "18")
                    _hour2 = "06";
                else if (_hour2 == "19")
                    _hour2 = "07";
                else if (_hour2 == "20")
                    _hour2 = "08";
                else if (_hour2 == "21")
                    _hour2 = "09";
                else if (_hour2 == "22")
                    _hour2 = "10";
                else if (_hour2 == "23")
                {
                    if (_min2 == "59")
                    {
                        _hour2 = "12";
                        _min2 = "00";
                    }
                    else
                        _hour2 = "11";
                }
                else
                    Tiempo2ComboBox.SelectedItem = "AM";
                if (_hour2 == "1")
                    _hour2 = "01";
                else if (_hour2 == "2")
                    _hour2 = "02";
                else if (_hour2 == "3")
                    _hour2 = "03";
                else if (_hour2 == "4")
                    _hour2 = "04";
                else if (_hour2 == "5")
                    _hour2 = "05";
                else if (_hour2 == "6")
                    _hour2 = "06";
                else if (_hour2 == "7")
                    _hour2 = "07";
                else if (_hour2 == "8")
                    _hour2 = "08";
                else if (_hour2 == "9")
                    _hour2 = "09";
                else if (_hour2 == "10")
                    _hour2 = "10";
                else if (_hour2 == "11")
                    _hour2 = "11";
                else if (_hour2 == "12")
                    _hour2 = "12";
                Hora2ComboBox.SelectedItem = _hour2;
                Minutos2ComboBox.SelectedItem = _min2;
                if (AlarmLogic.olista[Convert.ToInt32(_sender.Name)].Monday == 1)
                    MondayChecked.Checked = true;
                else
                    MondayChecked.Checked = false;
                if (AlarmLogic.olista[Convert.ToInt32(_sender.Name)].Tuesday == 1)
                    TuesdayChecked.Checked = true;
                else
                    TuesdayChecked.Checked = false;
                if (AlarmLogic.olista[Convert.ToInt32(_sender.Name)].Wednesday == 1)
                    WednesdayChecked.Checked = true;
                else
                    WednesdayChecked.Checked = false;
                if (AlarmLogic.olista[Convert.ToInt32(_sender.Name)].Thursday == 1)
                    ThursdayChecked.Checked = true;
                else
                    ThursdayChecked.Checked = false;
                if (AlarmLogic.olista[Convert.ToInt32(_sender.Name)].Friday == 1)
                    FridayComboBox.Checked = true;
                else
                    FridayComboBox.Checked = false;
                if (AlarmLogic.olista[Convert.ToInt32(_sender.Name)].Saturday == 1)
                    SaturdayChecked.Checked = true;
                else
                    SaturdayChecked.Checked = false;
                if (AlarmLogic.olista[Convert.ToInt32(_sender.Name)].Sunday == 1)
                    SundayChecked.Checked = true;
                else
                    SundayChecked.Checked = false;
            }   
            else
            {
                HoraComboBox.Text = "";
                MinutosComboBox.Text = "";
                TiempoComboBox.Text = "";
                Hora2ComboBox.Text = "";
                Minutos2ComboBox.Text = "";
                Tiempo2ComboBox.Text = "";
                MondayChecked.Checked = false;
                TuesdayChecked.Checked = false;
                WednesdayChecked.Checked = false;
                ThursdayChecked.Checked = false;
                FridayComboBox.Checked = false;
                SaturdayChecked.Checked = false;
                SundayChecked.Checked = false;

                HoraComboBox.Enabled = false;
                MinutosComboBox.Enabled = false;
                TiempoComboBox.Enabled = false;
                Hora2ComboBox.Enabled = false;
                Minutos2ComboBox.Enabled = false;
                Tiempo2ComboBox.Enabled = false;
                MondayChecked.Enabled = false;
                TuesdayChecked.Enabled = false;
                WednesdayChecked.Enabled = false;
                ThursdayChecked.Enabled = false;
                FridayComboBox.Enabled = false;
                SaturdayChecked.Enabled = false;
                SundayChecked.Enabled = false;
            }
            ButtonAdd.Text = "Edit";
        }
        private void DeleteButton_Click(object sender, MouseEventArgs e)
        {
            FontAwesome.Sharp.IconButton _sender = sender as FontAwesome.Sharp.IconButton;
            _alarm = AlarmLogic.olista[Convert.ToInt32(_sender.Name)];
            Alarm obj = new Alarm()
            {
                id = _alarm.id
            };
            bool respuesta = AlarmLogic.instancia.Delete(obj);
            if (respuesta)
            {
                LoadAlarm();
            }
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if(NameBox.Text != "")
            {
                if(TextIP.Text != "")
                {
                    if(ButtonAdd.Text == "Add")
                    {
                        int state, monday, tuesday, wednesday, thursday, friday, saturday, sunday, programer;
                        string horaenabled, horadisabled, ip;
                        horaenabled = Convert.ToString(HoraComboBox.SelectedItem);
                        if (Convert.ToString(TiempoComboBox.SelectedItem) == "PM")
                        {
                            if (horaenabled == "01")
                                horaenabled = "13";
                            else if (horaenabled == "02")
                                horaenabled = "14";
                            else if (horaenabled == "03")
                                horaenabled = "15";
                            else if (horaenabled == "04")
                                horaenabled = "16";
                            else if (horaenabled == "05")
                                horaenabled = "17";
                            else if (horaenabled == "06")
                                horaenabled = "18";
                            else if (horaenabled == "07")
                                horaenabled = "19";
                            else if (horaenabled == "08")
                                horaenabled = "20";
                            else if (horaenabled == "09")
                                horaenabled = "21";
                            else if (horaenabled == "10")
                                horaenabled = "22";
                            else if (horaenabled == "11")
                                horaenabled = "23";
                            else if (horaenabled == "12")
                                horaenabled = "24";
                        }
                        if (ProgramerChecked.Checked == true)
                        {
                            if(horaenabled == "24")
                                horaenabled = "23:59";
                            else
                                horaenabled = horaenabled + ":" + Convert.ToString(MinutosComboBox.SelectedItem);
                        }
                        else
                            horaenabled = "";
                        horadisabled = Convert.ToString(Hora2ComboBox.SelectedItem);
                        if (Convert.ToString(Tiempo2ComboBox.SelectedItem) == "PM")
                        {
                            if (horadisabled == "01")
                                horadisabled = "13";
                            else if (horadisabled == "02")
                                horadisabled = "14";
                            else if (horadisabled == "03")
                                horadisabled = "15";
                            else if (horadisabled == "04")
                                horadisabled = "16";
                            else if (horadisabled == "05")
                                horadisabled = "17";
                            else if (horadisabled == "06")
                                horadisabled = "18";
                            else if (horadisabled == "07")
                                horadisabled = "19";
                            else if (horadisabled == "08")
                                horadisabled = "20";
                            else if (horadisabled == "09")
                                horadisabled = "21";
                            else if (horadisabled == "10")
                                horadisabled = "22";
                            else if (horadisabled == "11")
                                horadisabled = "23";
                            else if (horadisabled == "12")
                                horadisabled = "24";
                        }
                        if (ProgramerChecked.Checked == true)
                        {
                            if(horadisabled == "24")
                                horadisabled = "23:59";
                            else
                                horadisabled = horadisabled + ":" + Convert.ToString(Minutos2ComboBox.SelectedItem);
                        }
                        else
                            horadisabled = "";
                        if (EstateCheked.Checked == true)
                            state = 1;
                        else
                            state = 0;

                        if (MondayChecked.Checked == true)
                            monday = 1;
                        else
                            monday = 0;
                        if (TuesdayChecked.Checked == true)
                            tuesday = 1;
                        else
                            tuesday = 0;
                        if (WednesdayChecked.Checked == true)
                            wednesday = 1;
                        else
                            wednesday = 0;
                        if (ThursdayChecked.Checked == true)
                            thursday = 1;
                        else
                            thursday = 0;
                        if (FridayComboBox.Checked == true)
                            friday = 1;
                        else
                            friday = 0;
                        if (SaturdayChecked.Checked == true)
                            saturday = 1;
                        else
                            saturday = 0;
                        if (SundayChecked.Checked == true)
                            sunday = 1;
                        else
                            sunday = 0;
                        if (ProgramerChecked.Checked == true)
                            programer = 1;
                        else
                            programer = 0;
                        ip = TextIP.Text;
                        Alarm obj = new Alarm()
                        {
                            Name = NameBox.Text,
                            State = state,
                            HourEnabled = horaenabled,
                            HourDisabled = horadisabled,
                            Monday = monday,
                            Tuesday = tuesday,
                            Wednesday = wednesday,
                            Thursday = thursday,
                            Friday = friday,
                            Saturday = saturday,
                            Sunday = sunday,
                            Programer = programer,
                            IP = ip
                        };
                        bool respuesta = AlarmLogic.instancia.Add(obj);
                        if (respuesta)
                        {
                            LoadAlarm();
                            modCommon.Alarm();
                        }
                    }
                    else
                    {
                        int state, monday, tuesday, wednesday, thursday, friday, saturday, sunday, programer;
                        string horaenabled, horadisabled, ip;
                        horaenabled = Convert.ToString(HoraComboBox.SelectedItem);
                        if (Convert.ToString(TiempoComboBox.SelectedItem) == "PM")
                        {
                            if (horaenabled == "01")
                                horaenabled = "13";
                            else if (horaenabled == "02")
                                horaenabled = "14";
                            else if (horaenabled == "03")
                                horaenabled = "15";
                            else if (horaenabled == "04")
                                horaenabled = "16";
                            else if (horaenabled == "05")
                                horaenabled = "17";
                            else if (horaenabled == "06")
                                horaenabled = "18";
                            else if (horaenabled == "07")
                                horaenabled = "19";
                            else if (horaenabled == "08")
                                horaenabled = "20";
                            else if (horaenabled == "09")
                                horaenabled = "21";
                            else if (horaenabled == "10")
                                horaenabled = "22";
                            else if (horaenabled == "11")
                                horaenabled = "23";
                            else if (horaenabled == "12")
                                horaenabled = "24";
                        }
                        if (ProgramerChecked.Checked == true)
                        {
                            if (horaenabled == "24")
                                horaenabled = "23:59";
                            else
                                horaenabled = horaenabled + ":" + Convert.ToString(MinutosComboBox.SelectedItem);
                        }
                        else
                            horaenabled = "";
                        horadisabled = Convert.ToString(Hora2ComboBox.SelectedItem);
                        if (Convert.ToString(Tiempo2ComboBox.SelectedItem) == "PM")
                        {
                            if (horadisabled == "01")
                                horadisabled = "13";
                            else if (horadisabled == "02")
                                horadisabled = "14";
                            else if (horadisabled == "03")
                                horadisabled = "15";
                            else if (horadisabled == "04")
                                horadisabled = "16";
                            else if (horadisabled == "05")
                                horadisabled = "17";
                            else if (horadisabled == "06")
                                horadisabled = "18";
                            else if (horadisabled == "07")
                                horadisabled = "19";
                            else if (horadisabled == "08")
                                horadisabled = "20";
                            else if (horadisabled == "09")
                                horadisabled = "21";
                            else if (horadisabled == "10")
                                horadisabled = "22";
                            else if (horadisabled == "11")
                                horadisabled = "23";
                            else if (horadisabled == "12")
                                horadisabled = "24";
                        }
                        if (ProgramerChecked.Checked == true)
                        {
                            if (horadisabled == "24")
                                horadisabled = "23:59";
                            else
                                horadisabled = horadisabled + ":" + Convert.ToString(Minutos2ComboBox.SelectedItem);
                        }
                        else
                            horadisabled = "";
                        if (EstateCheked.Checked == true)
                            state = 1;
                        else
                            state = 0;

                        if (MondayChecked.Checked == true)
                            monday = 1;
                        else
                            monday = 0;
                        if (TuesdayChecked.Checked == true)
                            tuesday = 1;
                        else
                            tuesday = 0;
                        if (WednesdayChecked.Checked == true)
                            wednesday = 1;
                        else
                            wednesday = 0;
                        if (ThursdayChecked.Checked == true)
                            thursday = 1;
                        else
                            thursday = 0;
                        if (FridayComboBox.Checked == true)
                            friday = 1;
                        else
                            friday = 0;
                        if (SaturdayChecked.Checked == true)
                            saturday = 1;
                        else
                            saturday = 0;
                        if (SundayChecked.Checked == true)
                            sunday = 1;
                        else
                            sunday = 0;
                        if (ProgramerChecked.Checked == true)
                            programer = 1;
                        else
                            programer = 0;
                        ip = TextIP.Text;
                        Alarm obj = new Alarm()
                        {
                            id = id,
                            Name = NameBox.Text,
                            State = state,
                            HourEnabled = horaenabled,
                            HourDisabled = horadisabled,
                            Monday = monday,
                            Tuesday = tuesday,
                            Wednesday = wednesday,
                            Thursday = thursday,
                            Friday = friday,
                            Saturday = saturday,
                            Sunday = sunday,
                            Programer = programer,
                            IP = ip
                        };
                        bool respuesta = AlarmLogic.instancia.Edit(obj);
                        if (respuesta)
                        {
                            ButtonAdd.Text = "Add";
                            LoadAlarm();
                            modCommon.Alarm();
                        }
                    }
                }
            }
        }
    }
}
