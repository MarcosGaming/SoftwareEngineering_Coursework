using System;
using System.Collections.Generic;
using System.Text;
using Business;

/*
 * As this is a prototype the different dictionaries are being hardcoded (this is bad practice), a way of solving this is usign some type of storage like a database to retrieve the 
 * components and their amount from stock and create a user interface to allow the manager or the recepcionist to modify those values. However for this project that is not being implemented.
 * SINGLETON DESIGN PATTERN
 * Class that manages the amount of each component available in the stock, singleton used to only have one instance of this class.
 * Last date modified: 18/03/2018
 **/

namespace Data
{
    public class Stock
    {
        private Dictionary<String, int> _frameStock;        //Amount of frames available
        private Dictionary<String, int> _gearsStock;        //Amount of gears available
        private Dictionary<String, int> _brakesStock;       //Amount of breaks available
        private Dictionary<String, int> _wheelsStock;       //Amount of wheels available
        private Dictionary<String, int> _handlebarsStock;   //Amount of handlebars available
        private Dictionary<String, int> _saddleStock;       //Amount of saddles available
        private static Stock _instance;                     //Stock instance for the singleton

        //Constructor for the singleton
        private Stock()
        {
            generateFrameStock();
            generateGearStock();
            generateBrakesStock();
            generateWheelsStock();
            generateHandlebarsStock();
            generateSaddleStock();
        }
        //Method to the the stock instance, only allows to get the instance not to set it
        public static Stock getInstance()
        {
            if(_instance == null)
            {
                _instance = new Stock();
            }
            return _instance;
        }

        //Methods to generate the dictionaries
        private void generateFrameStock()
        {
            _frameStock = new Dictionary<string, int>();
            _frameStock.Add("Small", 5);
            _frameStock.Add("Medium", 10);
            _frameStock.Add("Big", 3);
        }
        private void generateGearStock()
        {
            _gearsStock = new Dictionary<string, int>();
            _gearsStock.Add("Thumb Shifter", 30);
            _gearsStock.Add("Grip Shifter", 15);
            _gearsStock.Add("Triger Shifter", 5);
            _gearsStock.Add("Flight Deck Shifter", 2);
        }
        private void generateBrakesStock()
        {
            _brakesStock = new Dictionary<string, int>();
            _brakesStock.Add("Disk Brakes", 5);
            _brakesStock.Add("V-brakes", 1);
            _brakesStock.Add("Caliper Brakes", 10);
            _brakesStock.Add("Cantiveler Brakes", 20);
        }
        private void generateWheelsStock()
        {
            _wheelsStock = new Dictionary<string, int>();
            _wheelsStock.Add("Highways", 16);
            _wheelsStock.Add("Mountain", 32);
        }
        private void generateHandlebarsStock()
        {
            _handlebarsStock = new Dictionary<string, int>();
            _handlebarsStock.Add("Bullhorns Bars", 17);
            _handlebarsStock.Add("Drop Bars", 20);
            _handlebarsStock.Add("Riser Bars", 3);
        }
        private void generateSaddleStock()
        {
            _saddleStock = new Dictionary<string, int>();
            _saddleStock.Add("Forward", 12);
            _saddleStock.Add("Upright", 7);
            _saddleStock.Add("Triathlon", 5);
        }
        //Methods to return the dictionaries
        public Dictionary<String,int> getFrameStock()
        {
            return _frameStock;
        }
        public Dictionary<String, int> getGearsStock()
        {
            return _gearsStock;
        }
        public Dictionary<String, int> getBrakesStock()
        {
            return _brakesStock;
        }
        public Dictionary<String, int> getWheelsStock()
        {
            return _wheelsStock;
        }
        public Dictionary<String, int> getHandlebarsStock()
        {
            return _handlebarsStock;
        }
        public Dictionary<String, int> getSaddleStock()
        {
            return _saddleStock;
        }
        //Update the stock back method
        public void updateStockBack(List<Bike> bikes)
        {
            foreach(Bike b in bikes)
            {
                _frameStock[b.Frame.FrameSize] += 1;
                _gearsStock[b.GroupSet.Gears] += 1;
                _brakesStock[b.GroupSet.Brakes] += 1;
                _wheelsStock[b.Wheels.WheelsType] += 1;
                _handlebarsStock[b.FinishingSet.HandleBars] += 1;
                _saddleStock[b.FinishingSet.Saddle] += 1;

            }
        }
    }
}
