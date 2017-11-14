using CrudMVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CrudMVVM.ViewModel
{
     public  class ContatoViewModel : INotifyPropertyChanged    {
        public Contato ContatoAtual { get; set; }
        public Command SalvarContatoCommand { get; set; }
        public Command ExcluirContatoCommand { get; set; }
        public Command EditarContatoCommand { get; set; }
        public ObservableCollection<Contato> Contatos { get; set; }

        public ContatoViewModel() {
            ContatoAtual = new Contato();
            Contatos = new ObservableCollection<Contato>(new ContatoRepository().Listar());

            SalvarContatoCommand   = new Command(Salvar);
            ExcluirContatoCommand  = new Command<Contato>(ExcluirContato);
            EditarContatoCommand   = new Command<Contato>(EditarContato);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void Salvar()        {
            using (var dados = new ContatoRepository())   {
                if (ContatoAtual.Id == 0)   {
                    new ContatoRepository().Insert(ContatoAtual);
                    Contatos.Add(ContatoAtual);
                    ContatoAtual = new Contato();
                    OnPropertyChanged("ContatoAtual");
                }
                else  {
                    new ContatoRepository().Update(ContatoAtual);
                    Contatos = new ObservableCollection<Contato>(new ContatoRepository().Listar());
                    OnPropertyChanged("Contatos");
                    ContatoAtual = new Contato();
                    OnPropertyChanged("ContatoAtual");
                }

            }
        }


private void ExcluirContato(Contato contato)  {
            new ContatoRepository().Delete(contato);
            Contatos.Remove(contato);
        }

        private void EditarContato(Contato contato)  {
            ContatoAtual = contato;
            OnPropertyChanged("ContatoAtual");
        }

    }

}
