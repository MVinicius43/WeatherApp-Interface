using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WheatherAppClone
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        public List<Weather> Weathers { get => WeatherData(); }

        private List<Weather> WeatherData()
        {
            var tempList = new List<Weather>();
            tempList.Add(new Weather { Temp = "22", Date = "Sunday 16", Icon = "weather.png" });
            tempList.Add(new Weather { Temp = "21", Date = "Monday 17", Icon = "weather.png" });
            tempList.Add(new Weather { Temp = "18", Date = "Tuesday 18", Icon = "weather.png" });
            tempList.Add(new Weather { Temp = "19", Date = "Wednesday 19", Icon = "weather.png" });
            tempList.Add(new Weather { Temp = "22", Date = "Thursday 20", Icon = "weather.png" });
            tempList.Add(new Weather { Temp = "21", Date = "Friday 21", Icon = "weather.png" });
            tempList.Add(new Weather { Temp = "22", Date = "Saturday 22", Icon = "weather.png" });

            return tempList;
        }

        public class Weather
        {
            public string Temp { get; set; }
            public string Date { get; set; }
            public string Icon { get; set; }
        }
    }
}
