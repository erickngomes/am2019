using AmApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AmApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrincipalPage : MasterDetailPage
    {
        public PrincipalPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            MessagingCenter.Subscribe<PesquisarPage>(this,
                    "PesquisaPageAbrir",
                    (sender) =>
                    {
                        this.Detail = new NavigationPage(new PesquisarPage());
                        this.IsPresented = false;
                    });


            MessagingCenter.Subscribe<ListaDePesquisaPage>(this, "ListaPageAbrir",
                (sender) =>
                {
                    this.Detail = new NavigationPage(new ListaDePesquisaPage());
                    this.IsPresented = false;


                });

            MessagingCenter.Subscribe<PesquisaStatus>(this, "PesquisaRelatorioAbrir",
                 (sender) =>
                 {
                     Global.PesquisaSelecionada = sender;
                     this.Detail.Navigation.PushAsync(new PesquisaDetalhePage());
                 });

            MessagingCenter.Subscribe<PesquisaStatus>(this, "PesquisaEmAndamentoAbrir",
                 (sender) =>
                 {
                     this.Detail.Navigation.PushAsync(new PesquisaEmAndamento());
                     this.IsPresented = false;
                 });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            MessagingCenter.Unsubscribe<PesquisarPage>(this, "PesquisaDetalheAbrir");


        }
    }
}