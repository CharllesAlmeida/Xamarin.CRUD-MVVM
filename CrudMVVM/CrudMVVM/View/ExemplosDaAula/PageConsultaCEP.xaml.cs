using CrudMVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CrudMVVM.Service;

namespace CrudMVVM.View.ExemplosDaAula
{
        [XamlCompilation(XamlCompilationOptions.Compile)]
        public partial class PageConsultaCEP : ContentPage
        {
            public PageConsultaCEP()
            {
                InitializeComponent();
            }

            private async void Button_Clicked(object sender, EventArgs e)
            {
                if (txtCEP.Text != null && txtCEP.Text.Length == 8)
                {
                    CEP cep = await BuscaCepService.BuscaCEP(txtCEP.Text);
                    this.Cidade.Text = cep.Localidade.ToString();
                    this.complemento.Text = cep.Complemento.ToString();
                    this.bairro.Text = cep.Bairro.ToString();
                    this.uf.Text = cep.Uf.ToString();
                }
                else
                {
                    lblResultado.Text = "O CEP digitado é invalido";
                    lblResultado.TextColor = Color.Red;
                }

            }
        }
}