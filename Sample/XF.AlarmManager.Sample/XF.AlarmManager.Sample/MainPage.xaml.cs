using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XF.AlarmManager.Sample.Services;

namespace XF.AlarmManager.Sample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        private Command _setAlarmCommand;
        public Command SetAlarmCommand => _setAlarmCommand ?? (_setAlarmCommand = new Command(SetAlarm));

        private void SetAlarm()
        {
            var alarmService = DependencyService.Get<IAlarmService>();
            alarmService.SetAlarm();
        }
    }
}
