using System.Windows;

namespace WPFINotifyPropertyChangedDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        private Person obj { get; set; } 
        public MainWindow()
        {
            InitializeComponent();
            obj = new Person { Fname = "Mansi", Lname = "Desai" };
            this.DataContext = obj;
      
        }
    }
}
