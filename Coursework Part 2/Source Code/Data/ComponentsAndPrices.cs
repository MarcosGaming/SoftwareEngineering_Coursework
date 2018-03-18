using System;
using System.Collections.Generic;
using System.Text;

/*
 * As this is a prototype the different dictionaries are being hardcoded (this is bad practice), a way of solving this is usign some type of storage like a database to retrieve the 
 * components and their prices and create a user interface to allow the manager or the recepcionist to modify those values. However for this project that is not being implemented.
 * Class that manages the types of components and their corresponding prices.
 * Last date modified: 18/03/2018
 **/

namespace Data
{
   public class ComponentsAndPrices
    {
        private Dictionary<String, int> _framePrices;       //Dictionary with frame size types and corresponding prices
        private Dictionary<String, int> _gearsPrices;       //Dictionary with gears types and corresponding prices
        private Dictionary<String, int> _brakesPrices;      //Dictionary with brakes types and corresponding prices
        private Dictionary<String, int> _wheelsPrices;      //Dictionary with wheels types and corresponding prices
        private Dictionary<String, int> _handlebarsPrices;  //Dictionary with handlebars types and corresponding prices
        private Dictionary<String, int> _saddlePrices;      //Dictionary with saddle types and corresponding prices

        public ComponentsAndPrices()
        {
            generateFramePrices();
            generateGearsPrices();
            generateBrakesPrices();
            generateWheelsPrices();
            generateHandlebarsPrices();
            generateSaddlePrices();
        }

        //Methods to generate the different dictionaries
        private void generateFramePrices()
        {
            _framePrices = new Dictionary<String, int>();
            _framePrices.Add("Small", 30);
            _framePrices.Add("Medium", 40);
            _framePrices.Add("Big", 50);
        }
        private void generateGearsPrices()
        {
            _gearsPrices = new Dictionary<String, int>();
            _gearsPrices.Add("Thumb Shifter", 40);
            _gearsPrices.Add("Grip Shifter", 50);
            _gearsPrices.Add("Triger Shifter", 70);
            _gearsPrices.Add("Flight Deck Shifter", 90);
        }
        private void generateBrakesPrices()
        {
            _brakesPrices = new Dictionary<String, int>();
            _brakesPrices.Add("Disk Brakes", 100);
            _brakesPrices.Add("V-brakes", 20);
            _brakesPrices.Add("Caliper Brakes", 40);
            _brakesPrices.Add("Cantilever Brakes", 35);
        }
        private void generateWheelsPrices()
        {
            _wheelsPrices = new Dictionary<String, int>();
            _wheelsPrices.Add("Highways", 300);
            _wheelsPrices.Add("Mountain", 150);
        }
        private void generateHandlebarsPrices()
        {
            _handlebarsPrices = new Dictionary<String, int>();
            _handlebarsPrices.Add("Bullhorns Bars", 50);
            _handlebarsPrices.Add("Drop Bars", 75);
            _handlebarsPrices.Add("Riser Bars", 20);
        }
        private void generateSaddlePrices()
        {
            _saddlePrices = new Dictionary<String, int>();
            _saddlePrices.Add("Forward", 50);
            _saddlePrices.Add("Upright", 70);
            _saddlePrices.Add("Triathlon", 30);
        }
        //Methods to return the dictionaries
        public Dictionary<String, int> getFrames()
        {
            return _framePrices;
        }
        public Dictionary<String, int> getGears()
        {
            return _gearsPrices;
        }
        public Dictionary<String, int> getBrakes()
        {
            return _brakesPrices;
        }
        public Dictionary<String, int> getWheels()
        {
            return _wheelsPrices;
        }
        public Dictionary<String, int> getHandleBars()
        {
            return _handlebarsPrices;
        }
        public Dictionary<String, int> getSaddles()
        {
            return _saddlePrices;
        }

    }
}
