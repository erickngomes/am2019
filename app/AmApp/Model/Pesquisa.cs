using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace AmApp.Model
{

    public class Pesquisa : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public Pesquisa()
        {

        }

        public Pesquisa(string _nomeCompleto, string _Cpf, string _Rg)
        {
            
            this.NomeCompleto = _nomeCompleto;
            this.CPF = _Cpf;
            this.RG = _Rg;
        }



        private int idPesquisa;


        public int IdPesquisa
        {
            get { return idPesquisa; }
            set
            {
                if (idPesquisa != value)
                {
                    idPesquisa = value;
                    NotifyPropertyChanged();
                }
            }
        }



        public List<Scraping> Scraping { get; set; }



        private String scrapData;
        public String ScrapData
        {
            get { return scrapData; }
            set
            {
                if (scrapData != value)
                {
                    scrapData = value;
                    NotifyPropertyChanged();
                }
            }

        }

        private String nomeCompleto;
        public String NomeCompleto
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



    }
}
