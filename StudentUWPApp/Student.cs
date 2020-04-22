using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentUWPApp
{
    public class Student : INotifyPropertyChanged
    {

        private string name;

        public string Name {

            get => this.name;

            set
            {
                this.name = value;
                OnPropertyChanged();
            }


        }




        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        => this.PropertyChanged?.Invoke(this,
            new PropertyChangedEventArgs(propertyName));


    }
}
