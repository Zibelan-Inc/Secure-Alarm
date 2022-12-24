using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Input;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KosmoSecure.Logic;
using LiveCharts;
using LiveCharts.Events;
using LiveCharts.Wpf;

namespace KosmoSecure
{
    public partial class UC_Log : UserControl
    {
        private UserPreferenceChangedEventHandler UserPreferenceChanged;
        public static UC_Log frm;
        public UC_Log()
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

            dtLog.ThemeStyle.HeaderStyle.BackColor = themeColor;
        }
        private void UC_Log_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme != "")
            {
                modCommon.ChangedThemeLog(Properties.Settings.Default.Theme);
            }
            else
            {
                Properties.Settings.Default.Theme = "Dark";
                Properties.Settings.Default.Save();
                modCommon.ChangedThemeLog("Dark");
            }
            LoadTheme();
            LoadLog();
        }
        private void LoadLog()
        {
            var themeColor = Class.WinTheme.GetAccentColor();
            dtLog.DataSource = null;
            dtLog.DataSource = LogLogic.instancia.Listar();

            cartesianChart1.Series.Clear();
            List<int> values = new List<int>();
            SeriesCollection series = new SeriesCollection();
            var dates = (StadisticLogic.olista);
            StadisticLogic.instancia.Listar();
            for(int i = StadisticLogic.olista.Count -9; i <= StadisticLogic.olista.Count -1; i++)
            {
                values.Add(StadisticLogic.olista[i].Date);
            }
            series.Add(new LineSeries()
            {
                AllowDrop = false,
                ClipToBounds = false,
                FlowDirection = System.Windows.FlowDirection.LeftToRight,
                Focusable = false,
                HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch,
                IsEnabled = true,
                IsHitTestVisible = true,
                LineSmoothness = 0.7,
                OverridesDefaultStyle = false,
                SnapsToDevicePixels = false,
                StrokeThickness = 2,
                Title = "Lost IP",
                Values = new ChartValues<int>(values),
                UseLayoutRounding = false,
                VerticalAlignment = VerticalAlignment.Stretch
            });
            cartesianChart1.Series = series;
            modCommon.plseasewait = true;
        }
    }
}
