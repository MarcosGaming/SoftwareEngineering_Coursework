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
using Business;
using Data;

namespace SoftwareEngineeringCoursework
{
    /// <summary>
    /// Interaction logic for FinishedWindow.xaml
    /// </summary>
    public partial class FinishedWindow : Window
    {
        FacadeManagement facade = FacadeManagement.getInstance();
        //Bike built in last window
        Bike newBike;

        public FinishedWindow(Bike bike)
        {
            InitializeComponent();
            newBike = bike;
            facade.addBike(newBike);
            displayBikeCost();
        }

        private void addMoreBikesBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }
        private void finishBtn_Click(object sender, RoutedEventArgs e)
        {
            TotalCostWindow window = new TotalCostWindow();
            window.Show();
            this.Close();
        }

        //Display the bike cost
        private void displayBikeCost()
        {
            bikeCostLbl.Content = facade.getBikeCost(newBike).ToString();
        }
    }
}
