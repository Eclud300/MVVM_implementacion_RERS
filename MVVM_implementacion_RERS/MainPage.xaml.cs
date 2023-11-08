using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MVVM_implementacion_RERS
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent(j);
        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            Alerta();
        }

        private void Alerta()
        {
            DisplayAlert("Alerta", "Esta es una alerta", "Ok");
        }
    }
}
