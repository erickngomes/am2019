using SQLite;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AmApp.Model
{
    public class Usuario : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private int idUsuario;

        [PrimaryKey, AutoIncrement]
        public int IdUsuario
        {
            get { return idUsuario; }
            set
            {
                if (idUsuario != value)
                {
                    idUsuario = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private String Login;
        public String login
        {
            get { return Login; }
            set
            {
                if (Login != value)
                {
                    Login = value;
                    NotifyPropertyChanged();
                }
            }
        }


        private String Password;
        public String password
        {
            get { return Password; }
            set
            {
                if (Password != value)
                {
                    Password = value;
                    NotifyPropertyChanged();
                }
            }

        }

        private int id_usuario;
        public int ID_USUARIO
        {
            get { return id_usuario; }
            set
            {
                if (id_usuario != value)
                {
                    id_usuario = value;
                    NotifyPropertyChanged();
                }
            }

        }


        public Usuario()
        {

        }

        public Usuario(string _email, string _senha)
        {
            this.login = _email;
            this.password = _senha;
        }


    }
}
