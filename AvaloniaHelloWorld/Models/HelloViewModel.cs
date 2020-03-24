using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace AvaloniaHelloWorld.Models{
    class HelloViewModel : INotifyPropertyChanged{

        private string _greeting;
        private string _name;
        private string _os;

        public string Greeting {
            get => _greeting;
            set {
                if (value != _greeting) {
                    _greeting = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Name {
            get => _name;
            set {
                if (value != _name) {
                    _name = value;
                    OnPropertyChanged();
                }
            }
        }

        public string OS {
            get => _os;
            set {
                _os = System.Runtime.InteropServices.RuntimeInformation.OSDescription;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null){
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
