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
    /// Interaction logic for TotalCostWindow.xaml
    /// </summary>
    public partial class TotalCostWindow : Window
    {
        FacadeManagement facade = FacadeManagement.getInstance();
        public TotalCostWindow()
        {
            InitializeComponent();
            displayTotalCost();
            displayCompletionTime();
        }

        private void customerDetailsBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void cancelOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            //If the order is cancelled the stock needs to be updated back and the list with the bikes cleared
            facade.updateStockBack();
            facade.clearBikeList();
            //Return to the main window
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        //Display total order cost
        private void displayTotalCost()
        {
            totalCostLbl.Content = facade.getTotalBikesCost().ToString();
        }
        //Display completion time
        private void displayCompletionTime()
        {
            completionTimeLbl.Content = facade.getTotalCompletionTime() + " Hours";
        }
    }
}
