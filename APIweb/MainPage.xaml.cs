using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using APIweb.Modelo;
using System.Collections.ObjectModel;

namespace APIweb
{
    public partial class MainPage : ContentPage
    {
        private String url = "https://jsonplaceholder.typicode.com/todos";
        HttpClient cliente = new HttpClient();

        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            string contenido = await cliente.GetStringAsync(url);
            IEnumerable<UsuarioModelo> lista = JsonConvert.DeserializeObject<IEnumerable<UsuarioModelo>>(contenido);
            ltusuario.ItemsSource = new ObservableCollection<UsuarioModelo>(lista);
            base.OnAppearing();
        }


    }
}
