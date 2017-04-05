using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FormsAssistControl.Model.Entities
{
    public class ObservableBaseObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public void OnPropertyChange([CallerMemberName] string name = "")
        {
            if (this.PropertyChanged == null) { return; }

            this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
