using CrudMVVM.Model;
using CrudMVVM.ViewModel;
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
    public partial class PageContato : ContentPage
    {
        public Contato contatoEdicao { get; set; }

        public PageContato()
        {
            InitializeComponent();
            BindingContext = new ContatoViewModel();
        }
    }
}