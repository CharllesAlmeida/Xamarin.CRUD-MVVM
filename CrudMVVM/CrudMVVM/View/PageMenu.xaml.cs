using CrudMVVM.View.ExemplosDaAula;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrudMVVM.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageMenu : ContentPage
    {
        public PageMenu()
        {
            InitializeComponent();
        }

        private void CrudMVVM_Activated(object sender, EventArgs e)        {

            Navigation.PushAsync(new PageContato());
        }

        private void ConsumindoServico_Activated(object sender, EventArgs e)        {
            Navigation.PushAsync(new PageConsultaCEP());
        }


        private void DatePicker_Activated(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageDatePicker());
        }

        private void Reload_Activated(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageReload());
        }

        private void Texto_Activated(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageTexto());
        }

        private void Picker_Activated(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PagePicker());
        }

        private void Grid_Activated(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageGridLayout());
        }
    }
}