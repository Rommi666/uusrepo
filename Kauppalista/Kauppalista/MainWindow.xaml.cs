using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            TextBlock textBlock = new TextBlock();
            textBlock.Text = checkBox.Content.ToString();
            StockPanel.Children.Add(textBlock);
        }

        private void BuyButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (CheckBox checkBox in new CheckBox[] { CheckBox1, CheckBox2, CheckBox3 })
            {
                checkBox.IsChecked = false;
            }
            StockPanel.Children.Clear();
        }
    }
}