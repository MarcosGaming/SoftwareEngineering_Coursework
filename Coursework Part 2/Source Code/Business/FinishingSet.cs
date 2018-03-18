using System;
using System.Collections.Generic;
using System.Text;

/*
 * Class to create instances of type FinishingSet.
 * Last modified date: 18/03/2018
 */

namespace Business
{
    public class FinishingSet
    {
        private String _handleBars;     //Bike handlebars type
        private String _saddle;         //Bike saddle type

        //Getter and setter for the class properties
        public String HandleBars
        {
            get
            {
                return _handleBars;
            }
            set
            {
                if(value != null)
                {
                    _handleBars = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect handlebars value");
                }
            }
        }
        public String Saddle
        {
            get
            {
                return _saddle;
            }
            set
            {
                if (value != null)
                {
                    _saddle= value;
                }
                else
                {
                    throw new ArgumentException("Incorrect saddle value");
                }
            }
        }
    }
}
