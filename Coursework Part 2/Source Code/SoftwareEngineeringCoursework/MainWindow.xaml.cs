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
using Data;
using Business;

namespace SoftwareEngineeringCoursework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Components to fill the combo boxes
        ComponentsAndPrices components;
        //Bike to build
        Bike bike;
        public MainWindow()
        {
            InitializeComponent();
            components = new ComponentsAndPrices();
            bike = new Bike();
            initializeComboBoxes();
        }

        private void continueBtn_Click(object sender, RoutedEventArgs e)
        {
            if(!checkComboBoxes())
            {
                MessageBox.Show("Please select a value for all the combo boxes");
                return;
            }
            try
            {
                //Build bike based on the combo box values
                bike.Frame.FrameColour = frameColourCmbBox.SelectedItem.ToString();
                bike.Frame.FrameSize = frameSizeCmbBox.SelectedItem.ToString();
                bike.GroupSet.Gears = gearsCmbBox.SelectedItem.ToString();
                bike.GroupSet.Brakes = brakesCmbBox.SelectedItem.ToString();
                bike.Wheels.WheelsType = wheelsCmbBox.SelectedItem.ToString();
                bike.FinishingSet.HandleBars = handlebarsCmbBox.SelectedItem.ToString();
                bike.FinishingSet.Saddle = saddleCmbBox.SelectedItem.ToString();
                //Check for warranty
                if(warrantyCheckBox.IsChecked.Value)
                {
                    bike.updateWarranty();
                }
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
            }
            //If the bike has been built correctly continue to the next window (passing the bike)
            FinishedWindow window = new FinishedWindow(bike);
            window.Show();
            this.Close();
        }

        //Check if all combo box values have been selected
        private bool checkComboBoxes()
        {
            if(frameColourCmbBox.SelectedItem == null)
            {
                return false;
            }
            else if(frameSizeCmbBox.SelectedItem == null)
            {
                return false;
            }
            else if(gearsCmbBox.SelectedItem == null)
            {
                return false;
            }
            else if (brakesCmbBox.SelectedItem == null)
            {
                return false;
            }
            else if (wheelsCmbBox.SelectedItem == null)
            {
                return false;
            }
            else if (handlebarsCmbBox.SelectedItem == null)
            {
                return false;
            }
            else if (saddleCmbBox.SelectedItem == null)
            {
                return false;
            }
            return true;
        }
        //Method to generate the values for the combo boxes
        private void initializeComboBoxes()
        {
            //Generate frame colour combo box values
            frameColourCmbBox.Items.Add("Blue");
            frameColourCmbBox.Items.Add("Red");
            frameColourCmbBox.Items.Add("Black");
            frameColourCmbBox.Items.Add("Green");
            //Generate frame size combo box values
            for (int i = 0; i < components.getFrames().Count; i++)
            {
                frameSizeCmbBox.Items.Add(components.getFrames().Keys.ElementAt(i).ToString());
            }
            //Generate gears combo box values
            for (int i = 0; i < components.getGears().Count; i++)
            {
                gearsCmbBox.Items.Add(components.getGears().Keys.ElementAt(i).ToString());
            }
            //Generate brakes combo box values
            for (int i = 0; i < components.getBrakes().Count; i++)
            {
                brakesCmbBox.Items.Add(components.getBrakes().Keys.ElementAt(i).ToString());
            }
            //Generate wheels combo box values
            for (int i = 0; i < components.getWheels().Count; i++)
            {
                wheelsCmbBox.Items.Add(components.getWheels().Keys.ElementAt(i).ToString());
            }
            //Generate handlebars combo box values
            for (int i = 0; i < components.getHandleBars().Count; i++)
            {
                handlebarsCmbBox.Items.Add(components.getHandleBars().Keys.ElementAt(i).ToString());
            }
            //Generate saddle combo box values
            for (int i = 0; i < components.getSaddles().Count; i++)
            {
                saddleCmbBox.Items.Add(components.getSaddles().Keys.ElementAt(i).ToString());
            }
        }
    }
}
