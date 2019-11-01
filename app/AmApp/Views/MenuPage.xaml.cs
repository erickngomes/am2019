using AmApp.Layers.Data;
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
    public partial class MenuPage : ContentPage
    {
        public Scraping Scrapping { get; private set; }
        public Pesquisa Pesquisa { get; private set; }

        public MenuPage()
        {
            InitializeComponent();
        }


        public void PesquisarClicked(object o, EventArgs e)
        {
            MessagingCenter.Send<PesquisarPage>(new PesquisarPage(), "PesquisaPageAbrir");
        }

        public void ListaDePesquisaClicked(object o, EventArgs e)
        {
            MessagingCenter.Send<ListaDePesquisaPage>(new ListaDePesquisaPage(), "ListaPageAbrir");
        }


        public void SairClicked(object o, EventArgs e)
        {
            MessagingCenter.Send<String>("", "Logoff");
        }


    }
}