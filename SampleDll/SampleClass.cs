using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SampleDll
{
    public class SampleClass : INotifyPropertyChanged
    {
        private int number;
        public event PropertyChangedEventHandler PropertyChanged;



        public int Number
        {
            get => number;
            set
            {
                number = value;
                NotifyPropertyChanged();
            }
        }

        // This method is called by the Set accessor of each property.  
        // The CallerMemberName attribute that is applied to the optional propertyName  
        // parameter causes the property name of the caller to be substituted as an argument.  
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            Console.WriteLine("NotifyPropertyChanged called!");
        }

        // public event PropertyChangedEventHandler? PropertyChanged;
    }
}
