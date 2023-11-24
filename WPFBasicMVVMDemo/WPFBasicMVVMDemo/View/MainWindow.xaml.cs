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
using WPFBasicMVVMDemo.ViewModel;

namespace WPFBasicMVVMDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       PersonViewModel personviewmodel;
        public MainWindow()
        {
            InitializeComponent();
            personviewmodel = new PersonViewModel();
            DataContext = personviewmodel;
        }
    }
}
