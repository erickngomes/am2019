using AmApp.Model;
using AmApp.Views.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;



namespace AmApp.ViewModel
{
    public class PesquisaEmAndamentoViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public PesquisaEmAndamentoViewModel()
        {
            Pesquisa = Global.PesquisaSelecionada;

        }

        public PesquisaStatus _pesquisa;
        public PesquisaStatus Pesquisa
        {
            get
            {
                return _pesquisa;
            }
            set
            {
                _pesquisa = value;
                NotifyPropertyChanged();
            }
        }


    }


}
