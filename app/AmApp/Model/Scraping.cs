using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace AmApp.Model
{

    public class Scraping : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private String Label;
        public String label
        {
            get { return Label; }
            set
            {
                if (Label != value)
                {
                    Label = value;
                    NotifyPropertyChanged();
                }
            }

        }

        private String Value;
        public String value
        {
            get { return Value; }
            set
            {
                if (this.Value != value)
                {
                    this.Value = value;
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
                if (this.nomeCompleto != value)
                {
                    this.nomeCompleto = value;
                    NotifyPropertyChanged();
                }
            }

        }

        private String error;
        public String Error
        {
            get { return error; }
            set
            {
                if (this.error != value)
                {
                    this.error = value;
                    NotifyPropertyChanged();
                }
            }

        }

        public Scraping()
        {

        }


    }

}
