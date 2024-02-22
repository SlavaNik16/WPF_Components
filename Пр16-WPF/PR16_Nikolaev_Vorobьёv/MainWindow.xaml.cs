using System.Windows;

namespace PR16_Nikolaev_Vorobьёv
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Логин: {textL.Text}\n\rПароль: {textP.Text}");

        }
    }
}
