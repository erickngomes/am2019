using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using AmApp.Model;
using AmApp.Views;
using Xamarin.Forms;

namespace AmApp.ViewModel
{
    public class ListaDePesquisaViewModel
    {

        public ICommand PesquisaTappedCommand { get; private set; }
        public ListaDePesquisaViewModel()
        {

            ListaDePesquisaPosicao = new Layers.Business.PesquisaBusiness().GetListaDePesquisaStatus(Global.UsuarioLogado);
            PesquisaTappedCommand = new Command(() =>
            {
                if (PesquisaSelecionada.PESQUISA_STATUS.Equals("Em Progresso"))
                {
                    Global.PesquisaSelecionada = PesquisaSelecionada;
                    MessagingCenter.Send<PesquisaStatus>(PesquisaSelecionada, "PesquisaEmAndamentoAbrir");
                }
                else
                {
                    MessagingCenter.Send<PesquisaStatus>(PesquisaSelecionada, "PesquisaRelatorioAbrir");
                }
                
            });

        }


        public PesquisaStatus PesquisaSelecionada { get; set; }

        private List<PesquisaStatus> listaDePesquisaPosicao;
        public List<PesquisaStatus> ListaDePesquisaPosicao
        {
            get
            {
                return listaDePesquisaPosicao;
            }
            set
            {
                listaDePesquisaPosicao = value;
            }
        }


    }
}
