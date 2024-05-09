using PhoneBookWpf.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookWpf.ViewModels
{

    public class SubscriptionViewModel : INotifyPropertyChanged
    {
        private readonly Subscription _subscription;

        public SubscriptionViewModel(Subscription subscription)
        {
            _subscription = subscription;
            Subscription = new ObservableCollection<PhoneNumber>(_subscription.PhoneNumbers);
        }

        public ObservableCollection<PhoneNumber> Subscription { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
