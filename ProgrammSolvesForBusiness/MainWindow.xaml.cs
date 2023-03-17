using System;
using System.Collections.Generic;
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
using System.Data.Entity;

namespace ProgrammSolvesForBusiness
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Model1Entities context = new Model1Entities();
        CollectionViewSource agentViewSource;
        CollectionViewSource productViewSource;

        public MainWindow()
        {
            InitializeComponent();
            agentViewSource = ((CollectionViewSource)(FindResource("agentsViewSource")));
            productViewSource = ((CollectionViewSource)(FindResource("prodViewSource")));
            DataContext = this;
        }

        private void WinLoaded(object sender, RoutedEventArgs e)
        {
            context.Агент.Load();
            agentViewSource.Source = context.Агент.Local;
        }
    }
}
