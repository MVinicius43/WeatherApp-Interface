using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheatherAppClone.APIRest;
using WheatherAppClone.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static WheatherAppClone.Model.Weather;

namespace WheatherAppClone
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
            InicializaCidade();
            buttonBuscarCidade.Clicked += BuscaWeather;
            buttonBuscarCidade.Clicked += WeatherForecast;
        }

        private void InicializaCidade()
        {
            Weather.Rootobject weather = HGWeather.HGWeatherAPI("Barbacena");

            tempDiaTxt.Text = weather.results.temp.ToString();
            nomeCidade.Text = weather.results.city;
            dataDia.Text = weather.results.date;
            descricaoTempoDia.Text = weather.results.description;
            humidityTxt.Text = weather.results.humidity.ToString() + "%";
            windSpeedTxt.Text = weather.results.wind_speedy;

            List<Forecast> allList = new List<Forecast>();

            foreach (var list in weather.results.forecast)
            {
                allList.Add(list);
            }

            dayOneTxt.Text = allList[0].weekday;
            dateOneTxt.Text = allList[0].date;
            tempMaxOneTxt.Text = "Máx: " + allList[0].max + "°C";
            tempMinOneTxt.Text = "Min: " + allList[0].min + "°C";

            dayTwoTxt.Text = allList[1].weekday;
            dateTwoTxt.Text = allList[1].date;
            tempMaxTwoTxt.Text = "Máx: " + allList[1].max + "°C";
            tempMinTwoTxt.Text = "Min: " + allList[1].min + "°C";

            dayThreeTxt.Text = allList[2].weekday;
            dateThreeTxt.Text = allList[2].date;
            tempMaxThreeTxt.Text = "Máx: " + allList[2].max + "°C";
            tempMinThreeTxt.Text = "Min: " + allList[2].min + "°C";

            dayFourTxt.Text = allList[3].weekday;
            dateFourTxt.Text = allList[3].date;
            tempMaxFourTxt.Text = "Máx: " + allList[3].max + "°C";
            tempMinFourTxt.Text = "Min: " + allList[3].min + "°C";
        }

        private void BuscaWeather(object sender, EventArgs args)
        {
            string cidade = inserirNomeCidade.Text.Trim();
            Weather.Rootobject weather = HGWeather.HGWeatherAPI(cidade);

            tempDiaTxt.Text = weather.results.temp.ToString();
            nomeCidade.Text = weather.results.city;
            dataDia.Text = weather.results.date;
            descricaoTempoDia.Text = weather.results.description;
            humidityTxt.Text = weather.results.humidity.ToString() + "%";
            windSpeedTxt.Text = weather.results.wind_speedy;
        }

        private void WeatherForecast(object sender, EventArgs args)
        {
            string cidade = inserirNomeCidade.Text.Trim();
            Weather.Rootobject weather = HGWeather.HGWeatherAPI(cidade);

            List<Forecast> allList = new List<Forecast>();

            foreach (var list in weather.results.forecast)
            {
               allList.Add(list);
            }
            
            dayOneTxt.Text = allList[0].weekday;
            dateOneTxt.Text = allList[0].date;
            tempMaxOneTxt.Text = "Máx: " + allList[0].max + "°C";
            tempMinOneTxt.Text = "Min: " + allList[0].min + "°C";

            dayTwoTxt.Text = allList[1].weekday;
            dateTwoTxt.Text = allList[1].date;
            tempMaxTwoTxt.Text = "Máx: " + allList[1].max + "°C";
            tempMinTwoTxt.Text = "Min: " + allList[1].min + "°C";

            dayThreeTxt.Text = allList[2].weekday;
            dateThreeTxt.Text = allList[2].date;
            tempMaxThreeTxt.Text = "Máx: " + allList[2].max + "°C";
            tempMinThreeTxt.Text = "Min: " + allList[2].min + "°C";

            dayFourTxt.Text = allList[3].weekday;
            dateFourTxt.Text = allList[3].date;
            tempMaxFourTxt.Text = "Máx: " + allList[3].max + "°C";
            tempMinFourTxt.Text = "Min: " + allList[3].min + "°C";
        }
        
    }
}
    


