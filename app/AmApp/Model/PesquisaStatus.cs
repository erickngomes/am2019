using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace AmApp.Model
{

    public class PesquisaStatus : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public PesquisaStatus()
        {

        }


        private int idPessoa;

        public int ID_PESSOA
        {
            get { return idPessoa; }
            set
            {
                if (idPessoa != value)
                {
                    idPessoa = value;
                    NotifyPropertyChanged();
                }
            }
        }



        private String nomeCompleto;
        public String NOME_COMPLETO
        {
            get { return nomeCompleto; }
            set
            {
                if (nomeCompleto != value)
                {
                    nomeCompleto = value;
                    NotifyPropertyChanged();
                }
            }

        }


        private String Cpf;
        public String CPF
        {
            get { return Cpf; }
            set
            {
                if (Cpf != value)
                {
                    Cpf = value;
                    NotifyPropertyChanged();
                }
            }

        }

        private String Rg;
        public String RG
        {
            get { return Rg; }
            set
            {
                if (Rg != value)
                {
                    Rg = value;
                    NotifyPropertyChanged();
                }
            }

        }


        private String pesquisaStatus;
        public String PESQUISA_STATUS
        {
            get { return pesquisaStatus; }
            set
            {
                if (pesquisaStatus != value)
                {
                    pesquisaStatus = value;
                    NotifyPropertyChanged();
                }
            }

        }

        public List<Scraping> Scraping { get; set; }



    }
}
