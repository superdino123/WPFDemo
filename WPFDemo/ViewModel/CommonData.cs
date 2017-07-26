using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFDemo.ViewModel
{
    public class CommonData:INotifyPropertyChanged
    {
        private bool isEditPage;

        public bool IsEditPage {
            set
            {
                if (isEditPage.Equals(value)) return;
                isEditPage = value;
                OnPropertyChanged("IsEditPage");
            }
            get
            {
                return isEditPage;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
