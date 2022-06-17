using GranjaSQLite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GranjaSQLite.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IngresoAnimalView : ContentPage
    {
        public IngresoAnimalView()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Clicked(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                Animal animal = new Animal
                {
                    NameAnimal = txtNombre.Text
                };
                await App.SQLiteDB.SaveAnimalAsync(animal);
                txtNombre.Text = "";
                await DisplayAlert("Ingreso", "Se guardo de manera exitosa", "OK");
                var animalList = await App.SQLiteDB.getAnimalAsync();
                if (animalList != null)
                {
                    listAnimal.ItemsSource = animalList;
                }
            }

            else
            {
                await DisplayAlert("Advertencia", "Ingresar datos", "OK");
            }
        }
        public bool validarDatos()
        {
            bool respuesta;
            if (string.IsNullOrEmpty(txtNombre.Text)) 
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