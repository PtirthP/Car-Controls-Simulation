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
using System.Windows.Shapes;

namespace Car_Simulation
{
    /// <summary>
    /// Interaction logic for InteriorControls.xaml
    /// </summary>
    public partial class InteriorControls : Window
    {
        public InteriorControls()
        {
            InitializeComponent();
            rdnP.IsChecked = true;
            rdnNormal.IsChecked = true;
            rdnTurnSignalOff.IsChecked = true;    

            imgParkingBrake.Visibility = Visibility.Hidden;
            imgAC.Visibility = Visibility.Hidden;
            imgHeater.Visibility = Visibility.Hidden;
            imgWiper.Visibility = Visibility.Hidden;
            imgCruise.Visibility = Visibility.Hidden;
            imgLeftSignal.Visibility = Visibility.Hidden;
            imgRightSignal.Visibility = Visibility.Hidden;

        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mw = new MainWindow();
            mw.Show();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnTurnOff_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void cbxBrakes_Checked(object sender, RoutedEventArgs e)
        {
               elpBrakeLight1.Fill = Brushes.Red;
               elpBrakeLight2.Fill = Brushes.Red;
          
        }

        private void cbxBrakes_Unchecked(object sender, RoutedEventArgs e)
        {
            elpBrakeLight1.Fill = Brushes.Transparent;
            elpBrakeLight2.Fill = Brushes.Transparent;
        }

        private void cbxHeadlights_Checked(object sender, RoutedEventArgs e)
        {
            elpHeadlight1.Fill = Brushes.Gold;
            elpHeadlight2.Fill = Brushes.Gold;  
        }

        private void cbxHeadlights_Unchecked(object sender, RoutedEventArgs e)
        {
            elpHeadlight1.Fill = Brushes.Transparent;
            elpHeadlight2.Fill = Brushes.Transparent;
        }

        private void rdnP_Checked(object sender, RoutedEventArgs e)
        {
            lblGear.Content = "P";
        }

        private void rdnR_Checked(object sender, RoutedEventArgs e)
        {
            lblGear.Content = "R";
        }

        private void rdnN_Checked(object sender, RoutedEventArgs e)
        {
            lblGear.Content = "N";
        }

        private void rdnD_Checked(object sender, RoutedEventArgs e)
        {
            lblGear.Content = "D";
        }

        private void rdnS_Checked(object sender, RoutedEventArgs e)
        {
            lblGear.Content = "S";
        }

        private void rdn3_Checked(object sender, RoutedEventArgs e)
        {
            lblGear.Content = "3";
        }

        private void rdn2_Checked(object sender, RoutedEventArgs e)
        {
            lblGear.Content = "2";
        }

        private void rdn1_Checked(object sender, RoutedEventArgs e)
        {
            lblGear.Content = "1";
        }

        private void rdnNormal_Checked(object sender, RoutedEventArgs e)
        {
            lblMode.Content = "Normal";
        }

        private void rdnEcon_Checked(object sender, RoutedEventArgs e)
        {
            lblMode.Content = "Econ";
        }

        private void rdnSport_Checked(object sender, RoutedEventArgs e)
        {
            lblMode.Content = "Sport";
        }

        private void rdnOffRoad_Checked(object sender, RoutedEventArgs e)
        {
            lblMode.Content = "Off Road";
        }

        private void cbxSeatbelt_Checked(object sender, RoutedEventArgs e)
        {
            imgSeatbelt.Visibility = Visibility.Hidden;
        }

        private void cbxSeatbelt_Unchecked(object sender, RoutedEventArgs e)
        {
            imgSeatbelt.Visibility = Visibility.Visible;
        }

        private void cbxParkingBrake_Checked(object sender, RoutedEventArgs e)
        {
            imgParkingBrake.Visibility = Visibility.Visible;
        }

        private void cbxParkingBrake_Unchecked(object sender, RoutedEventArgs e)
        {
            imgParkingBrake.Visibility = Visibility.Hidden;
        }

        private void cbxAC_Checked(object sender, RoutedEventArgs e)
        {
            imgAC.Visibility = Visibility.Visible;
        }

        private void cbxAC_Unchecked(object sender, RoutedEventArgs e)
        {
            imgAC.Visibility = Visibility.Hidden;
        }

        private void cbxHeater_Checked(object sender, RoutedEventArgs e)
        {
            imgHeater.Visibility = Visibility.Visible;
        }

        private void cbxHeater_Unchecked(object sender, RoutedEventArgs e)
        {
            imgHeater.Visibility = Visibility.Hidden;
        }

        private void cbxWiper_Checked(object sender, RoutedEventArgs e)
        {
            imgWiper.Visibility = Visibility.Visible;
        }

        private void cbxWiper_Unchecked(object sender, RoutedEventArgs e)
        {
            imgWiper.Visibility = Visibility.Hidden;
        }

        private void cbxCruise_Unchecked(object sender, RoutedEventArgs e)
        {
            imgCruise.Visibility = Visibility.Hidden;
        }

        private void cbxCruise_Checked(object sender, RoutedEventArgs e)
        {
            imgCruise.Visibility = Visibility.Visible;
        }

        private void rdnLeft_Checked(object sender, RoutedEventArgs e)
        {
            imgLeftSignal.Visibility = Visibility.Visible;
            imgRightSignal.Visibility = Visibility.Hidden;
        }

        private void rdnTurnSignalOff_Checked(object sender, RoutedEventArgs e)
        {
            imgLeftSignal.Visibility = Visibility.Hidden;
            imgRightSignal.Visibility = Visibility.Hidden;
        }

        private void rdnRight_Checked(object sender, RoutedEventArgs e)
        {
            imgRightSignal.Visibility = Visibility.Visible;
            imgLeftSignal.Visibility = Visibility.Hidden;
        }

        private void rdnParked_Checked(object sender, RoutedEventArgs e)
        {
            imgLeftSignal.Visibility = Visibility.Visible;
            imgRightSignal.Visibility = Visibility.Visible;
        }

        private void rdnWindowUp_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Window Up");
        }

        private void rdnWindowDown_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Window Down");
        }
    }
}
