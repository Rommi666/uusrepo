using System.Windows;

namespace TalonOhjausSovellus
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ValotButton_Click(object sender, RoutedEventArgs e)
        {
            if (ValotButton.Content.ToString() == "Valot päällä")
            {
                ValotButton.Content = "Valot pois";
                // Tee koodi, jolla laitat valot päälle
            }
            else
            {
                ValotButton.Content = "Valot päällä";
                // Tee koodi, jolla laitat valot pois päältä
            }
        }

        private void LampotilaSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double uusiLampotila = LampotilaSlider.Value;
            LampotilaTextBlock.Text = "Lämpötila: " + uusiLampotila.ToString("N1");
            // Tee koodi, jolla asetat talon lämpötilan uuteen arvoon
        }

        private void OviButton_Click(object sender, RoutedEventArgs e)
        {
            if (OviButton.Content.ToString() == "Ovi kiinni")
            {
                OviButton.Content = "Ovi auki";
                // Tee koodi, jolla avaat talon oven
            }
            else
            {
                OviButton.Content = "Ovi kiinni";
                // Tee koodi, jolla suljet talon oven
            }
        }
    }
}
