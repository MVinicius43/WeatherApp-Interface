using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using WheatherAppClone.Model;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Xamarin.Forms.Internals;
using System.Net;

namespace WheatherAppClone.APIRest
{
    public class HGWeather
    {
        private static string HGWEndereco = Constantes.ApiURI;
        public static Weather.Rootobject HGWeatherAPI (string cidade)
        {
            string novaCidadeURL = string.Format(HGWEndereco, cidade);

            WebClient wc = new WebClient();
            string conteudo = wc.DownloadString(novaCidadeURL);

            return JsonConvert.DeserializeObject<Weather.Rootobject>(conteudo);
        }
    }
}
