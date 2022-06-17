using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GranjaSQLite.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GranjaSQLite.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReporteGeneralView : ContentPage
    {
        public ReporteGeneralView()
        {
            InitializeComponent();
        }
        private async void btnGenerarReporte_Clicked(object sender, EventArgs e)
        {
            if (generarReporte())
            {
                
                await DisplayAlert("Ingreso", "Se guardo de manera exitosa", "OK");
                var reportelList = await App.SQLiteDB.GetGenerarReporte(IdCorral);
                if (reportelList != null)
                {
                    listReporteGeneral.ItemsSource = reportelList;
                }
            }

            else
            {
                await DisplayAlert("Advertencia", "Error al generar el reporte", "OK");
            }
        }
        public bool generarReporte()
        {
            bool respuesta;
            if (IdCorral != null)
            {
                respuesta = false;
            }
            else
            {
                respuesta = true;
            }
            return respuesta;
        }
    }
}