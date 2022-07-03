using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace APIweb.Modelo
{
    public class UsuarioModelo: INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChange([CallerMemberName] string nombre = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }

        private int userid
        {
            get { return userid;  }
            set { userid = value;
                OnPropertyChange();
            }
        }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value;
                OnPropertyChange();
            }
        }

        private string title;

        public string Title
        {
            get { return title; }
            set { title = value;
                OnPropertyChange();
            }
        }

        private bool complete;

        

        private bool Complete
        {
            get { return complete; }
            set { complete = value;
                OnPropertyChange();
            }
        }

    }
}
