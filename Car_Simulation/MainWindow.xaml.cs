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

namespace Car_Simulation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            if (rdnKeyOut.IsChecked == false)
            {
                rdnKeyOut.IsChecked = true;
                lbIgnition.IsEnabled = false;
                lbDomeLight.IsEnabled = false;
                btnCarControls.IsEnabled = false;
            }
           
        }

        private void rdnKeyIn_Checked(object sender, RoutedEventArgs e)
        {
            lbIgnition.IsEnabled=true;
            lbDomeLight.IsEnabled = true;
            rdnEngineOff.IsChecked=true;
            rdnEngineOn.IsEnabled = false;
            rdnDomeAuto.IsChecked=true;
        }
        
        private void rdnKeyOut_Checked(object sender, RoutedEventArgs e)
        {
            lbIgnition.IsEnabled = false;
            lbDomeLight.IsEnabled = false;
        }

        private void rdnEngineOff_Checked(object sender, RoutedEventArgs e)
        {
            
            rdnKeyOut.IsEnabled = true;

            if (rdnDomeOff.IsChecked == true)
            {
                lbDomeLight.Background = Brushes.Transparent;
            }

            if (rdnDomeAuto.IsChecked == true)
            {
                lbDomeLight.Background = Brushes.Gold;
            }

            if (rdnDomeOn.IsChecked == true)
            {
                lbDomeLight.Background = Brushes.Gold;
            }

        }

        private void rdnEngineIgnition_Checked(object sender, RoutedEventArgs e)
        {
            rdnEngineOn.IsEnabled = true;
            rdnKeyOut.IsEnabled = false;
            rdnEngineOff.IsEnabled = true;


            if (rdnDomeOff.IsChecked == true)
            {
                lbDomeLight.Background = Brushes.Transparent;
            }

            if (rdnDomeAuto.IsChecked == true)
            {
                lbDomeLight.Background = Brushes.Gold;
            }

            if (rdnDomeOn.IsChecked == true)
            {
                lbDomeLight.Background = Brushes.Gold;
            }
        }

        private void rdnEngineOn_Checked(object sender, RoutedEventArgs e)
        {
            rdnEngineOff.IsEnabled = false;
            btnCarControls.IsEnabled = true;

            
            if (rdnDomeOff.IsChecked == true)
            {
                lbDomeLight.Background = Brushes.Transparent;
            }

            if (rdnDomeAuto.IsChecked == true)
            {
                lbDomeLight.Background = Brushes.Transparent;
            }

            if (rdnDomeOn.IsChecked == true)
            {
                lbDomeLight.Background = Brushes.Gold;
            }

        }

        private void rdnDomeOff_Checked(object sender, RoutedEventArgs e)
        {
            lbDomeLight.Background = Brushes.Transparent;
        }

        private void rdnDomeAuto_Checked(object sender, RoutedEventArgs e)
        {
            if (rdnEngineOff.IsChecked == true)
            {
                lbDomeLight.Background = Brushes.Gold;
            }

            if (rdnEngineIgnition.IsChecked == true)
            {
                lbDomeLight.Background = Brushes.Gold;
            }

            if (rdnEngineOn.IsChecked == true)
            {
                lbDomeLight.Background = Brushes.Transparent;
            }
        }

        private void rdnDomeOn_Checked(object sender, RoutedEventArgs e)
        {
            if (rdnEngineOff.IsChecked == true)
            {
                lbDomeLight.Background = Brushes.Gold;
            }

            if (rdnEngineIgnition.IsChecked == true)
            {
                lbDomeLight.Background = Brushes.Gold;
            }

            if (rdnEngineOn.IsChecked == true)
            {
                lbDomeLight.Background = Brushes.Gold;
            }
        }

        private void btnCarControls_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            InteriorControls ic = new InteriorControls();
            ic.ShowDialog();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnTurnOff_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
