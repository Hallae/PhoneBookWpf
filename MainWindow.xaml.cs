using PhoneBookWpf.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PhoneBookWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<SubscriptionViewModel> Subscriptions { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Subscription = new ObservableCollection<SubscriptionViewModel>();
            DataContext = this;
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            // Implement search logic here
            Console.WriteLine("Search button clicked");
        }

        private void ExportCsvButton_Click(object sender, RoutedEventArgs e)
        {
            // Implement CSV export logic here
            Console.WriteLine("Export CSV button clicked");
        }
    }
}
