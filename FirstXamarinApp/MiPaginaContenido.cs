using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FirstXamarinApp
{
    class MiPaginaContenido : ContentPage
    {
        public MiPaginaContenido()
        {
            var label = new Label
            {
                Text = "Escribe tu nombre"
            };
            var txtNombre = new Entry
            {
                Placeholder = "Escribe tu nombre"
            };
            Content = new StackLayout
            {
                Padding = 30,
                Spacing = 10,
                Children = { label, txtNombre }
            };
        }
        
    }
}
